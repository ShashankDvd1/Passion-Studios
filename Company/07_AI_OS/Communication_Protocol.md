---
document_id: "07-004"
title: "Communication Protocol"
owner: "CTO Agent"
status: "Approved"
version: "1.0"
created: "2026-06-27"
updated: "2026-06-27"
phase: "Phase 1 — Agent Operating System"
priority: "P0"
tags:
  - communication
  - protocol
  - agent-os
  - messaging
  - events
related_documents:
  - "07-001: Agent OS Vision"
  - "07-002: System Architecture"
  - "07-003: Agent Registry"
  - "10-001: Workflow Engine"
  - "13-001: Task System Overview"
related_agents:
  - "All Agents"
dependencies:
  - "07-002: System Architecture"
---

# Communication Protocol

## 1. Vision

Agents in the Agent OS never communicate directly with each other. All communication flows through defined channels with standardized message formats. This prevents spaghetti dependencies, enables auditing, and ensures the system remains modular — any agent can be replaced without rewiring communication paths.

## 2. Problem Statement

Without a communication protocol, agents develop ad-hoc dependencies. Agent A calls Agent B directly, bypassing governance. Agent C doesn't know Agent A's output exists because there's no broadcast mechanism. When Agent B is retired, Agent A breaks silently.

## 3. Goals

1. Define five communication channels covering all inter-agent interaction patterns.
2. Standardize message formats for each channel.
3. Ensure all communication is logged in the audit trail.
4. Prevent direct agent-to-agent coupling.

## 4. Non-Goals

- This does not define workflow sequencing (see `10_Workflows/`).
- This does not define human-agent communication (see `00-004: AI Collaboration Protocol`).

## 5. Principles

1. **No direct coupling.** Agents publish to channels, not to other agents. Agents subscribe to channels, not to other agents.
2. **Every message is logged.** The audit system records every message on every channel.
3. **Asynchronous by default.** Agents send messages and continue working. They do not block waiting for responses (unless explicitly synchronous).
4. **Structured messages.** Every message follows a schema. No free-form text between agents.

## 6. Requirements

### 6.1 Communication Channels

| Channel | Pattern | Purpose | Example |
|---------|---------|---------|---------|
| **Task Channel** | Command (1:1) | Assign work to a specific agent | Workflow Engine → Game Designer: "Create design spec for feature X" |
| **Output Channel** | Submit (1:1) | Agent submits completed work | Game Designer → Quality Pipeline: "Design spec ready for review" |
| **Event Channel** | Broadcast (1:many) | Notify system of state changes | "Feature X approved" → all subscribed agents |
| **Query Channel** | Request-Response (1:1) | Agent requests information from a service | Agent → Memory System: "Get recent player behavior data" |
| **Escalation Channel** | Escalate (1:up) | Route decisions beyond agent authority | Agent → Governance: "P1 decision needed on monetization approach" |

### 6.2 Standard Message Format

```yaml
message:
  id: "MSG-YYYY-MM-DD-NNNNNN"
  channel: "task | output | event | query | escalation"
  timestamp: "ISO-8601"
  sender:
    agent_id: "09-NNN"
    agent_name: "Agent Name"
  recipient:
    agent_id: "09-NNN | SYSTEM | BROADCAST"
    agent_name: "Agent Name | Quality Pipeline | All"
  priority: "P0 | P1 | P2 | P3"
  subject: "Brief description"
  body:
    type: "task_assignment | output_submission | event_notification | query_request | query_response | escalation_request"
    content: {}  # Channel-specific payload
    references:
      - doc_id: "Related document IDs"
      - workflow_id: "If part of a workflow"
      - task_id: "If related to a task"
  metadata:
    workflow_step: "Which workflow step generated this"
    requires_response: true | false
    response_sla: "Duration or null"
```

### 6.3 Channel-Specific Payloads

#### Task Channel Payload
```yaml
content:
  task_id: "TASK-NNNN"
  task_type: "design | implement | review | research | generate"
  description: "What needs to be done"
  acceptance_criteria: ["List of criteria"]
  context:
    - memory_refs: ["Relevant memory IDs"]
    - doc_refs: ["Relevant document IDs"]
  deadline: "ISO-8601 or null"
  output_format: "Expected output structure"
```

#### Output Channel Payload
```yaml
content:
  task_id: "TASK-NNNN"
  output_type: "document | code | design | analysis | content"
  output_location: "File path or inline content"
  self_review:
    passed: true | false
    checklist_results: {}
  quality_gate: "next gate in pipeline"
  confidence: "0.0 - 1.0"
  notes: "Any concerns or uncertainties"
```

#### Event Channel Payload
```yaml
content:
  event_type: "approved | rejected | completed | failed | blocked | created"
  entity_type: "feature | task | document | release | agent"
  entity_id: "ID of the entity"
  description: "What happened"
  impact: ["List of affected workflows or agents"]
```

#### Escalation Channel Payload
```yaml
content:
  decision_brief:
    problem: "What decision is needed"
    options: [{name: "", pros: [], cons: [], risk: ""}]
    recommendation: "Recommended option"
    reasoning: "Why"
    deadline: "When this must be decided"
  escalation_reason: "authority_exceeded | conflict | uncertainty | policy_violation"
  current_authority: "P-level of the escalating agent"
  required_authority: "P-level needed for this decision"
```

### 6.4 Communication Rules

| Rule | Description |
|------|-------------|
| **No side channels** | All agent communication goes through defined channels. No informal exchanges. |
| **Sender identifies** | Every message includes the sender's agent ID and name. Anonymous messages are rejected. |
| **Idempotent processing** | Agents must handle receiving the same message twice without producing duplicate work. |
| **Acknowledge receipt** | Task assignments must be acknowledged within the channel SLA. No silent drops. |
| **Fail loudly** | If an agent cannot process a message, it publishes a failure event. Silent failures are the worst failure. |
| **Context is included** | Task assignments include all necessary context. Agents should not need to query multiple systems to understand their task. |

### 6.5 SLAs by Channel

| Channel | Acknowledgment SLA | Completion SLA |
|---------|-------------------|----------------|
| Task (P0) | 15 minutes | Per task definition |
| Task (P1) | 1 hour | Per task definition |
| Task (P2) | 4 hours | Per task definition |
| Task (P3) | 24 hours | Per task definition |
| Output | Immediate (submission is the acknowledgment) | N/A |
| Event | No acknowledgment required | N/A |
| Query | 5 minutes (service response) | N/A |
| Escalation | 15 minutes (governance receipt) | Per Decision Framework SLA |

## 7. Acceptance Criteria

- [ ] Every inter-agent interaction can be categorized into exactly one of the five channels.
- [ ] Message format is parseable — a new agent can process messages without understanding the sender.
- [ ] No communication path bypasses the audit log.
- [ ] Channel SLAs are measurable and enforceable.
- [ ] An agent can be removed from the system without breaking any communication path (messages are re-routed or queued).

## 8. KPIs

| KPI | Target | Measurement |
|-----|--------|-------------|
| Message delivery rate | 100% (no dropped messages) | Audit log analysis |
| SLA compliance | 95%+ across all channels | SLA tracking |
| Side-channel violations | 0 | Communication audit |
| Average query response time | <2 minutes | Query channel metrics |

## 9. Risks

| Risk | Likelihood | Impact | Mitigation |
|------|-----------|--------|------------|
| Protocol too rigid for creative work | Medium | Medium | Channels handle structured coordination. Creative work happens within agent's task, not in messages. |
| Message volume overwhelms audit system | Low (initially) | Low | Start file-based. Migrate to database when volume requires it. |
| Agents find protocol overhead frustrating | Medium | Low | Protocol is the infrastructure, not the work. Agents spend 95% of time on domain tasks, 5% on protocol. |

## 10. Future Expansion

- **Real-time messaging.** When the OS becomes code-based, implement WebSocket or event-stream communication.
- **Message queuing.** Implement a proper message queue (e.g., Redis, RabbitMQ) for reliability at scale.
- **Cross-project messaging.** Messages between agents working on different game projects.

## 11. AI Automation Opportunities

- **Message routing.** Automated routing based on message type and recipient agent status.
- **SLA monitoring.** Automated alerts when acknowledgment or completion SLAs are at risk.
- **Communication pattern analysis.** Identify frequently communicating agent pairs — candidates for workflow optimization.

## 12. Open Questions

1. Should agents be able to subscribe to event types selectively, or do all agents receive all events?
2. How do we handle message ordering when multiple agents work concurrently?
3. Should there be a "direct message" channel for lightweight coordination that doesn't need full protocol overhead?

## 13. Decision History

| Date | Decision | Rationale |
|------|----------|-----------|
| 2026-06-27 | Five channels adopted | Task, Output, Event, Query, Escalation cover all inter-agent communication patterns. |
| 2026-06-27 | No direct agent coupling | Agents publish to channels, not to other agents. Prevents dependency hell. |
| 2026-06-27 | Asynchronous by default | Blocking communication creates bottlenecks. Async enables parallel work. |

## 14. Related Documents

| Doc ID | Title | Relationship |
|--------|-------|-------------|
| 07-002 | System Architecture | Architecture that defines the layer communication rules |
| 07-003 | Agent Registry | Registry of agents that participate in communication |
| 07-008 | Audit Log Standards | Logging requirements for all messages |
| 10-001 | Workflow Engine | Primary orchestrator that generates Task Channel messages |
| 13-001 | Task System Overview | Task management that Task Channel messages reference |
