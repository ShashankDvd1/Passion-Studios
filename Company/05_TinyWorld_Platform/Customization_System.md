---
document_id: "05-018"
title: "Customization System"
owner: "Game Designer Agent"
status: "Approved"
version: "1.0"
created: "2026-06-28"
updated: "2026-06-28"
phase: "Phase 3 — Tiny World Platform"
priority: "P1"
tags: [architecture, unity, customization, housing, grid]
related_documents: ["04-007: Ownership_System.md"]
related_agents: ["Game Designer Agent", "Gameplay Programmer Agent"]
dependencies: ["05-004: Object_System.md"]
---

# Customization System

## 2. Purpose
To allow the player to modify the world structurally and aesthetically (e.g., placing furniture, building fences, painting walls) and persist those changes.

## 3. Responsibilities
- Provide a grid-based or free-form placement validation system (Can I build this here?).
- Modify the `SpatialGrid` based on player placement (adding colliders, updating pathfinding).
- Save and load the custom state.

## 4. Dependencies
- World Simulation (`05-003`)
- Object System (`05-004`)

## 5. Reusable Interfaces
- `IPlaceable`: Data definition for an object that can be constructed/placed by the player.
- `IPaletteSwap`: For objects that can have their materials/colors changed dynamically.

## 6. Configuration Model
`PlaceableDefinition.asset` defines:
- Grid size (e.g., 2x2 cells).
- Placement restrictions (e.g., "Must be on a wall", "Cannot be outdoors").
- Cost to build.

## 7. Future Expansion
Blueprint systems, where players can save a multi-object layout (like a fully decorated room) and share it with others.

## 8. Relationship with HX Platform
This is the mechanical heart of the "Ownership System" (`04-007`) and the primary outlet for the "Expression" motivation (`04-014`).

## 9. Relationship with Agent OS
The UI Agent handles the menu for selecting items, while the Gameplay Programmer Agent handles the complex grid math for placing them. The documentation must clearly separate these concerns.

## 10. Unity Representation
- **Placement Logic:** A raycast-driven ghosting system that snaps to a virtual grid and checks for overlaps using `Physics.BoxCast` or the internal `SpatialGrid`.
- **Visuals:** Instantiated via the `ObjectManager` upon confirmation.

## 11. C# Architecture
- `PlacementController` (Handles the temporary 'ghost' object during building).
- `GridValidator` (Checks rules).
- `PlayerHousingState` (Data payload).

## 12. Data Model
- `PlacedObjectData` (ID, Position, Rotation, ColorVariant).

## 13. Unity Folder Mapping
`Assets/Scripts/Runtime/TinyWorldPlatform/Customization/`

## 14. AI Implementation Plan
- **Responsible Agent:** Gameplay Programmer Agent
- **Implementation Order:** 17
- **Review Agent:** Unity Architect Agent
- **Expected Deliverables:** Grid snapping logic, overlap validation, material variant swapping.

## 15. Performance Considerations
- **Static Batching:** If a player places 500 identical fence posts, they must be batched or instanced (GPU Instancing) to avoid 500 separate draw calls.

## 16. Testing Strategy
- Placement tests: Attempt to place objects out of bounds, intersecting the player, and overlapping other objects. Assert all fail validation.

## 17. Editor Tooling
- `Pre-fab Placer`: Allow level designers to use the exact same grid-placement logic in the Unity Editor that the player uses at runtime.

## 18. AI Code Generation Notes
The `PlacementController` should utilize a State Machine (Idle -> Selecting -> Placing -> Confirming). The "Ghost" object (the translucent preview) should use a specialized shader and MUST have its physics colliders disabled to avoid messing up the simulation during placement.

## 19. Known Risks
- Z-fighting when players figure out how to place rugs exactly on top of other floor tiles. (Mitigation: Add a tiny Y-offset to floor items based on their layer).

## 20. Acceptance Criteria
- [ ] Objects snap to a grid and validate placement rules.
- [ ] Placed objects update pathfinding so NPCs don't walk through them.
- [ ] Objects can be picked back up or recolored.

## 21. Validation Checklist
- [ ] Is GPU instancing enabled for heavily repeated objects?
- [ ] Does the placement logic account for different object rotations?
