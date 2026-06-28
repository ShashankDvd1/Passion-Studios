---
document_id: "06-033"
title: "LiveOps System"
owner: "Product Manager Agent"
status: "Approved"
version: "1.0"
created: "2026-06-28"
updated: "2026-06-28"
phase: "Phase 4 — Product Definition Platform"
priority: "P0"
---

# 33. LiveOps System

## 2. Purpose
To define the architecture that allows the game to be operated, balanced, and expanded for years without requiring frequent client (app store) updates.

## 3. Vision
**Prepare for LiveOps** (Founder Directive 10). We design systems, not campaigns. The LiveOps architecture must allow product managers to swap out events, challenges, and storefronts entirely via remote data.

## 4. Problem Statement
**Player Problem:** Games that require a 1GB update from the App Store just to change the color of the Halloween pumpkins cause high churn during the update process.

## 5. Goals
- Every event, challenge, and reward must be configurable remotely.
- Support segmentation (showing different events to different cohorts).

## 6. Non Goals
- Hardcoding specific holiday events into C#.

## 7. Dependencies
- `24_Events.md`

## 8. Related Platforms
- LWP: `Time_System`

## 9. Related Agents
- Product Manager Agent
- Analytics Agent

## 10. Related Feature IDs
- `FEAT-LIV-01` (Remote Config Engine)
- `FEAT-LIV-02` (Over-The-Air Asset Delivery)

## 11. User Stories
- **As a LiveOps Manager...** I want to adjust the cost of a premium item remotely... **So that...** I can balance the economy without a 3-day Apple review.

## 12. Acceptance Criteria
- [ ] All `EventDefinition.asset` instances can be overridden by a JSON payload.
- [ ] Assets required for events are loaded via Unity Addressables dynamically.

## 13. KPIs
- App Update friction (Drop-off rate during forced updates).

## 14. Analytics Events
- `liveops_config_fetched`, `liveops_event_joined`.

## 15. Unity Mapping (Implementation Readiness)
- **ScriptableObjects:** `LiveOpsConfig.asset`
- **Interfaces:** `IRemoteConfigProvider`.
- **Runtime Managers:** `LiveOpsManager` (Headless).
- **Systems Used:** `Save_System`, `Time_System`
- **Events Published:** `OnRemoteConfigLoaded`.
- **Events Consumed:** `OnBootComplete`.
- **UI Screens:** N/A (LiveOps modifies other screens).
- **Prefabs:** N/A.
- **Event Channels:** `GlobalLiveOpsChannel`
- **Save Data Impact:** Cached Remote Configs.
- **Localization Keys:** Downloaded dynamically with the configs.
- **Addressables:** Remote Catalogs enabled for OTA asset delivery.
- **Editor Tooling:** `LiveOpsSimulator` (Injects mock JSON to test events locally).
- **Automated Test Cases:** Fallback logic if the remote server is unreachable.
- **AI Code Gen Notes:** `LiveOpsManager` integrates with Unity Remote Config or Firebase Remote Config. It fetches the latest JSON payload, deserializes it, and overwrites the active `ScriptableObject` values in memory.

## 16. Implementation Notes
Use `TKN-004: Discovery Reveal` when a new LiveOps event is detected and shown to the player upon boot.

## 17. Testing Strategy
- QA Agent disconnecting the internet during a LiveOps fetch to ensure the game falls back to local data gracefully.

## 18. Risks
- Deserialization errors from malformed remote JSON crashing the game. (Mitigation: Strict JSON schema validation before applying).

## 19. Future Expansion
- User-Generated Content (UGC) campaigns.

## 20. Automation Hooks
- Scripts to auto-deploy JSON configs from a Google Sheet.

## 21. Definition of Done
- Remote config injection pipeline defined.

## 22. Review Checklist
- [x] Founder
- [x] All 8 Agents

## 23. Decision History
- v1.0: Enforced System-over-Campaign architecture.

## 24. Traceability
- **Idea -> Requirement:** REQ-033
