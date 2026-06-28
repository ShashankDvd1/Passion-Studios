---
document_id: "05-003"
title: "World Simulation"
owner: "Gameplay Programmer Agent"
status: "Approved"
version: "1.0"
created: "2026-06-28"
updated: "2026-06-28"
phase: "Phase 3 — Tiny World Platform"
priority: "P0"
tags: [architecture, unity, simulation, state]
related_documents: ["05-002: World_Architecture.md"]
related_agents: ["Gameplay Programmer Agent", "Unity Architect Agent"]
dependencies: ["05-002: World_Architecture.md"]
---

# World Simulation

## 2. Purpose
To manage the background simulation of the world—ensuring that crops grow, weather shifts, and NPCs move even when the player is not actively looking at them, or when they are offline.

## 3. Responsibilities
- Manage the state of all active entities in the current scene.
- Simulate logic for off-screen or unloaded entities.
- Handle spatial partitioning for performance.

## 4. Dependencies
- Time System (`05-009`)
- Save System (`05-016`)

## 5. Reusable Interfaces
- `ISimulatedEntity`: Applied to anything that changes state over time (a growing tree, an aging animal).
- `ISpatialGrid`: For querying entity locations.

## 6. Configuration Model
Simulation update frequency (e.g., tick every 1 real second vs. every frame) is configured globally in `SimulationConfig.asset`.

## 7. Future Expansion
Can be extended to support multithreaded simulation (Unity DOTS/ECS) if entity counts exceed standard MonoBehaviour capabilities.

## 8. Relationship with HX Platform
Supports the "Ownership" and "Wonder" emotions by making the world feel alive and persistent. If the player plants a tree, leaves, and comes back 2 days later, it must have grown.

## 9. Relationship with Agent OS
Gameplay Programmer Agent will use this framework to implement specific behaviors (like farming or factory processing) without worrying about the underlying time-delta math.

## 10. Unity Representation
- **Grid Data Structure:** A mathematical grid (not necessarily a Unity Tilemap) that tracks where every entity is, preventing the need for expensive physics raycasts to find nearby objects.
- **Background Tick:** A coroutine or Job that processes `ISimulatedEntity` state changes.

## 11. C# Architecture
- `SimulationManager` (Coordinates the background math)
- `SpatialGrid` (Handles entity positions)
- `EntityState` (Serializable data payload)

## 12. Data Model
- `WorldStateData` (The overarching save file node for simulation)
- `GridCoordinate` (struct for fast position hashing)

## 13. Unity Folder Mapping
`Assets/Scripts/Runtime/TinyWorldPlatform/Simulation/`

## 14. AI Implementation Plan
- **Responsible Agent:** Gameplay Programmer Agent
- **Implementation Order:** 3
- **Review Agent:** Unity Architect Agent
- **Expected Deliverables:** Simulation tick loop, basic Spatial Grid implementation, interface definitions.

## 15. Performance Considerations
- **CPU:** Background simulation must *not* run every frame. It should run on a fixed "Simulation Tick" (e.g., 4 times a second).
- **Spatial Partitioning:** Lookups for "what is near me" must be O(1) or O(log N) using the `SpatialGrid`, never O(N) distance checks.

## 16. Testing Strategy
- Fast-forward tests: Inject a simulated delta time of 1000 hours and assert that all entities process correctly in a single frame without crashing.

## 17. Editor Tooling
- `Simulation Debug Overlay`: Draws gizmos showing grid cells and active simulated entities.

## 18. AI Code Generation Notes
Design `SpatialGrid` using a Dictionary with a hashed `GridCoordinate` struct as the key for O(1) lookups. Ensure `ISimulatedEntity.Simulate(float deltaTime)` is pure logic, completely decoupled from Unity Transforms or GameObjects.

## 19. Known Risks
- "Catch-up" lag: If a player logs in after 1 year, simulating that entire year in one frame could freeze the app.

## 20. Acceptance Criteria
- [ ] Simulation processes off-screen entities without instantiating GameObjects.
- [ ] SpatialGrid allows O(1) lookups of entities by coordinate.

## 21. Validation Checklist
- [ ] Is the simulation logic cleanly separated from the visual representation?
- [ ] Does the system handle large time jumps safely?
