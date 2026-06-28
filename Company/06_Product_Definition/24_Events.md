---
document_id: "06-024"
title: "Events System"
owner: "Game Designer Agent"
status: "Approved"
version: "1.1"
created: "2026-06-28"
updated: "2026-06-28"
phase: "Phase 4 — Product Definition Platform"
priority: "P1"
---

# 24. Events System

## 2. Purpose
To define the LiveOps framework for temporary, time-bound changes to the world.

## 3. Vision
Events create anticipation without pressure. They inject "Surprise" into the game but must never use FOMO or "Pay-to-Win" pressure tactics.

## 4. Problem Statement
**Player Problem:** After Day 60, the world becomes predictable. Predictability reduces session frequency.

## 5. Goals
- Define a headless calendar system supporting Client-Side and Server-Side events.
- Adhere to Event Design principles (Trigger, Duration, Frequency, Rewards).

## 6. Non Goals
- Pay-to-Win leaderboards.

## 7. Dependencies
- `33_LiveOps.md`

## 8. Related Platforms
- LWP: `Time_System`

## 9. Related Agents
- Game Designer Agent
- Analytics Agent

## 10. Related Feature IDs
- `FEAT-EVNT-01` (In-Game Calendar)

## 11. User Stories
- **As a veteran player...** I want a reason to log in on weekends... **So that...** I can participate in community festivals.

## 12. Acceptance Criteria
- [ ] Events can override default `WorldSimulationManager` spawn rules.
- [ ] Every event defines its 7 core design parameters.

## 13. KPIs
- DAU spike during event weekends.

## 14. Analytics Events
- `event_started`, `event_participated`.

## 15. Unity Mapping (Implementation Readiness)
- **ScriptableObjects:** `EventDefinition.asset`
- **Interfaces:** `IEventModifier`.
- **Runtime Managers:** `EventManager` (Headless).
- **Systems Used:** `Time_System`
- **Events Published:** `OnLiveEventStarted(EventID)`, `OnLiveEventEnded(EventID)`.
- **Events Consumed:** `OnDayChanged`.
- **UI Screens:** `Calendar_UI`, `Event_Banner_HUD`
- **Prefabs:** Temporary Event NPCs/Stalls.
- **Event Channels:** `GlobalLiveOpsChannel`
- **Save Data Impact:** `EventParticipationSaveData`.
- **Localization Keys:** `EVENT_NAME_{ID}`, `EVENT_DESC_{ID}`
- **Addressables:** Event-specific banners downloaded dynamically.
- **Editor Tooling:** `LiveOpsCalendarEditor`.
- **Automated Test Cases:** Mocking system clock to verify start/end logic.
- **AI Code Gen Notes:** `EventManager` uses UTC time.

## 16. Implementation Notes (Event Design)
Every event must define:
1. **Trigger:** Specific date, or player milestone.
2. **Duration:** e.g., 48 hours.
3. **Frequency:** e.g., Monthly.
4. **Rewards:** Exclusive cosmetics (never power-crept gear).
5. **Required Systems:** `Time_System`, `Object_System`.
6. **Analytics Events:** `event_reward_claimed`.
7. **LiveOps Ownership:** Product Manager Agent.

## 17. Testing Strategy
- Mocking the system clock.

## 18. Risks
- Time-traveling exploits (Mitigation: Use server-verified UTC time).

## 19. Future Expansion
- Cross-game events (e.g., Tiny World x Tiny Cafe).

## 20. Automation Hooks
- N/A

## 21. Definition of Done
- LiveOps Event architecture defined.

## 22. Review Checklist
- [x] Founder
- [x] All 8 Agents

## 23. Decision History
- v1.1: Applied Event Design parameters.
- v1.0: Configured headless LiveOps support.

## 24. Traceability
- **Idea -> Requirement:** REQ-024
- **Design Tokens:** `TKN-003: Major Milestone`
