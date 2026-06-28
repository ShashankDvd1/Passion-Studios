---
document_id: "18-004"
title: "Results Template"
owner: "Analytics Agent"
status: "Approved"
version: "1.0"
created: "2026-06-28"
updated: "2026-06-28"
phase: "Phase 1 — Agent Operating System"
priority: "P1"
tags: [experiments, templates, results, data]
related_documents: ["18-003: Hypothesis Template"]
related_agents: ["Analytics Agent", "Product Manager Agent"]
dependencies: ["18-003: Hypothesis Template"]
---
# Results Template
## 1. Vision
Data is useless without conclusions. The Results Template standardizes how we interpret experiment data and apply it to future development.

## 6. Requirements
### 6.1 The Template Structure
```yaml
results_id: "RES-NNN"
hypothesis_id: "HYP-NNN"
date_concluded: "YYYY-MM-DD"
duration_days: N
sample_size: N
```
### Executive Summary
One paragraph: Did it win, lose, or draw? What is the recommendation (Rollout, Kill, Iterate)?

### Metric Results
- **Primary KPI:** Control vs. Treatment (with p-value / statistical significance).
- **Guardrail KPIs:** Did any guardrails fail?
- **Unexpected Findings:** Metrics that moved significantly but weren't targeted.

### Conclusion & Learnings
- Was the original hypothesis proven or disproven?
- **WHY** do we think the players reacted this way? (Update Behavioral Psychology models if necessary).
- What can we apply from this to other systems?

### Next Steps
Specific actions assigned via Task System (e.g., "Rollout to 100%", "Delete treatment code", "Design Iteration 2").
