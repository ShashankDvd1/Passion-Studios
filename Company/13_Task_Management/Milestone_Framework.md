---
document_id: "13-005"
title: "Milestone Framework"
owner: "Product Manager Agent"
status: "Approved"
version: "1.0"
created: "2026-06-28"
updated: "2026-06-28"
phase: "Phase 1 — Agent Operating System"
priority: "P1"
tags: [task-management, milestone, planning, tracking]
related_documents: ["13-004: Epic Structure", "01-004: Success Definition"]
related_agents: ["Product Manager Agent", "CEO Agent", "Founder Agent"]
dependencies: ["13-004: Epic Structure"]
---
# Milestone Framework
## Definition
A Milestone is a measurable achievement within an Epic. It marks significant progress and has clear, binary completion criteria (done or not done).
## Milestone Types
| Type | Scope | Example |
|------|-------|---------|
| **Product** | Feature or capability complete | "Crafting system playable end-to-end" |
| **Technical** | Infrastructure or architecture ready | "Addressables pipeline working on target devices" |
| **Business** | Business metric achieved | "D7 retention reaches 25%" |
| **Release** | Version shipped | "v1.0 submitted to App Store" |
| **Company** | Organizational achievement | "Agent OS Phase 1 complete" |
## Milestone Format
```yaml
milestone:
  id: "MS-NNN"
  title: "Milestone Title"
  epic: "EPIC-NNN"
  type: "product | technical | business | release | company"
  criteria: "Binary completion criteria — done or not done"
  target_date: "YYYY-MM-DD"
  actual_date: "YYYY-MM-DD or null"
  status: "Pending | In Progress | Achieved | Missed | Cancelled"
```
## Rules
- Milestones are binary: achieved or not. No "80% done" milestones.
- Missed milestones trigger a review (why missed, revised timeline, what changes).
- Company milestone achievements are celebrated (recognition reinforces culture).
