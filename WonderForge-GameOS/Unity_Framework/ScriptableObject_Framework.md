---
document_id: "OS-B1-09"
title: "ScriptableObject Framework"
type: "System"
owner: "Unity Architect Agent"
dependencies: ["OS-B1-04"]
feature_ids: ["FEAT-OS-06"]
requirement_ids: ["REQ-OS-06"]
prs_target: 100
---

# ScriptableObject Framework

## 1. Purpose
To standardize the creation, referencing, and serialization of game data using Unity `ScriptableObjects`, enforcing the "Data-Driven" Game OS principle.

## 2. Public API
- `T GetAsset<T>(string id)`
- `void LoadAddressableAssets(string label, Action onComplete)`

## 3. Unity Mapping
- **ScriptableObjects:** `BaseDatabase.asset`
- **Runtime Managers:** `AssetManager`
- **Events:** `OnAssetsLoaded`

## 4. AI Implementation Notes
- **Responsible Agent:** Unity Architect Agent
- **Prompt Note:** Ensure all `ScriptableObjects` inherit from a `BaseDefinition` class that requires a unique string ID for save/load mappings. Use Addressables API instead of direct references for anything larger than a few KBs.
