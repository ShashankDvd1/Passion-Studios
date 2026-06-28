---
document_id: "OS-B1-11"
title: "Debug Tools"
type: "System"
owner: "QA Agent"
dependencies: ["OS-B1-10"]
feature_ids: ["FEAT-OS-08"]
requirement_ids: ["REQ-OS-08"]
prs_target: 95
---

# Debug Tools

## 1. Purpose
To provide on-device testing capabilities (console, cheat menu, time manipulation) for QA and developers without requiring a Unity Editor connection.

## 2. Public API
- `void ShowDebugMenu()`
- `void RegisterCheat(string command, Action callback)`

## 3. Unity Mapping
- **ScriptableObjects:** N/A
- **Runtime Managers:** `DebugConsoleManager`
- **Events:** `OnDebugMenuToggled`

## 4. AI Implementation Notes
- **Responsible Agent:** QA Agent
- **Prompt Note:** Create a prefab that can be summoned via a multi-finger tap or swipe gesture (e.g., 4-finger tap). Exclude the prefab entirely from Release builds via assembly definitions or build scripts.
