---
document_id: "06-035"
title: "Performance Targets"
owner: "Unity Architect Agent"
status: "Approved"
version: "1.0"
created: "2026-06-28"
updated: "2026-06-28"
phase: "Phase 4 — Product Definition Platform"
priority: "P0"
---

# 35. Performance Targets

## 2. Purpose
To define the strict technical boundaries that all systems, art assets, and code must adhere to in order to ensure a crash-free experience on minimum spec devices.

## 3. Vision
Smooth performance is a UX feature. Dropped frames destroy immersion. Battery drain destroys retention.

## 4. Problem Statement
**Player Problem:** Games that turn mobile phones into space heaters are uninstalled, regardless of how fun they are.

## 5. Goals
- Target 60 FPS on mid-tier devices (iPhone 11 / Galaxy S20 equivalents).
- Maintain battery temperature below thermal throttling limits.

## 6. Non Goals
- Supporting 10-year-old devices (Target: Last 5 years).

## 7. Dependencies
- All LWP Systems.

## 8. Related Platforms
- LWP

## 9. Related Agents
- Unity Architect Agent
- QA Agent

## 10. Related Feature IDs
- N/A (Global Standard)

## 11. User Stories
- **As a player...** I want my phone battery to last longer than 1 hour while playing... **So that...** I can play on my commute without a charger.

## 12. Acceptance Criteria
- [ ] No allocations (`new` keyword or Boxing) in `Update()` loops.
- [ ] Strict object pooling for all instantiated GameObjects.

## 13. KPIs
- Crash Rate (< 1%).
- ANR (Application Not Responding) Rate (< 0.5%).

## 14. Analytics Events
- `performance_warning`, `crash_report` (via Crashlytics).

## 15. Unity Mapping (Implementation Readiness)
- **ScriptableObjects:** `QualitySettingsConfig.asset`
- **Interfaces:** `IPoolable`.
- **Runtime Managers:** `PerformanceMonitor` (Headless).
- **Systems Used:** `Grid_System` (for culling).
- **Events Published:** `OnThermalWarning`, `OnMemoryWarning`.
- **Events Consumed:** OS Level Memory warnings.
- **UI Screens:** N/A.
- **Prefabs:** N/A.
- **Event Channels:** `GlobalPerformanceChannel`.
- **Save Data Impact:** N/A.
- **Localization Keys:** N/A.
- **Addressables:** Load assets synchronously *only* during the boot screen.
- **Editor Tooling:** `MemoryProfilerWindow`.
- **Automated Test Cases:** Run 100 days of simulation in fast-forward to detect memory leaks.
- **AI Code Gen Notes:** `PerformanceMonitor` checks `Application.targetFrameRate` and listens to `Application.lowMemory`. It triggers garbage collection aggressively during scene transitions to avoid GC spikes during gameplay.

## 16. Implementation Notes
Polygon Budget: < 150,000 tris per frame.
Draw Calls: < 100 batches per frame (Requires heavy GPU Instancing and UI Atlas packing).

## 17. Testing Strategy
- Profiler tracking of Garbage Collection (GC) allocations per frame (Target: 0B).

## 18. Risks
- Memory leaks from un-unsubscribed C# events. (Mitigation: Strict `OnDisable` cleanup policies).

## 19. Future Expansion
- 120 FPS mode for iPad Pro / High-end Android.

## 20. Automation Hooks
- N/A

## 21. Definition of Done
- Performance budgets defined.

## 22. Review Checklist
- [x] Founder
- [x] All 8 Agents

## 23. Decision History
- v1.0: Enforced 0B allocation policy in Update loops.

## 24. Traceability
- **Idea -> Requirement:** REQ-035
