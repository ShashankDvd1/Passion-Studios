---
document_id: "06-009"
title: "Meta Gameplay Loop"
owner: "Game Designer Agent"
status: "Approved"
version: "1.0"
created: "2026-06-28"
updated: "2026-06-28"
phase: "Phase 4 — Product Definition Platform"
priority: "P0"
---

# 09. Meta Gameplay Loop

## 2. Purpose
To define the long-term, strategic cycles that provide meaning to the Core Loop. The Meta Loop translates daily chores into long-term emotional milestones (Ownership, Mastery).

## 3. Vision
The Meta Loop is about Transformation. The player transforms a messy, overgrown plot into a personalized, optimized, and beautiful sanctuary.

## 4. Problem Statement
**Player Problem:** If a game only has a core loop, players churn on Day 3. They need a reason to log in on Day 30.

## 5. Goals
- Map the Meta Loop (`Gather -> Refine -> Build/Upgrade -> Expand`).
- Define how progression layers (Cosmetic, World, Relationship) intersect.

## 6. Non Goals
- Adding infinite procedural levels with no permanent impact.

## 7. Dependencies
- `08_Core_Gameplay_Loop.md`
- `04-005: Meta_Experience_Loops`

## 8. Related Platforms
- LWP: `Progression_System` (`05-015`), `Customization_System` (`05-018`)

## 9. Related Agents
- Game Designer Agent
- Economy Agent

## 10. Related Feature IDs
- `FEAT-META-01` (House Upgrades)
- `FEAT-META-02` (Tool Upgrades)

## 11. User Stories
- **As a D14 player...** I want to upgrade my house... **So that...** I have more space to express myself and feel a sense of Ownership.
- **Analytics Events:** `house_upgraded`

## 12. Acceptance Criteria
- [ ] Meta loop clearly bridges short-term effort to long-term goals.

## 13. KPIs
- Meta-goal completion rate (e.g., % of players who reach House Level 2).

## 14. Analytics Events
- `meta_goal_started`
- `meta_goal_completed`

## 15. Unity Mapping
- **Expected Scene:** `MainWorldScene`
- **Required Prefabs:** Upgrade UI Modals, Tiered object visuals.
- **ScriptableObjects:** `UpgradeRequirement.asset`
- **Managers:** `ProgressionManager`, `CollectionManager`
- **Save Data:** `ProgressionSaveData`
- **AI Code Generation Notes:** Utilize the Strategy pattern to evaluate if a player has met the requirements for a meta-upgrade, allowing easy addition of new requirement types.

## 16. Implementation Notes
The meta loop must be heavily visible. UI should always remind the player what their next long-term goal is.

## 17. Testing Strategy
- Cheat resources to max and verify all meta-upgrades can be sequentially triggered without crashing.

## 18. Risks
- Meta loop goals are too far apart (e.g., takes 20 hours to get the first upgrade), causing churn.

## 19. Future Expansion
- Community Meta Loops (Server-wide goals).

## 20. Automation Hooks
- Economy Agent simulating resource flow over 30 days to validate upgrade pacing.

## 21. Definition of Done
- Meta Loop documented and pacing simulated.

## 22. Review Checklist
- [x] Founder
- [x] Product Manager Agent
- [x] Game Designer Agent
- [x] Human Experience Agent
- [x] Unity Architect Agent
- [x] Analytics Agent
- [x] Monetization Agent
- [x] QA Agent
- [x] Documentation Agent

## 23. Decision History
- v1.0: Derived from Ownership and Mastery HX principles.

## 24. Traceability
- **Idea -> Requirement:** REQ-009
- **Feature Registry Update:** Added `FEAT-META-01`.
