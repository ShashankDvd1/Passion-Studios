---
document_id: "00-002"
title: "Founder Workflow"
owner: "Founder Agent"
status: "Approved"
version: "1.0"
created: "2026-06-27"
updated: "2026-06-27"
phase: "Phase 0 — Constitutional Layer"
priority: "P0"
tags:
  - founder
  - workflow
  - operations
  - cadence
  - time-management
related_documents:
  - "00-001: Founder Charter"
  - "00-003: Decision Framework"
  - "00-004: AI Collaboration Protocol"
  - "02-003: Operating Principles"
  - "07-001: Agent OS Architecture (Phase 1)"
related_agents:
  - "Founder Agent"
  - "CEO Agent"
  - "All Agents (asynchronous handoffs)"
dependencies:
  - "00-001: Founder Charter"
---

# Founder Workflow

## 1. Vision

This document operationalizes the Founder Charter (`00-001`) into a concrete daily, weekly, and monthly rhythm. It defines when the founder does what, how AI agents queue work for founder review, and how the operating cadence scales as the company ships more games.

The founder is a single human in an AI-native company. Time is the scarcest resource. Every minute must be allocated to the highest-leverage activity available. This workflow ensures that the founder's time creates maximum impact — and that the AI workforce never blocks on founder availability for more than 24 hours on any non-critical matter.

## 2. Problem Statement

Without a defined workflow, the founder oscillates between reactive firefighting and unfocused exploration. AI agents generate work faster than a single human can review, creating an ever-growing backlog. The founder feels perpetually behind, leading to shortcuts (rubber-stamping reviews) or bottlenecks (agents idle while waiting).

A structured workflow creates predictability. Agents know when to expect founder attention. The founder knows what to focus on each day. Both sides operate with confidence.

## 3. Goals

1. Define a daily operating rhythm that maximizes founder impact within a sustainable time commitment.
2. Establish weekly and monthly rituals for strategic work that daily operations crowd out.
3. Create clear "office hours" windows so agents can batch decisions for founder review.
4. Ensure the system degrades gracefully when the founder is unavailable (illness, travel, breaks).

## 4. Non-Goals

- This document does not define what the founder decides (see `00-003: Decision Framework`).
- This document does not define how AI agents are managed (see `00-004: AI Collaboration Protocol`).
- This document is not a personal productivity system. It is an organizational interface specification.

## 5. Principles

1. **Energy management over time management.** Schedule high-judgment work (vision, quality review) for peak energy. Schedule routine work (approvals, admin) for low energy.
2. **Batch over interrupt.** Decision queues, not Slack pings. The founder reviews batched decisions twice daily, not on-demand.
3. **Sustainable pace.** The workflow must be maintainable for years, not sprints. Burnout kills companies faster than competition.
4. **Graceful degradation.** If the founder disappears for 48 hours, only P0 decisions should be blocked. Everything else continues.

## 6. Requirements

### 6.1 Daily Rhythm (Target: 5–6 focused hours)

| Time Block | Activity | Charter Responsibility | Duration |
|-----------|----------|----------------------|----------|
| **Morning Review** | Review overnight agent outputs. Decision queue (batch 1). Read analytics summary. Approve/reject queued items. | Quality Judgment + Decision Authority | 60–90 min |
| **Deep Work** | Play the game (testing). Creative direction work. Feature ideation. Design reviews. This is the founder's highest-leverage block. | Testing & Player Empathy + Product Vision | 120–150 min |
| **Afternoon Review** | Decision queue (batch 2). Code review (sampling). Content review (sampling). Respond to escalations. | Quality Judgment + Decision Authority | 60–90 min |
| **Strategic Block** | One strategic task per day: business development, market research, roadmap planning, documentation review. | Publishing & Business | 30–60 min |
| **End of Day** | Update task status. Queue tomorrow's priorities for Founder Agent. Log any decisions made outside the formal process. | — | 15 min |

**Total: ~5–6 hours of focused work per day.**

Remaining hours are unstructured — available for overflow, deep thinking, or rest.

### 6.2 Weekly Rituals

| Day | Ritual | Purpose | Duration |
|-----|--------|---------|----------|
| Monday | **Weekly Planning** | Set the week's top 3 priorities. Review last week's metrics. Align agent objectives. | 60 min |
| Wednesday | **Deep Game Session** | Extended playtesting session. Experience the game as a player, not as a developer. Take notes on feelings, friction, delight. | 90 min |
| Friday | **Weekly Retro & Review** | Review what shipped. Review what didn't. Identify bottlenecks. Update Decision Log. Quality audit (sample AI outputs from the week). | 60 min |

### 6.3 Monthly Rituals

| Ritual | Purpose | Duration |
|--------|---------|----------|
| **Scorecard Review** | Review all KPIs from Success Definition (`01-004`). Compare to targets. Identify trends. Adjust priorities. | 2 hours |
| **Architecture Review** | Review technical debt, engine module health, and reuse metrics with CTO Agent. | 90 min |
| **Competitor Scan** | Review Research Agent's monthly competitive intelligence report. Update Inspiration Atlas if needed. | 60 min |
| **Documentation Audit** | Spot-check 5 random documents for staleness, accuracy, and cross-reference integrity. | 45 min |
| **Values & Vision Check** | Re-read Company Vision and Core Values. Ask: "Are we still on track? Has anything drifted?" | 30 min |

### 6.4 Decision Queue Protocol

Agents do not interrupt the founder. They submit to the decision queue.

| Priority | SLA | Handling |
|----------|-----|---------|
| **P0 — Critical** | Same-day response | Flagged with push notification. Founder reviews in next available review block. |
| **P1 — Important** | 24-hour response | Queued for next review block. |
| **P2 — Standard** | 48-hour response | Queued. Founder may delegate back to agent with guidelines. |
| **P3 — Informational** | Acknowledged within 72 hours | Founder reads for awareness. No action required. |

If the decision queue exceeds 15 items, the Founder Agent triages and defers P2/P3 items.

### 6.5 Unavailability Protocol

When the founder is unavailable (planned or unplanned):

| Duration | Protocol |
|----------|----------|
| **<24 hours** | Normal operations. P2/P3 decisions auto-deferred. P1 queued. P0 only if truly critical. |
| **24–48 hours** | CEO Agent assumes P1 decision authority using the Decision Framework. P0 decisions queued unless they risk data loss or player harm. |
| **48–72 hours** | All non-critical development continues. No new features enter development. Bug fixes and content updates proceed. |
| **>72 hours** | Development enters "maintenance mode." Only critical bug fixes and scheduled LiveOps events execute. |

## 7. Acceptance Criteria

- [ ] The daily rhythm fits within 6 hours maximum — sustainable long-term.
- [ ] Every block maps to a Founder Charter responsibility.
- [ ] The decision queue SLAs are achievable given the daily rhythm.
- [ ] The unavailability protocol keeps the company operational for up to 72 hours without founder input.
- [ ] An AI agent (Founder Agent) can manage the queue, schedule, and reminders without founder configuration each day.

## 8. KPIs

| KPI | Target | Measurement |
|-----|--------|-------------|
| Daily workflow adherence | 80%+ of days follow the rhythm | Founder self-report (weekly retro) |
| Decision queue SLA compliance | 95%+ of decisions within SLA | Queue analytics |
| Weekly ritual completion | 100% of weekly rituals completed | Calendar audit |
| Monthly ritual completion | 100% of monthly rituals completed | Calendar audit |
| Founder satisfaction with time allocation | ≥7/10 weekly average | Self-report |

## 9. Risks

| Risk | Likelihood | Impact | Mitigation |
|------|-----------|--------|------------|
| Workflow too rigid, founder ignores it | Medium | Medium | Workflow is a guide, not a prison. Flexibility within blocks. Quarterly adjustment. |
| Review blocks insufficient as company scales | High (by Year 2) | Medium | As game count grows, review blocks must expand or quality standards must enable more agent autonomy. |
| Founder works more than 6 hours, approaching burnout | Medium | High | Hard stop discipline. Sustainable pace is non-negotiable. Track hours weekly. |
| Decision queue overwhelmed with low-priority items | Medium | Low | Founder Agent pre-filters. P3 items auto-acknowledged after 72 hours. |

## 10. Future Expansion

- **Co-founder integration.** If a co-founder joins, split the daily rhythm by domain (product vs. technical) with shared weekly rituals.
- **Multi-game workflow.** Allocate different days to different games (Game #1 = Mon/Wed, Game #2 = Tue/Thu, Fridays = portfolio-level).
- **Delegation ladder.** As trust in agents grows, move P1 decisions to agent authority, leaving founder with only P0.

## 11. AI Automation Opportunities

- **Founder Agent daily brief.** Auto-generated morning summary: overnight events, queue status, key metrics, today's priorities.
- **Calendar management.** Founder Agent maintains the ritual calendar and sends reminders.
- **Queue analytics.** Automated tracking of queue depth, SLA compliance, and decision patterns.
- **Workload prediction.** Forecast tomorrow's review load based on current agent activity and pipeline.

## 12. Open Questions

1. What is the founder's preferred working schedule? (Morning person? Night owl? Split day?)
2. Should weekends be fully off, or is a light Sunday evening planning session acceptable?
3. What communication channels will the founder monitor? (Just the decision queue? Email? Discord?)

## 13. Decision History

| Date | Decision | Rationale |
|------|----------|-----------|
| 2026-06-27 | 5–6 hour daily target adopted | Sustainable pace for a solo founder. Allows for deep work without exhaustion. |
| 2026-06-27 | Twice-daily batch review model | Prevents interrupt-driven workflow. Gives agents predictable response windows. |
| 2026-06-27 | 72-hour maximum unavailability before maintenance mode | Balances founder wellbeing with company continuity. |

## 14. Related Documents

| Doc ID | Title | Relationship |
|--------|-------|-------------|
| 00-001 | Founder Charter | Responsibilities this workflow operationalizes |
| 00-003 | Decision Framework | Decision process executed during review blocks |
| 00-004 | AI Collaboration Protocol | Interaction patterns for founder-agent communication |
| 02-003 | Operating Principles | Principles the founder models through this workflow |
| 07-001 | Agent OS Architecture | System that manages the decision queue and agent coordination |
