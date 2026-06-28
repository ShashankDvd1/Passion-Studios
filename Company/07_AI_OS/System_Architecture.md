---
document_id: "07-002"
title: "System Architecture"
owner: "CTO Agent"
status: "Approved"
version: "1.0"
created: "2026-06-27"
updated: "2026-06-27"
phase: "Phase 1 — Agent Operating System"
priority: "P0"
tags:
  - architecture
  - agent-os
  - technical
  - infrastructure
  - platform
related_documents:
  - "07-001: Agent OS Vision"
  - "07-003: Agent Registry"
  - "07-004: Communication Protocol"
  - "08-001: Agent Lifecycle"
  - "12-001: Memory Architecture"
  - "10-001: Workflow Engine"
related_agents:
  - "CTO Agent"
  - "Unity Architect Agent"
  - "Automation Agent"
dependencies:
  - "07-001: Agent OS Vision"
---

# System Architecture

## 1. Vision

This document defines the technical architecture of the Agent OS — how the subsystems connect, how data flows, how agents interact, and how the system scales. It is the blueprint that every subsystem document implements against.

The architecture follows a layered design: presentation layer (founder interface), orchestration layer (workflows and governance), agent layer (individual agents), and services layer (memory, knowledge, tasks, prompts, quality). Each layer communicates only with adjacent layers through defined interfaces.

## 2. Problem Statement

Without a defined architecture, the Agent OS becomes a spaghetti of ad-hoc integrations. Agent A calls Agent B directly, bypassing governance. Memory is scattered across files without indexing. Workflows are implicit (existing only in the founder's head) rather than explicit (defined as orchestration rules). The system cannot be extended, audited, or maintained.

A clean architecture prevents this entropy from day one.

## 3. Goals

1. Define the four-layer architecture with clear boundaries and interfaces.
2. Specify how each subsystem communicates with others.
3. Define the data flow for the three most common operations: executing a workflow, making a decision, and querying memory.
4. Establish the extension points where new components can be added without modifying existing ones.

## 4. Non-Goals

- This document does not specify implementation technology (the OS is currently documentation-defined, not code-defined).
- This document does not define individual subsystem internals (each subsystem has its own detailed doc).

## 5. Principles

1. **Layered communication.** No layer-skipping. Agents do not access memory directly; they request through the services layer. The founder does not direct agents directly; they go through the orchestration layer.
2. **Interface stability.** Internal implementations can change; interfaces between layers must remain stable.
3. **Stateless agents.** Agents themselves are stateless functions. All state lives in the services layer (memory, tasks, knowledge). This makes agents replaceable and versionable.
4. **Event-driven coordination.** Agents react to events (task assigned, review requested, decision needed), not to polling or scheduling.

## 6. Requirements

### 6.1 Four-Layer Architecture

```
┌──────────────────────────────────────────────────────────────┐
│                    LAYER 1: PRESENTATION                      │
│                                                                │
│  Founder Dashboard  │  Decision Queue  │  Status Reports       │
│  Audit Viewer       │  Review Pipeline │  Notifications        │
├──────────────────────────────────────────────────────────────┤
│                    LAYER 2: ORCHESTRATION                      │
│                                                                │
│  Workflow Engine (10)  │  Governance (16)  │  Quality (17)     │
│  Automation (14)       │  Experiments (18) │  Task Mgmt (13)   │
├──────────────────────────────────────────────────────────────┤
│                    LAYER 3: AGENTS                             │
│                                                                │
│  28+ Specialized Agents (09)                                   │
│  Managed by Agent Framework (08)                               │
│  Defined in Agent Registry (07-003)                            │
├──────────────────────────────────────────────────────────────┤
│                    LAYER 4: SERVICES                           │
│                                                                │
│  Memory (12)  │  Knowledge (11)  │  Prompts (15)              │
│  Audit Logs (07-008)  │  Communication (07-004)               │
└──────────────────────────────────────────────────────────────┘
```

### 6.2 Layer Responsibilities

#### Layer 1: Presentation
- **Purpose:** The founder's window into the OS.
- **Components:** Decision queue display, workflow status dashboard, review pipeline, audit viewer, notification system.
- **Consumers:** Founder (primary), future human team members.
- **Interface:** Reads from all lower layers. Writes only founder decisions and approvals.

#### Layer 2: Orchestration
- **Purpose:** Coordinates multi-agent work according to defined rules.
- **Components:** Workflow Engine, Governance, Quality Control, Automation, Task Management, Experiments.
- **Key behavior:** Receives triggers (new task, completed step, decision needed), determines which agent(s) should act, routes work, enforces governance, manages quality gates.
- **Interface:** Receives events from Layer 3. Sends tasks to Layer 3. Reads/writes Layer 4 services.

#### Layer 3: Agents
- **Purpose:** Domain-specific intelligence. Each agent knows its domain deeply.
- **Components:** 28+ specialized agents, managed by the Agent Framework.
- **Key behavior:** Receives tasks from Layer 2. Produces outputs (code, design, content, analysis). Requests services from Layer 4 (memory retrieval, knowledge lookup, prompt templates).
- **Interface:** Receives task assignments. Returns outputs and status. Requests services.

#### Layer 4: Services
- **Purpose:** Shared infrastructure that all agents and orchestration components depend on.
- **Components:** Memory System, Knowledge System, Prompt Engineering, Communication Protocol, Audit Logs.
- **Key behavior:** Stores and retrieves persistent state. Provides shared context. Logs all actions.
- **Interface:** Responds to service requests. Publishes events on state changes.

### 6.3 Data Flow: Execute a Workflow

```
Trigger (e.g., "New Feature Request")
    │
    ▼
[Workflow Engine] loads workflow definition (10-002)
    │
    ├── Step 1: Product Manager Agent → writes feature brief
    │       │
    │       └── [Quality] Self-review → Technical review
    │
    ├── Step 2: Game Designer Agent → creates design spec
    │       │
    │       ├── [Memory] reads player behavior data
    │       ├── [Knowledge] references Design Principles (02-002)
    │       └── [Quality] Self-review → Consistency review
    │
    ├── Step 3: [Governance] checks decision authority
    │       │
    │       └── If P0/P1 → routes to Founder via Decision Queue
    │           If P2/P3 → auto-approved
    │
    ├── Step 4: Unity Architect Agent → technical design
    │       │
    │       ├── [Memory] reads architecture patterns
    │       ├── [Knowledge] references engine module registry
    │       └── [Quality] Self-review → Technical review
    │
    ├── Step 5: Gameplay Programmer Agent → implementation
    │       │
    │       ├── [Prompts] loads code generation template
    │       ├── [Memory] reads relevant code context
    │       └── [Quality] Full pipeline → Code Review Agent
    │
    └── Step 6: QA Agent → testing and validation
            │
            └── [Quality] Final quality gate → Founder review (if P0/P1)
```

### 6.4 Data Flow: Make a Decision

```
Agent encounters decision point
    │
    ▼
[Agent] classifies priority (P0/P1/P2/P3) per Decision Framework (00-003)
    │
    ├── P2/P3: Agent decides autonomously
    │       │
    │       └── [Audit] Decision logged with rationale
    │
    └── P0/P1: Agent prepares Decision Brief
            │
            ▼
    [Governance] validates classification and completeness
            │
            ▼
    [Decision Queue] queued for founder at appropriate SLA
            │
            ▼
    [Founder] reviews, decides, provides rationale
            │
            ▼
    [Memory] Decision stored in Decision Memory (12-009)
            │
            ▼
    [Audit] Full decision trail recorded
            │
            ▼
    [Workflow Engine] resumes workflow with decision outcome
```

### 6.5 Data Flow: Query Memory

```
Agent needs context for a task
    │
    ▼
[Agent] submits memory query with:
    - Query type (company/project/feature/technical/decision)
    - Relevance scope (what the agent is working on)
    - Recency preference (recent vs. historical)
    │
    ▼
[Memory System] searches appropriate memory layer(s)
    │
    ├── Applies relevance scoring
    ├── Filters by access permissions
    └── Ranks by recency and relevance
    │
    ▼
[Memory System] returns context package:
    - Relevant memories (ranked)
    - Source references (doc IDs, dates)
    - Confidence score
    │
    ▼
[Agent] incorporates context into current task
```

### 6.6 Extension Points

| Extension Point | What Can Be Added | How |
|----------------|-------------------|-----|
| New Agent | A new specialized agent | Create definition in `09_Agent_Definitions/`, register in Agent Registry |
| New Workflow | A new automated process | Create workflow definition in `10_Workflows/`, register triggers |
| New Memory Type | A new memory category | Create memory spec in `12_Memory_System/`, register in Memory Architecture |
| New Quality Gate | A new review stage | Add to Quality Pipeline (`17-001`), update workflow definitions |
| New Governance Rule | A new decision authority | Add to appropriate Governance document, update Decision Matrix |
| New Prompt Template | A new AI prompt pattern | Add to `15_AI_Prompts/`, register in Prompt Templates index |
| New Game Project | A new game using the OS | Create project memory, configure game-specific agent parameters |

### 6.7 Communication Patterns

| Pattern | When Used | Example |
|---------|-----------|---------|
| **Task Assignment** | Orchestration → Agent | Workflow Engine assigns "Write feature brief" to Product Manager Agent |
| **Output Submission** | Agent → Orchestration | Game Designer Agent submits design spec to Quality Pipeline |
| **Service Request** | Agent → Services | Agent requests relevant memories from Memory System |
| **Event Publication** | Any → Any (via event bus) | "Feature approved" event triggers downstream workflow steps |
| **Escalation** | Agent → Governance | Agent escalates a decision beyond its authority level |
| **Notification** | Orchestration → Presentation | Decision Queue notifies founder of pending P0 decision |

## 7. Acceptance Criteria

- [ ] Every data flow can be traced through the four layers without ambiguity.
- [ ] No component communicates with a non-adjacent layer (no layer-skipping).
- [ ] Every extension point allows addition without modification of existing components.
- [ ] The architecture supports all 14 defined workflows (`10_Workflows/`).
- [ ] Agent statelessness is maintained — all state lives in Layer 4 services.

## 8. KPIs

| KPI | Target | Measurement |
|-----|--------|-------------|
| Architecture compliance | 100% of workflows follow the four-layer model | Architecture audit |
| Extension time (add new agent) | <30 minutes | Measured during agent creation |
| Extension time (add new workflow) | <60 minutes | Measured during workflow creation |
| Layer coupling violations | 0 | Architecture review |
| Service availability | 95%+ (no blocked agents due to service failure) | Operations monitoring |

## 9. Risks

| Risk | Likelihood | Impact | Mitigation |
|------|-----------|--------|------------|
| Architecture too abstract for a documentation-based system | High | Medium | Treat docs as the implementation. Architecture guides document organization and cross-referencing. Evolve to code when scale demands. |
| Layer boundaries create bureaucratic overhead | Medium | Medium | Layers govern structure, not speed. Agents operate freely within their layer. Boundaries are enforced at integration points, not within agent work. |
| Stateless agents lose efficiency (re-reading context each time) | Medium | Low | Memory System provides efficient context injection. Agents receive pre-packaged context, not raw data. |

## 10. Future Expansion

- **Code implementation.** When the company reaches scale that demands it, implement the Agent OS as a running software system with APIs, databases, and real-time orchestration.
- **Multi-instance deployment.** Run separate OS instances per game project with shared company-level services.
- **External API.** Expose Agent OS capabilities via API for integration with third-party tools (GitHub, Firebase, Unity Cloud).

## 11. AI Automation Opportunities

- **Architecture violation detection.** Automated scanning for layer-skipping or improper communication patterns.
- **Data flow tracing.** Given any trigger, automatically trace the expected data flow through all four layers.
- **Capacity planning.** Based on workflow volume trends, predict when the architecture needs to evolve from documentation to code.

## 12. Open Questions

1. Should the Presentation Layer (founder interface) be a real UI, or are markdown dashboards and file-based queues sufficient for now?
2. When does the "documentation-defined OS" need to become a "code-defined OS"? What triggers that transition?
3. How do we handle real-time coordination when multiple agents need to work on the same feature simultaneously?

## 13. Decision History

| Date | Decision | Rationale |
|------|----------|-----------|
| 2026-06-27 | Four-layer architecture adopted | Clean separation of concerns. Each layer has a clear responsibility and interface. Prevents spaghetti. |
| 2026-06-27 | Stateless agent design | Agents as pure functions of (task + context) → output. All state in services. Makes agents replaceable and versionable. |
| 2026-06-27 | Event-driven coordination | Agents react to events, not polling. More efficient, more scalable, cleaner dependencies. |

## 14. Related Documents

| Doc ID | Title | Relationship |
|--------|-------|-------------|
| 07-001 | Agent OS Vision | Vision this architecture implements |
| 07-003 | Agent Registry | Registry of agents in Layer 3 |
| 07-004 | Communication Protocol | Detailed communication patterns between layers |
| 08-001 | Agent Lifecycle | How agents in Layer 3 are created and managed |
| 10-001 | Workflow Engine | Orchestration layer's primary component |
| 12-001 | Memory Architecture | Service layer's memory subsystem |
| 16-001 | Decision Matrix | Governance layer's authority rules |
