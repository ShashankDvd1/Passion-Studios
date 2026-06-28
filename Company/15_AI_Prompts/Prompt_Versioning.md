---
document_id: "15-006"
title: "Prompt Versioning"
owner: "Prompt Engineering Agent"
status: "Approved"
version: "1.0"
created: "2026-06-28"
updated: "2026-06-28"
phase: "Phase 1 — Agent Operating System"
priority: "P2"
tags: [prompts, versioning, history]
related_documents: ["11-008: Version History Standards"]
related_agents: ["Prompt Engineering Agent"]
dependencies: ["11-008: Version History Standards"]
---
# Prompt Versioning
## 1. Vision
Like code, prompts must be versioned. If an agent's performance degrades, we must be able to rollback its prompt to a known good state.

## 6. Requirements
### 6.1 Versioning Schema
Prompts follow the standard MAJOR.MINOR schema (11-008).
- **MAJOR:** Fundamental logic or output format changes.
- **MINOR:** Wording tweaks, constraint additions, or component updates.

### 6.2 Rollback Protocol
- If an agent's first-pass approval rate (Quality Pipeline) drops by >15% over a 7-day period, the Prompt Engineering Agent automatically rolls back the prompt to the previous stable MINOR version and flags the founder.
- All version changes are logged in the Prompt Library metadata.
