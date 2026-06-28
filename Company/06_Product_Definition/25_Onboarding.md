---
document_id: "06-025"
title: "Onboarding"
owner: "UX Agent"
status: "Approved"
version: "1.1"
created: "2026-06-28"
updated: "2026-06-28"
phase: "Phase 4 — Product Definition Platform"
priority: "P0"
---

# 25. Onboarding

## 2. Purpose
To define the friction-less pipeline that brings a player from the "Install" state into the actual game world as quickly as possible.

## 3. Vision
Onboarding must be invisible. We do not front-load terms of service, account creation, server selection, or unskippable cutscenes.

## 4. Problem Statement
**Player Problem:** Every screen between tapping the app icon and gaining character control drops 10% of users.

## 5. Goals
- Achieve < 5 seconds from App Open to Gameplay.
- Delay account creation/linking until Day 3 (Progressive Disclosure).

## 6. Non Goals
- "Lore dumping" before the player cares about the world.

## 7. Dependencies
- `06_Player_Journey.md`

## 8. Related Platforms
- LWP: `Save_System`

## 9. Related Agents
- UX Agent
- Unity Architect Agent

## 10. Related Feature IDs
- `FEAT-ONB-01` (Fast Boot Sequence)

## 11. User Stories
- **As a new player...** I want to start playing instantly.

## 12. Acceptance Criteria
- [ ] No mandatory account login on first boot.
- [ ] Zero unskippable cinematic videos.

## 13. KPIs
- App Open to FTUE Start conversion rate (>95%).

## 14. Analytics Events
- `app_opened`, `onboarding_complete`

## 15. Unity Mapping (Implementation Readiness)
- **ScriptableObjects:** `BootConfig.asset`
- **Interfaces:** `IBootStep`.
- **Runtime Managers:** `BootManager` (Headless state machine).
- **Systems Used:** `Save_System`
- **Events Published:** `OnBootComplete`.
- **Events Consumed:** N/A.
- **UI Screens:** `Splash_Screen_Canvas`
- **Prefabs:** N/A
- **Event Channels:** N/A
- **Save Data Impact:** Local device ID generated automatically.
- **Localization Keys:** `UI_LOADING`
- **Addressables:** Core boot assets only.
- **Editor Tooling:** N/A.
- **Automated Test Cases:** Cold boot benchmarks.
- **AI Code Gen Notes:** `BootManager` runs a sequence of asynchronous `IBootStep` tasks. It must never freeze the main thread.

## 16. Implementation Notes
The first screen the player sees should instantly trigger a satisfying start button sound.

## 17. Testing Strategy
- QA Agent automating thousands of fresh installs to track boot failure rates.

## 18. Risks
- Silent sign-in fails, causing the game to hang on a black screen.

## 19. Future Expansion
- Cloud save syncing (after Day 3).

## 20. Automation Hooks
- N/A

## 21. Definition of Done
- Boot sequence logic defined.

## 22. Review Checklist
- [x] Founder
- [x] All 8 Agents

## 23. Decision History
- v1.1: Applied deep Unity Readiness.
- v1.0: Enforced delayed account creation.

## 24. Traceability
- **Idea -> Requirement:** REQ-025
