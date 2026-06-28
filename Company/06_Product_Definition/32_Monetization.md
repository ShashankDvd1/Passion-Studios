---
document_id: "06-032"
title: "Monetization"
owner: "Monetization Agent"
status: "Approved"
version: "1.1"
created: "2026-06-28"
updated: "2026-06-28"
phase: "Phase 4 — Product Definition Platform"
priority: "P0"
---

# 32. Monetization

## 2. Purpose
To define how Tiny World generates revenue while strictly adhering to the Studio Experience Guidelines.

## 3. Vision
Revenue supports development. Players are never punished for not spending. Player trust is a long-term business asset.

## 4. Problem Statement
**Player Problem:** "I love this game, but it's forcing me to pay $5 to finish this building, otherwise I wait 2 days."

## 5. Goals
- Cosmetic-first.
- Rewarded Ads first.
- Convenience second.
- Season Pass & Fair Bundles.

## 6. Non Goals
- Pay-to-Win.
- Deceptive timers.
- Artificial frustration.
- Misleading pricing.
- Lootboxes (Gacha).

## 7. Dependencies
- `Studio_Experience_Guidelines.md`

## 8. Related Platforms
- LWP: `Inventory_System`

## 9. Related Agents
- Monetization Agent
- Economy Agent

## 10. Related Feature IDs
- `FEAT-MON-01` (Premium Shop)

## 11. User Stories
- **As a player...** I want to know exactly what I am buying.

## 12. Acceptance Criteria
- [ ] No mechanics rely on randomized paid rewards.
- [ ] No timers that halt all gameplay progress exist.

## 13. KPIs
- ARPDAU.

## 14. Analytics Events
- `iap_purchase_attempt`, `iap_purchase_success`.

## 15. Unity Mapping (Implementation Readiness)
- **ScriptableObjects:** `StoreCatalog.asset`, `IAPProduct.asset`
- **Interfaces:** `IPurchaseValidator`.
- **Runtime Managers:** `StoreManager`, `IAPManager` (Headless).
- **Systems Used:** `Save_System`
- **Events Published:** `OnPurchaseSuccessful(ProductID)`.
- **Events Consumed:** `OnPurchaseButtonClicked`.
- **UI Screens:** `Premium_Store_UI`
- **Prefabs:** N/A.
- **Event Channels:** `GlobalMonetizationChannel`
- **Save Data Impact:** `WalletSaveData`.
- **Localization Keys:** `IAP_DESC_{ID}`
- **Remote Config Support:** Yes (for Store Bundles and Sales).
- **Addressables:** Store Banners.
- **Editor Tooling:** `IAPMockSimulator`.
- **Automated Test Cases:** Server-side receipt checking.
- **AI Code Gen Notes:** `IAPManager` must integrate with Unity IAP asynchronously.

## 16. Implementation Notes
Monetization focuses on "Expression" (cosmetics) and "Convenience" (skipping non-blocking tasks).

## 17. Testing Strategy
- QA Sandbox accounts verifying purchases.

## 18. Risks
- Receipt validation failures.

## 19. Future Expansion
- Creator Codes.

## 20. Automation Hooks
- N/A

## 21. Definition of Done
- Ethical monetization catalog defined.

## 22. Review Checklist
- [x] Founder
- [x] All 8 Agents

## 23. Decision History
- v1.1: Applied Ethical Monetization principles.
- v1.0: Enforced Ethical Monetization (No Lootboxes).

## 24. Traceability
- **Idea -> Requirement:** REQ-032
