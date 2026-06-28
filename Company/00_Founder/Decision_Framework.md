---
document_id: "00-003"
title: "Decision Framework"
owner: "Founder Agent"
status: "Approved"
version: "1.0"
created: "2026-06-27"
updated: "2026-06-27"
phase: "Phase 0 — Constitutional Layer"
priority: "P0"
tags:
  - governance
  - decisions
  - escalation
  - authority
  - process
related_documents:
  - "00-001: Founder Charter"
  - "00-002: Founder Workflow"
  - "02-001: Core Values"
  - "02-002: Design Principles"
  - "23-001: Decision Log (Phase 8)"
related_agents:
  - "Founder Agent"
  - "CEO Agent"
  - "All Agents (decision makers)"
dependencies:
  - "00-001: Founder Charter"
  - "02-001: Core Values"
---

# Decision Framework

## 1. Vision

Every company is the sum of its decisions. In an AI-native company, thousands of decisions happen daily — most made by agents without human oversight. This framework ensures those decisions are consistent, traceable, and reversible when possible.

The framework answers three questions for every decision:
1. **Who decides?** (Authority)
2. **How do they decide?** (Process)
3. **What happens after?** (Logging and review)

## 2. Problem Statement

Without a decision framework, AI agents either over-escalate (flooding the founder with trivial decisions) or under-escalate (making consequential decisions without oversight). Both failure modes are expensive:

- Over-escalation turns the founder into a bottleneck. Nothing moves without approval.
- Under-escalation allows misaligned decisions to compound until they create systemic problems.

Additionally, without decision logging, the company cannot learn from past decisions, identify patterns, or understand why the product evolved in a particular direction.

## 3. Goals

1. Classify all decisions into four priority levels with clear authority assignment.
2. Define a decision-making process for each priority level.
3. Require decision logging for P0 and P1 decisions.
4. Enable agents to make 80%+ of daily decisions autonomously.
5. Create an escalation path that is fast, clear, and non-punitive.

## 4. Non-Goals

- This framework does not define what decisions exist (those emerge from each agent's domain).
- This framework does not define the founder's schedule for reviewing decisions (see `00-002`).
- This framework is not a voting system. There is no democracy — there is authority with accountability.

## 5. Principles

1. **Reversibility determines authority level.** Easily reversible decisions can be made by any agent. Irreversible decisions require founder approval.
2. **Speed of decision beats perfection of decision.** A good decision now is better than a perfect decision next week. Decide with 70% confidence and course-correct.
3. **Disagree and commit.** Once a decision is made, all agents execute fully — even if they initially recommended a different approach. Dissent is welcome before the decision, not after.
4. **Decisions without data are hypotheses.** Label them as such. Schedule a review to validate or invalidate with evidence.
5. **Every P0/P1 decision is logged.** The Decision Log (`23_Decisions`) is the company's institutional memory.

## 6. Requirements

### 6.1 Decision Priority Levels

| Level | Name | Reversibility | Authority | Examples |
|-------|------|--------------|-----------|---------|
| **P0** | Critical | Irreversible or very expensive to reverse | Founder only | Game concept changes, monetization model, store submissions, ethical boundary decisions, engine architecture changes, business partnerships |
| **P1** | Important | Reversible but costly (days of rework) | Founder with agent recommendation | Feature scope decisions, major UI redesigns, economy balance changes, content strategy shifts, new agent creation, technology adoption |
| **P2** | Standard | Easily reversible (hours of rework) | Responsible agent autonomously | Implementation approach, bug fix strategy, content variants, prompt optimization, documentation structure, A/B test parameters |
| **P3** | Routine | Trivially reversible | Any agent | Code formatting, asset naming, documentation wording, task prioritization within sprints, test case selection |

### 6.2 Decision Process by Level

#### P0 — Critical Decision Process

```
1. Responsible Agent identifies P0 decision need
2. Agent prepares Decision Brief:
   - Problem statement (what decision is needed)
   - Options (minimum 3, with pros/cons/risks)
   - Recommendation (with reasoning)
   - Relevant data and references
   - Impact assessment (what changes if we choose each option)
   - Reversibility analysis
3. Founder Agent queues the brief as P0
4. Founder reviews in next available review block (same-day SLA)
5. Founder decides, documents rationale
6. Decision logged in 23_Decisions with full context
7. All affected agents notified and updated
```

#### P1 — Important Decision Process

```
1. Responsible Agent identifies P1 decision need
2. Agent prepares a concise decision brief:
   - Problem + 2–3 options + recommendation
   - Success metric for the recommended option
3. Founder Agent queues as P1
4. Founder reviews within 24 hours
5. Founder approves, modifies, or rejects with reasoning
6. Decision logged in 23_Decisions
7. Responsible agent executes
```

#### P2 — Standard Decision Process

```
1. Responsible Agent makes the decision
2. Agent applies relevant Core Values and Design Principles
3. Agent documents decision in their work log
4. No founder involvement unless agent is uncertain
5. Decision appears in weekly summary for founder awareness
```

#### P3 — Routine Decision Process

```
1. Agent decides and executes
2. No documentation required unless the decision sets a precedent
3. No founder involvement
```

### 6.3 Escalation Rules

An agent must escalate to the next authority level when:

| Trigger | Action |
|---------|--------|
| Decision affects player trust or safety | Escalate to P0 regardless of initial classification |
| Decision involves real money (spending, pricing, refunds) | Minimum P1 |
| Two agents disagree on a decision | Escalate one level. If still unresolved, escalate to founder. |
| Decision contradicts an existing approved document | Escalate to P1. Either the decision or the document must change. |
| Agent confidence is below 60% | Escalate one level |
| Decision creates a precedent (first time making this type of choice) | Escalate one level for the first instance. Future identical decisions at original level. |
| Impact scope exceeds agent's domain | Escalate one level and involve affected domain agents |

### 6.4 Decision Brief Template

```yaml
decision_id: "DEC-YYYY-MM-DD-NNN"
priority: "P0 | P1 | P2"
submitted_by: "Agent Name"
submitted_date: "YYYY-MM-DD"
domain: "Design | Engineering | Business | Operations"
problem: |
  One-paragraph problem statement.
options:
  - name: "Option A"
    description: "..."
    pros: ["..."]
    cons: ["..."]
    risk: "Low | Medium | High"
  - name: "Option B"
    description: "..."
    pros: ["..."]
    cons: ["..."]
    risk: "Low | Medium | High"
recommendation: "Option A"
reasoning: |
  Why this option best serves the Company Vision and Core Values.
success_metric: "How we'll know this was the right call."
reversibility: "How we undo this if it's wrong."
deadline: "When this decision must be made by."
```

### 6.5 Decision Log Requirements

Every P0 and P1 decision must be logged in `23_Decisions/` with:

- Decision ID
- Date
- Decision maker
- Priority level
- Problem statement
- Options considered
- Decision made
- Rationale
- Expected outcome
- Review date (when to check if decision was correct)
- Actual outcome (filled in at review date)

## 7. Acceptance Criteria

- [ ] Any agent can classify a decision into P0/P1/P2/P3 using the reversibility matrix without ambiguity.
- [ ] The escalation rules are mechanical — given a scenario, the correct escalation action is deterministic.
- [ ] P2/P3 decisions never reach the founder's decision queue.
- [ ] P0 decisions never skip founder review.
- [ ] Decision briefs take agents <15 minutes to prepare for P1, <30 minutes for P0.

## 8. KPIs

| KPI | Target | Measurement |
|-----|--------|-------------|
| Agent autonomous decision rate | 80%+ of all decisions are P2/P3 | Decision queue analytics |
| P0/P1 decision SLA compliance | 95%+ within SLA | Queue tracking |
| Decision log completeness | 100% of P0/P1 decisions logged | Decision log audit |
| Escalation accuracy | <10% false escalations (P2 classified as P1) | Quarterly review |
| Decision review follow-up | 90%+ of decisions reviewed at their scheduled review date | Decision log audit |

## 9. Risks

| Risk | Likelihood | Impact | Mitigation |
|------|-----------|--------|------------|
| Agents game the system by under-classifying decisions | Medium | High | Escalation triggers are explicit. Post-hoc audits catch misclassification. |
| Founder decision queue creates bottleneck | Medium | High | Workflow limits P0/P1 volume. Agent autonomy expands over time. |
| Decision log becomes stale (no one reviews past decisions) | Medium | Medium | Monthly scorecard review includes decision audit. Review dates enforced. |
| "Disagree and commit" suppresses valid dissent | Low | Medium | Dissent is recorded in the decision brief. If the decision fails, dissent is revisited. |

## 10. Future Expansion

- **Decision intelligence.** ML model that predicts decision outcomes based on historical log data.
- **Automated classification.** Agent OS automatically suggests P-level based on decision characteristics.
- **Multi-founder support.** If the team grows, the authority matrix expands to delegate P1 decisions by domain.

## 11. AI Automation Opportunities

- **Decision queue management.** Founder Agent manages queue priority, batching, and SLA tracking.
- **Decision brief generation.** Agents use the template to auto-generate structured briefs.
- **Precedent lookup.** Before making a P2 decision, agents search the Decision Log for similar past decisions.
- **Review reminders.** Automated reminders when a decision's review date arrives.
- **Pattern detection.** Identify recurring decision types that could be codified into standing policies, removing them from the queue entirely.

## 12. Open Questions

1. Should P2 decisions be logged selectively (e.g., first instance of a type, or when they set precedent)?
2. How should we handle urgent P0 decisions when the founder is in a deep work block?
3. Should there be a "P-negative" category for decisions so critical they require a cooling-off period before execution?

## 13. Decision History

| Date | Decision | Rationale |
|------|----------|-----------|
| 2026-06-27 | Four-level priority system adopted | P0–P3 provides sufficient granularity without over-complexity. Maps cleanly to reversibility. |
| 2026-06-27 | 70% confidence threshold for action | Prevents analysis paralysis. Matches Amazon's "disagree and commit" philosophy from Inspiration Atlas. |
| 2026-06-27 | Mandatory decision logging for P0/P1 | These decisions shape the company. Institutional memory requires explicit recording. |

## 14. Related Documents

| Doc ID | Title | Relationship |
|--------|-------|-------------|
| 00-001 | Founder Charter | Authority matrix that this framework operationalizes |
| 00-002 | Founder Workflow | Schedule that determines when decisions are reviewed |
| 02-001 | Core Values | First filter applied in every decision process |
| 02-002 | Design Principles | Design-specific filter for game decisions |
| 23-001 | Decision Log | Repository where all P0/P1 decisions are recorded |
