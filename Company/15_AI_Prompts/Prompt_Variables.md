---
document_id: "15-003"
title: "Prompt Variables"
owner: "Prompt Engineering Agent"
status: "Approved"
version: "1.0"
created: "2026-06-28"
updated: "2026-06-28"
phase: "Phase 1 — Agent Operating System"
priority: "P1"
tags: [prompts, variables, context-injection]
related_documents: ["15-001: Prompt Engineering Framework"]
related_agents: ["Prompt Engineering Agent"]
dependencies: ["15-001: Prompt Engineering Framework"]
---
# Prompt Variables
## 1. Vision
Variables are the dynamic injection points in a static prompt template. They connect the Memory System to the Agent OS execution layer.

## 6. Requirements
### 6.1 Standard Variables
| Variable | Source | Example Content |
|----------|--------|-----------------|
| `{{company_vision}}` | Company Memory | "Build cozy simulation games..." |
| `{{ethical_constraints}}` | Company Memory | "No dark patterns..." |
| `{{current_kpis}}` | Player Memory (Analytics) | "D7: 23%, ARPDAU: $0.15" |
| `{{task_description}}` | Task System | "Design crafting UI screen" |
| `{{previous_decisions}}` | Decision Memory | "Rejected layout A due to..." |

### 6.2 Variable Hydration Rules
- **Size Limits:** To prevent context window overflow, large variables (like `previous_decisions`) are truncated to the top 3 most relevant entries.
- **Missing Data:** If a variable cannot be hydrated, it is replaced with: `[NO CONTEXT AVAILABLE]`. Agents are instructed to handle this gracefully.
- **Escaping:** All injected data must be sanitized to prevent prompt injection (e.g., escaping special characters if the user input is included).
