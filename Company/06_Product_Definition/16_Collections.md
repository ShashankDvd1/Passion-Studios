---
document_id: "06-016"
title: "Collections"
owner: "Product Manager Agent"
status: "Approved"
version: "1.1"
created: "2026-06-28"
updated: "2026-06-28"
phase: "Phase 4 — Product Definition Platform"
priority: "P0"
---

# 16. Collections

## 2. Purpose
To define the Compendium/Museum mechanics, providing a long-term progression layer that drives meta-retention and Discovery.

## 3. Vision
Collections are permanent, **headless** records of discovery. They fuel "Pride", "Curiosity", and "Memory." This is a **Platform-First** system, usable for Bug Catching in Tiny World or Recipe books in Tiny Cafe.

## 4. Problem Statement
**Player Problem:** When a game lacks a collection record, finding a rare item a second time feels identical to the first. Checklist grinding without narrative meaning causes burnout.

## 5. Goals
- Define the `DiscoveryState` logic.
- Ensure every collection tells a story and connects to the world's lore.

## 6. Non Goals
- Forcing players to collect things via timed exclusive events (FOMO).

## 7. Dependencies
- `11_Progression.md`

## 8. Related Platforms
- LWP: `Progression_System`

## 9. Related Agents
- Product Manager Agent
- Game Designer Agent

## 10. Related Feature IDs
- `FEAT-COL-01` (Global Compendium)

## 11. User Stories
- **As a Completionist persona...** I want a UI that shows silhouetted missing items... **So that...** I know exactly what I need to hunt for next.

## 12. Acceptance Criteria
- [ ] The Collection Manager uses a generic `<T>` interface.
- [ ] Data is driven by ScriptableObjects.

## 13. KPIs
- % of Compendium completed per user at D30.

## 14. Analytics Events
- `item_discovered_first_time`

## 15. Unity Mapping (Implementation Readiness)
- **ScriptableObjects:** `CollectionCategory.asset`, `CollectionEntry.asset` (Contains lore, hints, and ID).
- **Interfaces:** `ICollectable`.
- **Runtime Managers:** `CollectionManager` (Headless).
- **Systems Used:** `Save_System`
- **Events Published:** `OnNewItemDiscovered(ItemID)`.
- **Events Consumed:** `OnItemAddedToInventory`.
- **Save Data:** `HashSet<string> DiscoveredItemIDs`
- **Editor Tools:** `CollectionDataValidator` (Ensures no duplicate IDs in ScriptableObjects).
- **Validation Rules:** Validate that an item ID exists in the master database before adding to the HashSet.
- **Pooling Requirements:** None.
- **Performance Budget:** HashSet lookups must be O(1).
- **Mobile Constraints:** Minimal memory allocation.
- **AI Code Gen Notes:** `CollectionManager` listens to the headless `InventoryManager`. If an item isn't in its `HashSet`, it adds it and fires an event. The UI layer listens to this event to trigger `TKN-006: Collection Celebration`.

## 16. Implementation Notes (Collection Philosophy)
Collections must encourage Discovery and Mastery, not checklist grinding.
Every discovered item unlocks a "Memory" or piece of lore, elevating it from a simple database flag to an emotional reward.

## 17. Testing Strategy
- Unit test to ensure duplicate additions do not crash the HashSet.

## 18. Risks
- Adding thousands of items causing save file bloat (Mitigation: Store only strings/ints).

## 19. Future Expansion
- "Shiny/Variant" tracking.

## 20. Automation Hooks
- N/A

## 21. Definition of Done
- Headless `CollectionManager` logic defined.

## 22. Review Checklist
- [x] Founder
- [x] All 8 Agents

## 23. Decision History
- v1.1: Applied Founder Directives (Platform First, Data Driven, Philosophy).
- v1.0: Implemented generic Headless architecture.

## 24. Traceability
- **Idea -> Requirement:** REQ-016
- **Design Tokens:** `OnNewItemDiscovered` triggers `TKN-006: Collection Celebration`.
