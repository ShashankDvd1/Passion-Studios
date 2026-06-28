---
document_id: "05-020"
title: "Platform Extensibility"
owner: "Unity Architect Agent"
status: "Approved"
version: "1.0"
created: "2026-06-28"
updated: "2026-06-28"
phase: "Phase 3 — Tiny World Platform"
priority: "P0"
tags: [architecture, unity, extensibility, modularity]
related_documents: ["05-001: Platform_Vision.md"]
related_agents: ["Unity Architect Agent", "Founder Agent"]
dependencies: []
---

# Platform Extensibility

## 2. Purpose
To define the strict boundaries between the "Platform" (reusable code) and the "Game" (specific themes, e.g., Tiny Farm). This document is the ultimate guardrail against spaghetti code.

## 3. Responsibilities
- Define how a specific game project inherits from the Platform package.
- Establish rules for writing game-specific logic without modifying Platform source code.

## 4. Dependencies
- Unity Package Manager (UPM).

## 5. Reusable Interfaces
- Extensibility relies on Dependency Injection and Interface implementation (e.g., implementing a custom `IGameRules` interface for a specific game).

## 6. Configuration Model
The Platform is distributed as a local package (`com.wonderforge.tinyplatform`). Game projects import it and cannot edit its C# files directly.

## 7. Future Expansion
Releasing the Tiny World Platform as an open-source or licensed framework for other indie developers.

## 8. Relationship with HX Platform
Ensures that the emotional rules (HX) and mechanical rules (Platform) remain universally applicable across our entire portfolio of games over the next decade.

## 9. Relationship with Agent OS
Agents are strictly instructed: "Never modify a file in the `TinyWorldPlatform` folder to fix a bug in the `TinyFarm` project."

## 10. Unity Representation
- **Package Manager:** The platform is a separate Unity Package with its own `.asmdef` (Assembly Definition).
- **Game Project:** The actual game (e.g., Tiny Farm) has its own `.asmdef` that references the Platform assembly.

## 11. C# Architecture
- Strict enforcement of `internal` vs `public` access modifiers in the Platform assembly.

## 12. Data Model
- N/A.

## 13. Unity Folder Mapping
`Packages/com.wonderforge.tinyplatform/` vs `Assets/Scripts/Runtime/TinyFarm/`

## 14. AI Implementation Plan
- **Responsible Agent:** Unity Architect Agent
- **Implementation Order:** 20
- **Review Agent:** Founder Agent
- **Expected Deliverables:** Package structure setup, strict `.asmdef` boundaries.

## 15. Performance Considerations
- Assembly Definitions improve compilation time. If the Platform is a separate assembly, changing a script in the Game project does not force Unity to recompile the massive Platform logic.

## 16. Testing Strategy
- Attempt to create a dependency cycle (Game -> Platform -> Game) and verify that the `.asmdef` compiler strictly rejects it.

## 17. Editor Tooling
- Custom project templates for Unity Hub (e.g., "New Tiny World Project") that automatically include the local package and set up the folder structure.

## 18. AI Code Generation Notes
Use abstract classes or virtual methods for Platform systems that *must* be overridden by the Game project. Use the `sealed` keyword on Platform classes that should never be inherited from, protecting the architecture from rogue agent modifications.

## 19. Known Risks
- Tight coupling: A programmer gets lazy and hardcodes a reference to a "Tractor" inside the `ObjectManager`. (This ruins the platform for "Tiny Aquarium").

## 20. Acceptance Criteria
- [ ] The Platform can be exported as a `.tgz` Unity Package.
- [ ] A completely new game project can import the package and run the core simulation loop without any art assets.

## 21. Validation Checklist
- [ ] Are there absolutely zero references to specific themes (farming, magic, space) in the Platform code?
- [ ] Is the code isolated via Assembly Definitions?
