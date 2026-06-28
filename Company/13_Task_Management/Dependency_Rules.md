---
document_id: "13-008"
title: "Dependency Rules"
owner: "Product Manager Agent"
status: "Approved"
version: "1.0"
created: "2026-06-28"
updated: "2026-06-28"
phase: "Phase 1 — Agent Operating System"
priority: "P1"
tags: [task-management, dependencies, blocking]
related_documents: ["13-001: Task System Overview", "13-002: Task States"]
related_agents: ["All Agents"]
dependencies: []
---
# Dependency Rules
## 1. Vision
Dependencies must be explicit. An agent should never start a task if the prerequisites are not complete. The Task System tracks and enforces these dependencies.

## 6. Requirements
### 6.1 Dependency Types
| Type | Description | Example |
|------|-------------|---------|
| **Hard Blocker (Finish-to-Start)** | Task B cannot start until Task A is DONE. | Code implementation cannot start until technical design is approved. |
| **Soft Blocker (Start-to-Start)** | Task B can start, but cannot finish until Task A finishes. | UI design can start based on draft UX, but cannot finalize until UX is approved. |
| **Data Dependency** | Task B requires a specific output artifact from Task A. | Economy Agent needs the behavioral model output from the Psychology Agent. |

### 6.2 Enforcing Dependencies
1. A task with unresolved hard blockers remains in `BACKLOG` and cannot move to `READY`.
2. When all blocking tasks reach `DONE`, the dependent task automatically moves to `READY`.
3. If a blocking task is `CANCELLED`, dependent tasks must be reviewed by the Product Manager Agent (they may also need cancellation).

### 6.3 Deadlock Prevention
- Circular dependencies (A blocks B, B blocks A) are invalid and flagged by the Task System upon creation.
- If discovered during execution, both tasks move to `BLOCKED` and escalate to the CTO Agent for resolution.
