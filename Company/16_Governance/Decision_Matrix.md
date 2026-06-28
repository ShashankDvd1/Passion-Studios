---
document_id: "16-001"
title: "Decision Matrix"
owner: "Founder Agent"
status: "Approved"
version: "1.0"
created: "2026-06-28"
updated: "2026-06-28"
phase: "Phase 1 — Agent Operating System"
priority: "P0"
tags: [governance, decisions, matrix, priority]
related_documents: ["00-003: Decision Framework"]
related_agents: ["All Agents"]
dependencies: ["00-003: Decision Framework"]
---
# Decision Matrix
## 1. Vision
The Agent OS must know who is allowed to decide what. This matrix defines exactly which decisions agents can make autonomously and which must escalate.

## 6. Requirements
### 6.1 Decision Categories
| Decision Category | Description | Authority |
|-------------------|-------------|-----------|
| **Vision & Values** | Core identity, ethics, brand | Founder Only (P0) |
| **Strategy & Scope** | Roadmap, features, budget, major architecture | Founder / CEO Agent (P1) |
| **Design & Mechanics** | Within approved feature scope | Product Agents (P2) |
| **Implementation** | Code architecture, tooling | Engineering Agents (P2) |
| **Operations** | Task routing, formatting, logs | Operations Agents (P3) |

### 6.2 Escalation Paths
- Agents consult the Decision Matrix before finalizing any output.
- If a decision exceeds their authority (e.g., Game Designer Agent wants to change the core loop), they generate a **Decision Brief** and route it to the Founder Agent via the Escalation Channel.
