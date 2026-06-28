---
document_id: "06-023"
title: "Quest System"
owner: "Game Designer Agent"
status: "Approved"
version: "1.1"
created: "2026-06-28"
updated: "2026-06-28"
phase: "Phase 4 — Product Definition Platform"
priority: "P0"
---

# 23. Quest System

## 2. Purpose
To define the bespoke, narrative-driven arcs that guide players through major emotional milestones.

## 3. Vision
Quests are the backbone of the "Relatedness" emotion. They provide Player Agency (Founder Directive 07) by offering choices rather than a rigidly fixed path.

## 4. Problem Statement
**Player Problem:** Linear quests that just say "Fetch 10 Wood" without narrative context are skipped.

## 5. Goals
- Define a node-based, headless quest tracker.
- Allow player agency in quest resolution (e.g., multiple ways to solve a problem).

## 6. Non Goals
- Radiant AI-generated infinite quests.

## 7. Dependencies
- `11_Progression.md`
- `18_Companions.md`

## 8. Related Platforms
- LWP: `NPC_System`
- HX Engine: `Autonomy Support`

## 9. Related Agents
- Game Designer Agent
- Behavioral Psychology Agent

## 10. Related Feature IDs
- `FEAT-QST-01` (Main Story Quests)

## 11. User Stories
- **As a player...** I want quests that change the town... **So that...** my actions feel like they matter.

## 12. Acceptance Criteria
- [ ] Quest logic supports multi-step sequences and branching choices.
- [ ] Every quest defines Player Value and Emotional Support.

## 13. KPIs
- % of players completing the Main Story quest line.

## 14. Analytics Events
- `quest_started`, `quest_completed`.

## 15. Unity Mapping (Implementation Readiness)
- **ScriptableObjects:** `QuestDefinition.asset`, `QuestStep.asset`, `DialogueTree.asset`
- **Interfaces:** `IQuestCondition`.
- **Runtime Managers:** `QuestManager`, `DialogueManager` (Headless).
- **Systems Used:** `Save_System`, `NPC_System`
- **Events Published:** `OnQuestStarted`, `OnQuestStepCompleted(QuestID, StepID)`, `OnQuestCompleted`.
- **Events Consumed:** `OnInteractionSuccess`, `OnDialogueNodeReached`.
- **UI Screens:** `Quest_Log_UI`, `Dialogue_Canvas`
- **Prefabs:** N/A
- **Event Channels:** `GlobalQuestChannel`
- **Save Data Impact:** `QuestSaveData` (QuestID, CurrentStepIndex, ChosenBranch).
- **Localization Keys:** `QUEST_TITLE_{ID}`, `DIALOGUE_NODE_{ID}`
- **Addressables:** Quest Item icons.
- **Editor Tooling:** `NodeGraphQuestEditor` (Visual editor for branching steps).
- **Automated Test Cases:** Pathfinding tests for branching logic ensuring no dead ends.
- **AI Code Gen Notes:** `QuestManager` evaluates active conditions.

## 16. Implementation Notes (Quest Principles)
Each quest must state:
1. **Player Value:** Narrative payoff.
2. **Emotion Supported:** Relatedness / Pride.
3. **Related Feature ID:** `FEAT-QST-01`.
4. **Related HX Principles:** Meaningful Choices.
5. **Related LWP Systems:** `NPC_System`.
6. **Analytics Events:** `quest_completed`.

## 17. Testing Strategy
- Bot jumping to specific quest steps to verify logic without playing 10 hours.

## 18. Risks
- Quest soft-locks (Mitigation: Quest items are un-droppable).

## 19. Future Expansion
- Branching story consequences affecting the town permanently.

## 20. Automation Hooks
- N/A

## 21. Definition of Done
- Node-based quest architecture defined.

## 22. Review Checklist
- [x] Founder
- [x] All 8 Agents

## 23. Decision History
- v1.1: Added player agency and deep Unity readiness.
- v1.0: Established node-based architecture.

## 24. Traceability
- **Idea -> Requirement:** REQ-023
- **Design Tokens:** `TKN-003: Major Milestone`
