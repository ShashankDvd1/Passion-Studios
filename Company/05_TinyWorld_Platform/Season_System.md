---
document_id: "05-011"
title: "Season System"
owner: "Game Designer Agent"
status: "Approved"
version: "1.0"
created: "2026-06-28"
updated: "2026-06-28"
phase: "Phase 3 — Tiny World Platform"
priority: "P1"
tags: [architecture, unity, seasons, time]
related_documents: ["05-009: Time_System.md", "05-010: Weather_System.md"]
related_agents: ["Game Designer Agent", "Unity Architect Agent"]
dependencies: ["05-009: Time_System.md"]
---

# Season System

## 2. Purpose
To manage long-term environmental cycles that fundamentally alter the world's appearance, economy, and available content over the course of an in-game year.

## 3. Responsibilities
- Track the current Season based on the Time System.
- Define what crops, fish, bugs, and forageable items can spawn.
- Override environmental visuals (e.g., turning grass brown in Autumn).

## 4. Dependencies
- Time System (`05-009`)
- Weather System (`05-010`)

## 5. Reusable Interfaces
- `ISeasonalEntity`: Applied to objects that need to change appearance based on the season (e.g., a deciduous tree).

## 6. Configuration Model
`SeasonDefinition.asset` contains:
- Allowed weather probabilities.
- Global color tint/lighting overrides.
- Arrays of available spawnable entities.

## 7. Future Expansion
Support for custom or fantasy seasons (e.g., "The Long Night" or "Eclipse Season") beyond the standard four.

## 8. Relationship with HX Platform
Seasons drive the "Anticipation" and "Discovery" loops. As a season nears its end, players rush to finish seasonal goals. When a new season starts, the world feels fresh and novel again, preventing visual fatigue.

## 9. Relationship with Agent OS
Game Designer Agent defines the rules (what crops grow when) in definitions. Art Director Agent handles the visual palette swaps.

## 10. Unity Representation
- **Manager:** `SeasonManager` listens to the Time System for month/season rollovers.
- **Visuals:** Entities read the current season from the `SeasonManager` upon loading and swap their Sprites/Materials accordingly.

## 11. C# Architecture
- `SeasonManager`
- `SeasonDefinition` (ScriptableObject)
- `SeasonalSpriteSwap` (MonoBehaviour for simple visual updates)

## 12. Data Model
- `SeasonType` (Enum: Spring, Summer, Autumn, Winter)

## 13. Unity Folder Mapping
`Assets/Scripts/Runtime/TinyWorldPlatform/Environment/`

## 14. AI Implementation Plan
- **Responsible Agent:** Unity Architect Agent
- **Implementation Order:** 10
- **Review Agent:** Game Designer Agent
- **Expected Deliverables:** Season definition parsing, global event firing on season change.

## 15. Performance Considerations
- When a season changes while the player is actively playing, updating 10,000 objects to their new seasonal visual state simultaneously will cause a massive CPU spike.
- **Solution:** Season changes should ideally occur during a loading screen (e.g., going to sleep and waking up the next day).

## 16. Testing Strategy
- Force a season change and verify that non-seasonal crops die, seasonal spawn tables update, and all `ISeasonalEntity` objects update their visuals.

## 17. Editor Tooling
- `Seasonal Palette Previewer`: View the scene under different seasonal lighting and color settings without entering play mode.

## 18. AI Code Generation Notes
Ensure that the `SeasonManager` acts as a central registry. Objects should not check the season in `Update()`. They should either check it `OnEnable()` or listen for the `GameEvent.SeasonChanged` event.

## 19. Known Risks
- Managing permutations: If a tree has 4 growth stages and 4 seasons, that requires 16 unique sprites. This can quickly bloat artist workload. (Mitigation: Use shader tints where possible instead of unique sprites).

## 20. Acceptance Criteria
- [ ] Season changes correctly based on calendar math.
- [ ] Spawn logic respects seasonal availability.
- [ ] Visuals swap based on the active season.

## 21. Validation Checklist
- [ ] Is the visual swap logic optimized to avoid framerate hitches?
- [ ] Does the system support an arbitrary number of seasons (not hardcoded to 4)?
