---
document_id: "06-017"
title: "Customization"
owner: "Product Manager Agent"
status: "Approved"
version: "1.1"
created: "2026-06-28"
updated: "2026-06-28"
phase: "Phase 4 — Product Definition Platform"
priority: "P0"
---

# 17. Customization

## 2. Purpose
To define the systems that allow players to express their identity through Avatar clothing, House decorations, and Farm layout.

## 3. Vision
Customization is emotional ownership. It is the primary driver for attachment and the foundation of our cosmetic monetization strategy. This is a **Platform-First** system (Grid logic reusable for Tiny Cafe seating arrangements).

## 4. Problem Statement
**Player Problem:** Hardcoded housing grids limit creativity. If everyone's house looks exactly the same, no one feels ownership.

## 5. Goals
- Define a generic Placement System (Headless data grid).
- Answer the emotional "Why" for every customization feature.

## 6. Non Goals
- Creating physics-based object placement.

## 7. Dependencies
- `05-018: Customization_System (LWP)`

## 8. Related Platforms
- LWP: `Save_System`

## 9. Related Agents
- Product Manager Agent
- Unity Architect Agent

## 10. Related Feature IDs
- `FEAT-001` (Persistent Grid Placement)

## 11. User Stories
- **As a Decorator Persona...** I want to rotate furniture 360 degrees... **So that...** my house layout feels organic.

## 12. Acceptance Criteria
- [ ] Grid data is completely decoupled from rendering (Headless).
- [ ] Customization focuses on expressive identity, not numerical buffs.

## 13. KPIs
- Number of cosmetic items owned per player.

## 14. Analytics Events
- `furniture_placed`, `avatar_equipped`.

## 15. Unity Mapping (Implementation Readiness)
- **ScriptableObjects:** `FurnitureDefinition.asset`, `ClothingDefinition.asset`
- **Interfaces:** `IPlaceable`, `IEquippable`.
- **Runtime Managers:** `PlacementManager`, `WardrobeManager` (Headless).
- **Systems Used:** `Save_System`
- **Events Published:** `OnGridUpdated(CellCoords)`, `OnAvatarChanged`.
- **Events Consumed:** `OnPlacementConfirmedInput`.
- **Save Data:** `GridSaveData` (x,y,z, rotation, id), `EquipSaveData`.
- **Editor Tools:** `GridVisualizerEditor` (Draws gizmos to visualize the logical grid in the Scene View).
- **Validation Rules:** Prevent placing objects on occupied coordinates.
- **Pooling Requirements:** GPU Instancing for identical furniture.
- **Performance Budget:** Placement check < 1ms.
- **Mobile Constraints:** Strict polygon limits on furniture prefabs.
- **AI Code Gen Notes:** `PlacementManager` maintains an internal `Dictionary<Vector3Int, string>` representing the grid. When an item is placed, it updates the dictionary and fires `OnGridUpdated`. A separate `WorldRenderer` script listens to this event to instantiate the prefab. 

## 16. Implementation Notes (Customization Philosophy)
Every customization option should answer:
1. **Why does the player care?** (They want their farm to look unique to their friends).
2. **What emotion does it create?** (Pride, Belonging).
3. **How does it strengthen identity?** (Allows mimicking real-life aesthetics).
4. **How does it improve attachment?** (IKEA Effect: They built it, so they love it).

## 17. Testing Strategy
- Bot randomly placing and removing items to ensure grid collision logic doesn't corrupt.

## 18. Risks
- Massive amount of instantiated GameObjects tanking mobile performance.

## 19. Future Expansion
- Sharing house designs via invite codes.

## 20. Automation Hooks
- N/A

## 21. Definition of Done
- Headless grid architecture approved.

## 22. Review Checklist
- [x] Founder
- [x] All 8 Agents

## 23. Decision History
- v1.1: Applied Founder Directives (Platform First, Customization Philosophy).
- v1.0: Headless grid definition established.

## 24. Traceability
- **Idea -> Requirement:** REQ-017
- **Design Tokens:** `OnGridUpdated` triggers `TKN-007: Ownership Pulse`. `Previewing` triggers `TKN-008: Customization Preview`.
