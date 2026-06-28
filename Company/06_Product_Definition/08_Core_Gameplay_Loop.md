---
document_id: "06-008"
title: "Core Gameplay Loop"
owner: "Game Designer Agent"
status: "Approved"
version: "1.1"
created: "2026-06-28"
updated: "2026-06-28"
phase: "Phase 4 — Product Definition Platform"
priority: "P0"
---

# 08. Core Gameplay Loop

## 2. Purpose
To define the minute-to-minute interactions of Tiny World, deriving mechanics directly from the target emotions (Curiosity, Delight, Competence) rather than starting with standard genre tropes.

## 3. Vision
The Core Loop is a rhythm of tension (minor effort/curiosity) and release (delight/reward). Gameplay exists solely to evoke emotion.

## 4. Problem Statement
**Player Problem:** Typical simulation loops (Plant -> Water -> Harvest) become mindless chores that drive churn due to boredom.

## 5. Goals
- Define the `Explore -> Discover -> Nurture -> Harvest` emotional loop.
- Structure gameplay at four distinct hierarchical levels.

## 6. Non Goals
- Creating a combat loop or high-APM (Actions Per Minute) stress loops.

## 7. Dependencies
- `04-004: Core_Experience_Loops` (HX Engine)
- `06-006: Player_Journey`

## 8. Related Platforms
- LWP: `Interaction_System` (`05-005`), `Player_System` (`05-006`)

## 9. Related Agents
- Game Designer Agent
- Human Experience Agent

## 10. Related Feature IDs
- `FEAT-CORE-01` (Interaction Verb System)
- `FEAT-CORE-02` (Grid Movement)

## 11. User Stories
- **As a player...** I want the act of harvesting to feel incredibly satisfying... **So that...** the manual labor feels like a reward in itself.
- **Analytics Events:** `core_loop_cycle_complete`

## 12. Acceptance Criteria
- [ ] Loop design follows the Emotion -> Motivation -> Mechanic order.
- [ ] Every interaction explicitly references a Design Token.

## 13. KPIs
- Core Actions per Minute (CAPM) during active play.

## 14. Analytics Events
- `harvest_action_success`
- `tool_equipped`

## 15. Unity Mapping (Implementation Readiness)
- **ScriptableObjects:** `VerbDictionary.asset`, `ToolDefinition.asset`
- **Runtime Managers:** `InteractionManager`, `PlayerController`
- **Systems Used:** `Object_System`, `Player_System`
- **Save Data Impact:** `PlayerInventorySaveData`
- **Events Published:** `OnInteractionSuccess`, `OnMicroRewardTriggered`
- **Events Consumed:** `OnInputReceived`
- **Addressables:** Base tool models, harvest VFX.
- **UI Screens:** `Interaction_Prompt_Canvas`
- **Prefabs:** `Player_Avatar`, `Interactable_Crop`
- **Performance Notes:** Interaction raycasts must use `NonAlloc` methods to avoid GC spikes on every tap.
- **Testing Requirements:** Verify high-frequency tapping does not skip animation states.
- **AI Code Generation Notes:** Make sure `InteractionManager` is headless and merely dispatches events that the `PlayerAnimator` listens to.

## 16. Implementation Notes (Gameplay Loop Hierarchy)
**1. Micro Loop (seconds):** `Tap → Visual/Audio Feedback → Reward` (Uses `TKN-002: Micro-Reward`).
**2. Core Loop (minutes):** `Explore Area → Discover Resource → Nurture/Process → Collect`. (Uses `TKN-001: Item Discovered`).
**3. Meta Loop (days):** `Gather Surplus → Unlock New Area/Tool → Personalize Space → Log Off`.
**4. Long-Term Loop (months):** `Create Memories (Events) → Build Identity (Housing/Pets) → Complete Compendium → Social Share`.

## 17. Testing Strategy
- Playtest the core loop for 10 minutes with no meta-progression enabled to see if the raw interaction feels good.

## 18. Risks
- Loop is too slow, causing frustration instead of relaxation.

## 19. Future Expansion
- New verbs (e.g., Fishing, Bug Catching) that hook into the same core loop architecture.

## 20. Automation Hooks
- QA Agent running an automated bot that executes the loop 1,000 times to test GC allocation.

## 21. Definition of Done
- Core loop flow diagram approved by Founder.

## 22. Review Checklist
- [x] Founder
- [x] All 8 Agents

## 23. Decision History
- v1.1: Added 4-level loop hierarchy and headless Unity mapping.
- v1.0: Derived core loop from HX target emotions.

## 24. Traceability
- **Idea -> Requirement:** REQ-008
- **Feature Registry Update:** Added `FEAT-CORE-01`.
