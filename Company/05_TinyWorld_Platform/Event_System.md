---
document_id: "05-012"
title: "Event System"
owner: "LiveOps Agent"
status: "Approved"
version: "1.0"
created: "2026-06-28"
updated: "2026-06-28"
phase: "Phase 3 — Tiny World Platform"
priority: "P0"
tags: [architecture, unity, events, liveops]
related_documents: ["04-015: LiveOps_Psychology.md"]
related_agents: ["LiveOps Agent", "Unity Architect Agent"]
dependencies: []
---

# Event System

## 2. Purpose
To manage temporary, state-altering global events (e.g., "Fishing Tournament", "Halloween Festival", "Meteor Shower") that override standard simulation rules and inject novelty into the world.

## 3. Responsibilities
- Schedule and dispatch active events based on the calendar or external LiveOps triggers.
- Apply global modifiers to the world (e.g., spawning event-specific NPCs or changing drop rates).
- Track player progress through event-specific objectives.

## 4. Dependencies
- Time System (`05-009`)
- Save System (`05-016`)

## 5. Reusable Interfaces
- `IEventRule`: A modular rule applied while an event is active (e.g., `DropRateMultiplierRule`).

## 6. Configuration Model
`WorldEventDefinition.asset` contains:
- Start/End time logic (e.g., "Every 15th of Summer" or "Specific real-world Date").
- Visual overrides (e.g., enabling festival tents in the plaza).
- List of `IEventRule` modifiers.

## 7. Future Expansion
Support for branching events based on global community progress (e.g., if the community donates enough wood, the festival enters "Phase 2").

## 8. Relationship with HX Platform
Drives the "LiveOps Psychology" (`04-015`) by creating Anticipation and Community Social Proof. Events break the standard routine to prevent burnout.

## 9. Relationship with Agent OS
The Automation Agent can download new `WorldEventDefinition` JSON files from a server, parse them into ScriptableObjects, and inject them into the game without requiring an app update.

## 10. Unity Representation
- **Manager:** `EventManager` checks active dates against the `TimeManager`.
- **Modifiers:** Uses the Strategy pattern to apply temporary rules to the `SimulationManager`.

## 11. C# Architecture
- `EventManager`
- `WorldEventDefinition`
- `EventObjectiveManager` (Tracks player progress for the active event)

## 12. Data Model
- `ActiveEventState` (Tracks which events are running, their remaining time, and player scores).

## 13. Unity Folder Mapping
`Assets/Scripts/Runtime/TinyWorldPlatform/Events/`

## 14. AI Implementation Plan
- **Responsible Agent:** LiveOps Agent
- **Implementation Order:** 11
- **Review Agent:** Unity Architect Agent
- **Expected Deliverables:** Event scheduler, Rule modifier application logic.

## 15. Performance Considerations
- Polling all active event rules for every single action (e.g., checking if there's a fishing event every time the player casts a line) is inefficient. Instead, the `EventManager` should inject the modifier into the specific system (e.g., `FishingManager`) only when the event starts.

## 16. Testing Strategy
- Trigger 3 overlapping events simultaneously and verify that conflicting modifiers resolve gracefully based on a defined priority system.

## 17. Editor Tooling
- `Event Simulator`: A timeline tool in the editor to visually see upcoming events over the next in-game year.

## 18. AI Code Generation Notes
Implement event modifiers using the Decorator pattern or by caching multipliers. Do not use heavy LINQ queries in the core game loop to check for active events.

## 19. Known Risks
- Feature bloat: Leaving old, inactive event prefabs loaded in memory. Ensure events strictly cleanup their spawned instances when they end.

## 20. Acceptance Criteria
- [ ] Events start and stop based on calendar logic.
- [ ] Event rules successfully modify underlying mechanics.
- [ ] Event progress is saved persistently.

## 21. Validation Checklist
- [ ] Are events data-driven (no C# code required to create a new one)?
- [ ] Do events clean up after themselves automatically?
