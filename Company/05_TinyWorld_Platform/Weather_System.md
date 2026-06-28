---
document_id: "05-010"
title: "Weather System"
owner: "Gameplay Programmer Agent"
status: "Approved"
version: "1.0"
created: "2026-06-28"
updated: "2026-06-28"
phase: "Phase 3 — Tiny World Platform"
priority: "P1"
tags: [architecture, unity, weather, environment]
related_documents: ["05-009: Time_System.md"]
related_agents: ["Gameplay Programmer Agent", "Art Director Agent"]
dependencies: ["05-009: Time_System.md"]
---

# Weather System

## 2. Purpose
To simulate dynamic atmospheric conditions (Sunny, Rain, Snow, Fog) that affect both the visual aesthetic of the world and the mechanical rules of the simulation.

## 3. Responsibilities
- Randomly or procedurally determine the weather forecast.
- Drive visual effects (VFX, Lighting, Post-Processing) based on current weather.
- Broadcast weather state to Simulation (e.g., crops get watered automatically if it rains).

## 4. Dependencies
- Time System (`05-009`).
- Event System (`05-012`).

## 5. Reusable Interfaces
- `IWeatherListener`: For objects that need to react immediately to weather changes.

## 6. Configuration Model
`WeatherDefinition.asset` defines:
- Visuals: Particle System prefab, Lighting color, Skybox material.
- Mechanics: `IsPrecipitation`, `CropGrowthMultiplier`, `FishSpawnOverrides`.

## 7. Future Expansion
Support for localized weather (e.g., raining in one biome, sunny in another) rather than global weather.

## 8. Relationship with HX Platform
Weather is a massive driver of the "Comfort" and "Delight" emotions. A sudden transition to a gentle rainstorm accompanied by relaxing audio is a core emotional pillar.

## 9. Relationship with Agent OS
By abstracting weather into definitions, the Audio Agent and Art Director Agent can update visual/audio assets without requiring the Gameplay Programmer Agent to rewrite the weather transitions.

## 10. Unity Representation
- **Manager:** `WeatherManager` listens to the Time System for day transitions.
- **Visuals:** A `WeatherController` script manages directional light interpolation, Volume post-processing transitions, and particle emission.

## 11. C# Architecture
- `WeatherManager`
- `WeatherDefinition` (ScriptableObject)
- `WeatherForecast` (Queue of upcoming weather)

## 12. Data Model
- `WeatherType` (Enum: Clear, Rain, Storm, Snow, etc.)
- `WeatherSaveData` (Current weather, next 3 days forecast).

## 13. Unity Folder Mapping
`Assets/Scripts/Runtime/TinyWorldPlatform/Environment/`

## 14. AI Implementation Plan
- **Responsible Agent:** Gameplay Programmer Agent
- **Implementation Order:** 9
- **Review Agent:** Art Director Agent
- **Expected Deliverables:** Forecast logic, smooth visual blending between weather states.

## 15. Performance Considerations
- **VFX Overdraw:** Rain/Snow particles must be heavily optimized to prevent mobile GPU bottlenecking due to transparency overdraw. Use GPU particles if feasible.

## 16. Testing Strategy
- Force-trigger every weather state via debug commands and verify that Lighting and Post-Processing successfully blend without snapping.

## 17. Editor Tooling
- `Weather Debugger`: A slider in the inspector to manually blend between weather states to tune lighting and colors.

## 18. AI Code Generation Notes
Ensure weather transitions use a `Coroutine` or `Lerp` over several seconds/minutes. Weather should never "snap" instantly unless explicitly required by a narrative event. The `WeatherManager` must fire an event when a transition *starts* and when it *completes*.

## 19. Known Risks
- Audio overlapping: Failing to fade out the 'Rain' audio track before fading in the 'Sunny' ambient track.

## 20. Acceptance Criteria
- [ ] Weather changes predictably based on the forecast.
- [ ] Visuals (Light, Post-Processing) blend smoothly between states.
- [ ] Mechanics (like crops) react to precipitation.

## 21. Validation Checklist
- [ ] Is the mechanical logic of weather separated from the visual rendering?
- [ ] Are weather probabilities configurable per Season?
