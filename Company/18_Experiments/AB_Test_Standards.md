---
document_id: "18-002"
title: "A/B Test Standards"
owner: "Analytics Agent"
status: "Approved"
version: "1.0"
created: "2026-06-28"
updated: "2026-06-28"
phase: "Phase 1 — Agent Operating System"
priority: "P1"
tags: [experiments, ab-testing, standards]
related_documents: ["18-001: Experiment Framework"]
related_agents: ["Analytics Agent"]
dependencies: ["18-001: Experiment Framework"]
---
# A/B Test Standards
## 1. Vision
Rigorous standards for conducting A/B tests to prevent false positives, Simpson's Paradox, and corrupted data.

## 6. Requirements
### 6.1 Test Setup
- **Sample Size:** Minimum sample size must be calculated *before* launch based on expected effect size and baseline metric.
- **Duration:** Minimum 7 days to account for day-of-week seasonality, regardless of how quickly significance is reached. Maximum 30 days (if not significant by then, effect size is negligible).

### 6.2 Target Metrics
- **Primary KPI:** The single metric this test aims to improve (e.g., D7 Retention).
- **Secondary KPIs:** Supporting metrics (e.g., Session Length, Core Loop completions).
- **Guardrail KPIs:** Metrics that must *not* significantly degrade (e.g., Crash Rate, ARPDAU). If a test improves the Primary KPI but tanks a Guardrail KPI, it fails.

### 6.3 Audience Splitting
- Uses consistent hashing to ensure a player remains in the same bucket (A or B) across sessions and devices.
- Segments must be mutually exclusive for tests targeting the same surface area.
