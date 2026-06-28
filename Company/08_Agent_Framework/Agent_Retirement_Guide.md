---
document_id: "08-003"
title: "Agent Retirement Guide"
owner: "CTO Agent"
status: "Approved"
version: "1.0"
created: "2026-06-27"
updated: "2026-06-27"
phase: "Phase 1 — Agent Operating System"
priority: "P1"
tags:
  - agents
  - retirement
  - lifecycle
  - cleanup
related_documents:
  - "08-001: Agent Lifecycle"
  - "07-003: Agent Registry"
  - "08-005: Capability Matrix"
  - "10-001: Workflow Engine"
related_agents:
  - "CTO Agent"
  - "Documentation Agent"
  - "Founder Agent"
dependencies:
  - "08-001: Agent Lifecycle"
---

# Agent Retirement Guide

## 1. Vision

Agents that no longer serve a purpose must be retired cleanly — not abandoned. A proper retirement ensures no workflow breaks, no dependency is orphaned, and the institutional knowledge the agent accumulated is preserved. Retirement is a mark of organizational maturity, not failure.

## 2. Problem Statement

Agents left active after their usefulness ends create noise: they appear in the Registry, consume review cycles, and confuse the system about who owns what. Worse, an unretired agent may continue producing output that no one reviews, quietly degrading quality.

## 3. Goals

1. Define a step-by-step retirement process.
2. Ensure zero orphaned dependencies after retirement.
3. Preserve the retired agent's knowledge and history.
4. Complete retirement in under 2 hours.

## 4. Non-Goals

- This does not cover agent evolution (see `08-004: Agent Versioning`).
- This does not cover agent merging (handled as retirement of one + evolution of another).

## 5. Principles

1. **Archive, never delete.** Retired agent definitions are preserved with "Retired" status.
2. **Dependencies first.** No retirement proceeds until all dependencies are resolved.
3. **Clean cut.** After retirement, zero references to the retired agent in active workflows.

## 6. Requirements

### 6.1 Retirement Process (6 Steps)

#### Step 1: Retirement Assessment (15 min)
- Confirm the agent meets one or more retirement criteria:
  - Domain no longer relevant to the company
  - Responsibilities absorbed by another agent
  - Consistently failing KPIs with no improvement path
  - Agent serves a project that has concluded
- Document the reason for retirement

#### Step 2: Dependency Audit (30 min)
- Search all active workflows in `10_Workflows/` for references to this agent
- Search all other agent definitions for dependencies on this agent
- Search all documents for references to this agent
- Compile a complete dependency list

#### Step 3: Responsibility Transfer (30 min)
- For each responsibility the retired agent holds:
  - Assign to an existing agent (expand their scope), OR
  - Create a new agent to absorb it (per `08-002`), OR
  - Confirm the responsibility is no longer needed
- Update receiving agents' definitions with new responsibilities
- Update affected workflows to reference the new responsible agent

#### Step 4: Knowledge Preservation (15 min)
- Archive the agent's prompt templates in `15_AI_Prompts/` with "Archived" status
- Preserve the agent's performance history in the audit log
- Document key learnings from the agent's operation in the retirement record
- Transfer any agent-specific memory entries to appropriate memory layers

#### Step 5: Registry & Documentation Update (15 min)
- Update Agent Registry (`07-003`): set status to "Retired," add retirement date
- Update Capability Matrix (`08-005`): remove retired agent's capabilities
- Add retirement entry to the agent definition's Decision History
- Update any cross-references in related documents

#### Step 6: Verification (15 min)
- Run dependency scan: zero active references to the retired agent
- Confirm all workflows execute without the retired agent
- Confirm receiving agents' definitions include transferred responsibilities
- Log retirement completion in audit log

### 6.2 Retirement Checklist

```
□ Retirement criteria met and documented
□ Founder approval obtained (P1 decision)
□ All workflow references identified and reassigned
□ All agent dependencies identified and resolved
□ All document references updated
□ Responsibilities transferred to receiving agents
□ Prompt templates archived (not deleted)
□ Performance history preserved
□ Key learnings documented
□ Agent Registry updated (status: Retired)
□ Capability Matrix updated
□ Verification scan passed (zero active references)
□ Retirement logged in audit system
```

### 6.3 Retirement Record Format

Appended to the retired agent's definition file:

```yaml
retirement:
  date: "YYYY-MM-DD"
  reason: "Why the agent was retired"
  approved_by: "Founder"
  responsibilities_transferred_to:
    - agent: "Receiving Agent Name"
      responsibilities: ["List of transferred responsibilities"]
  knowledge_preserved:
    prompt_archive: "Path to archived prompts"
    key_learnings: "Summary of what was learned during operation"
  final_metrics:
    total_tasks_completed: N
    average_approval_rate: N%
    autonomy_level_reached: "LN"
    active_duration: "X months"
```

## 7. Acceptance Criteria

- [ ] The 6-step process completes in under 2 hours.
- [ ] Zero orphaned dependencies after retirement.
- [ ] Retired agent's definition is preserved with full history.
- [ ] A retired agent can be reactivated using the archived definition if needed.

## 8. KPIs

| KPI | Target | Measurement |
|-----|--------|-------------|
| Retirement completion time | <2 hours | Lifecycle tracking |
| Post-retirement dependency violations | 0 | Verification scan |
| Knowledge preservation completeness | 100% of templates and history archived | Archive audit |

## 9. Risks

| Risk | Likelihood | Impact | Mitigation |
|------|-----------|--------|------------|
| Retirement breaks an undetected dependency | Low | High | Comprehensive dependency scan in Step 2. Verification in Step 6. |
| Receiving agent overwhelmed by transferred responsibilities | Medium | Medium | Evaluate receiving agent's capacity before transfer. Split across multiple agents if needed. |

## 10. Future Expansion

- Automated dependency scanning tool.
- Agent "hibernation" state (paused but not retired, for seasonal agents).

## 11. AI Automation Opportunities

- **Dependency scan automation.** Script that searches all documents and workflows for agent references.
- **Retirement record generation.** Auto-populate retirement record from Registry and audit log data.

## 12. Open Questions

1. Should retired agent IDs be reused for future agents, or permanently reserved?
2. How long should archived prompt templates be retained?

## 13. Decision History

| Date | Decision | Rationale |
|------|----------|-----------|
| 2026-06-27 | 6-step retirement process adopted | Covers assessment, dependencies, transfer, knowledge, documentation, verification. |
| 2026-06-27 | Archive-never-delete policy | Institutional memory. Retired agents may provide context for future decisions. |

## 14. Related Documents

| Doc ID | Title | Relationship |
|--------|-------|-------------|
| 08-001 | Agent Lifecycle | Retirement is Stage 6 of the lifecycle |
| 07-003 | Agent Registry | Registry updated during retirement |
| 08-005 | Capability Matrix | Matrix updated during retirement |
