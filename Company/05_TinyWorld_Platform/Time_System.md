---
document_id: "05-009"
title: "Time System"
owner: "Unity Architect Agent"
status: "Approved"
version: "1.0"
created: "2026-06-28"
updated: "2026-06-28"
phase: "Phase 3 — Tiny World Platform"
priority: "P0"
tags: [architecture, unity, time, clock]
related_documents: ["05-003: World_Simulation.md"]
related_agents: ["Unity Architect Agent", "Gameplay Programmer Agent"]
dependencies: []
---

# Time System

## 2. Purpose
To provide a centralized, configurable clock that governs the entire simulation, allowing in-game time to flow independently of real-world time, and supporting pausing, fast-forwarding, and offline catch-up.

## 3. Responsibilities
- Manage the conversion between Real Seconds and In-Game Minutes.
- Broadcast time-change events (Tick, HourPassed, DayPassed).
- Maintain the authoritative calendar (Day, Month, Year).

## 4. Dependencies
- Event System (`05-012`).

## 5. Reusable Interfaces
- `ITimeListener`: Allows objects to register for time events without polling.

## 6. Configuration Model
`TimeConfig.asset` defines:
- Seconds per In-Game Minute (e.g., 1 real second = 1 game minute).
- Minutes per Hour (usually 60).
- Hours per Day (usually 24).
- Days per Season/Month (e.g., 28 days).

## 7. Future Expansion
Supporting real-time sync (like Animal Crossing) simply by changing the `TimeConfig` ratio to 1:1.

## 8. Relationship with HX Platform
Time dictates pacing. A day that is too short creates "Anxiety" (rushing to finish chores). A day that is too long creates "Boredom." The Time System makes this easily tunable to achieve "Comfort."

## 9. Relationship with Agent OS
By relying on `TimeConfig`, AI agents can balance the game economy simply by tweaking data, without rewriting the core time math.

## 10. Unity Representation
- **MonoBehaviour:** A single `TimeManager` that updates a `DateTime` struct in its `Tick()` method.
- **Events:** Fires `GameEvent.TimeUpdated` via the Event Bus.

## 11. C# Architecture
- `TimeManager`
- `GameDateTime` (Custom struct to avoid Unity/C# DateTime overhead for custom calendars).

## 12. Data Model
- `GameDateTime` (Year, Season, Day, Hour, Minute).
- `TimeSaveData` (The exact timestamp when the game was last saved).

## 13. Unity Folder Mapping
`Assets/Scripts/Runtime/TinyWorldPlatform/Time/`

## 14. AI Implementation Plan
- **Responsible Agent:** Unity Architect Agent
- **Implementation Order:** 2.5 (Right after World Architecture)
- **Review Agent:** Code Review Agent
- **Expected Deliverables:** TimeManager, GameDateTime struct, Time progression logic.

## 15. Performance Considerations
- Do not fire a global event every in-game minute if it causes GC spikes. Fire minute events only to UI, and let simulation entities poll the time during their background tick.

## 16. Testing Strategy
- Unit tests verifying that leap years (if applicable) or month rollovers calculate correctly.
- Test fast-forwarding 5 years in a single frame.

## 17. Editor Tooling
- `Time Controller`: A debug window allowing the developer to pause time, set a specific hour, or fast-forward to test schedules and lighting.

## 18. AI Code Generation Notes
Do not use `System.DateTime` for the in-game calendar. Write a custom struct. `System.DateTime` brings unnecessary complexity and real-world Gregorian calendar rules that may conflict with a fantasy calendar (e.g., 28-day months).

## 19. Known Risks
- Floating point precision errors if total elapsed time is tracked as a single `float` over many in-game years. (Use `double` or track discrete integers for Days/Minutes).

## 20. Acceptance Criteria
- [ ] Time flows according to the ratio defined in `TimeConfig`.
- [ ] Events fire correctly on the hour and day boundaries.
- [ ] Time can be paused without stopping Unity's `Time.timeScale` (allowing UI animations to continue).

## 21. Validation Checklist
- [ ] Is the calendar math using a custom struct instead of `System.DateTime`?
- [ ] Can time be fast-forwarded safely?
