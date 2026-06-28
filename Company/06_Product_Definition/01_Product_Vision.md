---
document_id: "06-001"
title: "Product Vision"
owner: "Product Manager Agent"
status: "Approved"
version: "1.0"
created: "2026-06-28"
updated: "2026-06-28"
phase: "Phase 4 — Product Definition Platform"
priority: "P0"
---

# 01. Product Vision

## 2. Purpose
To define what Tiny World is and what it is not. This document prevents feature creep by providing a strict lens through which all future ideas must pass.

## 3. Vision
Tiny World is a living pocket world. Players do not complete levels; they build memories and relationships. Players return because they care about the world, not because they are forced by manipulative mechanics.

## 4. Problem Statement
**Player Problem:** Modern mobile games use dark patterns (FOMO, Paywalls) that cause anxiety and burnout. Players want a relaxing, persistent space that respects their time and intelligence.

## 5. Goals
- Create a digital space that feels like a "second home."
- Achieve industry-leading D30 retention through emotional attachment, not coercion.
- Establish the first commercial proof-of-concept for the Studio OS (HX Engine + Living World Platform).

## 6. Non Goals
- We are NOT building a competitive multiplayer game.
- We are NOT building an endless, procedurally generated roguelike.
- We are NOT building a hyper-casual disposable game.

## 7. Dependencies
- Studio OS Phase 1 (Agent OS)
- Studio OS Phase 2 (HX Engine)
- Studio OS Phase 3 (Living World Platform)

## 8. Related Platforms
- HX Platform: `04-001: HX_Principles`
- LWP: `05-001: Platform_Vision`

## 9. Related Agents
- Founder Agent (Vision Holder)
- Product Manager Agent (Execution)
- Human Experience Agent (Emotional Guardrail)

## 10. Related Feature IDs
- N/A (Vision level)

## 11. User Stories
- **As a player...** I want a relaxing game I can check on for 10 minutes a day... **So that...** I can decompress after work without feeling stressed.
- **Acceptance Criteria:** Session lengths are naturally capped gently.
- **Edge Cases:** Players trying to play for 8 hours straight.
- **Analytics Events:** `session_length`, `session_frequency`.

## 12. Acceptance Criteria
- [ ] The vision strictly forbids P2W and Lootboxes.
- [ ] The vision prioritizes emotion over mechanics.

## 13. KPIs
- Happy Retained Players (HRP)
- Session Health Index (SHI)

## 14. Analytics Events
- Core Funnel: `app_open` -> `tutorial_complete` -> `first_house_built`

## 15. Unity Mapping
- **Expected Scene:** `BootScene`, `MainWorldScene`
- **Required Prefabs:** N/A (Vision level)

## 16. Implementation Notes
This document is the filter. If an AI agent attempts to design a feature (e.g., a PvP arena), it must be rejected because it violates the "Non Goals."

## 17. Testing Strategy
- UX Playtesting focusing on "Relaxation" sentiment.

## 18. Risks
- Building a game that is *too* relaxing and becomes boring (lack of goals).

## 19. Future Expansion
- Tiny World transitioning into a shared co-op space.

## 20. Automation Hooks
- AI PR Reviewers will automatically reject PRs that introduce FOMO timers based on this document.

## 21. Definition of Done
- Vision is approved by Founder and distributed to all Agents.

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
- v1.0: Initial Vision established.

## 24. Traceability
- **Idea -> Requirement:** REQ-001
