---
document_id: "08-001"
title: "Agent Lifecycle"
owner: "CTO Agent"
status: "Approved"
version: "1.0"
created: "2026-06-27"
updated: "2026-06-27"
phase: "Phase 1 — Agent Operating System"
priority: "P0"
tags:
  - agents
  - lifecycle
  - framework
  - governance
  - management
related_documents:
  - "07-001: Agent OS Vision"
  - "07-002: System Architecture"
  - "08-002: Agent Creation Guide"
  - "08-003: Agent Retirement Guide"
  - "08-004: Agent Versioning"
  - "08-005: Capability Matrix"
  - "00-004: AI Collaboration Protocol"
related_agents:
  - "CTO Agent"
  - "Founder Agent"
  - "All Agents (subject to lifecycle)"
dependencies:
  - "07-001: Agent OS Vision"
  - "07-002: System Architecture"
---

# Agent Lifecycle

## 1. Vision

Every agent in the Agent OS has a lifecycle — from initial concept through active operation to eventual retirement. This document defines that lifecycle, ensuring agents are created with purpose, operated with governance, improved with data, and retired without leaving orphaned dependencies.

Agents are not permanent fixtures. They are tools that serve the company's evolving needs. When an agent's responsibilities are absorbed by another agent, when its domain becomes irrelevant, or when its performance consistently fails to meet standards, it is retired cleanly.

## 2. Problem Statement

Without a defined lifecycle, agents proliferate without governance. Duplicate agents emerge. Outdated agents continue operating with stale instructions. No one knows which agents exist, which are active, or which need updating. The Agent Registry becomes unreliable, and the OS degrades into a collection of disconnected prompts.

## 3. Goals

1. Define six lifecycle stages with clear entry and exit criteria.
2. Establish governance rules for each stage transition.
3. Ensure no agent operates without being registered, reviewed, and maintained.
4. Create a retirement process that cleanly removes agents without breaking dependencies.
5. Enable agent versioning so improvements are tracked and rollbacks are possible.

## 4. Non-Goals

- This document does not define how to create a specific agent (see `08-002: Agent Creation Guide`).
- This document does not define individual agent specifications (see `09_Agent_Definitions/`).
- This document does not define agent communication patterns (see `07-004: Communication Protocol`).

## 5. Principles

1. **Every agent earns its existence.** An agent without a clear mission, measurable KPIs, and active usage is a candidate for retirement.
2. **Agents evolve.** Version 1.0 of an agent will be different from version 3.0. The lifecycle supports continuous improvement without breaking changes.
3. **Clean retirement over slow decay.** An agent that is no longer needed is formally retired, not left to rot with stale instructions.
4. **The Registry is the source of truth.** If an agent isn't in the Registry with an "Active" status, it doesn't exist in the OS.

## 6. Requirements

### 6.1 Lifecycle Stages

```
┌──────────┐    ┌──────────┐    ┌──────────┐    ┌──────────┐    ┌──────────┐    ┌──────────┐
│ PROPOSED │───►│ CREATED  │───►│  ACTIVE  │───►│ REVIEW   │───►│ EVOLVED  │    │ RETIRED  │
│          │    │          │    │          │    │          │    │          │    │          │
│ Concept  │    │ Defined  │    │Operating │    │ Assessed │    │ Updated  │    │ Archived │
│ stage    │    │ & tested │    │ in OS    │    │ periodic │    │ version  │    │ cleanly  │
└──────────┘    └──────────┘    └──────────┘    └──────────┘    └──────────┘    └──────────┘
                                      ▲               │              │               ▲
                                      │               │              │               │
                                      └───────────────┘──────────────┘               │
                                      (continues active)   (new version)              │
                                                                                      │
                                                          (any stage)────────────────┘
                                                          (if criteria met)
```

### 6.2 Stage Definitions

#### Stage 1: PROPOSED

**Entry criteria:** Someone (founder or agent) identifies a need that no existing agent fulfills.

**Activities:**
- Write a one-paragraph agent proposal: mission, gap it fills, expected outputs.
- Verify no existing agent already covers this domain (check Capability Matrix `08-005`).
- Identify which workflows the agent would participate in.
- Estimate the volume and frequency of tasks the agent would handle.

**Exit criteria:** Founder approves the proposal. If the domain overlaps with an existing agent, either expand the existing agent or justify the new one.

**Decision authority:** Founder (P1 decision).

---

#### Stage 2: CREATED

**Entry criteria:** Proposal approved.

**Activities:**
- Write full agent definition using the Agent Template (`08-006`).
- Define all required sections: Identity, Mission, Purpose, Responsibilities, KPIs, Decision Authority, Required Context, Inputs, Outputs, Dependencies, Memory Access, Shared Knowledge, Communication Rules, Review Checklist, Success Metrics, Failure Modes, Automation Opportunities, Prompt Template, Prompt Variables, Example Tasks, Example Outputs, Escalation Rules, Related Documents.
- Create initial prompt template in `15_AI_Prompts/`.
- Test agent with 3–5 sample tasks. Evaluate output quality.
- Assign initial autonomy level (Level 1: Supervised per `00-004`).

**Exit criteria:** Agent definition complete, prompt template tested, sample outputs reviewed and approved by founder.

**Decision authority:** CTO Agent creates, founder approves.

---

#### Stage 3: ACTIVE

**Entry criteria:** Agent passes creation review.

**Activities:**
- Agent operates within the OS, receiving tasks from workflows.
- All outputs pass through the Quality Pipeline (`17-001`).
- Performance data is collected: approval rate, revision rate, reject rate, task completion time.
- Autonomy level progresses through the Autonomy Ladder (`00-004`) based on performance.

**Exit criteria:** This is the steady state. Agent remains active unless triggered for Review or Retirement.

**Triggers for Review:** Quarterly scheduled review, performance drop below KPI thresholds, domain scope change, or founder request.

---

#### Stage 4: REVIEW

**Entry criteria:** Quarterly review cycle, performance trigger, or scope change.

**Activities:**
- Review agent KPIs against targets.
- Assess prompt template effectiveness (approval/revision/reject rates).
- Check for scope creep (agent doing things outside its defined responsibilities).
- Check for scope gaps (tasks that should be this agent's responsibility but aren't).
- Evaluate whether the agent should be evolved, merged, split, or retired.
- Gather feedback from agents that depend on this agent's outputs.

**Exit criteria:** One of four outcomes:
1. **Continue Active** — agent is performing well, no changes needed.
2. **Evolve** — agent needs updates, transitions to Stage 5.
3. **Merge** — agent is absorbed into another agent.
4. **Retire** — agent is no longer needed, transitions to Stage 6.

**Decision authority:** CTO Agent recommends, founder approves for merges and retirements.

---

#### Stage 5: EVOLVED

**Entry criteria:** Review identifies needed changes.

**Activities:**
- Create new version of agent definition (e.g., v1.0 → v2.0).
- Update prompt templates.
- Test updated agent with sample tasks.
- Update Capability Matrix and Agent Registry.
- Migrate any in-flight tasks to the new version.

**Exit criteria:** Updated agent passes testing and returns to Active stage with the new version.

**Decision authority:** CTO Agent for P2 changes, founder for P1 changes (mission or scope changes).

---

#### Stage 6: RETIRED

**Entry criteria:** Review determines agent is no longer needed.

**Activities:**
- Identify all workflows that reference this agent.
- Reassign responsibilities to other agents or remove the workflow step.
- Archive (do not delete) the agent definition with a "Retired" status and retirement date.
- Update the Agent Registry and Capability Matrix.
- Archive associated prompt templates.
- Document retirement rationale in Decision History.

**Exit criteria:** No workflow references the retired agent. Agent definition is archived. Registry is updated.

**Decision authority:** Founder approval required for retirement.

### 6.3 Lifecycle Governance Rules

| Rule | Description |
|------|-------------|
| **No orphan agents** | Every active agent must be referenced by at least one workflow. An agent with no workflow references is flagged for review. |
| **No shadow agents** | Every agent interaction in the company must go through a registered, active agent. No ad-hoc AI prompting outside the OS. |
| **Quarterly review mandatory** | Every active agent is reviewed at least once per quarter. No exceptions. |
| **Version history preserved** | All previous versions of an agent definition are archived, not overwritten. Enables rollback. |
| **Dependency check on retirement** | An agent cannot be retired until all dependencies are resolved (workflows updated, responsibilities reassigned). |
| **Single responsibility** | Each agent has one primary mission. If an agent's responsibilities grow beyond its mission, it is split or its mission is formally expanded. |

### 6.4 Agent Health Metrics

Each active agent is continuously measured on:

| Metric | Healthy | Warning | Critical |
|--------|---------|---------|----------|
| First-pass approval rate | >70% | 50–70% | <50% |
| Revision rate | <20% | 20–35% | >35% |
| Reject rate | <5% | 5–15% | >15% |
| Task completion time | Within SLA | 1.5x SLA | >2x SLA |
| Escalation rate | <15% | 15–30% | >30% |
| Autonomy level | Level 2+ | Level 1 (after 30 days) | Level 1 (after 90 days) |

**Warning** status triggers an ad-hoc review. **Critical** status triggers immediate investigation and potential prompt/context overhaul.

## 7. Acceptance Criteria

- [ ] Every lifecycle stage has clear entry and exit criteria — no ambiguity about which stage an agent is in.
- [ ] The lifecycle supports both evolution (improving an agent) and retirement (removing an agent) cleanly.
- [ ] No agent can operate in the OS without being registered with an "Active" status.
- [ ] The quarterly review cadence is enforceable — automated reminders, not voluntary compliance.
- [ ] Agent health metrics provide early warning of performance degradation.

## 8. KPIs

| KPI | Target | Measurement |
|-----|--------|-------------|
| Agent Registry accuracy | 100% of operating agents are registered | Registry audit |
| Quarterly review completion | 100% of agents reviewed on schedule | Review log |
| Average agent health | 80%+ agents in "Healthy" across all metrics | Health dashboard |
| Agent creation time | <4 hours from proposal to active | Lifecycle tracking |
| Clean retirement rate | 100% of retirements complete dependency resolution | Retirement audit |

## 9. Risks

| Risk | Likelihood | Impact | Mitigation |
|------|-----------|--------|------------|
| Agent proliferation (too many agents for founder to manage) | Medium | Medium | Capability Matrix prevents overlap. Quarterly reviews prune. Merge underperforming agents. |
| Lifecycle process too heavy for a solo founder | Medium | Medium | CTO Agent manages lifecycle operations. Founder only approves P1 transitions (creation, retirement). |
| Shadow agents emerge (founder uses AI outside the OS) | High (initially) | Medium | Acceptable during transition. Gradually capture all AI interactions within the OS. |
| Agent review fatigue (quarterly reviews become rubber-stamp) | Medium | Low | Health metrics provide objective data. Reviews are data-driven, not subjective. |

## 10. Future Expansion

- **Self-proposing agents.** The OS detects unserved domains and proposes new agents automatically.
- **Automated evolution.** Agents that detect performance decline can trigger their own review and propose prompt updates.
- **Agent marketplace.** Retired agents from one company can be adapted for use in another company running the Agent OS.

## 11. AI Automation Opportunities

- **Lifecycle tracking.** Automated dashboard showing all agents, their current stage, health metrics, and next review date.
- **Review scheduling.** Automated quarterly review reminders with pre-generated health reports.
- **Dependency analysis.** When retirement is proposed, automatically identify all affected workflows and documents.
- **Health monitoring.** Real-time alerts when any agent metric enters Warning or Critical zones.

## 12. Open Questions

1. Should agents be able to propose their own evolution, or must all changes come from reviews?
2. What is the minimum viable agent? How simple can an agent be before it's just a prompt template?
3. How do we handle "temporary agents" — agents created for a specific project phase and then retired?

## 13. Decision History

| Date | Decision | Rationale |
|------|----------|-----------|
| 2026-06-27 | Six-stage lifecycle adopted | Proposed → Created → Active → Review → Evolved → Retired covers the full agent lifespan. |
| 2026-06-27 | Quarterly mandatory review | Prevents agent staleness. Data-driven reviews based on health metrics, not subjective assessment. |
| 2026-06-27 | Archive-don't-delete for retirement | Preserves institutional memory. Retired agents may be reactivated or referenced. |

## 14. Related Documents

| Doc ID | Title | Relationship |
|--------|-------|-------------|
| 07-001 | Agent OS Vision | OS vision that the lifecycle supports |
| 07-002 | System Architecture | Architecture within which agents operate |
| 08-002 | Agent Creation Guide | Detailed process for Stage 2 (Created) |
| 08-003 | Agent Retirement Guide | Detailed process for Stage 6 (Retired) |
| 08-004 | Agent Versioning | How versions work in Stage 5 (Evolved) |
| 08-005 | Capability Matrix | Map of all agent capabilities, updated at each lifecycle transition |
| 00-004 | AI Collaboration Protocol | Autonomy Ladder that governs agent operation in Stage 3 (Active) |
