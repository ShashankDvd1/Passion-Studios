---
document_id: "OS-DOC-03"
title: "Knowledge Graph Specification"
type: "Documentation"
owner: "Project Manager Agent"
dependencies: []
feature_ids: []
requirement_ids: []
prs_target: 100
---

# Studio Knowledge Graph Specification

## 1. Purpose
To ensure that all documentation, code, testing, and AI prompts exist as queryable nodes in a machine-readable graph.

## 2. The 4-Layer Architecture

### Layer 1: Markdown (Human Readable)
The actual content of documents (like this one). It acts as the Single Source of Truth (SSOT).

### Layer 2: YAML Frontmatter (Machine Readable)
Every Markdown file in `WonderForge-GameOS` MUST include YAML metadata at the top:
```yaml
---
document_id: "Unique-ID"
title: "Document Title"
type: "System|FeaturePack|Documentation|Tool"
owner: "Agent Name"
dependencies: ["List", "Of", "Document_IDs"]
feature_ids: ["Mapped_Feature_IDs"]
requirement_ids: ["Mapped_Requirement_IDs"]
prs_target: 95
---
```

### Layer 3: Generated JSON Index
A Python or Node.js script (to be written by the Backend Agent) will crawl all Markdown files, parse the YAML, and generate `knowledge_graph.json`. **This file is never edited manually.**

### Layer 4: Visualization
The CI/CD pipeline uses `knowledge_graph.json` to generate Mermaid and Graphviz (DOT) files automatically, appending them to a central Wiki for human visualization.
