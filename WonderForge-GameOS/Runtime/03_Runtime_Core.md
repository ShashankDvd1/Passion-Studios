---
document_id: "OS-B1-04"
title: "Runtime Core"
type: "System"
owner: "Unity Architect Agent"
dependencies: []
feature_ids: ["FEAT-OS-01"]
requirement_ids: ["REQ-OS-01"]
prs_target: 100
---

# Runtime Core

## 1. Purpose
The `Runtime Core` is the absolute foundation of the Game OS. It handles application lifecycle (Boot, Suspend, Resume, Quit) without any game-specific logic.

## 2. Public API
- `void Initialize()`
- `void OnAppSuspend()`
- `void OnAppResume()`

## 3. Unity Mapping
- **ScriptableObjects:** `BootConfig.asset`
- **Runtime Managers:** `BootManager`
- **Events:** `OnBootSequenceStarted`, `OnBootSequenceCompleted`

## 4. AI Implementation Notes
- **Responsible Agent:** Unity Architect Agent
- **Prompt Note:** Ensure `BootManager` uses `DontDestroyOnLoad` and acts as the entry point for Dependency Injection.
