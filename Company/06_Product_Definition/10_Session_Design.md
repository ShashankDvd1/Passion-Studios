---
document_id: "06-010"
title: "Session Design"
owner: "Game Designer Agent"
status: "Approved"
version: "1.1"
created: "2026-06-28"
updated: "2026-06-28"
phase: "Phase 4 — Product Definition Platform"
priority: "P0"
---

# 10. Session Design

## 2. Purpose
To architect gameplay so that it respects different mobile playstyles. Every session length must answer the four critical quality questions (Why open? What action? Emotional payoff? Why return?).

## 3. Vision
We do not punish players for logging off. If a player only has 1 minute while waiting for a bus, they should be able to log in, accomplish a micro-goal (Delight), and log out feeling good.

## 4. Problem Statement
**Player Problem:** Games that require a minimum 15-minute commitment to achieve *anything* do not fit into adult mobile lifestyles.

## 5. Goals
- Map specific features to specific session lengths (30s, 1m, 5m, 20m).
- Guarantee session quality via emotional checkpoints.

## 6. Non Goals
- Forcing players to stay logged in artificially via slow walking speeds.

## 7. Dependencies
- `08_Core_Gameplay_Loop.md`
- `09_Meta_Gameplay_Loop.md`

## 8. Related Platforms
- LWP: `Offline_System` (`05-017`), `Time_System` (`05-009`)

## 9. Related Agents
- Game Designer Agent
- UX Agent (for fast load times)

## 10. Related Feature IDs
- `FEAT-SESS-01` (Daily Login Rewards)
- `FEAT-SESS-02` (Offline Catchup Report)

## 11. User Stories
- **As a busy adult...** I want to feel productive in a 1-minute session... **So that...** I can play during short breaks without feeling like I wasted my time.

## 12. Acceptance Criteria
- [ ] 30-second session yields at least one `TKN-002: Micro-Reward`.

## 13. KPIs
- Median Session Length.
- Sessions Per User Per Day (SPUPD).

## 14. Analytics Events
- `session_start`
- `session_end` (payload includes duration).

## 15. Unity Mapping (Implementation Readiness)
- **ScriptableObjects:** `SessionRewardConfig.asset`
- **Runtime Managers:** `OfflineCatchupManager`, `TimeManager`
- **Systems Used:** `Time_System`, `Save_System`
- **Save Data Impact:** `LastLoginTimestamp`
- **Events Published:** `OnOfflineProgressCalculated`
- **Events Consumed:** `OnAppFocusGained`
- **UI Screens:** `OfflineSummary_Modal` (Appears instantly on boot).
- **Performance Notes:** To support 30-second sessions, the game MUST boot to a playable state in under 5 seconds. `Addressables` must be used aggressively.
- **Testing Requirements:** QA cold-boot tests.
- **AI Code Generation Notes:** Ensure the `OfflineCatchupManager` is completely decoupled from the UI. It calculates the math and fires an event; the UI just listens.

## 16. Implementation Notes (Session Quality Checklist)
Every session must answer:
1. **Why did the player open the game?** (e.g., Push notification that bread is baked, or daily habit routine).
2. **What meaningful action did they complete?** (e.g., Harvested the bread, fed the companion).
3. **What emotional payoff did they receive?** (e.g., Comfort, `TKN-002` visual/audio feedback).
4. **Why should they return?** (e.g., Put new ingredients in the oven, planting a seed for tomorrow).

## 17. Testing Strategy
- QA Agent to measure cold boot time on a low-end Android device (Target: < 5s).

## 18. Risks
- Long load times completely destroy the viability of 30-second sessions.

## 19. Future Expansion
- Push notifications that explicitly invite 1-minute sessions.

## 20. Automation Hooks
- N/A

## 21. Definition of Done
- Session flowcharts approved.

## 22. Review Checklist
- [x] Founder
- [x] All 8 Agents

## 23. Decision History
- v1.1: Injected 4-question session quality framework.
- v1.0: Initial session bands defined.

## 24. Traceability
- **Requirement -> Unity:** Mapped to boot optimization tasks.
