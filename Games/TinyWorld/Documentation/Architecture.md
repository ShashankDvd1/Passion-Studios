# Tiny World: Architecture Overview

## 1. Architectural Philosophy
In direct response to the **Tiny World Problem Statement**, the architecture is designed to fulfill two seemingly conflicting goals:
1. Ship a high-quality MVP within **30 days**.
2. Establish the **Wonder Forge Game OS**—a reusable, highly maintainable codebase for future titles.

To achieve this, the architecture strictly adheres to **AI-assisted Vibe Coding** principles: we do not over-engineer speculative features, but the systems we do build are fundamentally decoupled, mobile-optimized, and reusable.

## 2. The Engine Boundary
**Engine:** Unity (Universal Render Pipeline)
- **Rule of Separation:** Unity is treated strictly as a rendering engine and input provider. 
- **MonoBehaviours:** Limited to visual representation (e.g., animations, particle effects, UI binding) and the initial bootstrap sequence.
- **Core Logic:** All business logic, game state, economy, and saving are written in pure C# (.NET) completely independent of the `UnityEngine` lifecycle.

## 3. Core Pillars

### A. Manual Dependency Injection
We strictly forbid Singletons, Service Locators, `FindObjectOfType`, and `Resources.Load`. 
- **GameBootstrap:** A single MonoBehaviour that lives in the startup scene. It holds serialized references to Unity assets (like `GameConfig`) and passes them into the pure C# domain.
- **RuntimeInstaller:** The Composition Root. It manually constructs every core service (`SaveService`, `EventBus`, `AudioService`) and injects their dependencies via constructors.

### B. The Orchestrator Pattern
To avoid the massive performance overhead of thousands of Unity `Update()` calls, core systems implement custom interfaces (`IInitializable`, `IUpdatable`, `IDisposableService`).
- **GameRuntime:** Acts as the central brain. It caches all services into lists and manually ticks them. `GameBootstrap` drives the `GameRuntime.Tick()` from a single Unity `Update()` loop, ensuring maximum CPU cache coherency on mobile devices.

### C. Zero-Allocation Event-Driven Design
Systems must remain decoupled to support rapid MVP iterations. If the UI needs to know when a player gains Gold, it does not hold a reference to the Inventory system.
- **EventBus:** A struct-based, generic messaging system (`IEventBus`). By using `struct` constraints and C# generic dictionaries, publishing events creates **zero garbage allocation**, preventing GC spikes and frame drops on low-end Android devices.

### D. Asynchronous I/O
Mobile storage is notoriously slow. Any blocking operation will freeze the game.
- **SaveService:** Uses `System.Threading.Tasks` to offload file serialization (JSON) and disk writes to background threads, ensuring the UI remains perfectly responsive while saving progress.

### E. Data-Driven Configuration
To allow designers (or AI agents) to balance the game without recompiling code, all tuning data is externalized.
- **ConfigService:** Wraps a root `GameConfig` ScriptableObject. The bootstrapper injects the asset, and the C# systems query the `IConfigService`. This keeps magic numbers out of the code and prevents the need for dangerous `Resources.Load` calls.

## 4. MVP System Flow
1. Player launches the app on Android.
2. `GameBootstrap` loads in the initial scene.
3. `GameBootstrap` instantiates `GameRuntime` and passes in the Unity `GameConfig`.
4. `RuntimeInstaller` builds the `EventBus`, `SaveService`, `ConfigService`, and Managers.
5. `GameRuntime` asynchronously initializes all services (loading save files from disk).
6. `GameBootstrap` loads the `OutdoorsScene`.
7. Gameplay begins, driven entirely by the `GameRuntime.Tick()` loop and `IEventBus` messages.
