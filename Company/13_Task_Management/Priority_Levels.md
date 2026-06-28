---
document_id: "13-003"
title: "Priority Levels"
owner: "Founder Agent"
status: "Approved"
version: "1.0"
created: "2026-06-28"
updated: "2026-06-28"
phase: "Phase 1 — Agent Operating System"
priority: "P0"
tags: [task-management, priority, sla]
related_documents: ["13-001: Task System Overview", "00-003: Decision Framework"]
related_agents: ["All Agents"]
dependencies: ["00-003: Decision Framework"]
---
# Priority Levels
## Priority Definitions
| Priority | Label | SLA | Example Tasks | Who Assigns |
|----------|-------|-----|--------------|-------------|
| **P0** | Critical | Begin immediately, complete within 4 hours | Production crash, data breach, blocking release | Founder or QA Agent |
| **P1** | High | Begin within 4 hours, complete within 24 hours | Feature for current sprint, architecture blocker | Product Manager or Founder |
| **P2** | Medium | Begin within 24 hours, complete within sprint | Standard feature task, documentation update | Product Manager or assigned agent |
| **P3** | Low | Complete within 2 sprints | Nice-to-have improvement, research task | Any agent |

## Escalation Rules
- P0 overdue by 1 hour → Founder notified immediately
- P1 overdue by 4 hours → Founder Agent flags in decision queue
- P2 overdue by 2 days → Product Manager Agent reviews
- P3 overdue by 1 sprint → Auto-defer or auto-cancel review

## Priority Conflicts
When two P0 tasks compete for the same agent: Founder decides order. When two P1 tasks compete: Product Manager Agent decides based on RICE score and sprint goals.
