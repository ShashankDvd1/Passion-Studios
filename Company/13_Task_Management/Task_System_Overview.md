---
document_id: "13-001"
title: "Task System Overview"
owner: "Automation Agent"
status: "Approved"
version: "1.0"
created: "2026-06-28"
updated: "2026-06-28"
phase: "Phase 1 — Agent Operating System"
priority: "P0"
tags: [task-management, system, overview, infrastructure]
related_documents: ["07-002: System Architecture", "10-001: Workflow Engine"]
related_agents: ["Automation Agent", "Founder Agent", "All Agents"]
dependencies: ["07-002: System Architecture"]
---
# Task System Overview
## 1. Vision
The Task System tracks every unit of work in the company — from a simple document update to a multi-sprint feature implementation. It is the operational backbone that connects workflows (which define how work should happen) to actual work progress.
## 6. Requirements
### 6.1 Task Hierarchy
```
Epic (Strategic Goal)
├── Milestone (Measurable Achievement)
│   ├── Story (User-Facing Capability)
│   │   ├── Task (Single Agent Assignment)
│   │   │   └── Subtask (Atomic Work Unit)
│   │   └── Task
│   └── Story
└── Milestone
```
### 6.2 Task Schema
```yaml
task:
  id: "TASK-NNNN"
  title: "Descriptive title"
  type: "epic | milestone | story | task | subtask"
  status: "See Task States (13-002)"
  priority: "P0 | P1 | P2 | P3"
  assigned_agent: "09-NNN"
  workflow: "WF-NNN (if part of a workflow)"
  parent: "Parent task ID"
  dependencies: ["Blocking task IDs"]
  created: "ISO-8601"
  due: "ISO-8601 or null"
  completed: "ISO-8601 or null"
  acceptance_criteria: ["List of criteria"]
  output: "Link to output artifact"
```
### 6.3 System Rules
1. Every task has exactly one assigned agent (owner).
2. Every task has acceptance criteria before work begins.
3. Task status transitions follow the defined state machine (13-002).
4. Blocked tasks show their blocker clearly.
5. Completed tasks record their output artifact location.
6. Overdue tasks generate alerts per Priority Levels (13-003) SLAs.
