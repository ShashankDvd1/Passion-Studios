---
document_id: "10-011"
title: "Unity Implementation Workflow"
owner: "Unity Architect Agent"
status: "Approved"
version: "1.0"
created: "2026-06-28"
updated: "2026-06-28"
phase: "Phase 1 — Agent Operating System"
priority: "P0"
tags: [workflow, unity, implementation, engineering]
related_documents: ["10-001: Workflow Engine", "10-010: Code Review Workflow"]
related_agents: ["Unity Architect Agent", "Gameplay Programmer Agent", "Code Review Agent", "QA Agent", "Performance Agent"]
dependencies: ["10-001: Workflow Engine"]
---
# Unity Implementation Workflow
## Trigger
Manual — Technical design approved in a feature workflow.
## Steps
1. **Module Design** (Unity Architect) → Module boundaries, APIs, ScriptableObject schema, dependencies
2. **Implementation** (Gameplay Programmer) → C# code, ScriptableObjects, Event Bus integration
3. **Unit Testing** (Gameplay Programmer) → Unit tests for all public APIs
4. **Code Review** (Code Review Agent) → Triggers Code Review Workflow (10-010)
5. **Integration Testing** (QA Agent) → Integration with existing systems
6. **Performance Profiling** (Performance Agent) → Budget compliance check
7. **Final Validation** (QA Agent) → Acceptance criteria verification
## Governance: P2 within approved architecture. P1 if new patterns needed.
## Estimated Duration: 2-5 days
