---
document_id: "06-018"
title: "Companions"
owner: "Game Designer Agent"
status: "Approved"
version: "1.1"
created: "2026-06-28"
updated: "2026-06-28"
phase: "Phase 4 — Product Definition Platform"
priority: "P1"
---

# 18. Companions

## 2. Purpose
To define the systems governing pets and NPCs that follow or assist the player, generating "Relatedness" and "Delight."

## 3. Vision
Companions are not just passive followers or stat-boosters. They are relationships. They have internal state machines that react to the world independently of the player. This is a **Platform-First** system (usable for pets in Tiny Pets or staff in Tiny Cafe).

## 4. Problem Statement
**Player Problem:** Games where pets just stick to the player's heel like a magnet feel lifeless. 

## 5. Goals
- Define a Headless AI State Machine for companions.
- Give every companion distinct Personality, Behaviors, and Memories.

## 6. Non Goals
- Creating a complex combat party system (No combat).

## 7. Dependencies
- `11_Progression.md`

## 8. Related Platforms
- LWP: `NPC_System` (`05-008`), `AI_Navigation`

## 9. Related Agents
- Game Designer Agent
- Behavioral Psychology Agent

## 10. Related Feature IDs
- `FEAT-PET-01` (Pet Adoption)

## 11. User Stories
- **As a player...** I want my dog to occasionally dig up items... **So that...** having a companion feels mechanically rewarding, not just cosmetic.

## 12. Acceptance Criteria
- [ ] Companion AI uses a headless State Machine (Wander, Follow, Interact, Sleep).
- [ ] Companion data is completely decoupled from rendering.

## 13. KPIs
- % of players that interact with their companion daily.

## 14. Analytics Events
- `companion_adopted`, `companion_interacted`

## 15. Unity Mapping (Implementation Readiness)
- **ScriptableObjects:** `CompanionDefinition.asset`, `PersonalityConfig.asset`, `AIStateConfig.asset`
- **Interfaces:** `IState`, `ICompanionTarget`.
- **Runtime Managers:** `CompanionManager` (Headless).
- **Systems Used:** `Time_System`, `NPC_System`
- **Events Published:** `OnCompanionStateChanged`, `OnCompanionLootFound`, `OnRelationshipLevelUp`.
- **Events Consumed:** `OnTimeTick`, `OnPlayerInteraction`.
- **Save Data:** `CompanionSaveData` (ID, Name, LoyaltyLevel, CurrentState, Memories).
- **Editor Tools:** `StateMachineVisualizer`.
- **Validation Rules:** Validate that state transitions are valid per the `AIStateConfig`.
- **Pooling Requirements:** Pool companion GameObjects.
- **Performance Budget:** State evaluations < 1ms per frame for all active companions.
- **Mobile Constraints:** NavMesh pathfinding throttled to 5 updates per second max.
- **AI Code Gen Notes:** `CompanionManager` calculates the logic for *all* companions in the background. It decides "Dog A should dig." It fires an event. The `Dog_Controller` MonoBehaviour receives the event and plays the dig animation.

## 16. Implementation Notes (Companion Design)
Companions are relationships. Every companion must define:
1. **Personality:** (e.g., Lazy, Energetic).
2. **Behaviors:** (e.g., Sleeps in the sun, barks at birds).
3. **Preferences:** (e.g., Loves apples, hates fish).
4. **Daily Activities:** Schedule based on in-game time.
5. **Growth/Memories:** "Remembers" who gave them their favorite toy.

## 17. Testing Strategy
- AI bot running 24 in-game hours to ensure pets naturally cycle through schedules.

## 18. Risks
- Pathfinding (NavMesh) calculations for 20 companions tanking CPU.

## 19. Future Expansion
- Breeding or trading companions.

## 20. Automation Hooks
- N/A

## 21. Definition of Done
- Headless companion state machine approved.

## 22. Review Checklist
- [x] Founder
- [x] All 8 Agents

## 23. Decision History
- v1.1: Applied Founder Directives (Platform First, Data Driven, Companion Design).
- v1.0: Adopted headless AI state machine.

## 24. Traceability
- **Idea -> Requirement:** REQ-018
- **Design Tokens:** `OnPlayerInteraction` triggers `TKN-009: Companion Greeting`.
