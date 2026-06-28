---
document_id: "12-010"
title: "Architecture Memory"
owner: "Unity Architect Agent"
status: "Approved"
version: "1.0"
created: "2026-06-28"
updated: "2026-06-28"
phase: "Phase 1 — Agent Operating System"
priority: "P1"
tags: [memory, architecture, engineering, modules]
related_documents: ["12-001: Memory Architecture", "12-005: Technical Memory"]
related_agents: ["Unity Architect Agent", "Gameplay Programmer Agent"]
dependencies: ["12-001: Memory Architecture"]
---
# Architecture Memory
## Mission
Store engine-level architectural context: module registry, dependency graphs, API surfaces, pattern catalog, and architectural decision records. This ensures the Tiny World Engine evolves coherently across all games.
## Content Categories
| Category | What's Stored | Expiry |
|----------|-------------|--------|
| **Module Registry** | All engine modules, their APIs, dependencies, status | Continuously updated |
| **Dependency Graph** | Inter-module dependency map | Continuously updated |
| **Pattern Catalog** | Approved architectural patterns with examples | Until superseded |
| **ADRs** | Architecture Decision Records (problem, options, decision, consequences) | Permanent |
| **Technical Debt** | Architectural debt items with priority and remediation plan | Until resolved |
| **Reusability Scores** | Per-module reusability classification (engine vs. game-specific) | Updated per release |
## Distinct from Technical Memory (12-005): Architecture Memory is about system structure. Technical Memory is about implementation details. Architecture = "how modules connect." Technical = "how code within a module works."
