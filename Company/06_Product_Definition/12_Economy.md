---
document_id: "06-012"
title: "Economy"
owner: "Economy Agent"
status: "Approved"
version: "1.0"
created: "2026-06-28"
updated: "2026-06-28"
phase: "Phase 4 — Product Definition Platform"
priority: "P0"
---

# 12. Economy

## 2. Purpose
To define the macro-economic structure of Tiny World. The economy governs how value (time, resources, currency) moves through the game, acting as the structural foundation for the Meta Loop.

## 3. Vision
Coins are a byproduct of living in the world, not the primary motivation (Founder Directive 05). The economy must feel generous, not punitive. Inflation is expected and embraced in the late game.

## 4. Problem Statement
**Player Problem:** Games that maintain artificial scarcity indefinitely feel like second jobs. Players want to eventually reach "post-scarcity" where they can focus purely on creativity.

## 5. Goals
- Define the Sink (where value is destroyed) and Source (where value is created) balance.
- Ensure early game is tight (scarcity) and late game is loose (abundance).

## 6. Non Goals
- Creating a perfectly balanced, zero-inflation MMO economy (unnecessary for a single-player/co-op game).

## 7. Dependencies
- `09_Meta_Gameplay_Loop.md`

## 8. Related Platforms
- LWP: `Inventory_System`

## 9. Related Agents
- Economy Agent
- Game Designer Agent

## 10. Related Feature IDs
- `FEAT-ECON-01` (Soft Currency)
- `FEAT-ECON-02` (Resource Sinks)

## 11. User Stories
- **As a veteran player...** I want to have excess wealth... **So that...** I can buy cosmetic items without worrying about basic survival costs.
- **Analytics Events:** `purchase_cosmetic`

## 12. Acceptance Criteria
- [ ] Economy math proves a transition from scarcity to abundance around Day 30.

## 13. KPIs
- Average Wallet Balance per cohort.
- Sink/Source ratio.

## 14. Analytics Events
- `currency_earned` (Payload: source, amount)
- `currency_spent` (Payload: sink, amount)

## 15. Unity Mapping
- **Managers:** `WalletManager` (LWP `Player_System`).
- **Save Data:** `WalletSaveData`.
- **AI Code Gen Notes:** `WalletManager` must use `double` or `long` for currency to prevent integer overflow when late-game players accumulate billions of coins.

## 16. Implementation Notes
The Economy Agent will use Monte Carlo simulations to ensure the D7 upgrade doesn't cost more than a player can reasonably earn in 7 days of normal play.

## 17. Testing Strategy
- Automated unit tests running 100 simulated "days" of gathering to plot the wealth accumulation curve.

## 18. Risks
- Hyper-inflation happens too early, rendering all rewards meaningless on Day 10.

## 19. Future Expansion
- Implementing a "Premium" cosmetic currency (handled in `32_Monetization`).

## 20. Automation Hooks
- Economy Agent spreadsheet sync (pulling balance values directly from Google Sheets into Unity).

## 21. Definition of Done
- Macro-economy spreadsheet linked and approved.

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
- v1.0: Economy defined as transitionary (Scarcity -> Abundance).

## 24. Traceability
- **Idea -> Feature:** Mapped in `Feature_Registry`.
