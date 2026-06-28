---
document_id: "05-017"
title: "Offline System"
owner: "Backend Agent"
status: "Approved"
version: "1.0"
created: "2026-06-28"
updated: "2026-06-28"
phase: "Phase 3 — Tiny World Platform"
priority: "P0"
tags: [architecture, unity, offline, simulation, catch-up]
related_documents: ["05-003: World_Simulation.md", "05-009: Time_System.md"]
related_agents: ["Backend Agent", "Gameplay Programmer Agent"]
dependencies: ["05-003: World_Simulation.md"]
---

# Offline System

## 2. Purpose
To calculate and apply all world simulation changes that occurred while the player was not actively playing the game, ensuring the world feels persistent and alive.

## 3. Responsibilities
- Calculate the `TimeDelta` between the last save timestamp and the current login timestamp.
- Route the offline `TimeDelta` through the `SimulationManager`.
- Provide a summary of offline progress to the UI.

## 4. Dependencies
- Time System (`05-009`)
- Save System (`05-016`)
- World Simulation (`05-003`)

## 5. Reusable Interfaces
- `IOfflineSimulatable`: Entities that need to process large time jumps mathematically rather than step-by-step.

## 6. Configuration Model
`OfflineConfig.asset` defines constraints, such as `MaxOfflineSimulationDays` (e.g., cap catch-up math at 30 days to prevent math overflows or infinite resources if a player logs in after 5 years).

## 7. Future Expansion
Server-authoritative offline progress verification to prevent local time-skip cheating (if transitioning to a competitive/multiplayer model).

## 8. Relationship with HX Platform
Crucial for the "Habit Formation" (`04-012`) loop. The player expects their crops to be ready in the morning. If they aren't, the habit is broken and the player churns.

## 9. Relationship with Agent OS
The system must expose clear APIs so the UI Agent can easily fetch a structured list of "What happened while you were gone" to display to the player.

## 10. Unity Representation
- A lightweight controller that intercepts the boot sequence *before* the visual world is instantiated, applies the math, and then lets the world boot normally.

## 11. C# Architecture
- `OfflineManager`
- `OfflineCatchupRoutine` (Processes chunks of time).

## 12. Data Model
- `OfflineSummary` (A report struct containing yielded resources, grown entities, and expired events).

## 13. Unity Folder Mapping
`Assets/Scripts/Runtime/TinyWorldPlatform/Simulation/Offline/`

## 14. AI Implementation Plan
- **Responsible Agent:** Backend Agent
- **Implementation Order:** 16
- **Review Agent:** Unity Architect Agent
- **Expected Deliverables:** Timestamp comparison logic, chunked catch-up execution.

## 15. Performance Considerations
- **Chunking:** Never simulate a 30-day offline period in a single massive `for` loop that locks the main thread for 5 seconds. The catch-up math must either be instantaneous (algebraic) or chunked over several frames behind a loading screen.

## 16. Testing Strategy
- Time-skip testing: Load a save file, spoof the system clock forward by 1 week, and assert that crop growth stages map perfectly to a control state that was played for 1 week continuously.

## 17. Editor Tooling
- `Time Skipper`: A debug tool to simulate logging off and logging back in X hours later instantly.

## 18. AI Code Generation Notes
Prevent "Time-Travel Cheating" (players changing their OS clock). Compare the OS clock against a remote NTP server if an internet connection is available. If the OS clock is *behind* the last save timestamp, do not reverse the simulation; clamp the delta to 0.

## 19. Known Risks
- Math precision errors when applying extremely large deltas to float-based timers.

## 20. Acceptance Criteria
- [ ] Entities progress correctly based on elapsed real-world time between sessions.
- [ ] The simulation handles negative time deltas (time cheating) safely.
- [ ] Offline catch-up does not freeze the app on boot.

## 21. Validation Checklist
- [ ] Are we capping the maximum offline simulation time?
- [ ] Can the UI easily read a summary of what happened?
