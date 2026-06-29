# Architecture Decision Records (ADR) Log

**Project:** Tiny World / Wonder Forge Game OS
**Purpose:** Documents *why* technical decisions were made so future AI agents and engineers understand the constraints.

---

## [ADR-001] Dependency Inversion & Manual Registration
**Date:** 2026-06-29
**Status:** Accepted

### Context
We need a way to manage core systems (Save, EventBus, Config) without tightly coupling gameplay code to infrastructure.

### Decision
We will use manual dependency injection via `RuntimeInstaller` and `GameRuntime`. We strictly forbid the use of the `Singleton` pattern (e.g., `Instance`), `FindObjectOfType`, and Reflection-based Service Locators (like Zenject). 

### Consequences
*   **Pros:** Forces strict interfaces (`IGameService`, `IUpdatable`), guarantees zero hidden dependencies, improves unit testability, avoids performance overhead of reflection.
*   **Cons:** Requires manual wiring in `RuntimeInstaller.cs` when new services are added.

---

## [ADR-002] Rendering Pipeline
**Date:** 2026-06-29
**Status:** Accepted

### Context
Tiny World is a mobile game for Android. Development is occurring on older PC hardware.

### Decision
We strictly use the **Universal Render Pipeline (URP)**. HDRP is explicitly forbidden as it is too heavy for the target hardware and deployment platform.

### Consequences
*   **Pros:** Performant on older dev PCs, runs beautifully on low-end Android devices, highly customizable.
*   **Cons:** Cannot use high-end HDRP-specific lighting/volumetric features (which aren't needed for this art style anyway).
