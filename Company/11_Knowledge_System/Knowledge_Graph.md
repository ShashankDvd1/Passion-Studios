---
document_id: "11-001"
title: "Knowledge Graph"
owner: "Documentation Agent"
status: "Approved"
version: "1.0"
created: "2026-06-28"
updated: "2026-06-28"
phase: "Phase 1 — Agent Operating System"
priority: "P0"
tags: [knowledge, graph, relationships, documentation]
related_documents: ["07-001: Agent OS Vision", "11-007: Document Relationships", "11-006: Metadata Standards"]
related_agents: ["Documentation Agent", "All Agents"]
dependencies: ["07-001: Agent OS Vision"]
---

# Knowledge Graph

## 1. Vision
The Knowledge Graph is the map of everything the company knows. It connects every document, every agent, every decision, every concept, and every workflow into a navigable web of relationships. When an agent needs context, the Knowledge Graph answers: "What exists? How is it connected? What's relevant to this task?"

## 2. Problem Statement
Without a knowledge graph, documents are isolated files. An agent working on monetization doesn't know that the Ethical Framework constrains its work unless someone manually provides the reference. Context injection becomes guesswork instead of systematic lookup.

## 3. Goals
1. Map all company documents, agents, and concepts into a connected graph.
2. Enable any agent to discover relevant context by traversing relationships.
3. Detect orphaned documents (no connections) and missing connections.
4. Support the Memory System by providing structural context for memory queries.

## 6. Requirements

### 6.1 Node Types

| Node Type | Description | Example |
|-----------|-------------|---------|
| **Document** | Any file in the Company/ folder system | `Company_Vision.md (01-001)` |
| **Agent** | Any registered agent in the Agent Registry | `Game Designer Agent (09-004)` |
| **Concept** | A key idea, principle, or framework | `Seven-Question Gate`, `Core Loop`, `HRP` |
| **Workflow** | A defined multi-agent process | `New Feature Workflow (10-002)` |
| **Decision** | A logged decision with rationale | `DEC-2026-07-15-001` |
| **Memory** | A persistent memory entry | `Player churn analysis Q3 2026` |

### 6.2 Edge Types (Relationships)

| Edge Type | Meaning | Example |
|-----------|---------|---------|
| `DEPENDS_ON` | A requires B to function | Agent depends on a document for context |
| `REFERENCES` | A mentions or cites B | PRD references Design Principles |
| `PRODUCES` | A creates B as output | Agent produces a document type |
| `CONSUMES` | A uses B as input | Workflow step consumes agent output |
| `CONSTRAINS` | A limits or governs B | Ethical Framework constrains Monetization Agent |
| `IMPLEMENTS` | A is a concrete implementation of B | Workflow implements a principle |
| `SUPERSEDES` | A replaces B (versioning) | Agent v2.0 supersedes v1.0 |
| `RELATED_TO` | A and B are related but no directional dependency | Two documents covering adjacent topics |

### 6.3 Graph Structure (Top Level)

```
Company Vision (01-001)
├── CONSTRAINS → All Agents, All Workflows
├── REFERENCES → Studio Identity (01-002)
├── REFERENCES → Success Definition (01-004)
└── DEPENDS_ON → Core Values (02-001)

Core Values (02-001)
├── CONSTRAINS → Design Principles (02-002)
├── CONSTRAINS → Operating Principles (02-003)
├── CONSTRAINS → Quality Standards (02-004)
└── CONSTRAINS → Ethical Framework (02-005)

Agent OS Vision (07-001)
├── IMPLEMENTS → Operating Principles (02-003)
├── PRODUCES → System Architecture (07-002)
├── PRODUCES → Agent Registry (07-003)
└── DEPENDS_ON → Company Vision (01-001)

Each Agent (09-NNN)
├── DEPENDS_ON → Agent Template (08-006)
├── CONSUMES → Memory types (12-NNN)
├── REFERENCES → Related documents
├── PRODUCES → Domain-specific outputs
└── CONSTRAINS → Quality Standards (02-004), Ethical Framework (02-005)

Each Workflow (10-NNN)
├── DEPENDS_ON → Workflow Engine (10-001)
├── CONSUMES → Agent outputs (steps)
├── REFERENCES → Governance rules (16-NNN)
└── PRODUCES → Final deliverable
```

### 6.4 Graph Maintenance Rules

| Rule | Description |
|------|-------------|
| **Every document has ≥1 connection** | No orphan documents. If a doc has no connections, it's either missing references or unnecessary. |
| **Bidirectional awareness** | If A references B, B's `related_documents` should include A. |
| **Updated on document change** | When a document is created, modified, or retired, the graph is updated. |
| **Quarterly integrity audit** | Documentation Agent scans for broken references, orphans, and missing edges. |

### 6.5 Graph Queries

| Query | Purpose | Example |
|-------|---------|---------|
| "What constrains X?" | Find all governance applying to an agent or workflow | "What constrains Monetization Agent?" → Ethical Framework, Economy Agent balance |
| "What does X produce?" | Find all outputs of an agent | "What does Game Designer Agent produce?" → Design specs, content templates |
| "What depends on X?" | Impact analysis for changes | "What depends on Design Principles?" → All Product agents, all feature workflows |
| "What's related to X?" | Context discovery | "What's related to player retention?" → Behav Psych, Analytics, LiveOps, Success Definition |

## 7. Acceptance Criteria
- [ ] Every document in the company system has at least one graph connection
- [ ] All eight edge types cover every relationship in the system
- [ ] Graph queries return accurate results for context discovery
- [ ] Orphan detection identifies disconnected documents within 24 hours of creation

## 14. Related Documents
| Doc ID | Title | Relationship |
|--------|-------|-------------|
| 11-006 | Metadata Standards | Metadata that populates graph nodes |
| 11-007 | Document Relationships | Detailed relationship rules |
| 07-003 | Agent Registry | Agent nodes in the graph |
