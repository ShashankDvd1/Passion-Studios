---
document_id: "06-028"
title: "UI/UX System"
owner: "UX Agent"
status: "Approved"
version: "1.1"
created: "2026-06-28"
updated: "2026-06-28"
phase: "Phase 4 — Product Definition Platform"
priority: "P0"
---

# 28. UI/UX System

## 2. Purpose
To define the architecture for the User Interface, ensuring strict separation between data and presentation.

## 3. Vision
The UI should disappear (Founder Directive 02). Players should interact with the world, not menus. It must strictly follow the **Clarity First** and **One-Hand Friendly** mandates from the SEG.

## 4. Problem Statement
**Player Problem:** Cluttered UI screens that require two hands to reach the top corners.

## 5. Goals
- Anchor all primary interactable UI elements to the Thumb Zone.
- Implement a strict MVC/MVP architecture for all UI Canvases.
- Progressive disclosure of UI elements.

## 6. Non Goals
- Finalizing exact pixel dimensions.

## 7. Dependencies
- `Studio_Experience_Guidelines.md`

## 8. Related Platforms
- LWP: All Headless Managers.

## 9. Related Agents
- UX Agent
- Unity Architect Agent

## 10. Related Feature IDs
- `FEAT-UI-01` (Core HUD)

## 11. User Stories
- **As a player...** I want smooth animations when a menu opens.

## 12. Acceptance Criteria
- [ ] No UI script contains gameplay logic.
- [ ] Every interaction validates against the Design Token Library.

## 13. KPIs
- Session Satisfaction.
- Mis-click rates.

## 14. Analytics Events
- `ui_menu_opened`, `ui_menu_closed`.

## 15. Unity Mapping (Implementation Readiness)
- **ScriptableObjects:** `UIThemeConfig.asset`
- **Interfaces:** `IUIView`, `IUIController`.
- **Runtime Managers:** `UIManager` (Handles modal stack).
- **Systems Used:** `Save_System`
- **Events Published:** `OnUIModalOpened`, `OnUIModalClosed`.
- **Events Consumed:** All Headless Manager events.
- **UI Screens:** `Master_Canvas`, `HUD_Canvas`, `Popup_Canvas`.
- **Prefabs:** Standardized generic buttons, panels, toggles (UI Toolkit / uGUI mapping).
- **Event Channels:** `GlobalUIChannel`
- **Save Data Impact:** UI layout preferences.
- **Localization Keys:** Linked via `UITextLocalizer` component.
- **Accessibility Settings:** Bound directly to prefabs.
- **Remote Config Support:** Yes (for A/B testing layouts).
- **Addressables:** UI Sprites.
- **Editor Tooling:** `UIThemeApplier`.
- **Automated Test Cases:** Automated UI testing strategy (simulated clicks).
- **AI Code Gen Notes:** `UIManager` manages the stack (push/pop).

## 16. Implementation Notes (Design Token Validation)
Every UI interaction must intentionally express an emotion:
- Tap (Comfort -> `TKN-002`)
- Unlock (Celebration -> `TKN-003`)
- Discovery (Surprise -> `TKN-004`)

## 17. Testing Strategy
- Frame profiler to ensure UI Canvas rebuilds don't exceed 2ms.

## 18. Risks
- Over-using transparent UI panels.

## 19. Future Expansion
- Controller support mapping.

## 20. Automation Hooks
- Automated simulated clicks for QA.

## 21. Definition of Done
- MVC architecture established for all UI.

## 22. Review Checklist
- [x] Founder
- [x] All 8 Agents

## 23. Decision History
- v1.1: Applied UI Philosophy and AI Readiness.
- v1.0: Enforced "Thumb Zone".

## 24. Traceability
- **Idea -> Requirement:** REQ-028
