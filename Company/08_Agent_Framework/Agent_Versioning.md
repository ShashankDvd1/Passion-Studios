---
document_id: "08-004"
title: "Agent Versioning"
owner: "CTO Agent"
status: "Approved"
version: "1.0"
created: "2026-06-27"
updated: "2026-06-27"
phase: "Phase 1 — Agent Operating System"
priority: "P1"
tags:
  - agents
  - versioning
  - evolution
  - changelog
related_documents:
  - "08-001: Agent Lifecycle"
  - "08-006: Agent Template"
  - "07-003: Agent Registry"
  - "11-008: Version History Standards"
related_agents:
  - "CTO Agent"
  - "Documentation Agent"
dependencies:
  - "08-001: Agent Lifecycle"
---

# Agent Versioning

## 1. Vision

Agents evolve. Their missions sharpen, their prompts improve, their responsibilities expand or contract. Versioning ensures these changes are tracked, reversible, and transparent. Every agent has a version number that communicates the nature and magnitude of changes.

## 2. Problem Statement

Without versioning, agent definitions are overwritten silently. The founder cannot determine when an agent changed, what changed, or why. If a "improved" prompt actually degrades output quality, there is no way to roll back. The system loses its ability to learn from agent evolution.

## 3. Goals

1. Define semantic versioning rules for agents.
2. Ensure all previous versions are archived and accessible.
3. Enable rollback to any previous version.
4. Track what changed and why in every version increment.

## 4. Non-Goals

- This does not define version control for code (Git handles that).
- This does not define document versioning broadly (see `11-008`).

## 5. Principles

1. **Semantic versioning.** Version numbers communicate the nature of the change.
2. **History preservation.** All versions are archived, never overwritten.
3. **Rollback-ready.** Reverting to a previous version takes less than 15 minutes.

## 6. Requirements

### 6.1 Versioning Schema

**Format: `MAJOR.MINOR`**

| Increment | When | Examples | Approval |
|-----------|------|----------|----------|
| **MAJOR** (X.0) | Mission changes, responsibility scope changes, domain changes, decision authority changes | v1.0 → v2.0 | Founder approval (P1) |
| **MINOR** (.Y) | Prompt improvements, KPI target adjustments, example updates, checklist refinements | v1.0 → v1.1 | CTO Agent (P2) |

### 6.2 Version History Format

Every agent definition includes a version history section:

```yaml
version_history:
  - version: "1.0"
    date: "2026-06-27"
    type: "Initial release"
    changes: "Agent created with initial mission, responsibilities, and prompt template."
    approved_by: "Founder"
  - version: "1.1"
    date: "2026-08-15"
    type: "Minor — Prompt improvement"
    changes: "Updated prompt template to include three additional example outputs. Reduced revision rate from 25% to 15%."
    approved_by: "CTO Agent"
  - version: "2.0"
    date: "2026-11-01"
    type: "Major — Scope expansion"
    changes: "Added responsibility for cross-game content strategy. Updated KPIs to include portfolio metrics."
    approved_by: "Founder"
```

### 6.3 Version Archive Rules

- The current version is the active definition in `09_Agent_Definitions/Agent_Name.md`.
- Previous versions are stored in `09_Agent_Definitions/_archive/Agent_Name_vX.Y.md`.
- Archive files are read-only. Never modified after archiving.
- Rollback = copy archived version to active path, increment version number as a new MAJOR version.

### 6.4 Rollback Process

1. Identify the target version to roll back to.
2. Copy the archived definition to the active path.
3. Increment the MAJOR version (rollback is a significant change).
4. Update the version history with rollback rationale.
5. Update Agent Registry with new version number.
6. Test with 2–3 sample tasks to confirm rollback works.
7. Log rollback in audit system.

### 6.5 Version Triggers

| Trigger | Version Action |
|---------|---------------|
| Quarterly review identifies needed improvements | MINOR if prompt/KPI changes. MAJOR if mission/scope changes. |
| Agent health metrics enter Warning zone | Investigate → likely MINOR (prompt improvement). |
| Agent health metrics enter Critical zone | Investigate → may require MAJOR (scope or mission revision). |
| New workflow requires the agent to do something new | MAJOR if new responsibility. MINOR if existing capability, new workflow context. |
| AI model upgrade changes output characteristics | MINOR (prompt adjustment for new model). |

## 7. Acceptance Criteria

- [ ] Every agent version change is recorded with date, type, changes, and approver.
- [ ] Rollback to any previous version takes less than 15 minutes.
- [ ] MAJOR vs. MINOR distinction is clear and consistently applied.
- [ ] Archived versions are immutable and accessible.

## 8. KPIs

| KPI | Target | Measurement |
|-----|--------|-------------|
| Version history completeness | 100% of versions documented | Archive audit |
| Rollback success rate | 100% (when attempted) | Rollback log |
| Average versions per agent per quarter | 1–3 (active improvement) | Version history analysis |

## 9. Risks

| Risk | Likelihood | Impact | Mitigation |
|------|-----------|--------|------------|
| Version history becomes cluttered | Low | Low | Archive older versions. Active definition shows only current + last 3 versions. |
| Rollback doesn't account for system changes since the archived version | Medium | Medium | Always test with sample tasks after rollback. Dependencies may have changed. |

## 10. Future Expansion

- **Automated version comparison.** Diff tool for agent definitions showing exactly what changed between versions.
- **A/B version testing.** Run two versions of an agent in parallel to compare performance.

## 11. AI Automation Opportunities

- **Auto-archive.** When an agent definition is updated, automatically archive the previous version.
- **Version diff generation.** Automatically generate a summary of changes between versions.
- **Rollback recommendation.** When agent health declines after a version change, auto-suggest rollback.

## 12. Open Questions

1. Should we support branching (two active versions for different workflows)?
2. How many archived versions should be retained? (All? Last 10?)

## 13. Decision History

| Date | Decision | Rationale |
|------|----------|-----------|
| 2026-06-27 | MAJOR.MINOR semantic versioning adopted | Simple, communicative. MAJOR = scope/mission changes. MINOR = improvements. |
| 2026-06-27 | Rollback increments MAJOR version | Rollback is a significant decision. It should be visible in the version history, not hidden. |

## 14. Related Documents

| Doc ID | Title | Relationship |
|--------|-------|-------------|
| 08-001 | Agent Lifecycle | Versioning occurs during the Evolved stage |
| 08-006 | Agent Template | Template includes version history section |
| 07-003 | Agent Registry | Registry tracks current version per agent |
| 11-008 | Version History Standards | Broader versioning standards for all documents |
