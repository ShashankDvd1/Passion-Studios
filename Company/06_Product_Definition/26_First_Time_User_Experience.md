---
document_id: "06-026"
title: "First Time User Experience (FTUE)"
owner: "UX Agent"
status: "Approved"
version: "1.1"
created: "2026-06-28"
updated: "2026-06-28"
phase: "Phase 4 — Product Definition Platform"
priority: "P0"
---

# 26. First Time User Experience (FTUE)

## 2. Purpose
To define the very first 5 to 10 minutes of gameplay. The FTUE creates excitement, confidence, and curiosity.

## 3. Vision
The objective is NOT to teach every mechanic. The objective is to make players feel: "I understand enough to play," "I want to see what happens next," and "This world feels alive."

## 4. Problem Statement
**Player Problem:** Hand-holdy tutorials that freeze the screen and force the player to tap a glowing box insult player intelligence.

## 5. Goals
- Teach through action and interaction, not text.
- Provide Player Agency. Let the player choose what to interact with first.

## 6. Non Goals
- Teaching advanced meta-systems on Day 1.

## 7. Dependencies
- `25_Onboarding.md`

## 8. Related Platforms
- HX Engine (Autonomy Support)

## 9. Related Agents
- UX Agent
- Game Designer Agent

## 10. Related Feature IDs
- `FEAT-FTUE-01` (Gentle Guides)

## 11. User Stories
- **As a new player...** I want to feel smart for figuring out the controls.

## 12. Acceptance Criteria
- [ ] No more than 3 text boxes in the first 5 minutes.
- [ ] Screen is never artificially frozen.

## 13. KPIs
- FTUE Completion Rate (>80%).

## 14. Analytics Events
- `ftue_step_started`

## 15. Unity Mapping (Implementation Readiness)
- **ScriptableObjects:** `FTUEFlow.asset`
- **Interfaces:** `IFTUECondition`.
- **Runtime Managers:** `FTUEManager` (Headless).
- **Systems Used:** `Save_System`, `Interaction_System`
- **Events Published:** `OnFTUEStepCompleted`.
- **Events Consumed:** `OnInteractionSuccess`.
- **UI Screens:** `FTUE_Overlay_Canvas` (Non-blocking hints).
- **Prefabs:** `Highlight_Particle_VFX`
- **Event Channels:** `GlobalFTUEChannel`
- **Save Data Impact:** `FTUESaveData` (LastCompletedStep).
- **Localization Keys:** `FTUE_HINT_{ID}`
- **Addressables:** FTUE voice lines.
- **Editor Tooling:** `FTUEDebugger` (Skip to specific FTUE states).
- **Automated Test Cases:** Simulate player input completing the first 3 actions.
- **AI Code Gen Notes:** `FTUEManager` observes the game state passively.

## 16. Implementation Notes
Use `TKN-001: Item Discovered` to make interactions rewarding.

## 17. Testing Strategy
- A/B testing variations of the FTUE.

## 18. Risks
- Being *too* hands-off.

## 19. Future Expansion
- N/A

## 20. Automation Hooks
- N/A

## 21. Definition of Done
- FTUE flow diagram approved.

## 22. Review Checklist
- [x] Founder
- [x] All 8 Agents

## 23. Decision History
- v1.1: Implemented FTUE philosophy (Excitement/Confidence).
- v1.0: Forbidden screen-freezing tutorials.

## 24. Traceability
- **Idea -> Requirement:** REQ-026
