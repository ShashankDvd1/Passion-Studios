---
document_id: "01-004"
title: "Success Definition"
owner: "CEO Agent"
status: "Approved"
version: "1.0"
created: "2026-06-27"
updated: "2026-06-27"
phase: "Phase 0 — Constitutional Layer"
priority: "P0"
tags:
  - metrics
  - success
  - milestones
  - north-star
  - scoreboard
related_documents:
  - "01-001: Company Vision"
  - "01-003: Competitive Advantage"
  - "15-001: Analytics Architecture (Phase 6)"
  - "20-001: Business Model (Phase 7)"
  - "22-001: Product Roadmap (Phase 8)"
related_agents:
  - "CEO Agent"
  - "Founder Agent"
  - "Analytics Agent"
  - "Product Manager Agent"
dependencies:
  - "01-001: Company Vision"
  - "01-003: Competitive Advantage"
---

# Success Definition

## 1. Vision

Success is not one number. It is a balanced scorecard across four dimensions: Product (do players love it?), Business (is it sustainable?), Technology (is the infrastructure compounding?), and Organization (is the company healthy?). Optimizing for any single dimension at the expense of others is a failure mode, not a strategy.

This document defines what "winning" looks like at each milestone of the company's life. It is the scoreboard that every agent, every sprint, and every decision references.

## 2. Problem Statement

Without a shared definition of success, different agents optimize for different outcomes. The Analytics Agent optimizes for DAU. The Monetization Agent optimizes for ARPDAU. The Game Designer Agent optimizes for session depth. The founder optimizes for "feels right."

These objectives frequently conflict. A feature that increases DAU through notification pressure reduces player trust. A monetization change that increases ARPDAU concentrates revenue in whales, increasing business risk.

The Success Definition creates a hierarchy of metrics that resolves these conflicts explicitly.

## 3. Goals

1. Define one North Star Metric that guides all other optimization.
2. Establish a balanced scorecard across four dimensions.
3. Set concrete targets at 6-month, 1-year, 3-year, and 5-year horizons.
4. Create a metric hierarchy that resolves conflicts between competing optimizations.
5. Distinguish between vanity metrics (ignore) and actionable metrics (track).

## 4. Non-Goals

- This document does not define how metrics are collected (see `15_Analytics`).
- This document does not define financial projections (see `20_Business`).
- This document does not define product milestones (see `22_Roadmap`).

## 5. Principles

1. **One North Star.** Every company needs a single metric that, if it improves, everything else follows. All other metrics serve it.
2. **Health over growth.** A healthy game that grows slowly is more valuable than a growing game that churns violently. Prioritize retention and satisfaction over acquisition.
3. **Leading indicators over lagging indicators.** Revenue is a lagging indicator. Player satisfaction, retention, and engagement quality are leading indicators that predict revenue.
4. **Measure what matters, not what's easy.** Session count is easy to measure but meaningless without session quality. Invest in measuring the hard things.

## 6. Requirements

### 6.1 North Star Metric

**North Star: Happy Retained Players (HRP)**

Definition: The number of unique players who played at least 3 sessions in the last 7 days AND whose in-session behavior indicates positive engagement (no rage-quit signals, session length within healthy range, positive interactions).

This metric combines quantity (player count), quality (positive engagement), and consistency (3+ sessions in 7 days). It cannot be gamed by inflating downloads, extending sessions through friction, or manufacturing compulsion.

**Why this, not DAU:** DAU counts players who opened the app. It includes players checking a notification and leaving. It includes players who are addicted but unhappy. HRP filters for genuine positive engagement.

**Why this, not Revenue:** Revenue follows HRP. Revenue can also increase through exploitation, which we explicitly prohibit. HRP only goes up when we create genuine value.

### 6.2 Balanced Scorecard

#### Product Dimension — "Do players love it?"

| Metric | Definition | 6mo | 1yr | 3yr | 5yr |
|--------|-----------|-----|-----|-----|-----|
| HRP (North Star) | Active, positively engaged players (7-day) | 10K | 50K | 500K | 2M+ |
| D1 Retention | % of new players returning day after install | 40% | 45% | 50% | 55% |
| D7 Retention | % returning after 7 days | 20% | 25% | 30% | 35% |
| D30 Retention | % returning after 30 days | 8% | 12% | 15% | 20% |
| App Store Rating | Average across iOS + Android | 4.3+ | 4.5+ | 4.6+ | 4.7+ |
| NPS (Net Promoter Score) | Player willingness to recommend | 30+ | 40+ | 50+ | 60+ |

#### Business Dimension — "Is it sustainable?"

| Metric | Definition | 6mo | 1yr | 3yr | 5yr |
|--------|-----------|-----|-----|-----|-----|
| Monthly Revenue (portfolio) | Gross revenue across all titles | $5K | $30K | $300K | $1M+ |
| LTV / CPI Ratio | Lifetime value divided by cost per install | 1.5x | 2.5x | 4x | 5x+ |
| Revenue Diversification | % from non-top-1% spenders | 50%+ | 55%+ | 60%+ | 65%+ |
| Organic Install Rate | % of installs not from paid channels | 40%+ | 50%+ | 60%+ | 70%+ |
| Monthly Burn Rate | Total operating costs | Minimal | <$5K | <$20K | <$50K |

#### Technology Dimension — "Is the infrastructure compounding?"

| Metric | Definition | 6mo | 1yr | 3yr | 5yr |
|--------|-----------|-----|-----|-----|-----|
| Code Reuse Rate | % of codebase shared across titles | — | 60%+ | 80%+ | 85%+ |
| Time to New Game Prototype | Days from concept to playable prototype | — | 30 days | 14 days | 7 days |
| AI Generation Ratio | % of code/content generated by AI | 50% | 65% | 80% | 85% |
| Engine Module Count | Reusable modules in the Tiny World Engine | 10 | 25 | 50 | 75+ |
| Critical Bug Rate | P0/P1 bugs per release | <5 | <3 | <2 | <1 |

#### Organization Dimension — "Is the company healthy?"

| Metric | Definition | 6mo | 1yr | 3yr | 5yr |
|--------|-----------|-----|-----|-----|-----|
| Founder Bottleneck Score | % of decisions waiting >24hrs on founder | <20% | <10% | <5% | <3% |
| Agent Autonomy Rate | % of decisions agents make without escalation | 60% | 75% | 85% | 90% |
| Documentation Coverage | % of systems with current documentation | 80% | 90% | 95% | 98% |
| Decision Log Compliance | % of P0/P1 decisions logged with rationale | 90% | 95% | 98% | 100% |
| Games in Active Development | Concurrent titles in production | 1 | 1–2 | 2–3 | 3–5 |

### 6.3 Metric Hierarchy (Conflict Resolution)

When metrics conflict, resolve in this order:

1. **Player Trust** (Ethical Framework compliance) — non-negotiable floor
2. **HRP** (North Star) — the number we optimize
3. **Retention** (D1/D7/D30) — leading indicator of HRP
4. **NPS / Player Satisfaction** — qualitative complement to retention
5. **Revenue** — follows from 1–4 if they are healthy
6. **Growth** (DAU, installs) — follows from 1–5 if they are healthy

Example: If a feature increases DAU by 20% but decreases D7 retention by 5%, it is rejected. Retention outranks growth in the hierarchy.

### 6.4 Vanity Metrics (Do Not Optimize)

| Metric | Why It's Vanity |
|--------|----------------|
| Total Downloads | Counts every install, including churned users who never returned. Easily inflated by paid acquisition. |
| Total Registered Users | Cumulative and ever-increasing. Reveals nothing about current health. |
| Daily Session Count | A player opening the app 10x/day for 15 seconds each is not positive engagement. |
| Social Media Followers | Does not correlate with revenue or retention. |
| Time in App (without quality signal) | Long sessions from frustration look identical to long sessions from joy. |

## 7. Acceptance Criteria

- [ ] Every agent can look up the current target for any metric and determine whether the company is on track.
- [ ] The metric hierarchy resolves any conflict between two competing metrics without founder intervention.
- [ ] No vanity metric appears in any dashboard, report, or agent KPI.
- [ ] Targets are ambitious but achievable — not aspirational fiction.
- [ ] The North Star Metric (HRP) cannot increase through player exploitation.

## 8. KPIs

This document defines KPIs for the company. Its own KPIs are meta:

| KPI | Target | Measurement |
|-----|--------|-------------|
| Metric tracking coverage | 100% of scorecard metrics actively tracked | Analytics audit |
| Metric freshness | All dashboards updated within 24hrs | System monitoring |
| Target review cadence | Quarterly target reassessment | Calendar |
| Metric hierarchy invocation | Used in 100% of metric conflict resolutions | Decision log |

## 9. Risks

| Risk | Likelihood | Impact | Mitigation |
|------|-----------|--------|------------|
| Revenue targets too conservative | Medium | Low | Conservative targets protect against over-monetization pressure. Revise upward only with data. |
| HRP is difficult to measure reliably | Medium | Medium | Start with proxy metrics (D7 active + session quality signals). Refine as analytics mature. |
| Metric fixation — optimizing for numbers instead of player experience | Medium | High | NPS and qualitative feedback (player reviews, support tickets) serve as a check against metric tunnel vision. |
| Targets based on assumptions, not data, for Year 1 | High | Medium | All Year 1 targets are "informed guesses." Recalibrate after 3 months of real data. |

## 10. Future Expansion

- **Portfolio-level scorecard.** As multiple games ship, add portfolio aggregation: total portfolio HRP, revenue, cross-game retention.
- **Investor-ready dashboards.** If/when external funding is pursued, the scorecard translates directly to investor reporting.
- **Predictive modeling.** Use historical data to build predictive models for new game performance based on early metrics.

## 11. AI Automation Opportunities

- **Automated scorecard reporting.** Analytics Agent generates weekly/monthly scorecard reports with trend analysis.
- **Anomaly detection.** Flag metric movements that deviate significantly from trends (both positive and negative).
- **Metric conflict detection.** Alert when two tracked metrics move in opposite directions, suggesting a trade-off that requires human judgment.
- **Target recalibration.** After each quarter, suggest revised targets based on actual performance data.

## 12. Open Questions

1. Is HRP the right North Star, or should we consider a simpler metric like "weekly active players who rate their experience 4+/5"?
2. What revenue model assumption underlies the business targets? (Current targets assume hybrid IAP + Ads.)
3. At what HRP threshold do we consider Game #1 "validated" and green-light Game #2?

## 13. Decision History

| Date | Decision | Rationale |
|------|----------|-----------|
| 2026-06-27 | HRP selected as North Star Metric | Combines quantity, quality, and consistency. Resistant to exploitation-driven inflation. |
| 2026-06-27 | Four-dimension scorecard adopted | Product/Business/Technology/Organization ensures balanced optimization. |
| 2026-06-27 | Revenue ranked 5th in metric hierarchy | Revenue is an output of player trust + engagement, not an input. Optimizing revenue directly risks ethical violations. |

## 14. Related Documents

| Doc ID | Title | Relationship |
|--------|-------|-------------|
| 01-001 | Company Vision | KPI targets map to vision timeline |
| 01-003 | Competitive Advantage | Advantage strength measured through technology and organization metrics |
| 02-005 | Ethical Framework | Trust metrics and spending distribution enforce ethical compliance |
| 15-001 | Analytics Architecture | Technical implementation of metric tracking |
| 20-001 | Business Model | Financial projections built on business dimension targets |
| 22-001 | Product Roadmap | Milestone gates tied to metric thresholds |
