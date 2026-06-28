---
document_id: "OS-B1-05"
title: "Event System"
type: "System"
owner: "Unity Architect Agent"
dependencies: ["OS-B1-04"]
feature_ids: ["FEAT-OS-02"]
requirement_ids: ["REQ-OS-02"]
prs_target: 100
---

# Event System

## 1. Purpose
A decoupled, global Event Bus that allows systems to communicate without hard references to one another.

## 2. Public API
- `void Publish<T>(T eventData)`
- `void Subscribe<T>(Action<T> handler)`
- `void Unsubscribe<T>(Action<T> handler)`

## 3. Unity Mapping
- **ScriptableObjects:** N/A (Pure C#)
- **Runtime Managers:** `EventBus`
- **Events:** N/A (This is the system that handles events).

## 4. AI Implementation Notes
- **Responsible Agent:** Unity Architect Agent
- **Prompt Note:** Use generic C# `Action<T>` with a Dictionary mapping Type to a list of delegates. No `UnityEvent` for core architecture (too slow/allocates memory).
