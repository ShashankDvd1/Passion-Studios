# Systems Dictionary

This document serves as a quick reference for all active **Wonder Forge Game OS** systems currently implemented in the Tiny World project.

*Always check this document before building a new system to avoid duplicating infrastructure.*

---

## 1. GameRuntime (ENG-02)
*   **Location:** `Assets/Core/Runtime/GameRuntime.cs`
*   **Purpose:** The central orchestrator for all services. Replaces Singletons. Manages initialization, ticking (`Update`), and disposal of services.
*   **How to use:** Register your service in `RuntimeInstaller.cs`. Have your service implement `IGameService`, and optionally `IInitializable`, `IUpdatable`, or `IDisposableService`.

## 2. GameBootstrap (ENG-01)
*   **Location:** `Assets/Core/Bootstrap/GameBootstrap.cs`
*   **Purpose:** The single entry point in the initial Bootstrap scene. Initializes the `GameRuntime` and then loads the main menu.

## 3. GameLogger (ENG-01)
*   **Location:** `Assets/Core/Utilities/GameLogger.cs`
*   **Purpose:** Standardized logging wrapper. Use this instead of `Debug.Log` to ensure consistent formatting across the studio.

---
*(Note: To be updated as future milestones (EventBus, SaveSystem, ConfigManager) are completed).*
