---
document_id: "12-001"
title: "Memory Architecture"
owner: "CTO Agent"
status: "Approved"
version: "1.0"
created: "2026-06-28"
updated: "2026-06-28"
phase: "Phase 1 — Agent Operating System"
priority: "P0"
tags: [memory, architecture, agent-os, infrastructure]
related_documents: ["07-001: Agent OS Vision", "07-002: System Architecture"]
related_agents: ["CTO Agent", "All Agents"]
dependencies: ["07-002: System Architecture"]
---
# Memory Architecture
## 1. Vision
The Memory System is what makes the Agent OS intelligent over time. Without persistent memory, every agent interaction starts from zero — the same context is re-explained, the same mistakes are repeated, the same decisions are relitigated. The Memory System gives agents institutional knowledge.

## 2. Problem Statement
AI tools today are amnesiac. Each session starts blank. The founder manually pastes context, explains history, and re-establishes constraints. This doesn't scale. The Memory System automates context persistence so agents always know what has happened before.

## 6. Requirements
### 6.1 Memory Layers
```
┌─────────────────────────────────────────────┐
│           COMPANY MEMORY (12-002)            │
│   Values, vision, strategy, brand identity   │
│   Scope: All games, all time                 │
├─────────────────────────────────────────────┤
│           PROJECT MEMORY (12-003)            │
│   Game-specific: Tiny World context          │
│   Scope: One game, full project lifecycle    │
├──────────────┬──────────────────────────────┤
│ FEATURE MEM  │  TECHNICAL MEMORY (12-005)   │
│ (12-004)     │  Architecture decisions,      │
│ Per-feature  │  patterns, code context       │
│ design &     │  Scope: Engine + game code    │
│ outcomes     │                               │
├──────────────┼──────────────────────────────┤
│ PRODUCT MEM  │  RESEARCH MEMORY (12-007)    │
│ (12-006)     │  Market data, competitive     │
│ Backlog,     │  analysis, tech scouting      │
│ roadmap,     │  Scope: External knowledge    │
│ priorities   │                               │
├──────────────┼──────────────────────────────┤
│ PLAYER MEM   │  DECISION MEMORY (12-009)    │
│ (12-008)     │  All logged decisions with    │
│ Behavior,    │  context, rationale, outcome  │
│ segments,    │  Scope: Institutional memory  │
│ feedback     │                               │
├──────────────┴──────────────────────────────┤
│       ARCHITECTURE MEMORY (12-010)           │
│   Engine architecture, module registry,      │
│   dependency graph, technical debt tracker    │
│   Scope: Codebase-level decisions            │
└─────────────────────────────────────────────┘
```

### 6.2 Memory Entry Format
```yaml
memory_entry:
  id: "MEM-TYPE-YYYY-MM-DD-NNN"
  type: "company | project | feature | technical | product | research | player | decision | architecture"
  title: "Descriptive title"
  created: "ISO-8601"
  updated: "ISO-8601"
  author: "Agent or Founder who created this"
  relevance_score: 0.0-1.0  # Updated based on query frequency
  content: "The actual memory content"
  tags: ["Relevant tags for search"]
  references:
    - doc_ids: ["Related document IDs"]
    - agent_ids: ["Related agent IDs"]
  expiry: "ISO-8601 or 'permanent'"
```

### 6.3 Memory Operations
| Operation | Description | Access Control |
|-----------|-------------|---------------|
| **Write** | Create a new memory entry | Agent must have write access to the memory layer |
| **Read** | Query memory with relevance filtering | Agent must have read access to the memory layer |
| **Update** | Modify an existing entry (append, not overwrite) | Original author or Documentation Agent |
| **Prune** | Remove low-relevance entries past expiry | Documentation Agent only, quarterly |
| **Search** | Full-text and tag-based search across layers | Filtered by agent's access permissions |

### 6.4 Context Injection Rules
When an agent starts a task, the Memory System provides relevant context:
1. **Always include:** Company Memory fundamentals (values, mission, current priorities).
2. **Include if relevant:** Project Memory for the active game, Feature Memory for the feature being worked on.
3. **Include on request:** Technical, Research, Player, Decision, Architecture memory.
4. **Relevance scoring:** Rank memories by recency × relevance to the current task.
5. **Context budget:** Maximum context injection size per agent task (to prevent overload). Start with 2,000 words of context per invocation.

### 6.5 Memory Access Matrix
| Memory Layer | Leadership | Product | Engineering | Creative | Business | Operations |
|-------------|-----------|---------|-------------|----------|----------|-----------|
| Company | R | R | R | R | R | R/W |
| Project | R/W | R/W | R | R | R | R/W |
| Feature | R | R/W | R | R | R | R |
| Technical | R | R | R/W | R | — | R |
| Product | R | R/W | R | R | R | R |
| Research | R | R | R | R | R | R/W |
| Player | R | R | R | R | R/W | R |
| Decision | R/W | R | R | R | R | R/W |
| Architecture | R | R | R/W | — | — | R |

R = Read, R/W = Read/Write, — = No access

## 7. Acceptance Criteria
- [ ] Nine memory layers cover all company information needs
- [ ] Every agent has defined read/write access per the access matrix
- [ ] Context injection provides relevant context within the 2,000-word budget
- [ ] Memory entries are searchable by text, tags, type, and date range

## 14. Related Documents
| Doc ID | Title | Relationship |
|--------|-------|-------------|
| 07-002 | System Architecture | Memory is a Layer 4 service |
| 12-002 through 12-010 | Individual Memory Specs | Detailed specifications per layer |
