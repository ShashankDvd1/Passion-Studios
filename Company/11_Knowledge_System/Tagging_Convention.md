---
document_id: "11-004"
title: "Tagging Convention"
owner: "Documentation Agent"
status: "Approved"
version: "1.0"
created: "2026-06-28"
updated: "2026-06-28"
phase: "Phase 1 — Agent Operating System"
priority: "P1"
tags: [tagging, metadata, organization, search]
related_documents: ["11-006: Metadata Standards", "11-003: Naming Convention"]
related_agents: ["Documentation Agent"]
dependencies: ["11-003: Naming Convention"]
---
# Tagging Convention
## 1. Vision
Tags make documents discoverable. Every document has 3-8 tags from a controlled vocabulary. Tags enable cross-domain discovery — finding all documents related to "monetization" regardless of which folder they live in.

## 6. Requirements
### 6.1 Tag Categories
| Category | Purpose | Examples |
|----------|---------|---------|
| **Domain** | Which business domain | `product`, `engineering`, `business`, `creative`, `operations`, `leadership` |
| **System** | Which OS subsystem | `agent-os`, `agents`, `workflows`, `memory`, `knowledge`, `governance`, `quality`, `automation`, `prompts`, `experiments` |
| **Function** | What the doc does | `architecture`, `framework`, `standards`, `template`, `guide`, `review`, `matrix`, `pipeline` |
| **Game** | Game-specific (when applicable) | `tiny-world`, `engine`, `behavior-engine` |
| **Priority** | Importance level | `core-ip`, `platform`, `infrastructure` |

### 6.2 Tagging Rules
1. Every document must have 3-8 tags in its YAML frontmatter.
2. Tags are lowercase, hyphenated (`agent-os`, not `AgentOS` or `agent_os`).
3. At least 1 domain tag and 1 function tag per document.
4. Do not create new tags without adding them to this controlled vocabulary.
5. Tags are additive — if a document is relevant to multiple domains, add all relevant domain tags.

### 6.3 Controlled Tag Vocabulary
```
# Domain tags
product, engineering, business, creative, operations, leadership

# System tags
agent-os, agents, workflows, memory, knowledge, governance, quality,
automation, prompts, experiments, task-management

# Function tags
architecture, framework, standards, template, guide, review, matrix,
pipeline, catalog, protocol, dashboard, audit, security, performance,
lifecycle, versioning, creation, retirement, definition, convention

# Game tags
tiny-world, engine, behavior-engine, core-ip, platform

# Process tags
workflow, bugfix, feature, release, liveops, marketing, analytics,
code-review, testing, deployment, post-mortem, ab-test
```

## 7. Acceptance Criteria
- [ ] Every document has 3-8 tags from the controlled vocabulary
- [ ] No tags exist outside the controlled vocabulary
- [ ] Cross-domain search by tag returns all relevant documents

## 14. Related Documents
| Doc ID | Title | Relationship |
|--------|-------|-------------|
| 11-006 | Metadata Standards | Tags are part of the metadata schema |
| 11-003 | Naming Convention | Naming and tagging share formatting rules |
