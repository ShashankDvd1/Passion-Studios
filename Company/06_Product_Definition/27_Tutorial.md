---
document_id: "06-027"
title: "Tutorial System"
owner: "UX Agent"
status: "Approved"
version: "1.1"
created: "2026-06-28"
updated: "2026-06-28"
phase: "Phase 4 — Product Definition Platform"
priority: "P1"
---

# 27. Tutorial System

## 2. Purpose
To define the architecture for teaching mechanics *after* the FTUE.

## 3. Vision
Tutorials must use **Progressive Disclosure**. Introduce mechanics gradually based on player progress, natural exploration, and curiosity. Every new mechanic should feel like a reward.

## 4. Problem Statement
**Player Problem:** Info-dumping 10 systems on Day 1 ensures the player forgets 9 of them.

## 5. Goals
- Define a contextual trigger system.
- Ensure tutorials teach through interaction rather than large amounts of text.

## 6. Non Goals
- Unskippable forced guides.

## 7. Dependencies
- `26_First_Time_User_Experience.md`

## 8. Related Platforms
- LWP: `Discovery_System`

## 9. Related Agents
- UX Agent

## 10. Related Feature IDs
- `FEAT-TUT-01` (Contextual Tooltips)

## 11. User Stories
- **As a player...** I want to be taught how to fish only when I actually pick up a fishing rod.

## 12. Acceptance Criteria
- [ ] Tutorial popups use standard Data-Driven definitions.
- [ ] Mechanics unlock organically.

## 13. KPIs
- Feature Adoption Rate.

## 14. Analytics Events
- `tutorial_shown`, `tutorial_skipped`.

## 15. Unity Mapping (Implementation Readiness)
- **ScriptableObjects:** `TutorialDefinition.asset`
- **Interfaces:** `ITutorialTrigger`.
- **Runtime Managers:** `TutorialManager` (Headless).
- **Systems Used:** `Save_System`
- **Events Published:** `OnTutorialTriggered(TutorialID)`.
- **Events Consumed:** Generic global events.
- **UI Screens:** `Contextual_Tooltip_Canvas`
- **Prefabs:** N/A
- **Event Channels:** `GlobalTutorialChannel`
- **Save Data Impact:** `HashSet<string> CompletedTutorials`.
- **Localization Keys:** `TUTORIAL_TITLE_{ID}`, `TUTORIAL_BODY_{ID}`
- **Addressables:** UI Sprites for tooltips.
- **Editor Tooling:** `TutorialTriggerValidator`.
- **Automated Test Cases:** Event listener memory leak testing.
- **AI Code Gen Notes:** `TutorialManager` evaluates `ITutorialTrigger` conditions whenever global events fire.

## 16. Implementation Notes
Trigger `TKN-004: Discovery Reveal` when a tooltip appears.

## 17. Testing Strategy
- Unit testing the event listeners.

## 18. Risks
- Event listener bloat.

## 19. Future Expansion
- Video tooltips.

## 20. Automation Hooks
- N/A

## 21. Definition of Done
- Contextual tutorial logic defined.

## 22. Review Checklist
- [x] Founder
- [x] All 8 Agents

## 23. Decision History
- v1.1: Enforced Progressive Disclosure.
- v1.0: Established contextual logic.

## 24. Traceability
- **Idea -> Requirement:** REQ-027
