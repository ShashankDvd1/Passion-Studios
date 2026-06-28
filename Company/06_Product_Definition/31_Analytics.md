---
document_id: "06-031"
title: "Analytics"
owner: "Analytics Agent"
status: "Approved"
version: "1.1"
created: "2026-06-28"
updated: "2026-06-28"
phase: "Phase 4 — Product Definition Platform"
priority: "P0"
---

# 31. Analytics

## 2. Purpose
To define the telemetry strategy for Tiny World, allowing data-driven decisions.

## 3. Vision
Collect data to improve player experience. Not to maximize addiction.

## 4. Problem Statement
**Player Problem:** Games that harvest excessive data drain mobile batteries and violate trust.

## 5. Goals
- Track Studio-wide KPIs: D1/D7/D30 Retention, Session Satisfaction, FTUE Completion, Feature Adoption, Happiness Score, Attachment Score.
- Every event must define its Purpose, KPI, Decision supported, Dashboard owner, Privacy classification, and Retention value.

## 6. Non Goals
- Selling data to third-party ad brokers.

## 7. Dependencies
- `Studio_Experience_Guidelines.md`

## 8. Related Platforms
- LWP: `Analytics_System`

## 9. Related Agents
- Analytics Agent
- Product Manager Agent

## 10. Related Feature IDs
- `FEAT-ANL-01` (Firebase Integration)

## 11. User Stories
- **As a Developer...** I want to know exactly where players get stuck in the tutorial.

## 12. Acceptance Criteria
- [ ] No PII is sent.
- [ ] Events missing a "Decision Supported" field are removed.

## 13. KPIs
- Analytics discrepancy rate < 5%.

## 14. Analytics Events
- Defined in the Content Registry.

## 15. Unity Mapping (Implementation Readiness)
- **ScriptableObjects:** `AnalyticsConfig.asset`
- **Interfaces:** `IAnalyticsProvider`.
- **Runtime Managers:** `AnalyticsManager` (Headless).
- **Systems Used:** `Save_System`
- **Events Published:** N/A.
- **Events Consumed:** All global events.
- **UI Screens:** `Privacy_TOS_Modal`.
- **Prefabs:** N/A.
- **Event Channels:** `GlobalAnalyticsChannel`
- **Save Data Impact:** `ConsentSaveData`.
- **Localization Keys:** `UI_PRIVACY_POLICY`
- **Remote Config Support:** N/A.
- **Addressables:** N/A.
- **Editor Tooling:** `AnalyticsValidator`.
- **Automated Test Cases:** Consent flag enforcement.
- **AI Code Gen Notes:** `AnalyticsManager` uses an interface wrapper.

## 16. Implementation Notes (Event Philosophy)
Before adding an event, answer:
- **Purpose:** Why do we need this?
- **Decision Supported:** If this number goes down, what will we change? (If the answer is "nothing", don't track it).

## 17. Testing Strategy
- QA Agent using Charles Proxy.

## 18. Risks
- Exceeding monthly event quotas.

## 19. Future Expansion
- Crashlytics integration.

## 20. Automation Hooks
- N/A

## 21. Definition of Done
- Privacy-first taxonomy defined.

## 22. Review Checklist
- [x] Founder
- [x] All 8 Agents

## 23. Decision History
- v1.1: Applied Analytics Philosophy and Studio-wide KPIs.
- v1.0: Enforced Privacy by Design.

## 24. Traceability
- **Idea -> Requirement:** REQ-031
