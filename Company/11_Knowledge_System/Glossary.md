---
document_id: "11-002"
title: "Glossary"
owner: "Documentation Agent"
status: "Approved"
version: "1.0"
created: "2026-06-28"
updated: "2026-06-28"
phase: "Phase 1 — Agent Operating System"
priority: "P1"
tags: [glossary, terminology, reference]
related_documents: ["07-005: Shared Vocabulary", "11-003: Naming Convention"]
related_agents: ["Documentation Agent"]
dependencies: ["07-005: Shared Vocabulary"]
---

# Glossary

## 1. Vision
The comprehensive glossary of all terms used across the company. Extends the Shared Vocabulary (`07-005`) from ~50 core terms to 200+ terms covering all domains. This is the definitive reference for any ambiguous term.

## 2. Goals
1. Define every term used in company documentation.
2. Organize by domain for quick lookup.
3. Cross-reference related terms.

## 6. Requirements

### Company & Strategy
| Term | Definition |
|------|-----------|
| Agent OS | The complete AI operating system: agents, workflows, memory, governance, quality control. |
| Behavior Engine | The behavioral psychology framework for player engagement design. Reusable across games. |
| Tiny World Engine | The reusable Unity game engine framework. Technical infrastructure shared across games. |
| Tiny World | The first game product. Working title. |
| Wonder Forge Studios | Working company name. Configurable placeholder. |
| North Star Metric | The single most important metric: Happy Retained Players (HRP). |
| Competitive Moat | The six interlocking advantages that protect the company from competition. |

### Agent OS
| Term | Definition |
|------|-----------|
| Agent | A specialized AI role with defined mission, inputs, outputs, and governance. |
| Agent Registry | The central catalog of all agents with status and metadata. |
| Autonomy Level | An agent's earned trust level (L1-L4) determining review requirements. |
| Capability Matrix | Map of all company capabilities to their responsible agents. |
| Communication Channel | One of five defined pathways for inter-agent communication: Task, Output, Event, Query, Escalation. |
| Context Injection | The process of providing relevant memory and knowledge to an agent before task execution. |
| Decision Queue | Prioritized list of decisions awaiting founder review. |
| Escalation | Routing a decision beyond current agent authority. Correct behavior, not failure. |
| Fallback Agent | A backup agent that handles work when the primary agent is unavailable. |
| Knowledge Graph | The connected map of all documents, agents, concepts, and relationships. |
| Memory Layer | A categorized type of persistent memory (company, project, feature, etc.). |
| Prompt Template | A reusable, versioned prompt structure with variables for AI invocations. |
| Quality Gate | A checkpoint in a workflow where output must pass review before proceeding. |
| Quality Pipeline | The multi-stage review process: self → technical → consistency → founder. |
| Safe Mode | Emergency state: non-critical workflows paused, system state preserved, founder notified. |
| Workflow | A defined multi-step process orchestrating multiple agents toward an outcome. |
| Workflow Engine | The orchestration component that executes workflow definitions. |

### Product & Game Design
| Term | Definition |
|------|-----------|
| Core Loop | The minute-to-minute repeating gameplay cycle. |
| Meta Loop | Long-term progression systems wrapping the core loop. |
| Seven-Question Gate | The 7-question filter from Design Principles every feature must pass. |
| Target Emotion | One of 11 emotions (from Design Principles) a feature is designed to trigger. |
| Anti-Emotion | One of 5 emotions a feature must never trigger (anxiety, guilt, frustration, boredom, regret). |
| Hook Cycle | A behavioral engagement model: trigger → action → variable reward → investment. |
| Sink/Faucet | Economy modeling: faucets create resources, sinks remove them. Balance prevents inflation. |
| Content Template | A configurable content structure AI can populate (e.g., event narrative template). |
| Wonder Moment | A designed moment of unexpected delight that creates an emotional peak. |
| RICE Score | Prioritization formula: Reach × Impact × Confidence ÷ Effort. |
| PRD | Product Requirements Document. Feature specification written by Product Manager Agent. |

### Technical
| Term | Definition |
|------|-----------|
| ScriptableObject | Unity data container for configuration and game data. The data backbone. |
| Event Bus | Pub/sub system for decoupled communication between code modules. |
| Addressable | An asset loaded on-demand through Unity Addressables, not bundled in initial build. |
| Module | A self-contained, reusable code unit in the engine with defined APIs. |
| DOTween | Animation library for UI and gameplay animations in Unity. |
| Remote Config | Firebase/UGS system for changing game configuration without app update. |
| Cloud Save | Server-side save system for player data persistence and cross-device sync. |

### Business & Analytics
| Term | Definition |
|------|-----------|
| HRP | Happy Retained Players. Players with 3+ sessions in 7 days showing positive engagement. |
| DAU/WAU/MAU | Daily/Weekly/Monthly Active Users. |
| D1/D7/D30 | Day 1/7/30 retention. Percentage of players who return after N days. |
| LTV | Lifetime Value. Predicted total revenue from one player. |
| CPI | Cost Per Install. Marketing cost to acquire one new player. |
| ARPDAU | Average Revenue Per Daily Active User. |
| ROAS | Return On Ad Spend. Revenue generated per dollar spent on advertising. |
| IAP | In-App Purchase. Real-money transaction. |
| Soft Launch | Limited geographic release for data gathering before global launch. |
| A/B Test | Controlled experiment comparing two variants to measure impact. |
| Cohort Analysis | Grouping players by shared characteristic (install date, behavior) for comparison. |

### Governance & Process
| Term | Definition |
|------|-----------|
| P0 | Highest priority. Existential decisions. Founder-only. Response: immediate. |
| P1 | High priority. Strategic decisions. Founder approval required. Response: 24 hours. |
| P2 | Medium priority. Tactical decisions. Agent-autonomous with documentation. Response: 48 hours. |
| P3 | Low priority. Operational decisions. Fully autonomous. Response: 72 hours. |
| Decision Brief | Structured format for presenting decisions: problem, options, recommendation, deadline. |
| Post-Mortem | Blameless retrospective analyzing an event's causes, impacts, and learnings. |
| Sprint | A time-boxed work period (typically 1-2 weeks). |
| Epic | A large body of work decomposed into multiple tasks across sprints. |
| Milestone | A significant achievement marking progress toward a strategic goal. |

## 7. Acceptance Criteria
- [ ] Every term used in company documentation has a glossary entry
- [ ] Terms are organized by domain for quick lookup
- [ ] No term has conflicting definitions across documents
- [ ] Glossary is updated within 48 hours of new term introduction

## 14. Related Documents
| Doc ID | Title | Relationship |
|--------|-------|-------------|
| 07-005 | Shared Vocabulary | Core vocabulary this glossary extends |
| 11-003 | Naming Convention | Naming rules that reference glossary terms |
