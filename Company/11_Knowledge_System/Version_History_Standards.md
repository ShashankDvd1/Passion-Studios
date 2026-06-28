---
document_id: "11-008"
title: "Version History Standards"
owner: "Documentation Agent"
status: "Approved"
version: "1.0"
created: "2026-06-28"
updated: "2026-06-28"
phase: "Phase 1 — Agent Operating System"
priority: "P1"
tags: [versioning, standards, documentation, history]
related_documents: ["08-004: Agent Versioning", "11-009: Change Log Standards"]
related_agents: ["Documentation Agent"]
dependencies: []
---
# Version History Standards
## 1. Vision
Every document in the company system is versioned. Version history tracks what changed, when, why, and who approved it. This enables rollback, accountability, and institutional memory of document evolution.

## 6. Requirements
### 6.1 Versioning Schema
**Format: MAJOR.MINOR** (same as Agent Versioning `08-004`)
- **MAJOR (X.0):** Fundamental changes to purpose, scope, or structure. Requires founder approval.
- **MINOR (.Y):** Content updates, corrections, additions within existing scope. Owner-approved.

### 6.2 Version History Format
Every document includes (or references) a version history:
```yaml
version_history:
  - version: "1.0"
    date: "2026-06-28"
    author: "Creating Agent"
    type: "Initial release"
    summary: "Document created as part of Phase 1."
  - version: "1.1"
    date: "2026-08-01"
    author: "Documentation Agent"
    type: "Minor — Content update"
    summary: "Added 3 new glossary terms, corrected cross-reference."
```

### 6.3 Rules
1. Version number in frontmatter always reflects the current (latest) version.
2. Version history is append-only — never modify historical entries.
3. MAJOR changes require a new entry in the document's Decision History section.
4. Documents start at v1.0 (not v0.1 — we don't publish drafts as versioned docs).

## 7. Acceptance Criteria
- [ ] Every document has a valid version number in frontmatter
- [ ] Version increments follow MAJOR.MINOR rules consistently
- [ ] Version history entries include date, author, type, and summary

## 14. Related Documents
| Doc ID | Title | Relationship |
|--------|-------|-------------|
| 08-004 | Agent Versioning | Same schema applied to agents |
| 11-009 | Change Log Standards | Detailed change tracking |
