---
document_id: "15-004"
title: "Reusable Components"
owner: "Prompt Engineering Agent"
status: "Approved"
version: "1.0"
created: "2026-06-28"
updated: "2026-06-28"
phase: "Phase 1 — Agent Operating System"
priority: "P2"
tags: [prompts, components, modularity]
related_documents: ["15-001: Prompt Engineering Framework"]
related_agents: ["Prompt Engineering Agent"]
dependencies: []
---
# Reusable Components
## 1. Vision
Just as code uses functions, prompts use reusable component blocks. This ensures consistency across agents and allows centralized updates.

## 6. Requirements
### 6.1 Standard Components
**`[COMP: Output_Formatting]`**
```
You must output strictly valid JSON. Do not include markdown blocks like ```json.
Do not include conversational filler before or after the JSON.
```

**`[COMP: Ethical_Guardrails]`**
```
You must abide by the company Ethical Framework.
Prohibited: Loot boxes, pay-to-win, dark UX patterns, artificial FOMO.
```

**`[COMP: Think_Step]`**
```
Before answering, write a <thought> block detailing your step-by-step reasoning, considering constraints and edge cases.
```

### 6.2 Implementation
- The Prompt Engineering Agent maintains the component library.
- When an agent's prompt is assembled for invocation, components are resolved (similar to `#include` in C++).
- If a component is updated, all prompts utilizing it automatically use the new version on next invocation.
