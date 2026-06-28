---
document_id: "10-012"
title: "Git Commit Workflow"
owner: "Automation Agent"
status: "Approved"
version: "1.0"
created: "2026-06-28"
updated: "2026-06-28"
phase: "Phase 1 — Agent Operating System"
priority: "P1"
tags: [workflow, git, version-control]
related_documents: ["10-001: Workflow Engine", "10-010: Code Review Workflow"]
related_agents: ["Gameplay Programmer Agent", "Automation Agent"]
dependencies: ["10-001: Workflow Engine"]
---
# Git Commit Workflow
## Trigger
Event — Code passes Code Review Workflow (10-010).
## Steps
1. **Pre-Commit Checks** (Automation Agent) → Lint, format, test suite, build validation
2. **Commit Message** (Gameplay Programmer Agent) → Conventional commit format: `type(scope): description`
3. **Branch Strategy** (Automation Agent) → Feature branch → develop → main. No direct main commits.
4. **Pull Request** (Gameplay Programmer Agent) → PR with description, linked issue/task, review checklist
5. **Merge** (Automation Agent) → Squash merge to develop. Preserve full history in feature branch.
6. **Post-Merge** (Automation Agent) → Trigger CI build, update task status, notify relevant agents
## Commit Message Format
```
feat(crafting): add recipe discovery system
fix(economy): correct soft currency overflow at max level
docs(agent-os): update Agent Registry with new agent
refactor(events): extract event bus into reusable module
test(crafting): add unit tests for recipe validation
```
## Governance: P3 — automated. Founder involved only for release branch merges.
## Estimated Duration: 15-30 minutes
