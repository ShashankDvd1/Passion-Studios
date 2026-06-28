---
document_id: "15-007"
title: "Prompt Evaluation"
owner: "Prompt Engineering Agent"
status: "Approved"
version: "1.0"
created: "2026-06-28"
updated: "2026-06-28"
phase: "Phase 1 — Agent Operating System"
priority: "P1"
tags: [prompts, evaluation, metrics]
related_documents: ["15-001: Prompt Engineering Framework"]
related_agents: ["Prompt Engineering Agent", "Analytics Agent"]
dependencies: []
---
# Prompt Evaluation
## 1. Vision
Prompts are evaluated continuously in production using objective metrics, not subjective feelings.

## 6. Requirements
### 6.1 Core Metrics
| Metric | Target | Definition |
|--------|--------|------------|
| **First-Pass Approval Rate** | >80% | Tasks approved by Quality Gates without requiring revision. |
| **Constraint Violation Rate** | <2% | Instances where the output violates a defined negative constraint. |
| **Format Error Rate** | 0% | Outputs that fail JSON/YAML parsing. |
| **Token Efficiency** | Context-dependent | Ratio of generated output value to input tokens consumed. |

### 6.2 Weekly Evaluation
- The Prompt Engineering Agent generates a weekly report of the bottom 3 performing agent prompts based on First-Pass Approval Rate.
- These bottom 3 prompts are automatically scheduled for the Prompt Optimization workflow (`15-008`).
