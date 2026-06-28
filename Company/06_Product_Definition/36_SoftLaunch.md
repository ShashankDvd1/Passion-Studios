---
document_id: "06-036"
title: "Soft Launch Strategy"
owner: "Product Manager Agent"
status: "Approved"
version: "1.0"
created: "2026-06-28"
updated: "2026-06-28"
phase: "Phase 4 — Product Definition Platform"
priority: "P1"
---

# 36. Soft Launch Strategy

## 2. Purpose
To define the staggered rollout plan to gather real-world analytics, validate the Human Curiosity Framework (HCF), and test backend scalability before global release.

## 3. Vision
Soft Launch is not a marketing beat; it is a clinical trial. We test the behavior engine in isolation in low-CPI regions before scaling.

## 4. Problem Statement
**Player Problem:** Games that launch globally with broken progression or crashing backends burn their most valuable early adopters.

## 5. Goals
- Validate D1, D7, and D30 Retention against the Studio KPIs.
- Ensure the `BootManager` and `SocialManager` do not crash under load.

## 6. Non Goals
- Maximizing revenue during Soft Launch.

## 7. Dependencies
- `31_Analytics.md`

## 8. Related Platforms
- LWP

## 9. Related Agents
- Product Manager Agent
- Analytics Agent

## 10. Related Feature IDs
- N/A

## 11. User Stories
- **As a Developer...** I want 1,000 active daily users... **So that...** I have enough statistical significance to validate the FTUE completion rate.

## 12. Acceptance Criteria
- [ ] Tier 3 and Tier 2 countries are selected based on high Android market share and low CPI.
- [ ] A/B testing framework is active.

## 13. KPIs
- Target D1 Retention: > 40%
- Target D7 Retention: > 15%

## 14. Analytics Events
- N/A

## 15. Unity Mapping (Implementation Readiness)
- N/A

## 16. Implementation Notes
Phase 1: Technical Soft Launch (Philippines / Indonesia) - Focus on crashes and FTUE.
Phase 2: Retention Soft Launch (Nordics / Canada) - Focus on D7/D30 and monetization conversion.

## 17. Testing Strategy
- N/A

## 18. Risks
- YouTubers leaking the game early, spoiling the Global Launch.

## 19. Future Expansion
- N/A

## 20. Automation Hooks
- N/A

## 21. Definition of Done
- Soft Launch regions and KPI targets defined.

## 22. Review Checklist
- [x] Founder
- [x] All 8 Agents

## 23. Decision History
- v1.0: Established 2-phase soft launch.

## 24. Traceability
- **Idea -> Requirement:** REQ-036
