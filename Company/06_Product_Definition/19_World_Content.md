---
document_id: "06-019"
title: "World Content"
owner: "Game Designer Agent"
status: "Approved"
version: "1.1"
created: "2026-06-28"
updated: "2026-06-28"
phase: "Phase 4 — Product Definition Platform"
priority: "P0"
---

# 19. World Content

## 2. Purpose
To define the systems that manage the natural resources (trees, rocks, fish, bugs) that populate the Living World.

## 3. Vision
The world must feel alive and responsive. Resources do not just "spawn" instantly; they grow over time based on headless simulation data (e.g., soil moisture, season). This is a **Platform-First** cellular automata engine.

## 4. Problem Statement
**Player Problem:** Static worlds where a tree respawns exactly 5 minutes after being chopped feel like theme parks, not living ecosystems.

## 5. Goals
- Define a Headless Spawner System that uses cellular automata or probability grids to regenerate content organically.
- Ensure every world object defines its modular properties.

## 6. Non Goals
- Procedurally generated infinite terrain.

## 7. Dependencies
- `14_Resource_Flow.md`

## 8. Related Platforms
- LWP: `Object_System`, `Grid_System`

## 9. Related Agents
- Game Designer Agent
- Unity Architect Agent

## 10. Related Feature IDs
- `FEAT-WRLD-01` (Dynamic Resource Spawners)

## 11. User Stories
- **As a player...** I want the forest to look different every week... **So that...** exploring always feels slightly new.

## 12. Acceptance Criteria
- [ ] Spawner logic is entirely separated from GameObject instantiation.
- [ ] Every world object defines its 10 modular properties.

## 13. KPIs
- Ecosystem balance (ensuring players never run out of core wood/stone).

## 14. Analytics Events
- `biome_unlocked`, `resource_depleted`.

## 15. Unity Mapping (Implementation Readiness)
- **ScriptableObjects:** `WorldObjectDefinition.asset`, `BiomeConfig.asset`, `SpawnRule.asset`.
- **Interfaces:** `IWorldSimulatable`.
- **Runtime Managers:** `WorldSimulationManager` (Headless).
- **Systems Used:** `Time_System`, `Grid_System`.
- **Events Published:** `OnCellUpdated`, `OnWorldEventStarted`.
- **Events Consumed:** `OnOfflineCatchupTriggered`, `OnDayChanged`.
- **Save Data:** `GridCellData` (Contains current resource ID and growth stage).
- **Editor Tools:** `SpawnProbabilityPainter` (Paint spawn heatmaps in Scene View).
- **Validation Rules:** Prevent spawning overlapping static colliders.
- **Pooling Requirements:** Heavy reliance on Object Pooling for trees/rocks.
- **Performance Budget:** Offline catch-up must resolve in < 2 seconds.
- **Mobile Constraints:** Avoid instantiating colliders for objects not currently in the camera frustum.
- **AI Code Gen Notes:** `WorldSimulationManager` operates purely on a 2D array of `GridCellData`. During offline catch-up, it loops through the array, updates the data mathematically, and then tells the renderer to update the visuals. 

## 16. Implementation Notes (Modular World Content)
Every world object must define:
1. **Object Type:** (e.g., Tree, Rock, Bush).
2. **Interaction:** (e.g., Requires Axe Level 2).
3. **Spawn Rules:** (e.g., Only near water).
4. **Lifecycle:** (e.g., Sapling -> Mature -> Dead).
5. **Persistence:** Does it reset in Winter?
6. **Save Behavior:** Does it save its exact HP?
7. **Analytics Events:** Which event fires on harvest?
8. **Design Tokens:** (e.g., `TKN-002: Micro-Reward`).
9. **Dependencies:** Requires soil.
10. **Future Expansion:** Can be tapped for syrup later.

## 17. Testing Strategy
- Time-lapse simulation recording the array data over 365 in-game days to tune spawn rates.

## 18. Risks
- Offline catch-up taking too long. (Mitigation: Chunking the map).

## 19. Future Expansion
- Weather events that temporarily alter spawn rules.

## 20. Automation Hooks
- N/A

## 21. Definition of Done
- Headless simulation grid logic defined.

## 22. Review Checklist
- [x] Founder
- [x] All 8 Agents

## 23. Decision History
- v1.1: Applied Founder Directives (Platform First, Modular Content).
- v1.0: Implemented headless grid simulation.

## 24. Traceability
- **Idea -> Requirement:** REQ-019
