---
document_id: "18-003"
title: "Hypothesis Template"
owner: "Product Manager Agent"
status: "Approved"
version: "1.0"
created: "2026-06-28"
updated: "2026-06-28"
phase: "Phase 1 — Agent Operating System"
priority: "P1"
tags: [experiments, templates, hypothesis]
related_documents: ["18-001: Experiment Framework"]
related_agents: ["Product Manager Agent", "Analytics Agent"]
dependencies: []
---
# Hypothesis Template
## 1. Vision
A standardized format for declaring what we believe will happen and why, *before* we write any code.

## 6. Requirements
### 6.1 The Template Structure
```yaml
hypothesis_id: "HYP-NNN"
feature_id: "FEAT-NNN"
status: "Draft | Active | Concluded"
```
### Observation
What data or player behavior led to this idea? (e.g., "Only 12% of players interact with the garden after Day 3.")

### Hypothesis Statement
**If we** [change X]
**Then** [metric Y] **will improve by** [Z%]
**Because** [behavioral psychology or game design rationale].

### Metrics
- **Primary KPI:** (e.g., D7 Retention)
- **Guardrail KPIs:** (e.g., Session Length must not decrease by >5%)

### Variants
- **Control (A):** The current experience.
- **Treatment (B):** The proposed change.

### Required Resources
Estimated engineering and art effort to build the minimum viable test.
