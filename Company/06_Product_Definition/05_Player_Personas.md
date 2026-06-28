---
document_id: "06-005"
title: "Player Personas"
owner: "Behavioral Psychology Agent"
status: "Approved"
version: "1.0"
created: "2026-06-28"
updated: "2026-06-28"
phase: "Phase 4 — Product Definition Platform"
priority: "P1"
---

# 05. Player Personas

## 2. Purpose
To define the target audiences for Tiny World, ensuring features are built for specific, psychologically modeled user types rather than a generic "average player."

## 3. Vision
We do not build games for everyone. We build highly resonant experiences for specific psychological profiles (The Decorator, The Optimizer, The Collector).

## 4. Problem Statement
**Player Problem:** Games that try to appeal to everyone end up appealing deeply to no one, resulting in poor long-term retention.

## 5. Goals
- Define the 3 core player personas.
- Map motivations (`04-014`) to these personas.

## 6. Non Goals
- Building features for the "Competitive PvP" persona (this is anti-vision).

## 7. Dependencies
- `04-014: Player_Motivation.md`

## 8. Related Platforms
- HX Engine

## 9. Related Agents
- Behavioral Psychology Agent
- Game Designer Agent

## 10. Related Feature IDs
- `FEAT-DEC-01` (Decorating features for Persona A)

## 11. User Stories
- **As a Decorator Persona...** I want more color variants for furniture... **So that...** my house matches my specific aesthetic.

## 12. Acceptance Criteria
- [ ] Personas are grounded in Self-Determination Theory.

## 13. KPIs
- Player Segmentation distribution in analytics.

## 14. Analytics Events
- Persona tagging based on early gameplay choices (e.g., spending first $100 on seeds vs. furniture).

## 15. Unity Mapping
- N/A

## 16. Implementation Notes
Designers must justify which persona a feature serves during feature pitch.

## 17. Testing Strategy
- Playtesting with external users matched to these personas.

## 18. Risks
- Alienating one persona by heavily favoring another in updates.

## 19. Future Expansion
- Analyzing live data to discover emergent, unexpected personas.

## 20. Automation Hooks
- Analytics Agent assigning a `Persona_ID` user property in Firebase.

## 21. Definition of Done
- 3 Personas fully defined with motivations and pain points.

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
- v1.0: Personas established.

## 24. Traceability
- **Idea -> Feature:** Mapped in `User_Story_Registry.md`.
