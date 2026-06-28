---
document_id: "OS-B1-06"
title: "Save System"
type: "System"
owner: "Backend Agent"
dependencies: ["OS-B1-04", "OS-B1-05"]
feature_ids: ["FEAT-OS-03"]
requirement_ids: ["REQ-OS-03"]
prs_target: 100
---

# Save System

## 1. Purpose
A generic, robust serialization engine supporting local file saving and cloud synchronization.

## 2. Public API
- `void Save<T>(string key, T data)`
- `T Load<T>(string key)`
- `void Delete(string key)`

## 3. Unity Mapping
- **ScriptableObjects:** `SaveConfig.asset`
- **Runtime Managers:** `SaveManager`
- **Events:** `OnSaveStarted`, `OnSaveCompleted`, `OnSaveError`

## 4. AI Implementation Notes
- **Responsible Agent:** Backend Agent
- **Prompt Note:** Must support JSON serialization initially, with an interface `ISerializer` to allow binary or MessagePack upgrades later. Must handle corrupted files gracefully by keeping a `.bak` copy.
