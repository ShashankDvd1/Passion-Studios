---
document_id: "05-002"
title: "World Architecture"
owner: "Unity Architect Agent"
status: "Approved"
version: "1.0"
created: "2026-06-28"
updated: "2026-06-28"
phase: "Phase 3 — Tiny World Platform"
priority: "P0"
tags: [architecture, unity, systems, data-driven]
related_documents: ["05-001: Platform_Vision.md"]
related_agents: ["Unity Architect Agent", "Backend Agent"]
dependencies: ["05-001: Platform_Vision.md"]
---

# World Architecture

## 2. Purpose
To define the high-level software architecture that makes the Tiny World Platform highly modular, performant, and completely data-driven. 

## 3. Responsibilities
- Define the pattern for how modules communicate (Events vs. Direct Reference).
- Define the initialization order of the world.
- Establish the data-driven content pipeline.

## 4. Dependencies
- Unity Addressables System.
- Dependency Injection Framework (e.g., VContainer or Zenject).

## 5. Reusable Interfaces
- `IInitializable`: For systems requiring setup at boot.
- `ITickable`: For systems requiring frame-by-frame updates (avoids thousands of Unity `Update()` calls).
- `IDataProvider`: For systems that read/write save state.

## 6. Configuration Model
All game content (Items, NPCs, Weather states) is defined as `ScriptableObjects` (Definitions). The architecture never hardcodes logic for specific content.

## 7. Future Expansion
The architecture is designed to support "Mods" or user-generated content by allowing external JSON data to be parsed into Definitions at runtime.

## 8. Relationship with HX Platform
Provides the stability and performance required so that players never experience immersion-breaking lag or crashes, protecting the "Comfort" emotion.

## 9. Relationship with Agent OS
By using strict interfaces (`ITickable`, `IInitializable`), coding agents can generate new systems that automatically plug into the architecture without modifying the core codebase.

## 10. Unity Representation
- **Central Update Loop:** A single `GameLoopManager` MonoBehaviour calls `Tick()` on registered `ITickable` objects, rather than having hundreds of MonoBehaviours running `Update()`.
- **Event Bus:** A ScriptableObject-based event architecture for decoupled system communication.

## 11. C# Architecture
- `GameLoopManager` (Central Update)
- `EventBus` (Pub/Sub system)
- `ModuleRegistry` (Dependency resolver)
- `DefinitionDatabase` (Central repository for all ScriptableObject definitions)

## 12. Data Model
- `GameEvent` (struct payload)
- `EntityDefinition` (ScriptableObject base class)

## 13. Unity Folder Mapping
`Assets/Scripts/Runtime/TinyWorldPlatform/Architecture/`

## 14. AI Implementation Plan
- **Responsible Agent:** Unity Architect Agent
- **Implementation Order:** 2
- **Review Agent:** Code Review Agent
- **Expected Deliverables:** Event Bus implementation, GameLoopManager, Base Definition classes.

## 15. Performance Considerations
- **Update Frequency:** Moving all updates to a single `GameLoopManager` drastically reduces the C++ to C# interop overhead in Unity.
- **GC Allocation:** The Event Bus must be zero-allocation (using structs and avoiding boxing/unboxing).

## 16. Testing Strategy
- Performance tests comparing `GameLoopManager` iteration over 10,000 objects vs. 10,000 standard `Update()` methods.
- Event Bus memory leak tests.

## 17. Editor Tooling
- `Event Monitor Window`: To visualize which events are firing in real-time for debugging.

## 18. AI Code Generation Notes
Implement the Event Bus using generic C# Actions or a zero-alloc custom implementation. Ensure `GameLoopManager` handles exceptions cleanly so one failed module doesn't crash the entire update loop.

## 19. Known Risks
- Order of execution bugs if `ITickable` priorities are mismanaged.

## 20. Acceptance Criteria
- [ ] Event Bus allows pub/sub without allocating GC.
- [ ] `GameLoopManager` successfully ticks registered systems.

## 21. Validation Checklist
- [ ] Is the architecture completely independent of the game theme?
- [ ] Have we eliminated reliance on Unity's default `Update()` for core simulation logic?
