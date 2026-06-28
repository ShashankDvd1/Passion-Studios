---
document_id: "15-001"
title: "Prompt Engineering Framework"
owner: "Prompt Engineering Agent"
status: "Approved"
version: "1.0"
created: "2026-06-28"
updated: "2026-06-28"
phase: "Phase 1 — Agent Operating System"
priority: "P0"
tags: [prompts, framework, engineering, ai]
related_documents: ["09-024: Prompt Engineering Agent"]
related_agents: ["Prompt Engineering Agent"]
dependencies: []
---
# Prompt Engineering Framework
## 1. Vision
Prompts are not magic spells; they are source code. They must be engineered, versioned, tested, and optimized with the same rigor as C# or Python. This framework defines how we construct reliable, deterministic AI behavior.

## 6. Requirements
### 6.1 Core Principles
1. **Determinism over Creativity:** Unless specifically requesting creative ideas (e.g., Content Creator Agent), prompts must produce predictable, parsable output formats.
2. **Context Injection:** Agents cannot "remember" context between sessions without the Memory System. Context must be injected dynamically via variables.
3. **Constraint-Based Design:** Tell the AI exactly what it *cannot* do, as strictly as what it *should* do.
4. **Step-by-Step Reasoning:** Complex tasks require `<thought>` tags or explicit instruction to reason before answering (Chain of Thought).

### 6.2 Standard Prompt Structure
Every system prompt must follow this structure (as seen in Agent Definitions `09-NNN`):
1. **Role / Identity:** "You are the [Agent Name]..."
2. **Mission:** The core objective.
3. **Context:** Injected variables (values, strategy, current data).
4. **Task:** The specific request.
5. **Constraints:** Non-negotiable rules.
6. **Output Format:** Expected JSON, YAML, or Markdown structure.

### 6.3 Prompt Componentization
Prompts are built from reusable blocks (`15-004`), managed by the Prompt Engineering Agent, ensuring changes to a core block (like the Ethical Framework constraint block) propagate to all relevant agents automatically.
