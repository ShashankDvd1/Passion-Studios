---
document_id: "12-009"
title: "Decision Memory"
owner: "Founder Agent"
status: "Approved"
version: "1.0"
created: "2026-06-28"
updated: "2026-06-28"
phase: "Phase 1 — Agent Operating System"
priority: "P0"
tags: [memory, decisions, institutional, governance]
related_documents: ["12-001: Memory Architecture", "00-003: Decision Framework"]
related_agents: ["Founder Agent", "CEO Agent", "All Agents"]
dependencies: ["12-001: Memory Architecture"]
---
# Decision Memory
## Mission
Store every significant decision with full context: what was decided, why, what alternatives were considered, who decided, and what the outcome was. This is the company's institutional brain — ensuring no decision is relitigated without new information, and all agents learn from past decisions.
## Content Categories
| Category | What's Stored | Expiry |
|----------|-------------|--------|
| **P0 Decisions** | Existential decisions (vision, values, strategy pivots) | Permanent |
| **P1 Decisions** | Strategic decisions (features, architecture, partnerships) | Permanent |
| **P2 Decisions** | Tactical decisions (implementation approaches, prioritization) | 12 months |
| **P3 Decisions** | Operational decisions (scheduling, formatting, tooling) | 6 months |
| **Decision Outcomes** | What actually happened after the decision | Appended when known |
| **Reversed Decisions** | Decisions that were changed, with rationale for reversal | Permanent |
## Decision Entry Format
```yaml
decision:
  id: "DEC-YYYY-MM-DD-NNN"
  priority: "P0 | P1 | P2 | P3"
  date: "ISO-8601"
  decided_by: "Founder | CEO Agent | Agent Name"
  problem: "What decision was needed"
  options_considered: [{name: "", pros: [], cons: []}]
  decision_made: "Which option was chosen"
  rationale: "Why this option"
  outcome: "pending | successful | partially_successful | failed | reversed"
  outcome_date: "ISO-8601 or null"
  outcome_notes: "What happened"
```
## Key Rule: Before any agent proposes a decision, they query Decision Memory for prior decisions on the same topic. If a P0/P1 decision exists, the agent references it rather than relitigating.
