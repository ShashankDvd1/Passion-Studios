---
document_id: "13-002"
title: "Task States"
owner: "Automation Agent"
status: "Approved"
version: "1.0"
created: "2026-06-28"
updated: "2026-06-28"
phase: "Phase 1 — Agent Operating System"
priority: "P0"
tags: [task-management, states, workflow, status]
related_documents: ["13-001: Task System Overview"]
related_agents: ["All Agents"]
dependencies: ["13-001: Task System Overview"]
---
# Task States
## State Machine
```
BACKLOG → READY → IN_PROGRESS → IN_REVIEW → DONE
                       │              │
                       ▼              ▼
                   BLOCKED        REVISION
                       │              │
                       ▼              ▼
                   IN_PROGRESS   IN_PROGRESS
                   
Any state → CANCELLED (terminal)
```
## State Definitions
| State | Meaning | Who Sets | Exit Criteria |
|-------|---------|----------|--------------|
| **BACKLOG** | Identified but not ready for work | Product Manager | Acceptance criteria defined, agent assigned |
| **READY** | Ready for work, all dependencies met | Workflow Engine | Agent picks up the task |
| **IN_PROGRESS** | Agent is actively working | Assigned Agent | Output produced and submitted |
| **IN_REVIEW** | Output submitted, awaiting quality gate | Quality Pipeline | Review passes or revision requested |
| **REVISION** | Review returned with feedback | Quality Pipeline | Agent addresses feedback and resubmits |
| **BLOCKED** | Cannot proceed (dependency, decision needed) | Assigned Agent | Blocker resolved |
| **DONE** | Completed, output accepted | Quality Pipeline | Final quality gate passed |
| **CANCELLED** | Will not be completed | Product Manager/Founder | Task no longer needed |
## Rules
1. Only forward transitions (no skipping states) except BLOCKED and CANCELLED.
2. Tasks in BLOCKED must identify the specific blocker.
3. Tasks in REVISION must include specific feedback.
4. DONE tasks must have an output artifact linked.
