---
document_id: "06-030"
title: "Notifications"
owner: "UX Agent"
status: "Approved"
version: "1.1"
created: "2026-06-28"
updated: "2026-06-28"
phase: "Phase 4 — Product Definition Platform"
priority: "P1"
---

# 30. Notifications

## 2. Purpose
To define the local and remote push notification strategy to bring players back without causing annoyance.

## 3. Vision
Notifications must never manipulate players. Every notification must answer: Why is this valuable? What player benefit exists? Could they ignore it? Would I personally appreciate receiving it?

## 4. Problem Statement
**Player Problem:** Games that spam 4 push notifications a day get their notification permissions permanently disabled.

## 5. Goals
- Define exactly which game events warrant a push notification.
- Support smart scheduling, quiet hours, localization, personalization, and frequency limits.

## 6. Non Goals
- "Your energy is full" notifications.

## 7. Dependencies
- `Studio_Experience_Guidelines.md`

## 8. Related Platforms
- LWP: `Time_System`

## 9. Related Agents
- UX Agent
- Analytics Agent

## 10. Related Feature IDs
- `FEAT-NOTIF-01` (Local Push)
- `FEAT-NOTIF-02` (Remote Push)

## 11. User Stories
- **As a player...** I want to know exactly when my house upgrade is finished.

## 12. Acceptance Criteria
- [ ] Notifications never lie about game state.
- [ ] Notifications support "Quiet Hours".

## 13. KPIs
- Notification Opt-in Rate.
- Push Notification CTR.

## 14. Analytics Events
- `notification_sent`, `notification_clicked`, `notification_dismissed`.

## 15. Unity Mapping (Implementation Readiness)
- **ScriptableObjects:** `NotificationConfig.asset`
- **Interfaces:** `INotificationService`.
- **Runtime Managers:** `NotificationManager` (Headless).
- **Systems Used:** `Time_System`
- **Events Published:** `OnNotificationScheduled`.
- **Events Consumed:** `OnAppFocusLost`, `OnAppFocusGained`.
- **UI Screens:** `Settings_Modal` (Toggles for quiet hours and frequency).
- **Prefabs:** N/A
- **Event Channels:** `GlobalNotificationChannel`
- **Save Data Impact:** `SettingsSaveData`.
- **Localization Keys:** `NOTIF_BODY_{ID}`
- **Accessibility Settings:** Screen reader support for notification payloads.
- **Remote Config Support:** Enable/Disable specific remote campaigns.
- **Addressables:** N/A.
- **Editor Tooling:** `NotificationDebugger`.
- **Automated Test Cases:** Ensure quiet hours properly delay execution.
- **AI Code Gen Notes:** `NotificationManager` schedules local notifications based on remaining timers when the app is suspended.

## 16. Implementation Notes
Notifications should only trigger for positive, high-anticipation events.

## 17. Testing Strategy
- QA Agent testing background suspension on iOS and Android.

## 18. Risks
- OS-level notification throttling.

## 19. Future Expansion
- Rich notifications.

## 20. Automation Hooks
- N/A

## 21. Definition of Done
- Notification scheduling rules defined.

## 22. Review Checklist
- [x] Founder
- [x] All 8 Agents

## 23. Decision History
- v1.1: Added Notification Philosophy (Quiet hours, Value test).
- v1.0: Enforced "Respectful Notifications" rule.

## 24. Traceability
- **Idea -> Requirement:** REQ-030
