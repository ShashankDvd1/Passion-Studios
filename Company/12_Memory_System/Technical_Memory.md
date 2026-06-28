---
document_id: "12-005"
title: "Technical Memory"
owner: "Unity Architect Agent"
status: "Approved"
version: "1.0"
created: "2026-06-28"
updated: "2026-06-28"
phase: "Phase 1 — Agent Operating System"
priority: "P1"
tags: [memory, technical, engineering, code]
related_documents: ["12-001: Memory Architecture", "12-010: Architecture Memory"]
related_agents: ["Unity Architect Agent", "Gameplay Programmer Agent"]
dependencies: ["12-001: Memory Architecture"]
---
# Technical Memory
## Mission
Store code-level context: implementation patterns, debugging findings, performance observations, and technical decisions that inform future development. Prevents reinventing solutions and repeating bugs.
## Content Categories
| Category | What's Stored | Expiry |
|----------|-------------|--------|
| **Code Patterns** | Established patterns and usage examples | Until superseded |
| **Bug Findings** | Root causes, fixes, and prevention rules | Permanent |
| **Performance Data** | Profiling results, optimization history | 12 months rolling |
| **Library/SDK Notes** | Quirks, workarounds, version-specific issues | Until library updated |
| **Implementation Decisions** | Why we chose approach A over B | Feature lifetime |
| **Technical Debt Register** | Known debt items with priority and plan | Until resolved |
## Injected when: Engineering agents work on code implementation or review.
