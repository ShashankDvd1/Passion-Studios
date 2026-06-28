---
document_id: "06-029"
title: "Accessibility"
owner: "UX Agent"
status: "Approved"
version: "1.1"
created: "2026-06-28"
updated: "2026-06-28"
phase: "Phase 4 — Product Definition Platform"
priority: "P0"
---

# 29. Accessibility

## 2. Purpose
To ensure Tiny World is playable and enjoyable by the widest possible audience.

## 3. Vision
Accessibility is a feature, not an afterthought (Founder Directive 03). It must be part of the Definition of Done for every single mechanic.

## 4. Problem Statement
**Player Problem:** Games that rely purely on audio cues (or tiny red/green indicators) lock out massive portions of the player base.

## 5. Goals
- Support Color Blindness, Large Text, Motion Sensitivity, Haptic/Audio alternatives, Left-handed play, Low-end devices, and Offline behavior.

## 6. Non Goals
- "Auto-playing" the game.

## 7. Dependencies
- `Studio_Experience_Guidelines.md`

## 8. Related Platforms
- HX Engine

## 9. Related Agents
- UX Agent

## 10. Related Feature IDs
- `FEAT-ACC-01` (Accessibility Settings)

## 11. User Stories
- **As a colorblind player...** I want crop readiness to be indicated by shape, not just color.

## 12. Acceptance Criteria
- [ ] No mechanic relies *solely* on color to convey critical information.
- [ ] Every feature passes the 8-point accessibility evaluation before being marked Done.

## 13. KPIs
- Adoption rate of Accessibility toggles.

## 14. Analytics Events
- `accessibility_setting_changed`

## 15. Unity Mapping (Implementation Readiness)
- **ScriptableObjects:** `AccessibilityProfile.asset`
- **Interfaces:** `IColorBlindAdaptable`.
- **Runtime Managers:** `AccessibilityManager` (Headless).
- **Systems Used:** `Save_System`
- **Events Published:** `OnAccessibilityProfileChanged`.
- **Events Consumed:** N/A.
- **UI Screens:** `Settings_Modal`
- **Prefabs:** High-contrast variants of critical icons.
- **Event Channels:** `GlobalSettingsChannel`
- **Save Data Impact:** `SettingsSaveData`.
- **Localization Keys:** `UI_ACCESSIBILITY_{KEY}`
- **Remote Config Support:** N/A.
- **Addressables:** UI Atlases for high-contrast modes.
- **Editor Tooling:** `ColorBlindSimulator`.
- **Automated Test Cases:** Font scaling overlap tests.
- **AI Code Gen Notes:** `AccessibilityManager` applies global material property overrides.

## 16. Implementation Notes
Accessibility is evaluated across:
1. Color blindness
2. Large text
3. Motion sensitivity
4. Haptic alternatives
5. Audio alternatives
6. Left-handed play
7. Low-end devices
8. Offline behavior

## 17. Testing Strategy
- Use Unity's Device Simulator to verify UI text legibility at maximum font scale.

## 18. Risks
- High-contrast modes breaking the intended "cozy" aesthetic.

## 19. Future Expansion
- Screen-reader API integration.

## 20. Automation Hooks
- N/A

## 21. Definition of Done
- 8-point evaluation passed.

## 22. Review Checklist
- [x] Founder
- [x] All 8 Agents

## 23. Decision History
- v1.1: Applied 8-point accessibility requirement.
- v1.0: Enforced Color/Audio redundancy.

## 24. Traceability
- **Idea -> Requirement:** REQ-029
