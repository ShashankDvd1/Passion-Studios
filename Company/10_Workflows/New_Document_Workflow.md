---
document_id: "10-005"
title: "New Document Workflow"
owner: "Documentation Agent"
status: "Approved"
version: "1.0"
created: "2026-06-28"
updated: "2026-06-28"
phase: "Phase 1 — Agent Operating System"
priority: "P1"
tags: [workflow, documentation]
related_documents: ["10-001: Workflow Engine", "16-010: Documentation Standards"]
related_agents: ["Documentation Agent", "Any requesting agent"]
dependencies: ["10-001: Workflow Engine"]
---
# New Document Workflow
## Trigger
Manual — Any agent identifies a need for a new document.
## Steps
1. **Document Proposal** (Requesting Agent) → Purpose, scope, audience, owner
2. **Standards Check** (Documentation Agent) → Verify YAML frontmatter, section structure, naming
3. **Content Draft** (Requesting Agent) → Write the document following the standard template
4. **Cross-Reference Validation** (Documentation Agent) → All references valid, no broken links
5. **Quality Review** (Quality Pipeline) → Self-review → Consistency review
6. **Registration** (Documentation Agent) → Add to knowledge graph, update related docs
## Estimated Duration: 1-2 days
