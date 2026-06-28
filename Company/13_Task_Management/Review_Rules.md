---
document_id: "13-009"
title: "Review Rules"
owner: "Code Review Agent"
status: "Approved"
version: "1.0"
created: "2026-06-28"
updated: "2026-06-28"
phase: "Phase 1 — Agent Operating System"
priority: "P0"
tags: [task-management, review, quality, gates]
related_documents: ["17-001: Quality Pipeline", "13-002: Task States"]
related_agents: ["All Agents"]
dependencies: ["17-001: Quality Pipeline"]
---
# Review Rules
## 1. Vision
Every piece of work passes through defined quality gates before it is considered DONE. Review rules define how tasks transition from `IN_PROGRESS` through `IN_REVIEW` to `DONE` or `REVISION`.

## 6. Requirements
### 6.1 Review Routing
1. When a task is submitted for review, it enters the Quality Pipeline (`17-001`).
2. The specific reviews required depend on the task type (e.g., code requires Code Review Agent; game design requires technical review by Unity Architect).
3. Founder review is the final gate for P0/P1 tasks.

### 6.2 Review SLA
- Reviews must be completed within 24 hours of submission.
- Overdue reviews are escalated to the Founder Agent.

### 6.3 Feedback Format
- Feedback must be **actionable, specific, and objective**.
- Reviewers must cite the specific standard or principle being violated (e.g., "Violates SOLID principle: Class X has multiple responsibilities. See Quality Standards 02-004").
- Vague feedback ("Make this better") is rejected.

### 6.4 Revision Loops
- If a task is returned for `REVISION`, the assigned agent addresses the feedback and resubmits.
- A task that enters the `REVISION` state 3 times for the same issue escalates to the CTO Agent or Founder for intervention.
