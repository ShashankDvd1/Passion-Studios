---
document_id: "05-008"
title: "NPC System"
owner: "Gameplay Programmer Agent"
status: "Approved"
version: "1.0"
created: "2026-06-28"
updated: "2026-06-28"
phase: "Phase 3 — Tiny World Platform"
priority: "P0"
tags: [architecture, unity, ai, npc, dialogue]
related_documents: ["05-007: Creature_System.md", "04-016: Social_Psychology.md"]
related_agents: ["Gameplay Programmer Agent", "Game Designer Agent"]
dependencies: ["05-007: Creature_System.md"]
---

# NPC System

## 2. Purpose
To govern the behavior, daily schedules, relationship data, and dialogue delivery of complex humanoid entities (NPCs), making the world feel populated by characters with their own lives.

## 3. Responsibilities
- Manage NPC daily schedules (Where they are and what they are doing at a given time).
- Manage relationship scores and unlocked dialogue tiers.
- Execute branching dialogue sequences via the UI.

## 4. Dependencies
- Time System (`05-009`)
- Interaction System (`05-005`)

## 5. Reusable Interfaces
- `IScheduleProvider`: Defines an entity that requests pathfinding destinations based on time of day.
- `IDialogueProvider`: Defines an entity that can yield dialogue trees upon interaction.

## 6. Configuration Model
- `NpcDefinition.asset` (Base stats, visual prefab).
- `NpcSchedule.asset` (A list of Time/Location keyframes).
- `DialogueTree.asset` (Node-based conversation data).

## 7. Future Expansion
LLM integration for dynamic dialogue generation, bounded by personality prompts defined in the `NpcDefinition`.

## 8. Relationship with HX Platform
NPCs are the primary vector for "Belonging" and "Identity." If NPCs remember the player's past actions and reference them, emotional attachment skyrockets.

## 9. Relationship with Agent OS
Game Designer Agent writes dialogue trees as JSON/ScriptableObjects. The Platform automatically parses them without requiring new C# code.

## 10. Unity Representation
- **Pathing:** Uses the same NavMesh infrastructure as the Creature System, but guided by a Schedule Manager instead of a basic Wander state.
- **Dialogue UI:** A decoupled MVC setup where the `DialogueManager` passes text to the `DialogueView` Canvas.

## 11. C# Architecture
- `NpcManager`
- `ScheduleManager`
- `DialogueManager`
- `RelationshipManager` (Tracks friendship/romance data)

## 12. Data Model
- `NpcSaveData` (Current location, current schedule index, relationship points).
- `DialogueNode` (Text, Portrait, Choices, Required Conditions).

## 13. Unity Folder Mapping
`Assets/Scripts/Runtime/TinyWorldPlatform/NPCs/`

## 14. AI Implementation Plan
- **Responsible Agent:** Gameplay Programmer Agent
- **Implementation Order:** 8
- **Review Agent:** Unity Architect Agent
- **Expected Deliverables:** Schedule parsing logic, Dialogue Manager, NPC interaction handler.

## 15. Performance Considerations
- **Off-screen Teleportation:** If the player is far away, the NPC should bypass physical pathfinding and instantly warp to their scheduled location (or simulate walking via math) to save CPU.

## 16. Testing Strategy
- Fast-forward time by 24 hours and assert that all NPCs are in their correct scheduled locations.

## 17. Editor Tooling
- `Dialogue Node Editor`: A visual, node-based graph editor in Unity for writers to build branching conversations without coding.

## 18. AI Code Generation Notes
The Dialogue system must support "Conditions" (e.g., only show this text if Friendship > 5) and "Events" (e.g., if the player chooses this option, give them an item). Implement these using the Command/Strategy pattern.

## 19. Known Risks
- Schedule conflicts (e.g., two NPCs scheduled to occupy the exact same coordinate at the same time).

## 20. Acceptance Criteria
- [ ] NPCs move to different locations based on the in-game clock.
- [ ] Interacting with an NPC triggers a branching dialogue tree.
- [ ] Relationship data is successfully saved and loaded.

## 21. Validation Checklist
- [ ] Is the dialogue system decoupled from the visual UI?
- [ ] Are NPCs performing full physics pathfinding when off-screen? (Must be NO).
