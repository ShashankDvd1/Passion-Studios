---
document_id: "05-005"
title: "Interaction System"
owner: "Gameplay Programmer Agent"
status: "Approved"
version: "1.0"
created: "2026-06-28"
updated: "2026-06-28"
phase: "Phase 3 — Tiny World Platform"
priority: "P0"
tags: [architecture, unity, interaction, verbs]
related_documents: ["05-004: Object_System.md", "04-004: Core_Experience_Loops.md"]
related_agents: ["Gameplay Programmer Agent", "UX Agent"]
dependencies: ["05-004: Object_System.md"]
---

# Interaction System

## 2. Purpose
To define a universal, extensible framework for how the player (or NPCs) engage with the world. It maps input to "Verbs" (Chop, Talk, Harvest, Inspect) without hardcoding specific logic into the objects themselves.

## 3. Responsibilities
- Detect interactable objects within range.
- Determine valid interactions based on current state and equipped tools.
- Execute interactions and trigger visual/audio feedback (Delight).

## 4. Dependencies
- Object System (`05-004`)
- Event System (`05-012`)

## 5. Reusable Interfaces
- `IInteractable`: Applied to any object that can receive an interaction.
- `IInteractionHandler`: A strategy pattern interface defining what happens when a specific interaction is executed.

## 6. Configuration Model
Interactions are mapped in a `VerbDictionary.asset`. An object's `ObjectDefinition` lists which Verbs it accepts.

## 7. Future Expansion
Support for multi-actor interactions (e.g., two players needing to interact with a heavy object simultaneously).

## 8. Relationship with HX Platform
This is the mechanical delivery system for the Core Experience Loops (`04-004`) and the primary vector for the Delight System (`04-008`). It must feel snappy and responsive.

## 9. Relationship with Agent OS
Gameplay Programmer Agent can easily add new mechanics (like "Watering" or "Painting") simply by creating a new `IInteractionHandler` and registering the Verb, without touching core architecture.

## 10. Unity Representation
- **Detection:** A trigger collider or spatial grid query around the player.
- **Execution:** A Command pattern implementation where `InteractionCommand` objects are dispatched.

## 11. C# Architecture
- `InteractionManager` (Handles detection and UI prompts)
- `IInteractable` (Component on world objects)
- `InteractionContext` (Payload containing actor, target, tool)
- `InteractionCommand` (The executable action)

## 12. Data Model
- `VerbType` (Enum: Harvest, Talk, Inspect, Attack, etc.)
- `InteractionResult` (Success, Failed_MissingTool, Failed_Cooldown)

## 13. Unity Folder Mapping
`Assets/Scripts/Runtime/TinyWorldPlatform/Interaction/`

## 14. AI Implementation Plan
- **Responsible Agent:** Gameplay Programmer Agent
- **Implementation Order:** 5
- **Review Agent:** Unity Architect Agent
- **Expected Deliverables:** Raycast/Trigger detection logic, Command pattern executor, sample `Harvest` interaction.

## 15. Performance Considerations
- **Detection:** Polling for interactables every frame using `Physics.SphereCast` can be expensive. Prefer using `OnTriggerEnter/Exit` to maintain a cached list of nearby interactables.

## 16. Testing Strategy
- Unit tests verifying that attempting to execute an invalid interaction (e.g., Chopping a rock) returns the correct `Failed` result without throwing exceptions.

## 17. Editor Tooling
- Visual debugging to show the player's current interaction radius and highlight the currently targeted object.

## 18. AI Code Generation Notes
Implement using the Command pattern. This allows interactions to be easily queued, undone, or passed to the network layer if multiplayer is added later.

## 19. Known Risks
- Z-fighting/Targeting ambiguity: When multiple interactable objects are overlapping, the system needs clear rules to prioritize the intended target.

## 20. Acceptance Criteria
- [ ] Player can detect nearby objects.
- [ ] UI prompts update dynamically based on the object's supported Verbs.
- [ ] Executing the interaction triggers the correct `IInteractionHandler`.

## 21. Validation Checklist
- [ ] Is the logic completely decoupled from the specific input device (controller vs. touch)?
- [ ] Does it support tool-based context (e.g., having an axe equipped changes the default Verb)?
