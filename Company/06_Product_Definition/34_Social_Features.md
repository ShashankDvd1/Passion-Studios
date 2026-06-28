---
document_id: "06-034"
title: "Social Features"
owner: "Product Manager Agent"
status: "Approved"
version: "1.0"
created: "2026-06-28"
updated: "2026-06-28"
phase: "Phase 4 — Product Definition Platform"
priority: "P1"
---

# 34. Social Features

## 2. Purpose
To define the asynchronous and synchronous systems that connect players to one another, driving long-term retention through social obligation and "Pride."

## 3. Vision
Tiny World is inherently cozy. Social features should focus on cooperation, gifting, and visiting, not toxic PVP or resource stealing. 

## 4. Problem Statement
**Player Problem:** Single-player simulation games become lonely after Month 3, causing players to leave for games where they can play with friends.

## 5. Goals
- Implement asynchronous visiting (visiting a friend's offline farm).
- Implement a simple daily gifting system.

## 6. Non Goals
- Real-time MMO combat or synchronous physics synchronization.

## 7. Dependencies
- `17_Customization.md` (What players look at when visiting).

## 8. Related Platforms
- LWP: `Save_System` (Cloud saves required).

## 9. Related Agents
- Product Manager Agent
- Behavioral Psychology Agent

## 10. Related Feature IDs
- `FEAT-SOC-01` (Friend List)
- `FEAT-SOC-02` (Asynchronous Visiting)

## 11. User Stories
- **As a player...** I want to see how my friend decorated their house... **So that...** I can get inspiration and feel proud of my own house.

## 12. Acceptance Criteria
- [ ] Players can send and receive 1 gift per friend, per day.
- [ ] Visiting loads a static snapshot of the friend's farm (no real-time sync required).

## 13. KPIs
- Average friends per user.
- Gifts sent per DAU.

## 14. Analytics Events
- `friend_added`, `gift_sent`, `farm_visited`.

## 15. Unity Mapping (Implementation Readiness)
- **ScriptableObjects:** `SocialConfig.asset`
- **Interfaces:** `INetworkService`.
- **Runtime Managers:** `SocialManager` (Headless).
- **Systems Used:** `Save_System`
- **Events Published:** `OnFriendAdded`, `OnGiftReceived`.
- **Events Consumed:** `OnSocialActionClicked`.
- **UI Screens:** `Friends_List_UI`, `Mailbox_UI`.
- **Prefabs:** `Friend_Avatar_Ghost`.
- **Event Channels:** `GlobalSocialChannel`.
- **Save Data Impact:** `SocialSaveData` (Friend IDs, LastGiftSentTimestamps).
- **Localization Keys:** `UI_FRIEND_INVITE`
- **Addressables:** N/A.
- **Editor Tooling:** `MockNetworkClient` (Fakes sending/receiving network calls).
- **Automated Test Cases:** Prevent sending multiple gifts to the same friend in 24 hours.
- **AI Code Gen Notes:** `SocialManager` handles REST API calls to a backend service (e.g., PlayFab or Firebase) to fetch friend snapshots.

## 16. Implementation Notes
Trigger `TKN-006: Collection Celebration` (Joyful sound) when receiving a gift from a friend.

## 17. Testing Strategy
- Load testing the backend with 10,000 simulated gift requests per second.

## 18. Risks
- Backend costs spiraling out of control if social requests aren't batched.

## 19. Future Expansion
- Neighborhoods (Clans) and cooperative community events.

## 20. Automation Hooks
- N/A

## 21. Definition of Done
- Asynchronous social logic defined.

## 22. Review Checklist
- [x] Founder
- [x] All 8 Agents

## 23. Decision History
- v1.0: Chose asynchronous visits over synchronous multiplayer to reduce MVP scope.

## 24. Traceability
- **Idea -> Requirement:** REQ-034
