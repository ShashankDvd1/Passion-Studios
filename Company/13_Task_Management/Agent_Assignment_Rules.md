---
document_id: "13-007"
title: "Agent Assignment Rules"
owner: "Product Manager Agent"
status: "Approved"
version: "1.0"
created: "2026-06-28"
updated: "2026-06-28"
phase: "Phase 1 — Agent Operating System"
priority: "P1"
tags: [task-management, assignment, agents, routing]
related_documents: ["08-005: Capability Matrix", "13-001: Task System Overview"]
related_agents: ["All Agents"]
dependencies: ["08-005: Capability Matrix"]
---
# Agent Assignment Rules
## 1. Vision
Work must route to the right agent automatically. The Capability Matrix defines who *can* do the work; these assignment rules define who *actually* gets the task based on current capacity, domain ownership, and task type.

## 6. Requirements
### 6.1 Core Assignment Rules
1. **Single Owner:** Every task has exactly one assigned agent. No shared ownership.
2. **Domain Matching:** Tasks are assigned to the primary agent for the relevant domain/capability (per Capability Matrix `08-005`).
3. **Capacity Constraints:** Agents have an assumed concurrent task limit (default: 3 active tasks).
4. **Fallback Assignment:** If the primary agent is overloaded or unavailable, work queues in their backlog or escalates to their domain fallback agent.
5. **Workflow Overrides:** Workflow definitions (`10-NNN`) explicitly define agent assignments for specific steps, overriding general rules.

### 6.2 Cross-Domain Tasks
When a task spans multiple domains (e.g., "Design and implement new UI screen"):
- **Rule:** Decompose the task. The Product Manager Agent breaks it into single-domain subtasks (UX flow → UI design → Implementation) and assigns them sequentially.

### 6.3 Reassignment
- Agents can reassign a task if it falls outside their capability.
- Reassignment must be logged with the reason.
- Continuous reassignment (bouncing) triggers an escalation to the CTO Agent to clarify domain boundaries.
