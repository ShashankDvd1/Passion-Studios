---
document_id: "07-007"
title: "Performance Dashboard"
owner: "Analytics Agent"
status: "Approved"
version: "1.0"
created: "2026-06-27"
updated: "2026-06-27"
phase: "Phase 1 — Agent Operating System"
priority: "P1"
tags:
  - monitoring
  - metrics
  - dashboard
  - observability
related_documents:
  - "07-001: Agent OS Vision"
  - "07-003: Agent Registry"
  - "08-001: Agent Lifecycle"
  - "07-006: Error Recovery"
  - "01-004: Success Definition"
related_agents:
  - "Analytics Agent"
  - "Founder Agent"
  - "Automation Agent"
dependencies:
  - "07-001: Agent OS Vision"
  - "07-003: Agent Registry"
---

# Performance Dashboard

## 1. Vision

The founder needs a single-page view of the entire Agent OS health — agent performance, workflow throughput, decision queue status, memory health, and quality metrics. The Performance Dashboard is that view. It answers: "Is the system healthy?" in under 60 seconds.

## 2. Problem Statement

Without a dashboard, the founder must manually check each subsystem to assess OS health. With 28+ agents, 14+ workflows, and multiple memory layers, this is unscalable. Problems go undetected until they cause visible failures.

## 3. Goals

1. Define all metrics displayed on the dashboard.
2. Organize metrics into categories for fast scanning.
3. Define health thresholds (green/yellow/red) for each metric.
4. Enable the founder to assess OS health in under 60 seconds.

## 4. Non-Goals

- This does not define game analytics dashboards (future `15_Analytics`).
- This does not define business dashboards (future `20_Business`).

## 5. Principles

1. **Glanceable.** The most critical metrics are visible without scrolling or clicking.
2. **Actionable.** Every yellow/red metric has an associated action or document.
3. **Trend-aware.** Show direction (improving/declining), not just current state.

## 6. Requirements

### 6.1 Dashboard Sections

#### Section 1: System Health (Top-Level)

| Metric | Green | Yellow | Red |
|--------|-------|--------|-----|
| Overall OS Status | All subsystems healthy | 1-2 subsystems degraded | 3+ subsystems degraded or Safe Mode |
| Active Agents | All registered agents responsive | 1-2 agents in Warning health | Any agent in Critical health |
| Workflow Throughput | Tasks completing within SLA | 10-20% SLA misses | >20% SLA misses |
| Decision Queue Depth | <10 items | 10-20 items | >20 items |
| Error Rate (24hr) | <5 failures | 5-15 failures | >15 failures or any F7/F8 |

#### Section 2: Agent Performance

| Metric | Per Agent | Green | Yellow | Red |
|--------|-----------|-------|--------|-----|
| Approval Rate | First-pass approval % | >70% | 50-70% | <50% |
| Revision Rate | Outputs needing revision | <20% | 20-35% | >35% |
| Reject Rate | Outputs rejected entirely | <5% | 5-15% | >15% |
| Autonomy Level | Current L1-L4 | L2+ (after 30 days) | L1 (after 30 days) | L1 (after 90 days) |
| Task Completion | Within SLA | >90% | 75-90% | <75% |

#### Section 3: Workflow Status

| Metric | Green | Yellow | Red |
|--------|-------|--------|-----|
| Active Workflows | All progressing | 1-2 stalled | 3+ stalled |
| Average Completion Time | Within historical average | 1.5x historical | >2x historical |
| Founder Blocked | 0 workflows waiting >24hr on founder | 1-2 blocked | 3+ blocked |
| Quality Gate Pass Rate | >80% first-pass | 60-80% | <60% |

#### Section 4: Memory & Knowledge

| Metric | Green | Yellow | Red |
|--------|-------|--------|-----|
| Memory Query Relevance | >80% relevant results | 60-80% | <60% |
| Documentation Freshness | >95% current (<7 days) | 85-95% | <85% |
| Cross-Reference Integrity | 0 broken references | 1-5 broken | >5 broken |

#### Section 5: Governance

| Metric | Green | Yellow | Red |
|--------|-------|--------|-----|
| Decision SLA Compliance | >95% | 85-95% | <85% |
| Decision Log Completeness | 100% P0/P1 logged | 90-99% | <90% |
| Escalation Accuracy | <10% false escalations | 10-20% | >20% |

### 6.2 Dashboard Update Frequency

| Section | Update Frequency |
|---------|-----------------|
| System Health | Real-time (on each event) |
| Agent Performance | Daily rollup |
| Workflow Status | Real-time |
| Memory & Knowledge | Weekly audit |
| Governance | Daily rollup |

### 6.3 Alert System

| Alert Level | Trigger | Action |
|-------------|---------|--------|
| **Info** | Any metric moves from Green to Yellow | Logged. Included in daily brief. |
| **Warning** | Any metric stays Yellow for 48+ hours | Flagged in decision queue as P2. |
| **Critical** | Any metric enters Red | Flagged in decision queue as P1. Immediate investigation. |
| **Emergency** | Safe Mode activated | P0 notification to founder. All non-critical work paused. |

## 7. Acceptance Criteria

- [ ] The founder can assess overall OS health in under 60 seconds from the dashboard.
- [ ] Every metric has green/yellow/red thresholds that are objectively measurable.
- [ ] Alerts route to the decision queue at appropriate priority levels.
- [ ] The dashboard covers all 5 OS subsystem categories.

## 8. KPIs

| KPI | Target | Measurement |
|-----|--------|-------------|
| Dashboard review time | <60 seconds for full scan | Founder feedback |
| Alert accuracy | >90% of alerts are actionable | Alert review |
| Green status across all metrics | 80%+ of metrics green on any given day | Dashboard data |

## 9. Risks

| Risk | Likelihood | Impact | Mitigation |
|------|-----------|--------|------------|
| Dashboard overload (too many metrics) | Medium | Medium | Five sections with 3-5 metrics each. Hierarchy: system → agents → workflows → memory → governance. |
| Thresholds set wrong (too sensitive or too lax) | High | Low | Calibrate thresholds monthly based on actual data. Start conservative. |

## 10. Future Expansion

- **Visual dashboard.** Implement as a web-based real-time dashboard when the OS becomes code-based.
- **Predictive health.** Use trend data to predict future metric states.
- **Comparative dashboards.** Compare OS performance across different game projects.

## 11. AI Automation Opportunities

- **Automated daily brief.** Founder Agent generates a morning dashboard summary with highlights and action items.
- **Anomaly detection.** Flag unusual metric patterns before they cross thresholds.
- **Root cause linking.** When a metric goes yellow/red, automatically link to likely failure log entries.

## 12. Open Questions

1. Should the dashboard be a markdown document updated daily, or a live system?
2. Should agents see the dashboard (for self-awareness), or only the founder?

## 13. Decision History

| Date | Decision | Rationale |
|------|----------|-----------|
| 2026-06-27 | Five-section dashboard structure | Covers system, agents, workflows, memory, governance. MECE without overload. |
| 2026-06-27 | Green/Yellow/Red threshold system | Universal, glanceable, actionable. Maps to alert severity. |

## 14. Related Documents

| Doc ID | Title | Relationship |
|--------|-------|-------------|
| 07-001 | Agent OS Vision | Vision for observable operations |
| 07-003 | Agent Registry | Source of agent status data |
| 07-006 | Error Recovery | Failure data feeds into dashboard |
| 08-001 | Agent Lifecycle | Agent health metrics displayed here |
| 01-004 | Success Definition | Company KPIs complement OS metrics |
