---
document_id: "05-007"
title: "Creature System"
owner: "Gameplay Programmer Agent"
status: "Approved"
version: "1.0"
created: "2026-06-28"
updated: "2026-06-28"
phase: "Phase 3 — Tiny World Platform"
priority: "P1"
tags: [architecture, unity, ai, creatures, behaviors]
related_documents: ["05-003: World_Simulation.md"]
related_agents: ["Gameplay Programmer Agent", "Behavioral Psychology Agent"]
dependencies: ["05-003: World_Simulation.md"]
---

# Creature System

## 2. Purpose
To define the architecture for autonomous, non-humanoid entities (animals, pets, monsters, ambient wildlife) that populate the world and give it a sense of living ecosystem.

## 3. Responsibilities
- Manage creature AI (Wandering, Fleeing, Seeking).
- Manage creature life cycles (Spawning, Growth, Death/Despawn).
- Handle the visual instancing of creatures based on the simulation grid.

## 4. Dependencies
- World Simulation (`05-003`).
- Unity NavMesh (or custom pathfinding).

## 5. Reusable Interfaces
- `ICreatureAI`: The strategy interface for behavior execution.
- `IActor`: Creatures can perform interactions (e.g., a cow eating grass).

## 6. Configuration Model
`CreatureDefinition.asset` defines base stats (speed, fear radius, drops), while `BehaviorTreeConfig.asset` defines their AI logic data.

## 7. Future Expansion
Flocking behaviors, predator/prey ecosystems, and advanced genetics/breeding systems.

## 8. Relationship with HX Platform
Crucial for the "Nurture" motivation (`04-014`). Pets and farm animals must display clear emotional states (happy, hungry) to trigger the player's empathy.

## 9. Relationship with Agent OS
The system must be built using modular AI states so the Game Designer Agent can create new creatures just by mixing and matching existing behaviors (e.g., `WanderState` + `FleeWhenApproachedState`).

## 10. Unity Representation
- **AI Logic:** Implemented via a lightweight State Machine or Behavior Tree.
- **Pathfinding:** Unity NavMeshAgent (if 3D) or A* Pathfinding Project (if 2D/Grid).

## 11. C# Architecture
- `CreatureManager` (Handles spawning)
- `CreatureBrain` (Executes the State Machine)
- `BaseCreatureState` (Abstract class for behaviors)

## 12. Data Model
- `CreatureStateData` (Serializable: Position, Hunger, Age, Happiness).

## 13. Unity Folder Mapping
`Assets/Scripts/Runtime/TinyWorldPlatform/Creatures/`

## 14. AI Implementation Plan
- **Responsible Agent:** Gameplay Programmer Agent
- **Implementation Order:** 7
- **Review Agent:** Unity Architect Agent
- **Expected Deliverables:** Finite State Machine (FSM) framework, NavMesh integration, base Wander state.

## 15. Performance Considerations
- **AI Throttling:** 100 creatures running pathfinding every frame will crush the CPU. NavMesh queries must be time-sliced (e.g., only 5 creatures calculate paths per frame).
- **Off-screen Logic:** Creatures far from the player should switch to a simplified "simulation" state rather than running full Unity physics/pathfinding.

## 16. Testing Strategy
- Spawn 500 creatures in a scene and verify that AI throttling maintains a solid 60 FPS.

## 17. Editor Tooling
- `AI Debugger`: A runtime tool that displays a creature's current State, path destination, and sensory radius as gizmos.

## 18. AI Code Generation Notes
Implement the State Pattern for the AI. Avoid massive `switch` statements in the `Update` loop. States should be separate classes implementing `IState`.

## 19. Known Risks
- Creatures getting stuck in geometry or entering endless loop states (e.g., rapidly flipping between moving left and right).

## 20. Acceptance Criteria
- [ ] Creatures can independently navigate the environment.
- [ ] Creatures transition between states (e.g., Idle -> Wander) successfully.
- [ ] System gracefully handles off-screen simulation.

## 21. Validation Checklist
- [ ] Is pathfinding time-sliced for performance?
- [ ] Are behaviors modular enough to be reused across different creature types?
