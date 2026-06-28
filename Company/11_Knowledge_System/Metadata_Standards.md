---
document_id: "11-006"
title: "Metadata Standards"
owner: "Documentation Agent"
status: "Approved"
version: "1.0"
created: "2026-06-28"
updated: "2026-06-28"
phase: "Phase 1 — Agent Operating System"
priority: "P0"
tags: [metadata, standards, frontmatter, documentation]
related_documents: ["11-004: Tagging Convention", "11-005: Cross Reference Rules"]
related_agents: ["Documentation Agent"]
dependencies: []
---
# Metadata Standards
## 1. Vision
Every document in the company system carries YAML frontmatter metadata. This metadata enables automated processing, search, filtering, and knowledge graph population. It is not optional decoration — it is structural infrastructure.

## 6. Requirements
### 6.1 Required Frontmatter Fields
```yaml
---
document_id: "NN-NNN"           # Unique identifier (folder-sequence)
title: "Document Title"          # Human-readable title
owner: "Responsible Agent"       # Agent that maintains this document
status: "Draft | Approved | Deprecated | Retired"
version: "X.Y"                  # Semantic version
created: "YYYY-MM-DD"           # Creation date
updated: "YYYY-MM-DD"           # Last modification date
phase: "Phase N — Phase Name"   # Which build phase
priority: "P0 | P1 | P2 | P3"  # Document priority
tags: []                        # 3-8 tags from controlled vocabulary
related_documents: []           # doc_id: Title format
related_agents: []              # Agent names
dependencies: []                # Documents this doc depends on
---
```

### 6.2 Field Validation Rules
| Field | Validation |
|-------|-----------|
| `document_id` | Must match pattern `NN-NNN`. Must be unique across all documents. |
| `status` | Must be one of: Draft, Approved, Deprecated, Retired. |
| `version` | Must follow MAJOR.MINOR format. |
| `tags` | Must contain 3-8 items from controlled vocabulary (11-004). |
| `related_documents` | Each item must be a valid doc_id that exists. |
| `created` / `updated` | Must be valid ISO dates. `updated` ≥ `created`. |

### 6.3 Status Lifecycle
```
Draft → Approved → Deprecated → Retired
                 ↑              │
                 └──────────────┘ (can be re-approved after update)
```

## 7. Acceptance Criteria
- [ ] 100% of documents have valid YAML frontmatter with all required fields
- [ ] All field validation rules pass automated checks
- [ ] No duplicate document_ids exist

## 14. Related Documents
| Doc ID | Title | Relationship |
|--------|-------|-------------|
| 11-004 | Tagging Convention | Tag vocabulary for the `tags` field |
| 11-005 | Cross Reference Rules | Reference format for `related_documents` field |
