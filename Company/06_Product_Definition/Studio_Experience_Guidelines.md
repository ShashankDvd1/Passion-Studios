---
document_id: "06-SEG"
title: "Studio Experience Guidelines (SEG)"
owner: "UX Agent"
status: "Approved"
version: "1.1"
created: "2026-06-28"
updated: "2026-06-28"
phase: "Phase 4 — Product Definition Platform"
priority: "P0"
---

# Studio Experience Guidelines (SEG)

## 2. Purpose
To establish the non-negotiable UX/UI and ethical design principles that sit above all individual systems. This is the UX constitution for every current and future game built on the Studio OS.

## 3. Vision
We do not use dark patterns. We respect the player's time, privacy, and physiological limits. The interface should feel invisible, acting as a frictionless bridge to the world.

## 4. Problem Statement
**Player Problem:** Many mobile games unintentionally become inconsistent, clunky, and predatory as more features are added over time.

## 5. Goals
- Enforce **Clarity First**.
- Guarantee **One-Hand Friendly** gameplay.
- Mandate **Accessibility by Default**.
- Enforce **Respectful Notifications** and **Privacy by Design**.
- Validate **Ethical Monetization**.

## 6. Non Goals
- Defining specific UI art assets.

## 7. Dependencies
- `01_Product_Vision.md`

## 8. Related Platforms
- HX Engine

## 9. Related Agents
- UX Agent
- Monetization Agent

## 10. Related Feature IDs
- N/A (Global Guidelines)

## 11. User Stories
- **As a player...** I want to be able to harvest crops with one hand while holding my coffee.

## 12. Acceptance Criteria
- [ ] All subsequent documents strictly adhere to these principles.
- [ ] Every UI interaction is validated against the Design Token Library.

## 13. KPIs
- Player Happiness Score.
- Crash-Free Sessions.

## 14. Analytics Events
- N/A

## 15. Unity Mapping (Implementation Readiness)
- N/A (Guiding philosophy document).

## 16. Implementation Notes (UX Constitution)
Every future game must inherit these standards:
1. **Interaction Principles:** UI should disappear. Maximum clarity, minimum friction. Progressive disclosure.
2. **Visual Feedback Standards:** Immediate feedback on every tap.
3. **Audio Feedback Standards:** Tactile sounds.
4. **Haptic Standards:** Optional but present for all critical tokens.
5. **Accessibility Principles:** Color blindness, large text, motion sensitivity, low-end devices, offline behavior evaluated for *every* feature.
6. **Animation Philosophy:** Snappy (0.15s open, 0.2s close).
7. **Reward Presentation:** Clear, anticipated, and surprising.
8. **Error Recovery:** Soft fails without crashing.
9. **Loading Experience:** Invisible or under 5 seconds.
10. **Emotional Design Standards:** Validate against `Delight`, `Curiosity`, `Progress`, `Surprise`, `Comfort`, `Celebration`, `Ownership`.
11. **Player Respect Principles:** No fake urgency.
12. **Monetization Ethics:** Players are never punished for not spending.

## 17. Testing Strategy
- UX Labs testing with players holding a physical object in their non-dominant hand.

## 18. Risks
- Drifting from these principles to hit short-term revenue KPIs.

## 19. Future Expansion
- Cross-platform controller standards.

## 20. Automation Hooks
- N/A

## 21. Definition of Done
- SEG approved by Founder.

## 22. Review Checklist
- [x] Founder
- [x] All 8 Agents

## 23. Decision History
- v1.1: Added 12 UX Constitution principles (Founder Directive 01).
- v1.0: Created to govern Batch 5.

## 24. Traceability
- **Idea -> Requirement:** REQ-SEG
