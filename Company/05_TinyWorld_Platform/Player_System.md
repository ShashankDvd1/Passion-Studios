---
document_id: "05-006"
title: "Player System"
owner: "Gameplay Programmer Agent"
status: "Approved"
version: "1.0"
created: "2026-06-28"
updated: "2026-06-28"
phase: "Phase 3 — Tiny World Platform"
priority: "P0"
tags: [architecture, unity, player, avatar, inventory]
related_documents: ["05-005: Interaction_System.md"]
related_agents: ["Gameplay Programmer Agent", "Game Designer Agent"]
dependencies: []
---

# Player System

## 2. Purpose
To define the central avatar of the player, managing their movement state, physical inventory, equipped tools, and personal progression data in a highly decoupled manner.

## 3. Responsibilities
- Manage the player's physical avatar (Movement, Animation State).
- Manage the player's logical state (Inventory, Energy/Stamina, Wallet).
- Act as the primary actor for the Interaction System.

## 4. Dependencies
- Interaction System (`05-005`).
- Unity Input System (New).

## 5. Reusable Interfaces
- `IActor`: Base interface for anything that can perform actions (shared with NPCs).
- `IInventoryContainer`: Interface for managing item stacks (shared with Chests).

## 6. Configuration Model
Player base stats (Max Energy, Movement Speed, Starting Inventory Size) are defined in `PlayerConfig.asset`.

## 7. Future Expansion
Support for local co-op (instantiating multiple Player Controllers) or networked multiplayer.

## 8. Relationship with HX Platform
The Player System directly manages "Energy" or "Stamina," which is a primary pacing mechanism related to the "Comfort" and "Progression" loops.

## 9. Relationship with Agent OS
Gameplay Programmer Agent will construct this system so that Game Designers can tweak movement feel (acceleration, jump height) purely via ScriptableObjects without code changes.

## 10. Unity Representation
- **MonoBehaviours:** `PlayerController` (movement physics), `PlayerAnimator` (visual state).
- **Data:** `PlayerState` (pure C# class handling inventory and stats, decoupled from MonoBehaviours).

## 11. C# Architecture
- `PlayerController`
- `InventoryManager`
- `WalletManager` (Handles currencies)
- `EquipmentManager` (Handles currently held tools/clothing)

## 12. Data Model
- `InventorySlot` (struct: ItemID, Amount)
- `PlayerSaveData` (Composite object containing position, inventory array, and currency dict).

## 13. Unity Folder Mapping
`Assets/Scripts/Runtime/TinyWorldPlatform/Player/`

## 14. AI Implementation Plan
- **Responsible Agent:** Gameplay Programmer Agent
- **Implementation Order:** 6
- **Review Agent:** Unity Architect Agent
- **Expected Deliverables:** Kinematic character controller, decoupled Inventory array, Input System bindings.

## 15. Performance Considerations
- Inventory lookups (e.g., "Does the player have 5 wood?") should use cached dictionary lookups or bitmasks if possible, as they will be queried constantly by UI and interaction systems.

## 16. Testing Strategy
- Inventory tests: Adding items beyond capacity, splitting stacks, merging stacks, boundary testing currencies (negative values).

## 17. Editor Tooling
- `Inventory Debugger`: A custom inspector to instantly add/remove items to the player's inventory during play mode for rapid testing.

## 18. AI Code Generation Notes
Strictly adhere to the Model-View-Controller (MVC) pattern. `PlayerSaveData` is the Model. `PlayerController` is the Controller. The UI and Avatar are the Views. Do not put inventory logic inside the movement script.

## 19. Known Risks
- Tightly coupling the camera logic to the player script, making it difficult to do cinematic camera pans or cutscenes. (Use Cinemachine instead).

## 20. Acceptance Criteria
- [ ] Player can move using standard inputs.
- [ ] Items can be added, removed, and stacked in the inventory.
- [ ] Player state cleanly serializes to JSON.

## 21. Validation Checklist
- [ ] Is inventory logic completely separated from Unity MonoBehaviours?
- [ ] Does the player implement `IActor` for interactions?
