---
document_id: "05-015"
title: "Progression System"
owner: "Game Designer Agent"
status: "Approved"
version: "1.0"
created: "2026-06-28"
updated: "2026-06-28"
phase: "Phase 3 — Tiny World Platform"
priority: "P0"
tags: [architecture, unity, progression, skills, unlocks]
related_documents: ["04-010: Progression_System.md (HX)"]
related_agents: ["Game Designer Agent", "Gameplay Programmer Agent"]
dependencies: []
---

# Progression System

## 2. Purpose
To manage experience points (XP), skill levels, and capability unlocks for the player and their tools, providing a sense of growth and mastery over the world.

## 3. Responsibilities
- Track XP for various categories (e.g., Farming, Fishing, Combat).
- Manage level-ups and broadcast level-up events.
- Evaluate unlock conditions (e.g., "Can the player use this tool?").

## 4. Dependencies
- Save System (`05-016`)

## 5. Reusable Interfaces
- `IXpSource`: Anything that yields experience points.
- `IUnlockCondition`: An interface for evaluating if an action is permitted.

## 6. Configuration Model
`ProgressionCurve.asset` defines the XP required for each level (using math formulas or explicit arrays). `SkillDefinition.asset` defines categories.

## 7. Future Expansion
Support for "Prestige" systems where max-level players can reset their progress for permanent meta-bonuses.

## 8. Relationship with HX Platform
Provides the mechanical pacing for the "Competence" and "Progress" emotions defined in the HX Engine (`04-010`).

## 9. Relationship with Agent OS
Game Designer Agent defines the XP curves and thresholds. Gameplay Programmer Agent implements the generic math evaluator.

## 10. Unity Representation
- **Manager:** `ProgressionManager` acts as the single source of truth for the player's current skill levels.
- **Conditions:** `UnlockCondition` ScriptableObjects are attached to items (e.g., an Iron Axe requires Foraging Level 5).

## 11. C# Architecture
- `ProgressionManager`
- `SkillState` (Tracks current XP and level for a specific skill)
- `UnlockEvaluator` (Utility to check if a list of conditions is met)

## 12. Data Model
- `ProgressionSaveData` (Dictionary mapping SkillID to XP values).

## 13. Unity Folder Mapping
`Assets/Scripts/Runtime/TinyWorldPlatform/Progression/`

## 14. AI Implementation Plan
- **Responsible Agent:** Gameplay Programmer Agent
- **Implementation Order:** 14
- **Review Agent:** Game Designer Agent
- **Expected Deliverables:** XP tracking, curve evaluation, Level Up event dispatch.

## 15. Performance Considerations
- Checking `ProgressionManager.HasMetCondition()` must be extremely fast, as the Interaction System may check it every frame to see if a UI prompt should be shown.

## 16. Testing Strategy
- Feed 1,000,000 XP to the system and verify it correctly calculates the resulting level without exceeding max level bounds.
- Verify `LevelUp` events fire the correct number of times if a player gains enough XP to jump multiple levels at once.

## 17. Editor Tooling
- `Progression Curve Visualizer`: An editor window that graphs the XP requirements over time so designers can spot grind walls visually.

## 18. AI Code Generation Notes
Store XP as an integer or `long`, never a `float`, to prevent precision loss. Level calculation should use a binary search on the `ProgressionCurve` array if it is large, or just array indexing if it's 1:1 mapping.

## 19. Known Risks
- Underflowing or overflowing XP values if multipliers (e.g., event bonuses) are applied incorrectly.

## 20. Acceptance Criteria
- [ ] Player can gain XP and level up.
- [ ] Items/Actions can be successfully gated behind level requirements.
- [ ] Progression state serializes correctly.

## 21. Validation Checklist
- [ ] Is XP stored securely as an integer type?
- [ ] Are curve calculations optimized for fast lookups?
