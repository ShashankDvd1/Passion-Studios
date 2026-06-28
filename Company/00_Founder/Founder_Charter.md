---
document_id: "00-001"
title: "Founder Charter"
owner: "Founder"
status: "Approved"
version: "1.0"
created: "2026-06-27"
updated: "2026-06-27"
phase: "Phase 0 — Constitutional Layer"
priority: "P0"
tags:
  - founder
  - governance
  - authority
  - operations
related_documents:
  - "00-002: Founder Workflow"
  - "00-003: Decision Framework"
  - "00-004: AI Collaboration Protocol"
  - "01-001: Company Vision"
  - "02-003: Operating Principles"
  - "02-004: Quality Standards"
related_agents:
  - "Founder Agent"
  - "CEO Agent"
  - "All Agents (governance)"
dependencies: []
---

# Founder Charter

## 1. Vision

The founder is the single human in an AI-native company. This charter defines what that means — not philosophically, but operationally. It establishes the founder's irreplaceable responsibilities, the decisions that require human judgment, and the vast surface area that AI agents own autonomously.

In a traditional studio, the founder does everything until they hire people to stop doing things. In an AI-native studio, the founder starts by defining what only a human should do — then delegates everything else to agents from day one.

The founder's role is not to produce. It is to direct, curate, and decide.

## 2. Problem Statement

Without a clear charter, the founder becomes the bottleneck for every decision, every review, every approval. The company cannot scale beyond the founder's waking hours. The AI workforce sits idle waiting for human input on decisions that don't require human judgment.

Conversely, without boundaries on AI autonomy, agents make decisions that conflict with the founder's creative vision, ethical standards, or business strategy — requiring expensive rework.

The charter solves both problems by drawing a precise line between human authority and AI autonomy.

## 3. Goals

1. Define the founder's five core responsibilities with zero ambiguity.
2. Establish a clear authority matrix — what requires founder approval, what doesn't.
3. Ensure the founder spends 80%+ of time on high-leverage activities (vision, taste, quality judgment) and less than 20% on operational throughput.
4. Create a governance model that scales — adding new agents or game projects should not increase founder workload proportionally.
5. Prevent decision paralysis by making escalation rules explicit.

## 4. Non-Goals

- This charter does not define the founder's personal schedule (see `00-002: Founder Workflow`).
- This charter does not define how decisions are made (see `00-003: Decision Framework`).
- This charter does not define AI interaction patterns (see `00-004: AI Collaboration Protocol`).
- This charter is not a job description for future human hires. It governs the founder-AI relationship specifically.

## 5. Principles

1. **The founder is the taste layer.** AI generates. The founder curates. Taste cannot be automated — it is the human competitive advantage.
2. **Authority flows from irreplaceability.** The founder holds authority over decisions that require human judgment: creative vision, ethical boundaries, player empathy, brand intuition, and publishing risk.
3. **Everything else is delegated by default.** If a task does not require human judgment, an AI agent should own it. The burden of proof is on keeping things manual, not on automating them.
4. **The founder protects the player.** No AI agent, no revenue target, and no growth metric overrides the founder's judgment about what is right for the player.
5. **Availability is not a virtue.** The founder does not need to be "always on." The system should function asynchronously, queuing decisions for founder review in batches rather than demanding real-time attention.

## 6. Requirements

### 6.1 Founder's Five Core Responsibilities

| # | Responsibility | Definition | Time Allocation |
|---|---------------|------------|-----------------|
| 1 | **Product Vision** | Set and maintain the creative direction for every product. Define what "good" looks like. Approve major feature directions. Reject what doesn't fit. | 25% |
| 2 | **Quality Judgment** | Review AI-generated code, design, art, and content. Apply human taste and player empathy that AI cannot replicate. Raise or lower the quality bar. | 30% |
| 3 | **Decision Authority** | Make P0 and P1 decisions as defined in `00-003: Decision Framework`. Resolve escalations from agents. Break ties. | 15% |
| 4 | **Testing & Player Empathy** | Play the game. Experience it as a player. Identify friction, delight, confusion, and boredom that data and agents miss. | 20% |
| 5 | **Publishing & Business** | App Store submissions, business relationships, financial decisions, legal sign-offs, public communications. | 10% |

### 6.2 Authority Matrix

| Decision Type | Authority | Founder Role |
|--------------|-----------|-------------|
| Creative vision & game direction | Founder exclusive | Decide |
| Monetization model & pricing | Founder exclusive | Decide |
| Publishing & store submissions | Founder exclusive | Execute |
| Ethical boundaries & player trust | Founder exclusive | Decide |
| Brand & public communications | Founder exclusive | Approve |
| Feature prioritization (P0/P1) | Founder with agent input | Decide |
| Architecture patterns | CTO Agent | Review on request |
| Code implementation | Programmer Agents | Review (sampling) |
| Content generation | Content Agents | Review (sampling) |
| Bug triage (P2/P3) | QA Agent | Informed |
| Documentation updates | Documentation Agent | Not involved |
| A/B test design | Analytics Agent | Approve test plan |
| A/B test results interpretation | Analytics Agent | Review insights |
| LiveOps event scheduling | LiveOps Agent | Approve calendar |
| Performance optimization | Performance Agent | Informed |
| Prompt engineering | Prompt Engineering Agent | Review standards |

### 6.3 Escalation Triggers

Agents must escalate to the founder when:

1. A decision is irreversible or expensive to reverse.
2. Two agents disagree and cannot resolve via the Decision Framework.
3. A proposed change conflicts with the Company Vision (`01-001`), Core Values (`02-001`), or Ethical Framework (`02-005`).
4. Player-facing changes affect monetization, privacy, or trust.
5. Any action involves real money (purchases, refunds, ad network changes).
6. Uncertainty exceeds the agent's defined confidence threshold.

### 6.4 Non-Escalation Rules

Agents must NOT escalate when:

1. The decision is covered by an approved design document.
2. The change is a bug fix that does not alter game behavior.
3. The decision is within the agent's documented authority.
4. The founder has previously approved a similar decision (check Decision Log in `23_Decisions`).

## 7. Acceptance Criteria

- [ ] Any agent can read this document and determine whether a specific decision requires founder involvement — without ambiguity.
- [ ] The founder's five responsibilities are mutually exclusive and collectively exhaustive (MECE).
- [ ] The authority matrix covers every decision type that will arise in the first 12 months of development.
- [ ] Escalation rules are testable: given a scenario, one can mechanically determine whether escalation is required.
- [ ] The time allocation adds to 100% and reflects realistic founder capacity.

## 8. KPIs

| KPI | Target | Measurement |
|-----|--------|-------------|
| Founder time on high-leverage activities (Vision + Quality) | ≥55% | Weekly time audit |
| Decisions bottlenecked on founder (queue > 24hrs) | <5 per week | Decision queue monitoring |
| False escalations (agent escalated unnecessarily) | <10% of escalations | Escalation review |
| Missed escalations (agent decided when should have escalated) | 0 critical, <3 minor per month | Post-decision audit |
| Founder satisfaction with AI output quality | ≥7/10 weekly average | Founder self-report |

## 9. Risks

| Risk | Likelihood | Impact | Mitigation |
|------|-----------|--------|------------|
| Founder becomes bottleneck despite charter | High (initially) | High | Decision Framework (00-003) aggressively delegates. Weekly bottleneck review. |
| Agents under-escalate to avoid delays | Medium | High | Critical path decisions require proactive founder check-ins. Audit trail. |
| Founder over-reviews, micromanages AI output | Medium | Medium | Sampling-based review (not 100% review). Trust the quality standards. |
| Charter becomes stale as company evolves | Low | Medium | Quarterly charter review. Decision History tracks amendments. |
| Single founder = single point of failure | High | Critical | Document everything. Agent OS should function for 48hrs without founder input on non-critical matters. |

## 10. Future Expansion

- **Hiring human team members.** This charter must evolve to define authority delegation to humans, not just AI. When does a human hire get decision authority? What changes?
- **Multiple game projects.** The charter must scale. The founder cannot be P0 authority on 10 games simultaneously. Portfolio-level governance rules needed.
- **Founder succession.** If the company outlives the founder's involvement, how does authority transfer? Long-term consideration.

## 11. AI Automation Opportunities

- **Decision queue management.** Founder Agent aggregates, prioritizes, and batches pending decisions for founder review.
- **Escalation routing.** Automated classification of whether a decision requires founder input based on the authority matrix.
- **Time allocation tracking.** Passive monitoring of founder activity categories against the 25/30/15/20/10 target allocation.
- **Review sampling.** Intelligent selection of AI-generated outputs for founder review — prioritize novel patterns over routine implementations.
- **Bottleneck alerts.** Automatic notification when founder decision queue exceeds thresholds.

## 12. Open Questions

1. Should the founder establish "office hours" — fixed windows when agents can expect synchronous feedback?
2. What is the founder's target weekly time commitment? 40hrs? 50hrs? This affects all time allocation math.
3. How should the charter adapt if a co-founder or CTO joins the team?

## 13. Decision History

| Date | Decision | Rationale |
|------|----------|-----------|
| 2026-06-27 | Five core responsibilities defined | MECE framework covering the irreplaceable human functions. Everything not listed is delegable. |
| 2026-06-27 | Sampling-based code review adopted | Reviewing 100% of AI-generated code is unsustainable. Quality standards + automated testing reduce the need for human review to a representative sample. |

## 14. Related Documents

| Doc ID | Title | Relationship |
|--------|-------|-------------|
| 00-002 | Founder Workflow | Operationalizes this charter into daily/weekly rhythms |
| 00-003 | Decision Framework | Defines how decisions at each authority level are actually made |
| 00-004 | AI Collaboration Protocol | Defines the interaction patterns between founder and AI agents |
| 01-001 | Company Vision | The vision this charter serves and protects |
| 02-001 | Core Values | Values that constrain all decisions, including founder's |
| 02-003 | Operating Principles | Day-to-day operational norms the founder must model |
| 02-004 | Quality Standards | The quality bar the founder enforces through review |
| 02-005 | Ethical Framework | Ethical constraints the founder is ultimate guardian of |
