---
document_id: "06-015"
title: "Inventory System"
owner: "Product Manager Agent"
status: "Approved"
version: "1.1"
created: "2026-06-28"
updated: "2026-06-28"
phase: "Phase 4 — Product Definition Platform"
priority: "P0"
---

# 15. Inventory System

## 2. Purpose
To define the data structure and interaction rules for how items are stored, stacked, and transferred.

## 3. Vision
The Inventory System is a **Platform-First** reusable architecture. It must be generic enough to power Tiny World, Tiny Farm, Tiny Cafe, and future games without rewriting the core `InventoryManager` logic.

## 4. Problem Statement
**Player Problem:** Clunky inventory management is the #1 friction point. If the underlying data structure is tightly coupled to the UI, bugs like item duplication are inevitable.

## 5. Goals
- Define a scalable, **Headless** inventory architecture.
- Support infinite generic containers (Backpack, Chest, Silo, Mailbox).
- Ensure the system is **Data-Driven** (driven by ScriptableObjects, not hardcoded).

## 6. Non Goals
- Designing the visual layout of the backpack UI (Handled in `28_UI_UX.md`).

## 7. Dependencies
- `14_Resource_Flow.md` (What goes into the inventory).

## 8. Related Platforms
- LWP: `Save_System`, `Object_System`.

## 9. Related Agents
- Unity Architect Agent
- QA Agent (Exploit testing)

## 10. Related Feature IDs
- `FEAT-INV-01` (Core Backpack)

## 11. User Stories
- **As a player...** I want my items to auto-stack when I pick them up.

## 12. Acceptance Criteria
- [ ] System is 100% decoupled from `UnityEngine.UI` and `UnityEngine.Canvas`.
- [ ] Every item defines the 10 Inventory Principles (Identity, Category, Rarity, Origin, Purpose, Stack Rules, Ownership Rules, Save Rules, Analytics Events, Future Upgrade Path).

## 13. KPIs
- Defect density in inventory code (Target: 0 critical dupes).

## 14. Analytics Events
- `item_looted`, `item_destroyed`

## 15. Unity Mapping (Implementation Readiness)
- **ScriptableObjects:** `ItemDefinition.asset` (Configures all item properties).
- **Interfaces:** `IInventoryContainer`, `IItemTransferable`.
- **Runtime Managers:** `InventoryManager` (Headless logic owner).
- **Systems Used:** `Save_System`
- **Events Published:** `OnInventoryChanged(ContainerID)`, `OnItemAdded(ItemID, Amount)`.
- **Events Consumed:** `OnInteractionSuccess(LootableObject)`.
- **Save Data:** `List<ContainerSaveData>` (Serializable pure C# classes).
- **Editor Tools:** `InventoryDebuggerWindow` (View/Edit inventory states during play mode without UI).
- **Validation Rules:** Validate stack limits before accepting additions.
- **Pooling Requirements:** None for logic, `InventorySlot` UI prefabs must be pooled.
- **Performance Budget:** Transfer operations must execute in < 1ms.
- **Mobile Constraints:** Keep memory footprint low by avoiding struct boxing during iteration.
- **AI Code Gen Notes:** `InventoryManager` must use standard C# events. `InventoryUI` subscribes to these events to instantiate slot prefabs.

## 16. Implementation Notes (Inventory Principles)
Inventory represents player ownership, not just a "bag." Every item is a data object with:
1. **Identity:** Unique ID string.
2. **Category:** E.g., Material, Tool, Cosmetic.
3. **Rarity:** Common to Legendary.
4. **Origin:** Where it was found (useful for analytics/debugging).
5. **Purpose:** Consumable, Crafting, Sellable.
6. **Stack Rules:** Max count per slot.
7. **Ownership Rules:** Can it be dropped? Traded?
8. **Save Rules:** Does it persist?
9. **Analytics Events:** Which funnel does it trigger?
10. **Future Upgrade Path:** Is there a higher tier?

## 17. Testing Strategy
- AI unit tests bypassing Unity completely (pure C# logic tests for splits/merges).

## 18. Risks
- Race conditions during rapid transfer between open chests causing item duplication.

## 19. Future Expansion
- Shared multiplayer chests.

## 20. Automation Hooks
- N/A

## 21. Definition of Done
- Headless architecture and principles verified.

## 22. Review Checklist
- [x] Founder
- [x] All 8 Agents

## 23. Decision History
- v1.1: Applied Founder Directives (Platform First, Data Driven, Principles).
- v1.0: Implemented Headless Golden Rule.

## 24. Traceability
- **Idea -> Requirement:** REQ-015
- **Design Tokens:** `OnItemAdded` triggers `TKN-004: Inventory Add`. Upgrade triggers `TKN-005: Inventory Upgrade`.
