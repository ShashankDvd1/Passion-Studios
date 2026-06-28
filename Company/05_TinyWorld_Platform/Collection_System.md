---
document_id: "05-014"
title: "Collection System"
owner: "Game Designer Agent"
status: "Approved"
version: "1.0"
created: "2026-06-28"
updated: "2026-06-28"
phase: "Phase 3 — Tiny World Platform"
priority: "P1"
tags: [architecture, unity, collections, compendium]
related_documents: ["04-011: Collection_System.md (HX)"]
related_agents: ["Game Designer Agent", "Gameplay Programmer Agent"]
dependencies: ["05-013: Discovery_System.md"]
---

# Collection System

## 2. Purpose
To track long-term set completion and meta-goals, providing the mechanical backend for compendiums, museums, and sticker books.

## 3. Responsibilities
- Define logical groupings of items (Sets).
- Track which items within a Set the player has acquired.
- Distribute rewards when a Set is completed.

## 4. Dependencies
- Discovery System (`05-013`)
- Player System (Inventory) (`05-006`)

## 5. Reusable Interfaces
- `ICollectible`: Added to item definitions that belong in a collection book.

## 6. Configuration Model
`CollectionSetDefinition.asset` defines:
- The IDs required to complete the set.
- The reward (items, currency, or cosmetic unlocks) granted upon completion.

## 7. Future Expansion
Global community collections where millions of players contribute to a single massive set.

## 8. Relationship with HX Platform
The mechanical execution of the "Collection System" (`04-011`), driving the Zeigarnik effect and long-term D90 retention.

## 9. Relationship with Agent OS
Game Designer Agent creates the JSON/ScriptableObjects that define what items belong to what sets, requiring zero programmer intervention.

## 10. Unity Representation
- **Manager:** `CollectionManager` listens to inventory and discovery events to update Set progress.
- **UI:** Reads data from `CollectionManager` to draw the Compendium visually.

## 11. C# Architecture
- `CollectionManager`
- `CollectionSetDefinition`

## 12. Data Model
- `CollectionSaveData` (Tracks claimed rewards and completed sets).

## 13. Unity Folder Mapping
`Assets/Scripts/Runtime/TinyWorldPlatform/Progression/`

## 14. AI Implementation Plan
- **Responsible Agent:** Gameplay Programmer Agent
- **Implementation Order:** 13
- **Review Agent:** Game Designer Agent
- **Expected Deliverables:** Set validation logic, reward distribution logic.

## 15. Performance Considerations
- Do not check every collection set on every frame. The `CollectionManager` should only evaluate progress when an `ItemAddedToInventory` or `ItemDiscovered` event is fired.

## 16. Testing Strategy
- Test completing a set and verify the reward is granted exactly once.
- Test edge case: adding the final item to a set when the player's inventory is full (reward distribution must handle this gracefully, perhaps sending it to a mailbox).

## 17. Editor Tooling
- `Collection Validator`: A script that scans all `CollectionSetDefinition` assets to ensure no invalid or missing item IDs are referenced.

## 18. AI Code Generation Notes
Use an event-driven architecture. The CollectionManager subscribes to the Event Bus. When it receives a trigger, it checks the delta. Ensure claimed rewards are tracked in a `HashSet` to prevent duplicate claiming exploits.

## 19. Known Risks
- Referencing deleted item IDs in a collection set, causing runtime null reference exceptions.

## 20. Acceptance Criteria
- [ ] Sets can be defined entirely via ScriptableObjects.
- [ ] Completing a set grants the specified reward.
- [ ] Progress is accurately saved and restored.

## 21. Validation Checklist
- [ ] Is progress evaluation event-driven rather than polled?
- [ ] Is there protection against claiming the same set reward twice?
