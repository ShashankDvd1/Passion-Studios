---
document_id: "17-005"
title: "Documentation Review Standards"
owner: "Documentation Agent"
status: "Approved"
version: "1.0"
created: "2026-06-28"
updated: "2026-06-28"
phase: "Phase 1 — Agent Operating System"
priority: "P2"
tags: [quality, review, documentation]
related_documents: ["17-001: Quality Pipeline", "16-010: Documentation Standards"]
related_agents: ["Documentation Agent"]
dependencies: ["17-001: Quality Pipeline"]
---
# Documentation Review Standards
## 1. Vision
Ensure that all output (documents, specs, ADrs) is properly formatted, linked, and ingestible by the Knowledge Graph before it is finalized.

## 6. Requirements
### 6.1 The Review Checklist
Performed exclusively by the Documentation Agent:
1. Does it have valid YAML frontmatter?
2. Are all cross-references (`doc_id` format) valid and unbroken?
3. Is it properly tagged?
4. Is it stored in the correct folder based on the Naming Convention (`11-003`)?
5. Is the tone professional and concise?

### 6.2 Auto-Fixing
Unlike other review stages that bounce work back to the creator, the Documentation Agent is authorized to autonomously fix minor formatting errors (e.g., fixing a broken link, adding a missing tag) rather than blocking the pipeline.
