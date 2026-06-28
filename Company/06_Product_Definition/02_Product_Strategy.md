---
document_id: "06-002"
title: "Product Strategy"
owner: "Product Manager Agent"
status: "Approved"
version: "1.0"
created: "2026-06-28"
updated: "2026-06-28"
phase: "Phase 4 — Product Definition Platform"
priority: "P0"
---

# 02. Product Strategy

## 2. Purpose
To define the Go-To-Market strategy, monetization philosophy, and live-ops lifecycle of Tiny World to ensure financial viability without compromising the Product Vision.

## 3. Vision
Tiny World will become a top-grossing casual simulation game by maximizing LTV (Lifetime Value) through extreme long-term retention rather than aggressive short-term monetization.

## 4. Problem Statement
**Business Problem:** Traditional F2P games burn through users fast, requiring high UA (User Acquisition) spend. We need a game where players stick around for years, lowering blended CPI (Cost Per Install) via organic word-of-mouth.

## 5. Goals
- Achieve D1: 45%, D7: 20%, D30: 10% retention metrics.
- Achieve an ARPDAU of $0.15 via cosmetics and convenience, zero P2W.
- Build a community-driven organic growth funnel.

## 6. Non Goals
- High ARPDAU at the expense of retention.
- Ad-driven monetization (No forced video ads).

## 7. Dependencies
- Product Vision (`06-001`)

## 8. Related Platforms
- HX Engine (Monetization Ethics)

## 9. Related Agents
- Monetization Agent
- Product Manager Agent
- Marketing Agent

## 10. Related Feature IDs
- `FEAT-MON-01` (Premium Currency)
- `FEAT-MON-02` (Cosmetic Shop)

## 11. User Stories
- **As a player...** I want to buy unique decorations... **So that...** I can show them off to my friends, supporting the developers in the process.

## 12. Acceptance Criteria
- [ ] Strategy relies on organic growth and community building.
- [ ] Monetization is strictly cosmetic/convenience.

## 13. KPIs
- LTV / CAC ratio > 3.0
- Organic vs Paid install ratio > 50%.

## 14. Analytics Events
- `iap_purchase_attempt`
- `iap_purchase_success`

## 15. Unity Mapping
- **Expected Scene:** N/A (Strategy level)

## 16. Implementation Notes
Marketing Agent should focus on cozy gaming communities on TikTok and Reddit.

## 17. Testing Strategy
- A/B testing store fronts for highest conversion without dark patterns.

## 18. Risks
- Cosmetic-only monetization may not yield enough revenue if the player base is too small.

## 19. Future Expansion
- Brand partnerships (e.g., Sanrio themed cosmetic packs).

## 20. Automation Hooks
- Scripts to calculate daily LTV/CAC via AppsFlyer/Firebase APIs.

## 21. Definition of Done
- Strategy approved by Founder.

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
- v1.0: Cosmetic-only monetization strategy approved.

## 24. Traceability
- **Idea -> Requirement:** REQ-002
