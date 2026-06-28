---
document_id: "16-010"
title: "Documentation Standards"
owner: "Documentation Agent"
status: "Approved"
version: "1.0"
created: "2026-06-28"
updated: "2026-06-28"
phase: "Phase 1 — Agent Operating System"
priority: "P1"
tags: [governance, documentation, standards]
related_documents: ["11-006: Metadata Standards"]
related_agents: ["Documentation Agent"]
dependencies: ["11-006: Metadata Standards"]
---
# Documentation Standards
## 1. Vision
Documentation is the source code of the company. It must be consistently structured, highly readable, and easily parsed by both humans and AI.

## 6. Requirements
### 6.1 Mandatory Structure
Every standard document must include:
1. YAML Frontmatter (per `11-006`).
2. H1 `# Document Title` matching the filename and frontmatter title.
3. Defined sections (Vision, Requirements, etc.) using H2 `##`.

### 6.2 Writing Style
- **Concise:** Use bullet points and tables instead of walls of text.
- **Definitive:** Use "must" and "will" instead of "should" or "could" for rules.
- **DRY (Don't Repeat Yourself):** Reference other documents instead of redefining concepts.

### 6.3 Maintenance
- Documents must be updated when reality changes. A stale document is worse than no document.
- The Documentation Agent flags any document without a review in >6 months for freshness auditing.
