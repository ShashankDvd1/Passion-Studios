---
document_id: "OS-DOC-01"
title: "Repository Architecture"
type: "Documentation"
owner: "Project Manager Agent"
dependencies: []
feature_ids: []
requirement_ids: []
prs_target: 100
---

# Repository Architecture

## 1. Overview
The Wonder Forge Studios technical ecosystem is strictly separated into modular repositories. The **Company** repository handles product definition and business strategy. The **WonderForge-GameOS** repository handles reusable engineering infrastructure. **Games** consume the GameOS via Unity Package Manager (UPM) or git submodules.

## 2. Directory Structure

```text
WonderForge-Studios/
│
├── Company/ (Business & Product Definition)
│   ├── 00_Company_Foundation/
│   ├── 01_AI_OS/
│   ├── 02_Human_Experience/
│   ├── 03_Living_World/
│   ├── 04_Product_Definition/
│   ├── 05_Strategy/
│   └── Documentation/
│
├── WonderForge-GameOS/ (Reusable Engineering Platform)
│   ├── Runtime/ (Event Bus, Save System, DI)
│   ├── Unity_Framework/ (UI, Audio, ScriptableObjects)
│   ├── Feature_Packs/ (Idle, Conveyor, Inventory)
│   ├── Content_Pipeline/
│   ├── AI_Framework/
│   ├── Analytics/
│   ├── LiveOps/
│   ├── Testing/
│   ├── Tools/
│   ├── Templates/
│   ├── Samples/
│   └── Documentation/
│
├── Games/ (Implementations)
│   ├── ConveyorChaos/ (Validation Project)
│   ├── TinyWorld/ (Flagship Simulator)
│   └── FutureGames/
│
├── InternalTools/
└── Experiments/
```

## 3. Dependency Rules
1. **Upward strictly forbidden:** `WonderForge-GameOS` cannot reference any code inside `Games/`.
2. **Horizontal strictness:** `Feature_Packs` can depend on `Runtime/` and `Unity_Framework/`, but cannot depend on other `Feature_Packs` unless explicitly defined via Interfaces.
3. **Consumption:** Games consume GameOS. GameOS consumes Company documentation.
