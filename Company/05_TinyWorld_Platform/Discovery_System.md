---
document_id: "05-013"
title: "Discovery System"
owner: "Game Designer Agent"
status: "Approved"
version: "1.0"
created: "2026-06-28"
updated: "2026-06-28"
phase: "Phase 3 — Tiny World Platform"
priority: "P1"
tags: [architecture, unity, discovery, unlocks]
related_documents: ["04-006: Curiosity_System.md"]
related_agents: ["Game Designer Agent", "Gameplay Programmer Agent"]
dependencies: []
---

# Discovery System

## 2. Purpose
To track what the player has seen, interacted with, or unlocked, managing the "fog of war" for information and mechanics.

## 3. Responsibilities
- Track boolean states for first-time encounters (e.g., "Has Seen Iron Ore").
- Manage the unlocking of UI elements (e.g., hiding the crafting tab until the player discovers their first recipe).
- Fire events when new information is acquired to trigger UI Delight.

## 4. Dependencies
- Save System (`05-016`)

## 5. Reusable Interfaces
- `IDiscoverable`: An entity that can be registered in the Discovery System upon interaction.

## 6. Configuration Model
Discovery is inherently stateful. Definitions do not dictate discovery; the interaction with a Definition creates a state entry in the `DiscoveryManager`.

## 7. Future Expansion
Sharing discoveries with friends (e.g., "Your friend Bob discovered a new fish species").

## 8. Relationship with HX Platform
This is the mechanical backend for the "Curiosity System" (`04-006`). It ensures the player is not overwhelmed by information on Day 1 by progressively disclosing mechanics.

## 9. Relationship with Agent OS
Game Designer Agent relies on this system to create pacing. By gating content behind discovery flags rather than arbitrary levels, progression feels organic.

## 10. Unity Representation
- A centralized hash set of discovered string IDs.
- UI elements subscribe to `DiscoveryManager` to know when to unhide themselves.

## 11. C# Architecture
- `DiscoveryManager`
- `DiscoveryTracker` (Utility class attached to objects to ping the Manager upon interaction).

## 12. Data Model
- `DiscoverySaveData` (A serialized `List<string>` of discovered IDs).

## 13. Unity Folder Mapping
`Assets/Scripts/Runtime/TinyWorldPlatform/Progression/`

## 14. AI Implementation Plan
- **Responsible Agent:** Gameplay Programmer Agent
- **Implementation Order:** 12
- **Review Agent:** Unity Architect Agent
- **Expected Deliverables:** High-performance HashSet tracker, save serialization.

## 15. Performance Considerations
- String hashing: Checking if an item is discovered should use integer hashes (`Animator.StringToHash` equivalent) rather than doing string comparisons thousands of times a frame.

## 16. Testing Strategy
- Unit tests verifying that duplicate discovery attempts do not throw errors or duplicate save data.

## 17. Editor Tooling
- `Discovery Editor`: A debug tool to easily toggle specific discovery flags on/off during play mode to test different onboarding states.

## 18. AI Code Generation Notes
The `DiscoveryManager` should expose a method `bool HasDiscovered(int hashedId)`. It should use a `HashSet<int>` for O(1) lookups. When serializing to disk, convert the hashes back to human-readable strings if debugging is required, or keep them as ints for small save sizes.

## 19. Known Risks
- Changing an item's ID in development will orphan its discovery state in existing save files.

## 20. Acceptance Criteria
- [ ] Interacting with an `IDiscoverable` marks it as known.
- [ ] UI elements can listen for discovery events to unhide themselves.
- [ ] Lookups are O(1) and do not allocate GC.

## 21. Validation Checklist
- [ ] Are we using hashes instead of strings for runtime lookups?
- [ ] Does this system integrate smoothly with the Save System?
