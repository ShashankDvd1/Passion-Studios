---
document_id: "10-014"
title: "Post Mortem Workflow"
owner: "CEO Agent"
status: "Approved"
version: "1.0"
created: "2026-06-28"
updated: "2026-06-28"
phase: "Phase 1 — Agent Operating System"
priority: "P1"
tags: [workflow, post-mortem, learning, retrospective]
related_documents: ["10-001: Workflow Engine", "12-009: Decision Memory"]
related_agents: ["CEO Agent", "Product Manager Agent", "Relevant domain agents"]
dependencies: ["10-001: Workflow Engine"]
---
# Post Mortem Workflow
## Trigger
Event — After major incident (F7/F8 failure), product launch, feature launch, or quarterly review.
## Steps
1. **Timeline Reconstruction** (CEO Agent) → Chronological events from audit logs
2. **Root Cause Analysis** (Relevant domain agents) → What caused the outcome (good or bad)
3. **Impact Assessment** (Analytics Agent) → Quantified impact on KPIs
4. **Lessons Learned** (All involved agents) → What worked, what didn't, what to change
5. **Action Items** (Product Manager Agent) → Specific, assigned, time-bound improvements
6. **Memory Update** (Documentation Agent) → Store learnings in Decision Memory (12-009)
7. **Founder Review** (Founder) → Review findings and approve action items
## Governance: P1 for incident post-mortems. P2 for routine retrospectives.
## Format: Blameless. Focus on systems and processes, not individuals or agents.
## Estimated Duration: 2-4 hours
