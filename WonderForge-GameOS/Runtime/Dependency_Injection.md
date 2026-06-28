---
document_id: "OS-B1-08"
title: "Dependency Injection"
type: "System"
owner: "Unity Architect Agent"
dependencies: ["OS-B1-04"]
feature_ids: ["FEAT-OS-05"]
requirement_ids: ["REQ-OS-05"]
prs_target: 100
---

# Dependency Injection

## 1. Purpose
To prevent Singleton abuse and tight coupling by resolving dependencies dynamically at runtime.

## 2. Public API
- `void Bind<TInterface, TImplementation>()`
- `T Resolve<T>()`

## 3. Unity Mapping
- **ScriptableObjects:** N/A
- **Runtime Managers:** `DIContainer`
- **Events:** N/A

## 4. AI Implementation Notes
- **Responsible Agent:** Unity Architect Agent
- **Prompt Note:** Implement a lightweight Service Locator or constructor injection pattern. Avoid heavy reflection during gameplay to meet the `35_Performance` 0-byte allocation rule.
