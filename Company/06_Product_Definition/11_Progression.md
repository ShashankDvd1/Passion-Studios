---
document_id: "06-011"
title: "Progression"
owner: "Game Designer Agent"
status: "Approved"
version: "1.1"
created: "2026-06-28"
updated: "2026-06-28"
phase: "Phase 4 — Product Definition Platform"
priority: "P0"
---

# 11. Progression

## 2. Purpose
To define the multiple vectors of growth the player experiences. Progression must never rely solely on a generic "Level" or "Coins."

## 3. Vision
Progression must be multi-dimensional (Founder Directive 02). Each system has independent goals and rewards, preventing a single monolithic grind-wall.

## 4. Problem Statement
**Player Problem:** Linear progression systems create hard "grind walls" that stall gameplay, causing players to log off and churn.

## 5. Goals
- Track independent progression systems.
- Ensure no single layer blocks all others.

## 6. Non Goals
- "Pay to Skip" timers that punish players for not spending money.

## 7. Dependencies
- `04-010: Progression_System (HX)`
- `05-015: Progression_System (LWP)`

## 8. Related Platforms
- LWP: `Customization_System`, `NPC_System`, `Collection_System`

## 9. Related Agents
- Game Designer Agent

## 10. Related Feature IDs
- `FEAT-PROG-01` (Skill Leveling)

## 11. User Stories
- **As a player...** I want to feel like I am always moving forward... **So that...** even a 5-minute session feels productive.

## 12. Acceptance Criteria
- [ ] At least 4 orthogonal progression layers are available to the player by Day 3.

## 13. KPIs
- % of players engaging with 3+ progression layers.

## 14. Analytics Events
- `progression_milestone_reached` (Payload: LayerName, Level).

## 15. Unity Mapping (Implementation Readiness)
- **ScriptableObjects:** `SkillDefinition.asset`, `AchievementDefinition.asset`.
- **Runtime Managers:** `ProgressionManager`, `RelationshipManager`.
- **Systems Used:** `Save_System`
- **Save Data Impact:** `SkillState`, `RelationshipSaveData`.
- **Events Published:** `OnLevelUp`, `OnMilestoneReached` (Triggers `TKN-003: Major Milestone`).
- **Events Consumed:** `OnActionCompleted` (to award XP).
- **Addressables:** UI Badges, Level Up VFX.
- **UI Screens:** `Progression_Dashboard_UI`.
- **Testing Requirements:** Validate XP distribution curves.
- **AI Code Gen Notes:** `ProgressionManager` must be headless. It tracks integers and broadcasts events. It should not instantiate UI confetti itself.

## 16. Implementation Notes (Multi-Dimensional Layers)
Each layer has independent goals/rewards:
- **World Progression:** Unlocking new map zones.
- **Player Progression:** Upgrading max stamina/energy.
- **Collection Progression:** Filling the museum (Rewards unique cosmetics).
- **Companion Progression:** Pet loyalty levels.
- **Discovery Progression:** Finding all hidden recipes.
- **Customization Progression:** House size upgrades.
- **Relationship Progression:** NPC heart levels (Rewards narrative events).
- **Seasonal Progression:** Completing a month's events.
- **Achievement Progression:** Meta-goals (e.g., "Chop 1,000 trees").

## 17. Testing Strategy
- AI balancing bots playing 10,000 simulated days.

## 18. Risks
- UI overload. Showing 9 progression bars on Day 1 will cause paralysis.

## 19. Future Expansion
- "Prestige" progression.

## 20. Automation Hooks
- Economy Agent auto-balancing the XP curves.

## 21. Definition of Done
- Multi-layered progression mapped.

## 22. Review Checklist
- [x] Founder
- [x] All 8 Agents

## 23. Decision History
- v1.1: Expanded to 9 specific multi-dimensional layers.
- v1.0: Multi-layered progression established.

## 24. Traceability
- **Idea -> Requirement:** REQ-011
