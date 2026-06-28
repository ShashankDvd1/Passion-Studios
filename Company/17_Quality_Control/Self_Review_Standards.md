---
document_id: "17-002"
title: "Self Review Standards"
owner: "QA Agent"
status: "Approved"
version: "1.0"
created: "2026-06-28"
updated: "2026-06-28"
phase: "Phase 1 — Agent Operating System"
priority: "P1"
tags: [quality, review, self-review]
related_documents: ["17-001: Quality Pipeline"]
related_agents: ["All Agents"]
dependencies: ["17-001: Quality Pipeline"]
---
# Self Review Standards
## 1. Vision
Quality begins with the creator. Before asking another agent or the Founder to review work, an agent must verify its own output against constraints.

## 6. Requirements
### 6.1 The Self-Review Process
- Implemented as a final prompt step or a secondary evaluation pass by the same agent.
- The agent must explicitly output a filled checklist verifying constraints.

### 6.2 Universal Self-Review Checklist
Before submission, every agent must answer:
1. Did I address the specific task requested?
2. Did I follow all explicit negative constraints?
3. Is my output in the exact requested format (JSON/YAML/Markdown)?
4. Did I reference the required framework (Design, Ethical, Architecture)?
5. If this is a decision, did I provide a clear recommendation?

### 6.3 Failure Handling
If the agent detects a failure during self-review, it must regenerate the output before submitting it to the next pipeline stage.
