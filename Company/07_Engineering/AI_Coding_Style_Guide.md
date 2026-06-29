# AI Coding Style Guide

**Version:** 1.0
**Target Audience:** AI Developer Agents (Antigravity, etc.)

Every script written for **Wonder Forge Studios** must follow these strict rules.

## 1. Class Structure
- Must include standard `XML Documentation` (`<summary>`) above the class and public methods.
- Methods should be short (under 20-30 lines).
- No magic numbers. Use `const` or `SerializeField` fields at the top.
- No `TODO` comments without an immediate plan to fix them. Generate production-ready code.
- Prefix infrastructure logs with the system name (e.g., `[EventBus]`, `[Runtime]`).

## 2. Dependencies
- Never use `FindObjectOfType`.
- Never use `Singleton` (e.g., `Manager.Instance`).
- Never use `Resources.Load` (Use Addressables or direct references via ScriptableObjects).

## 3. Interfaces Over Implementations
- Do not reference concrete classes in gameplay code (e.g., don't use `SaveManager`, use `ISaveService`).

## 4. Mobile Performance (Zero-Allocation)
- Avoid LINQ (`.Where`, `.ToList()`) in `Update()` loops.
- Use `for` loops instead of `foreach` for Lists in `Tick()` loops to avoid enumerator allocations.
- Avoid boxing/unboxing. Use `structs` for events.

## Example: Perfect Class

```csharp
using UnityEngine;

namespace WonderForge.TinyWorld.Core.Example
{
    /// <summary>
    /// This is an example of a perfectly formatted class.
    /// </summary>
    public class ExampleService : IGameService
    {
        private const float MAX_HEALTH = 100f;

        /// <summary>
        /// Initializes the example service.
        /// </summary>
        public void Initialize()
        {
            GameLogger.Log("[Example] Initialized successfully.");
        }
    }
}
```
