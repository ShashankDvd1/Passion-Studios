---
document_id: "17-007"
title: "Learning Framework"
owner: "CEO Agent"
status: "Approved"
version: "1.0"
created: "2026-06-28"
updated: "2026-06-28"
phase: "Phase 1 — Agent Operating System"
priority: "P1"
tags: [quality, learning, improvement, post-mortem]
related_documents: ["10-014: Post Mortem Workflow", "12-009: Decision Memory"]
related_agents: ["CEO Agent", "All Agents"]
dependencies: []
---
# Learning Framework
## 1. Vision
An AI workforce that doesn't learn from its mistakes is just a fast way to generate garbage. The Learning Framework ensures that every failure, bug, and missed KPI results in a structural improvement to the system.

## 6. Requirements
### 6.1 Learning Triggers
A learning cycle is triggered by:
- Any F6, F7, or F8 system error.
- A failed A/B test or missed feature KPI.
- A Post-Mortem Workflow (`10-014`).
- P0 bugs found in production.

### 6.2 The Learning Process
1. **Identify the Gap:** Was it a missing constraint? A bad prompt? A flawed workflow?
2. **System Update:** Instead of just fixing the immediate bug, update the underlying system.
   - Example: If a mechanic triggered player anxiety, don't just redesign the mechanic—update the *Behavioral Psychology Agent's prompt* to explicitly check for that specific pattern in the future.
3. **Memory Storage:** Log the learning in Decision Memory (`12-009`) or Persistent Company Memory (`12-002`).

### 6.3 Blameless Culture
Agents don't have egos, but prompts do have flaws. When a failure occurs, the default assumption is that the instructions (prompts or workflows) were inadequate, not that the AI model "failed." Fix the instructions.
