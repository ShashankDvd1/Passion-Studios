---
document_id: "13-010"
title: "Completion Criteria"
owner: "QA Agent"
status: "Approved"
version: "1.0"
created: "2026-06-28"
updated: "2026-06-28"
phase: "Phase 1 — Agent Operating System"
priority: "P0"
tags: [task-management, completion, done, definition]
related_documents: ["13-001: Task System Overview"]
related_agents: ["All Agents"]
dependencies: []
---
# Completion Criteria
## 1. Vision
"Done" must mean exactly one thing: the work is complete, tested, reviewed, documented, and ready for production. There is no "dev done" or "mostly done."

## 6. Requirements
### 6.1 Definition of Done (DoD) - Universal
For ANY task to reach the `DONE` state:
1. **Output Produced:** The specified deliverable (code, document, design) exists.
2. **Acceptance Criteria Met:** All criteria defined in the task description are verified.
3. **Quality Gates Passed:** All required reviews (self, technical, consistency, founder) are approved.
4. **Documentation Updated:** Relevant knowledge base or memory entries are updated.
5. **No Regressions:** The work does not break existing functionality.

### 6.2 Domain-Specific Completion
| Domain | Additional "Done" Criteria |
|--------|----------------------------|
| **Engineering** | Code compiles, unit tests pass, no critical lint errors, merged to target branch. |
| **Product** | PRD complete, metrics defined, Seven-Question Gate passed. |
| **Creative** | Assets integrated, performance budgets met, style guide adhered to. |
| **Documentation** | YAML frontmatter valid, cross-references working, added to Knowledge Graph. |

### 6.3 Output Artifact Linking
A task is not considered `DONE` until the final output artifact (e.g., PR link, document doc_id, asset path) is explicitly linked in the task record.
