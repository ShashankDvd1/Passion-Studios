---
document_id: "07-003"
title: "Agent Registry"
owner: "CTO Agent"
status: "Approved"
version: "1.0"
created: "2026-06-27"
updated: "2026-06-27"
phase: "Phase 1 — Agent Operating System"
priority: "P0"
tags:
  - agents
  - registry
  - catalog
  - capabilities
  - status
related_documents:
  - "07-001: Agent OS Vision"
  - "07-002: System Architecture"
  - "08-001: Agent Lifecycle"
  - "08-005: Capability Matrix"
  - "09-001 through 09-028: Individual Agent Definitions"
related_agents:
  - "CTO Agent"
  - "Founder Agent"
  - "Documentation Agent"
dependencies:
  - "07-001: Agent OS Vision"
  - "08-001: Agent Lifecycle"
---

# Agent Registry

## 1. Vision

The Agent Registry is the single source of truth for every agent in the Agent OS. It answers: What agents exist? What is each agent's status? What does each agent do? Who does each agent report to? Where is each agent's full definition?

No agent operates outside the Registry. If it is not listed here with "Active" status, it does not exist in the system.

## 2. Problem Statement

Without a central registry, agents are invisible. The founder cannot determine how many agents exist, which are active, or whether two agents overlap in responsibility. Workflows reference agents that may have been retired. New agents are created without checking for duplicates. The OS becomes opaque.

## 3. Goals

1. Catalog all 28 initial agents with essential metadata.
2. Provide a single-page view of the entire AI workforce.
3. Enable fast lookup: given a task type, find the responsible agent.
4. Track lifecycle status for every agent.
5. Detect capability gaps and overlaps.

## 4. Non-Goals

- This document does not contain full agent definitions (those live in `09_Agent_Definitions/`).
- This document does not define agent capabilities in detail (see `08-005: Capability Matrix`).

## 5. Principles

1. **Registry is authoritative.** Any conflict between the Registry and an individual agent definition is resolved in favor of the Registry.
2. **Always current.** The Registry is updated within 24 hours of any agent lifecycle transition.
3. **Minimal but complete.** The Registry contains only essential metadata — full details live in individual agent definitions.

## 6. Requirements

### 6.1 Registry Schema

Each agent entry contains:

```yaml
agent_id: "09-NNN"
name: "Agent Name"
status: "Active | Created | Review | Retired"
version: "X.Y"
domain: "Product | Engineering | Business | Operations | Creative"
mission: "One-sentence mission statement"
owner: "Who manages this agent's lifecycle"
autonomy_level: "1-Supervised | 2-Guided | 3-Trusted | 4-Autonomous"
definition_path: "09_Agent_Definitions/Agent_Name.md"
created_date: "YYYY-MM-DD"
last_review: "YYYY-MM-DD"
next_review: "YYYY-MM-DD"
```

### 6.2 Complete Agent Registry

#### Leadership Agents

| ID | Agent | Domain | Mission | Status | Autonomy |
|----|-------|--------|---------|--------|----------|
| 09-001 | **Founder Agent** | Operations | Manage the founder's decision queue, schedule, and information flow | Active | L2 |
| 09-002 | **CEO Agent** | Business | Strategic oversight, company-level decisions, stakeholder management | Active | L2 |

#### Product Agents

| ID | Agent | Domain | Mission | Status | Autonomy |
|----|-------|--------|---------|--------|----------|
| 09-003 | **Product Manager Agent** | Product | Own feature lifecycle from ideation through measurement | Active | L1 |
| 09-004 | **Game Designer Agent** | Product | Design game systems, mechanics, and player experiences | Active | L1 |
| 09-005 | **Behavioral Psychology Agent** | Product | Apply behavioral science to engagement and retention design | Active | L1 |
| 09-006 | **UX Agent** | Product | Design player-facing interactions, flows, and accessibility | Active | L1 |
| 09-012 | **Economy Agent** | Product | Design and balance game economies, currencies, and resource flows | Active | L1 |

#### Engineering Agents

| ID | Agent | Domain | Mission | Status | Autonomy |
|----|-------|--------|---------|--------|----------|
| 09-007 | **Unity Architect Agent** | Engineering | Design engine architecture, patterns, and technical standards | Active | L1 |
| 09-008 | **Gameplay Programmer Agent** | Engineering | Implement game features, mechanics, and systems in Unity/C# | Active | L1 |
| 09-009 | **Backend Agent** | Engineering | Design and manage Firebase, UGS, and server-side systems | Active | L1 |
| 09-021 | **Security Agent** | Engineering | Ensure data security, anti-cheat, and platform compliance | Active | L1 |
| 09-022 | **Performance Agent** | Engineering | Monitor and optimize runtime performance, memory, and battery | Active | L1 |
| 09-023 | **Code Review Agent** | Engineering | Review AI-generated code for quality, patterns, and standards | Active | L2 |

#### Creative Agents

| ID | Agent | Domain | Mission | Status | Autonomy |
|----|-------|--------|---------|--------|----------|
| 09-016 | **Content Creator Agent** | Creative | Generate game content: text, descriptions, narratives, events | Active | L1 |
| 09-017 | **Art Director Agent** | Creative | Define and enforce visual identity, art pipeline, and asset standards | Active | L1 |
| 09-018 | **UI Agent** | Creative | Design and implement user interface systems and screens | Active | L1 |
| 09-019 | **Audio Agent** | Creative | Design sound, music, and audio systems | Active | L1 |

#### Business Agents

| ID | Agent | Domain | Mission | Status | Autonomy |
|----|-------|--------|---------|--------|----------|
| 09-010 | **LiveOps Agent** | Business | Plan and execute live events, seasonal content, daily operations | Active | L1 |
| 09-011 | **Analytics Agent** | Business | Design analytics architecture, track KPIs, generate insights | Active | L1 |
| 09-013 | **Monetization Agent** | Business | Design ethical monetization within the Ethical Framework | Active | L1 |
| 09-014 | **Marketing Agent** | Business | Plan marketing strategy, community, and user acquisition | Active | L1 |
| 09-015 | **ASO Agent** | Business | Optimize app store presence, keywords, screenshots, and listings | Active | L1 |

#### Operations Agents

| ID | Agent | Domain | Mission | Status | Autonomy |
|----|-------|--------|---------|--------|----------|
| 09-020 | **QA Agent** | Operations | Design test strategies, manage quality gates, validate releases | Active | L1 |
| 09-024 | **Prompt Engineering Agent** | Operations | Maintain and optimize the prompt library and engineering standards | Active | L2 |
| 09-025 | **Research Agent** | Operations | Conduct market research, competitive analysis, and technology scouting | Active | L1 |
| 09-026 | **Automation Agent** | Operations | Identify and implement automation opportunities across all domains | Active | L2 |
| 09-027 | **Documentation Agent** | Operations | Maintain documentation integrity, freshness, and cross-references | Active | L2 |
| 09-028 | **Innovation Agent** | Operations | Explore new technologies, game concepts, and business model experiments | Active | L1 |

### 6.3 Registry Statistics

| Metric | Value |
|--------|-------|
| Total Agents | 28 |
| Active | 28 |
| Retired | 0 |
| Leadership Domain | 2 |
| Product Domain | 5 |
| Engineering Domain | 6 |
| Creative Domain | 4 |
| Business Domain | 5 |
| Operations Domain | 6 |
| Level 1 (Supervised) | 22 |
| Level 2 (Guided) | 6 |
| Level 3 (Trusted) | 0 |
| Level 4 (Autonomous) | 0 |

### 6.4 Domain Responsibility Map

```
┌─────────────────────────────────────────────────────────────┐
│                     FOUNDER (Human)                          │
│         Product Vision │ Quality │ Decisions │ Testing       │
└──────────────────┬──────────────────────────┬───────────────┘
                   │                          │
    ┌──────────────▼──────┐     ┌────────────▼────────────┐
    │    LEADERSHIP        │     │      OPERATIONS          │
    │  Founder Agent       │     │  QA Agent                │
    │  CEO Agent           │     │  Prompt Engineering      │
    └──────────┬───────────┘     │  Research Agent          │
               │                 │  Automation Agent        │
    ┌──────────▼──────┐          │  Documentation Agent     │
    │    PRODUCT       │         │  Innovation Agent        │
    │  Product Manager │         └──────────────────────────┘
    │  Game Designer   │
    │  Behav. Psych    │    ┌──────────────────────────────┐
    │  UX Agent        │    │      ENGINEERING              │
    │  Economy Agent   │    │  Unity Architect              │
    └──────────────────┘    │  Gameplay Programmer          │
                            │  Backend Agent                │
    ┌──────────────────┐    │  Security Agent               │
    │    CREATIVE       │    │  Performance Agent            │
    │  Content Creator │    │  Code Review Agent            │
    │  Art Director    │    └──────────────────────────────┘
    │  UI Agent        │
    │  Audio Agent     │    ┌──────────────────────────────┐
    └──────────────────┘    │      BUSINESS                 │
                            │  LiveOps Agent                │
                            │  Analytics Agent              │
                            │  Monetization Agent           │
                            │  Marketing Agent              │
                            │  ASO Agent                    │
                            └──────────────────────────────┘
```

## 7. Acceptance Criteria

- [ ] Every agent in the OS has an entry in the Registry with all schema fields populated.
- [ ] Given a task description, the Registry enables identification of the responsible agent within 30 seconds.
- [ ] No two agents have overlapping primary missions.
- [ ] The Registry reflects the current lifecycle status of every agent.
- [ ] Registry statistics are accurate and updated at every lifecycle transition.

## 8. KPIs

| KPI | Target | Measurement |
|-----|--------|-------------|
| Registry accuracy | 100% match with actual agent definitions | Monthly audit |
| Update latency | <24 hours after any lifecycle transition | Transition log |
| Capability gap detection | 0 unserved domains | Quarterly capability review |
| Duplicate detection | 0 overlapping agent missions | Mission statement comparison |

## 9. Risks

| Risk | Likelihood | Impact | Mitigation |
|------|-----------|--------|------------|
| Registry drifts from reality | Medium | High | Documentation Agent maintains. Automated cross-check against `09_Agent_Definitions/`. |
| Too many agents for founder to track | Low (currently) | Medium | Domain grouping provides manageable clusters. Founder interacts with domains, not individual agents. |
| Agent ID conflicts as agents are added/retired | Low | Low | Sequential numbering with gaps (retired IDs are not reused). |

## 10. Future Expansion

- **Dynamic registry.** Machine-readable registry (YAML/JSON) that agents can query programmatically.
- **Agent marketplace.** Browse and install pre-built agent definitions from a community library.
- **Multi-project views.** Filter the registry by project to see which agents are active on which game.

## 11. AI Automation Opportunities

- **Registry maintenance.** Documentation Agent automatically updates the Registry when agent definitions change.
- **Gap analysis.** Quarterly automated scan for unserved workflow steps that need agent assignment.
- **Health aggregation.** Pull health metrics from all agents into a single dashboard view.

## 12. Open Questions

1. Should agent IDs be globally unique across all OS installations (for future licensing)?
2. Should the Registry include performance history summary, or only current status?
3. How do we handle agents that serve multiple domains equally?

## 13. Decision History

| Date | Decision | Rationale |
|------|----------|-----------|
| 2026-06-27 | 28 initial agents registered across 6 domains | Covers all company functions. Each domain has 2–6 specialized agents. |
| 2026-06-27 | Five domains established | Leadership, Product, Engineering, Creative, Business, Operations — MECE coverage. |
| 2026-06-27 | All agents start at Level 1 except 6 utility agents at Level 2 | Utility agents (Code Review, Prompt Engineering, Automation, Documentation, Founder, CEO) handle operational tasks with lower risk. |

## 14. Related Documents

| Doc ID | Title | Relationship |
|--------|-------|-------------|
| 07-001 | Agent OS Vision | Vision the Registry serves |
| 08-001 | Agent Lifecycle | Lifecycle stages tracked in the Registry |
| 08-005 | Capability Matrix | Detailed capability breakdown for each registered agent |
| 09-001 to 09-028 | Agent Definitions | Full specifications for each registered agent |
