---
document_id: "05-001"
title: "Platform Vision"
owner: "Founder Agent"
status: "Approved"
version: "1.0"
created: "2026-06-28"
updated: "2026-06-28"
phase: "Phase 3 — Tiny World Platform"
priority: "P0"
tags: [architecture, vision, platform, living-world]
related_documents: ["01-001: Company Vision", "04-001: HX_Principles.md"]
related_agents: ["All Agents"]
dependencies: []
---

# Platform Vision

## 2. Purpose
To define the immutable philosophy of the Tiny World Platform: we are building a reusable Living World simulation engine, not a disposable game. The world is the main character; it evolves, reacts, and persists independent of the player.

## 3. Responsibilities
- Establish the technical baseline for 80% code reusability across all future titles (Tiny Farm, Tiny Aquarium, etc.).
- Enforce the separation between core simulation logic and theme-specific content.

## 4. Dependencies
- Human Experience (HX) Engine (for emotional targets).
- Unity 6 (Target Engine).

## 5. Reusable Interfaces
- `ILivingWorld`: The highest-level contract for the platform.
- `IPlatformModule`: Base interface for all systems (Weather, Time, NPCs) to plug into the `ILivingWorld`.

## 6. Configuration Model
The platform is entirely data-driven. Rules (e.g., how fast time passes, what crops exist) are injected via ScriptableObjects, meaning a new game requires new data, not new C# systems.

## 7. Future Expansion
The architecture must support future transitions to multiplayer (authoritative server) or spatial computing (AR/VR) without rewriting the core simulation math.

## 8. Relationship with HX Platform
The Tiny World Platform provides the mechanical levers (weather, time, NPCs) that the HX Platform pulls to generate specific emotions (Wonder, Comfort, Delight).

## 9. Relationship with Agent OS
The Agent OS acts as the development team. The Tiny World Platform is designed specifically to be legible to AI agents (clear interfaces, strict SOLID principles) so agents can write code for it with minimal hallucination.

## 10. Unity Representation
- Core systems are implemented as `MonoBehaviour` singletons or static managers initialized via a `Bootstrapper` scene.
- Configuration relies heavily on `ScriptableObjects` injected via a Service Locator or Dependency Injection framework (e.g., VContainer).

## 11. C# Architecture
- `LivingWorldBootstrapper`: Initializes the platform.
- `PlatformConfig`: ScriptableObject holding global settings.
- `ServiceLocator`: Resolves dependencies for all modular systems.

## 12. Data Model
- `ProjectSettings/LivingWorldConfig.asset`
- Strict separation of `StateData` (mutable, saved to disk) and `DefinitionData` (immutable, stored in ScriptableObjects).

## 13. Unity Folder Mapping
`Assets/Scripts/Runtime/TinyWorldPlatform/Core/`

## 14. AI Implementation Plan
- **Responsible Agent:** Unity Architect Agent
- **Implementation Order:** 1 (Foundation)
- **Review Agent:** Founder Agent
- **Expected Deliverables:** Project folder structure, Service Locator pattern implementation, basic Bootstrapper.

## 15. Performance Considerations
- **CPU:** The core platform loop must consume < 5ms per frame on a mid-range mobile device (Snapdragon 845 equivalent).
- **Memory:** Strict separation of Definition Data (loaded via Addressables) and State Data to prevent RAM bloat.

## 16. Testing Strategy
- Unit tests verifying the Service Locator can register and resolve `IPlatformModule` instances.

## 17. Editor Tooling
- `Platform Dashboard`: A custom Unity Editor Window to view the status of all registered platform modules at runtime.

## 18. AI Code Generation Notes
When generating code for this, use strict Dependency Injection. Do not use `FindObjectOfType` or tight coupling. The architecture must be highly decoupled.

## 19. Known Risks
- Over-engineering: Building a platform so abstract that it becomes difficult to actually make a fun game with it.

## 20. Acceptance Criteria
- [ ] A new Unity project can be bootstrapped with the core platform in under 5 minutes.
- [ ] The platform can run headless (without visuals) to verify simulation math.

## 21. Validation Checklist
- [ ] Are the interfaces completely agnostic of "farming" or "aquariums"?
- [ ] Is the data strictly separated from the logic?
