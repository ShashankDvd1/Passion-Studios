---
document_id: "OS-B1-13"
title: "Editor Utilities"
type: "System"
owner: "Unity Architect Agent"
dependencies: []
feature_ids: ["FEAT-OS-10"]
requirement_ids: ["REQ-OS-10"]
prs_target: 100
---

# Editor Utilities

## 1. Purpose
To provide custom Unity Inspector tooling, validation scripts, and generation wizards that speed up AI-assisted Vibe Coding.

## 2. Public API
- N/A (Editor code only)

## 3. Unity Mapping
- **ScriptableObjects:** N/A
- **Runtime Managers:** N/A
- **Events:** N/A

## 4. AI Implementation Notes
- **Responsible Agent:** Unity Architect Agent
- **Prompt Note:** Implement `PropertyDrawers` for custom data structures and a central `GameOS Window` (via `UIElements`) to validate the Platform Reuse Score (PRS) and ensure no missing references exist before building.
