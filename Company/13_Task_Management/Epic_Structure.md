---
document_id: "13-004"
title: "Epic Structure"
owner: "Product Manager Agent"
status: "Approved"
version: "1.0"
created: "2026-06-28"
updated: "2026-06-28"
phase: "Phase 1 — Agent Operating System"
priority: "P1"
tags: [task-management, epic, planning]
related_documents: ["13-001: Task System Overview", "13-005: Milestone Framework"]
related_agents: ["Product Manager Agent", "CEO Agent"]
dependencies: ["13-001: Task System Overview"]
---
# Epic Structure
## Definition
An Epic is a strategic goal decomposed into milestones, stories, and tasks. Epics span multiple sprints and represent significant product capabilities.
## Epic Format
```yaml
epic:
  id: "EPIC-NNN"
  title: "Epic Title"
  owner: "Product Manager Agent"
  objective: "What this epic achieves (1 sentence)"
  success_metric: "How we know it's successful"
  target_date: "Target completion"
  milestones: ["MS-NNN"]
  status: "Planning | Active | Complete | Cancelled"
```
## Epic Lifecycle
1. **Planning:** Epic defined with objective, success metric, and initial milestone breakdown.
2. **Active:** Milestones being executed. Stories and tasks flowing through sprints.
3. **Complete:** All milestones achieved. Success metric validated.
4. **Post-Mortem:** Epic reviewed for learnings (per Post Mortem Workflow 10-014).
## Rules
- Maximum 3 active epics simultaneously (focus over breadth).
- Every epic has exactly one owner (Product Manager Agent by default).
- Epics without progress for 2 sprints trigger a review: continue, restructure, or cancel.
