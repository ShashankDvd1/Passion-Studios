---
document_id: "OS-B1-07"
title: "Configuration Framework"
type: "System"
owner: "Product Manager Agent"
dependencies: ["OS-B1-04", "OS-B1-06"]
feature_ids: ["FEAT-OS-04"]
requirement_ids: ["REQ-OS-04"]
prs_target: 95
---

# Configuration Framework

## 1. Purpose
To handle the loading, caching, and querying of remote and local configuration JSON files for LiveOps and A/B Testing.

## 2. Public API
- `T GetConfig<T>(string configID)`
- `void FetchRemoteConfigs(Action onComplete)`

## 3. Unity Mapping
- **ScriptableObjects:** `RemoteConfigSettings.asset`
- **Runtime Managers:** `ConfigManager`
- **Events:** `OnConfigsUpdated`

## 4. AI Implementation Notes
- **Responsible Agent:** Product Manager Agent
- **Prompt Note:** Keep it agnostic. The `IConfigProvider` interface must allow swapping between Unity Remote Config, Firebase, or a custom REST API.
