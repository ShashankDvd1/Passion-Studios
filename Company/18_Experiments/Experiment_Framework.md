---
document_id: "18-001"
title: "Experiment Framework"
owner: "Analytics Agent"
status: "Approved"
version: "1.0"
created: "2026-06-28"
updated: "2026-06-28"
phase: "Phase 1 — Agent Operating System"
priority: "P0"
tags: [experiments, framework, testing, data]
related_documents: ["01-004: Success Definition"]
related_agents: ["Analytics Agent", "Product Manager Agent"]
dependencies: ["01-004: Success Definition"]
---
# Experiment Framework
## 1. Vision
We don't guess; we test. Every feature, balance change, or UI update that affects player behavior must be run as an experiment. The Experiment Framework ensures we learn the true impact of our decisions.

## 6. Requirements
### 6.1 Core Principles
1. **Hypothesis-Driven:** No experiment runs without a written hypothesis (`18-003`).
2. **Control vs. Treatment:** Always measure against a control group to isolate impact.
3. **Statistical Significance:** Never make a decision on "gut feeling" early data. Wait for 95% statistical significance.
4. **Kill Switch:** Every experiment must have a remote-config kill switch in case of catastrophic metrics failure (e.g., crashing economy).

### 6.2 Experiment Lifecycle
1. **Design:** Product Manager Agent writes Hypothesis.
2. **Implementation:** Engineering Agents build variant + kill switch.
3. **Launch:** Rolled out to a target segment (e.g., 5% of new users).
4. **Monitor:** Analytics Agent tracks KPIs vs. Control.
5. **Decision:** Once significant, Analytics Agent recommends Rollout (100%), Iterate, or Kill.
6. **Documentation:** Results written to Results Template (`18-004`) and stored in Feature Memory.
