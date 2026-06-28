---
document_id: "05-004"
title: "Object System"
owner: "Unity Architect Agent"
status: "Approved"
version: "1.0"
created: "2026-06-28"
updated: "2026-06-28"
phase: "Phase 3 — Tiny World Platform"
priority: "P0"
tags: [architecture, unity, objects, entities]
related_documents: ["05-003: World_Simulation.md"]
related_agents: ["Unity Architect Agent", "Gameplay Programmer Agent"]
dependencies: ["05-003: World_Simulation.md"]
---

# Object System

## 2. Purpose
To define the lifecycle, data model, and visual representation of every interactive object in the world (trees, rocks, furniture, crafting stations) in a way that separates static data from mutable state.

## 3. Responsibilities
- Define how objects are spawned, pooled, and destroyed.
- Manage the separation between what an object *is* (Definition) and its current *condition* (State).
- Handle the visual instancing of objects based on simulation state.

## 4. Dependencies
- Unity Addressables (for async loading of object visuals).
- World Simulation (`05-003`).

## 5. Reusable Interfaces
- `IWorldObject`: The base contract for an entity in the world.
- `IStatefulObject`: For objects that have mutable save data (e.g., a chest with inventory).
- `IStatelessObject`: For objects that only have position/rotation (e.g., a decorative rock).

## 6. Configuration Model
Each object type is defined by an `ObjectDefinition` ScriptableObject, containing its ID, display name, base prefab reference (Addressable), and default components.

## 7. Future Expansion
Support for runtime user-generated content (UGC) objects by parsing JSON definitions into `ObjectDefinition` instances.

## 8. Relationship with HX Platform
Supports the "Ownership" system by allowing objects to be placed, customized, and persistently saved by the player.

## 9. Relationship with Agent OS
Provides a strict blueprint so AI agents can generate new object types purely by generating JSON/ScriptableObject data, without writing C# code.

## 10. Unity Representation
- **Prefabs:** Visuals only. Logic is injected at runtime.
- **Addressables:** Prefabs are never hard-referenced. They are loaded asynchronously via Addressables `AssetReference`.
- **Pooling:** All `IWorldObject` prefabs are routed through a central ObjectPool to prevent GC allocation on spawn/destroy.

## 11. C# Architecture
- `ObjectManager` (Handles spawning and pooling)
- `ObjectDefinition` (ScriptableObject)
- `WorldObject` (MonoBehaviour attached to the visual prefab, linking it to the Simulation)

## 12. Data Model
- `ObjectId` (String or Hash)
- `ObjectStateData` (Contains current health, custom color, inventory contents; serialized to disk).

## 13. Unity Folder Mapping
`Assets/Scripts/Runtime/TinyWorldPlatform/Objects/`

## 14. AI Implementation Plan
- **Responsible Agent:** Unity Architect Agent
- **Implementation Order:** 4
- **Review Agent:** Code Review Agent
- **Expected Deliverables:** ObjectManager, Addressable loading pipeline, generic Object Pool.

## 15. Performance Considerations
- **Pooling:** Strict requirement. Instantiating and Destroying objects during gameplay is prohibited to avoid CPU spikes and memory fragmentation.
- **Memory:** If 10,000 trees exist in the Simulation, only the ~100 currently visible on camera should have instantiated Prefabs. The rest exist only as `ObjectStateData`.

## 16. Testing Strategy
- Spawning 5,000 objects, moving the camera, and verifying that visual instancing/pooling handles the load without dropping below 60fps.

## 17. Editor Tooling
- `Object Definition Creator`: A wizard to quickly generate a ScriptableObject, assign an Addressable prefab, and register it to the database.

## 18. AI Code Generation Notes
Ensure `WorldObject` acts purely as a "View" in the MVC pattern. It should read its state from the `SimulationManager` and update its visuals accordingly, rather than holding its own authoritative state.

## 19. Known Risks
- Addressable loading latency: If an object takes too long to load, the player might see "pop-in."

## 20. Acceptance Criteria
- [ ] Objects can be spawned and despawned using pooling.
- [ ] Visual prefabs are loaded asynchronously via Addressables.
- [ ] Objects correctly link their visual representation to their simulation state.

## 21. Validation Checklist
- [ ] Is state strictly separated from definition?
- [ ] Are we avoiding `Instantiate()` during core gameplay loops?
