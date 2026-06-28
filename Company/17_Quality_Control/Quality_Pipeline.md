---
document_id: "17-001"
title: "Quality Pipeline"
owner: "QA Agent"
status: "Approved"
version: "1.0"
created: "2026-06-28"
updated: "2026-06-28"
phase: "Phase 1 — Agent Operating System"
priority: "P0"
tags: [quality, pipeline, review, gates]
related_documents: ["02-004: Quality Standards", "13-009: Review Rules"]
related_agents: ["All Agents"]
dependencies: ["02-004: Quality Standards"]
---
# Quality Pipeline
## 1. Vision
AI models hallucinate, drift, and take shortcuts. The Quality Pipeline is the multi-layered filter that catches these errors before they reach production. It turns raw AI generation into enterprise-grade output.

## 6. Requirements
### 6.1 The Pipeline Stages
Every piece of output passes through these gates in order. A failure at any gate returns the work to the creator for revision.

1. **Self-Review:** The creator agent reviews its own work against a checklist.
2. **Technical Review:** A domain expert agent verifies the technical accuracy and architecture.
3. **Consistency Review:** An adjacent agent verifies alignment with world, brand, and economy constraints.
4. **Documentation Review:** Documentation Agent verifies format and cross-references.
5. **Founder Review:** The final sign-off for P0/P1 items.

### 6.2 Pipeline Application
Not all tasks require the full pipeline. The routing depends on the task priority and agent autonomy:
- **P0/P1 Tasks:** Full pipeline (Stages 1-5).
- **P2 Tasks:** Stages 1-3.
- **P3 Tasks:** Stage 1 only (with random audits).
