---
document_id: "12-003"
title: "Project Memory"
owner: "Product Manager Agent"
status: "Approved"
version: "1.0"
created: "2026-06-28"
updated: "2026-06-28"
phase: "Phase 1 — Agent Operating System"
priority: "P0"
tags: [memory, project, game-specific]
related_documents: ["12-001: Memory Architecture"]
related_agents: ["Product Manager Agent", "CEO Agent"]
dependencies: ["12-001: Memory Architecture"]
---
# Project Memory
## Mission
Store game-specific context for each project (Tiny World, Game #2, etc.). When the Agent OS starts a new game project, a new Project Memory instance is created. The OS itself doesn't change; only the Project Memory changes.
## Content Categories
| Category | What's Stored | Expiry | Examples |
|----------|-------------|--------|---------|
| **Game Concept** | Genre, theme, core loop, meta systems | Project lifetime | "Cozy sim, garden world, craft-grow-discover loop" |
| **Current Sprint** | Active tasks, priorities, blockers | Sprint duration | "Sprint 5: Weather system + friend visiting" |
| **Feature History** | All shipped features with outcomes | Project lifetime | "Garden Expansion shipped D30, +3% retention" |
| **Player Profile** | Target audience definition | Project lifetime | "25-35F, casual, cozy gamers, 2-3 sessions/day" |
| **Launch Status** | Current phase (dev, alpha, soft launch, global) | Project lifetime | "Pre-alpha, targeting soft launch Q4 2026" |
| **Platform Targets** | Target devices, OS versions, stores | Project lifetime | "iOS 16+, Android 10+, iPhone 12+" |
## Key Property: Game-agnostic OS + game-specific Project Memory = reusable system.
