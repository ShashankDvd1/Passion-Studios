---
document_id: "17-003"
title: "Technical Review Standards"
owner: "Unity Architect Agent"
status: "Approved"
version: "1.0"
created: "2026-06-28"
updated: "2026-06-28"
phase: "Phase 1 — Agent Operating System"
priority: "P1"
tags: [quality, review, technical]
related_documents: ["17-001: Quality Pipeline"]
related_agents: ["Code Review Agent", "Unity Architect Agent", "QA Agent"]
dependencies: ["17-001: Quality Pipeline"]
---
# Technical Review Standards
## 1. Vision
Verify that the output is technically sound, secure, performant, and correctly implemented.

## 6. Requirements
### 6.1 Reviewers
- Code is reviewed by Code Review Agent.
- Architecture is reviewed by Unity Architect Agent.
- Game mechanics are reviewed by Game Designer Agent.

### 6.2 Technical Review Checklist
1. **Correctness:** Does it do what it's supposed to do?
2. **Architecture:** Does it follow defined patterns (e.g., SOLID, Event Bus)?
3. **Performance:** Does it meet performance budgets?
4. **Security:** Does it introduce vulnerabilities?
5. **Testing:** Is there adequate test coverage?

### 6.3 Automated First Pass
For code, the Technical Review always begins with automated static analysis (linting, compiling, test running) before the AI review layer engages.
