---
document_id: "06-014"
title: "Resource Flow"
owner: "Economy Agent"
status: "Approved"
version: "1.1"
created: "2026-06-28"
updated: "2026-06-28"
phase: "Phase 4 — Product Definition Platform"
priority: "P1"
---

# 14. Resource Flow

## 2. Purpose
To map exactly how raw materials are converted into intermediate goods, and finally into end-products or currency.

## 3. Vision
Resource flow must feel logical and rewarding. Every resource must possess meaning and intent, rather than being meaningless clutter.

## 4. Problem Statement
**Player Problem:** Games with overly complex crafting trees (requiring 15 nested sub-components) cause cognitive overload and inventory fatigue.

## 5. Goals
- Limit crafting depth to a maximum of 3 tiers (Raw -> Refined -> Final).
- Define the 7 core properties of every resource.

## 6. Non Goals
- Factorio-level automation complexity (anti-cozy).

## 7. Dependencies
- `12_Economy.md`

## 8. Related Platforms
- LWP: `Object_System` (Crafting Stations)

## 9. Related Agents
- Economy Agent
- UX Agent

## 10. Related Feature IDs
- `FEAT-CRAFT-01` (Refinery Stations)

## 11. User Stories
- **As a player...** I want to know exactly what an item is used for when I pick it up.

## 12. Acceptance Criteria
- [ ] No crafting recipe exceeds 3 tiers of depth.
- [ ] Every resource defines its 7 properties.

## 13. KPIs
- % of refined goods crafted vs. raw materials sold directly.

## 14. Analytics Events
- `crafting_attempt`, `crafting_success`

## 15. Unity Mapping (Implementation Readiness)
- **ScriptableObjects:** `ResourceDefinition.asset`, `RecipeDefinition.asset`
- **Runtime Managers:** `CraftingManager`, `InventoryManager`
- **Systems Used:** `Inventory_System`
- **Save Data Impact:** `PlayerInventorySaveData`
- **Events Published:** `OnItemCrafted`, `OnResourceGathered`
- **Events Consumed:** `OnInteractionSuccess`
- **Addressables:** Resource icons, 3D meshes.
- **UI Screens:** `Crafting_Modal`, `Item_Tooltip`
- **Performance Notes:** Crafting validation must avoid heavy garbage collection (use cached lists).
- **AI Code Gen Notes:** `CraftingManager` is headless. It receives a `RecipeDefinition`, checks `InventoryManager`, subtracts inputs, adds outputs, and fires an event. It has no references to UI canvases.

## 16. Implementation Notes (Resource Philosophy)
Every single item defined in the game must answer:
1. **Purpose:** Why does this exist? (e.g., Used to craft basic tools).
2. **Source:** Where does it come from? (e.g., Chopping Oak Trees).
3. **Sink:** How is it permanently destroyed? (e.g., Consumed in the Furnace).
4. **Storage:** How does it stack? (e.g., Stacks to 99 in Silo).
5. **Scarcity:** How rare is it? (e.g., Common, high drop rate).
6. **Visibility:** How is it telegraphed to the player? (e.g., Sparkles in the overworld).
7. **Emotional Meaning:** How should the player feel getting it? (e.g., Comfort knowing they have enough wood for winter).

## 17. Testing Strategy
- Exploit testing: Attempt to craft an item, drop the materials from inventory on the same frame, and ensure the craft fails.

## 18. Risks
- Inventory clutter from too many unique intermediate resources.

## 19. Future Expansion
- Late-game automation (Sprinklers, Auto-crafters).

## 20. Automation Hooks
- Economy Agent validating that sell prices scale correctly.

## 21. Definition of Done
- Resource flow diagram mapped.

## 22. Review Checklist
- [x] Founder
- [x] All 8 Agents

## 23. Decision History
- v1.1: Applied 7-property resource philosophy.

## 24. Traceability
- **Requirement -> Unity:** Mapped in `Unity_System_Registry.md`.
