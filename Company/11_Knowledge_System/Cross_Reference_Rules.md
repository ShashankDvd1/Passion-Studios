---
document_id: "11-005"
title: "Cross Reference Rules"
owner: "Documentation Agent"
status: "Approved"
version: "1.0"
created: "2026-06-28"
updated: "2026-06-28"
phase: "Phase 1 — Agent Operating System"
priority: "P0"
tags: [cross-reference, documentation, integrity, standards]
related_documents: ["11-001: Knowledge Graph", "11-006: Metadata Standards"]
related_agents: ["Documentation Agent"]
dependencies: ["11-001: Knowledge Graph"]
---
# Cross Reference Rules
## 1. Vision
Cross-references are the connective tissue of the documentation system. They ensure no document exists in isolation and every reader can navigate from any document to related context.

## 6. Requirements
### 6.1 Reference Format
All cross-references use document IDs, never file paths or document titles alone.

**Correct:** `Decision Framework (00-003)`
**Incorrect:** `see the decision framework document` or `see Decision_Framework.md`

### 6.2 Reference Types
| Type | Format | Example |
|------|--------|---------|
| Inline reference | `Document Title (doc_id)` | `Design Principles (02-002)` |
| Frontmatter reference | `"doc_id: Document Title"` in `related_documents` | `"02-002: Design Principles"` |
| Section reference | `Document Title (doc_id), Section N` | `Agent Lifecycle (08-001), Section 6.2` |
| Agent reference | `Agent Name (agent_id)` | `Game Designer Agent (09-004)` |

### 6.3 Mandatory References
| Document Type | Must Reference |
|--------------|---------------|
| Agent Definition | Agent Template (08-006), related agents, required documents |
| Workflow | Workflow Engine (10-001), participating agents, governance rules |
| Quality document | Quality Standards (02-004) |
| Any monetization-related | Ethical Framework (02-005) |
| Any governance-related | Decision Framework (00-003) |

### 6.4 Bidirectional Reference Rule
If Document A references Document B, then Document B's `related_documents` frontmatter should include Document A. Documentation Agent enforces this during quarterly audits.

### 6.5 Integrity Rules
1. **No broken references.** Every doc_id referenced must exist in the system.
2. **No circular-only references.** If A→B→A with no other connections, investigate — likely a structural issue.
3. **Orphan detection.** Any document with 0 incoming references is flagged for review.
4. **Reference freshness.** If a referenced document is retired or superseded, all references to it must be updated.

## 7. Acceptance Criteria
- [ ] 100% of cross-references use doc_id format
- [ ] 0 broken references across all documents
- [ ] 0 orphan documents (every doc has ≥1 incoming reference)
- [ ] Bidirectional references maintained for all connections

## 14. Related Documents
| Doc ID | Title | Relationship |
|--------|-------|-------------|
| 11-001 | Knowledge Graph | Graph edges implement cross-references |
| 11-006 | Metadata Standards | Frontmatter reference format |
