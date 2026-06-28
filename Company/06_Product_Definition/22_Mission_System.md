---
document_id: "06-022"
title: "Mission System"
owner: "Game Designer Agent"
status: "Approved"
version: "1.1"
created: "2026-06-28"
updated: "2026-06-28"
phase: "Phase 4 — Product Definition Platform"
priority: "P1"
---

# 22. Mission System

## 2. Purpose
To define the daily, repeatable micro-tasks that guide the player during short sessions (e.g., "Harvest 10 Carrots", "Talk to the Blacksmith").

## 3. Vision
Missions exist to provide immediate structure for 5-minute sessions. They must encourage exploration and creativity, rather than repetitive checklists.

## 4. Problem Statement
**Player Problem:** "I have 5 minutes to play, but I don't know what to do right now." 

## 5. Goals
- Provide 3 daily micro-goals.
- Follow Founder Directive 03: Missions should guide, not force.

## 6. Non Goals
- Narrative dialogue trees (Handled in Quests).

## 7. Dependencies
- `10_Session_Design.md` (5-minute session bands)

## 8. Related Platforms
- LWP: `Save_System`
- HX Engine: `Autonomy Support`

## 9. Related Agents
- Game Designer Agent
- Economy Agent

## 10. Related Feature IDs
- `FEAT-MISS-01` (Daily Missions)

## 11. User Stories
- **As a player...** I want a quick checklist of chores... **So that...** I feel accomplished even if I don't make long-term meta progress today.

## 12. Acceptance Criteria
- [ ] Mission definitions are entirely contained in ScriptableObjects.
- [ ] Every mission clearly states Player Value, Emotion Supported, and Analytics Events.

## 13. KPIs
- Daily Mission Completion Rate.

## 14. Analytics Events
- `mission_started`, `mission_completed` (Payload: MissionID, TimeTaken).

## 15. Unity Mapping (Implementation Readiness)
- **ScriptableObjects:** `MissionDefinition.asset`, `RewardTable.asset`
- **Interfaces:** `IMissionCondition`.
- **Runtime Managers:** `MissionManager` (Headless).
- **Systems Used:** `Time_System`, `Save_System`
- **Events Published:** `OnMissionProgressUpdated`, `OnMissionCompleted`.
- **Events Consumed:** `OnDayChanged`, `OnItemAdded`, `OnInteractionSuccess`.
- **UI Screens:** `Mission_Tracker_HUD`
- **Prefabs:** N/A
- **Event Channels:** `GlobalMissionChannel`
- **Save Data Impact:** `MissionSaveData` (MissionID, CurrentProgress).
- **Localization Keys:** `MISSION_DESC_{ID}`
- **Addressables:** Mission Icons.
- **Editor Tooling:** `MissionSimulator` (Test mission completion logic).
- **Automated Test Cases:** Unit test triggering required events to verify the mission state transitions.
- **AI Code Gen Notes:** `MissionManager` uses an event-bus pattern.

## 16. Implementation Notes (Mission Principles)
Each mission must state:
1. **Player Value:** Clear direction for a short session.
2. **Emotion Supported:** Competence.
3. **Related Feature ID:** `FEAT-MISS-01`.
4. **Related HX Principles:** Autonomy (Player can ignore the mission).
5. **Related LWP Systems:** `Time_System`.
6. **Analytics Events:** `mission_completed`.

## 17. Testing Strategy
- AI unit test triggering the required events to verify the mission state transitions to "Complete."

## 18. Risks
- Missions asking for items the player cannot access yet.

## 19. Future Expansion
- Weekly Guild/Co-Op Missions.

## 20. Automation Hooks
- N/A

## 21. Definition of Done
- Headless event-driven mission system defined.

## 22. Review Checklist
- [x] Founder
- [x] All 8 Agents

## 23. Decision History
- v1.1: Applied Founder Directives (Mission Principles, Deep Unity Readiness).
- v1.0: Separated Missions from Quests.

## 24. Traceability
- **Idea -> Requirement:** REQ-022
- **Design Tokens:** `TKN-002: Micro-Reward`
