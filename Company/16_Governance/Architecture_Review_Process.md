---
document_id: "16-007"
title: "Architecture Review Process"
owner: "Unity Architect Agent"
status: "Approved"
version: "1.0"
created: "2026-06-28"
updated: "2026-06-28"
phase: "Phase 1 — Agent Operating System"
priority: "P1"
tags: [governance, architecture, review, engineering]
related_documents: ["12-010: Architecture Memory", "02-003: Operating Principles"]
related_agents: ["Unity Architect Agent"]
dependencies: []
---
# Architecture Review Process
## 1. Vision
Prevent technical debt and ensure engine reusability through rigorous architectural oversight before code is written.

## 6. Requirements
### 6.1 When is Review Required?
An Architecture Review is required for:
1. New engine modules or major feature systems.
2. Changes to cross-module communication (Event Bus).
3. New third-party SDKs or packages.
4. Changes to data persistence strategies (Cloud Save, ScriptableObjects).

### 6.2 Review Criteria
- **Reusability:** Can this module be extracted for Game 2?
- **Coupling:** Does this introduce circular dependencies?
- **Simplicity:** Does it follow "Boring Technology"?
- **Performance:** Does it meet the established budget?

### 6.3 Outcomes
- Output is an approved Architecture Decision Record (ADR) stored in Architecture Memory (`12-010`).
