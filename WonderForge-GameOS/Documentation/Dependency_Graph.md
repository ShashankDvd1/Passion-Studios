---
document_id: "OS-DOC-02"
title: "Dependency Graph"
type: "Documentation"
owner: "Unity Architect Agent"
dependencies: ["OS-DOC-01"]
feature_ids: []
requirement_ids: []
prs_target: 100
---

# Game OS Dependency Graph

## 1. Overview
This document defines the strict hierarchical dependencies of the Wonder Forge Game OS. Cyclic dependencies are prohibited.

## 2. Mermaid Visualization (Layer 4)

```mermaid
graph TD
    %% Core Infrastructure (No Dependencies)
    A[Runtime Core] --> B[Event Bus]
    A --> C[Dependency Injection]
    A --> D[Logging]
    
    %% Mid-Level Infrastructure
    B --> E[Save System]
    B --> F[Configuration Framework]
    C --> E
    C --> F
    
    %% Unity Frameworks
    E --> G[ScriptableObject Framework]
    F --> G
    G --> H[UI Framework]
    G --> I[Audio Framework]
    
    %% High-Level Feature Packs
    H --> J[Feature Packs]
    I --> J
    E --> J
    
    %% Game Implementations
    J --> K[Conveyor Chaos]
    J --> L[Tiny World]
```

## 3. Enforcement
- The `Testing_Framework` validates this graph by analyzing assembly definition files (`.asmdef`) in Unity. If a Feature Pack references a Game assembly, the CI/CD build fails.
