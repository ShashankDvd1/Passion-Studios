---
document_id: "07-005"
title: "Shared Vocabulary"
owner: "Documentation Agent"
status: "Approved"
version: "1.0"
created: "2026-06-27"
updated: "2026-06-27"
phase: "Phase 1 — Agent Operating System"
priority: "P1"
tags:
  - vocabulary
  - terminology
  - communication
  - standards
related_documents:
  - "07-004: Communication Protocol"
  - "11-002: Glossary"
  - "11-003: Naming Convention"
  - "02-003: Operating Principles"
related_agents:
  - "Documentation Agent"
  - "All Agents"
dependencies:
  - "07-004: Communication Protocol"
---

# Shared Vocabulary

## 1. Vision

Every agent in the OS must use the same words to mean the same things. "Feature," "module," "sprint," "release," "player," "session" — each has one definition. Ambiguity in terminology creates ambiguity in execution.

## 2. Problem Statement

When an AI agent says "deploy," does it mean push to staging, push to production, or submit to the app store? When one agent says "player engagement," does it mean DAU, session length, or emotional attachment? Without shared vocabulary, agents produce outputs that appear aligned but are actually describing different things.

## 3. Goals

1. Define canonical terminology for the 50+ most-used terms across the company.
2. Distinguish terms that are commonly confused.
3. Create a reference every agent's prompt template can include.

## 4. Non-Goals

- This is not a comprehensive glossary (see `11-002: Glossary` for the full glossary).
- This does not define naming conventions for code/assets (see `11-003: Naming Convention`).

## 5. Principles

1. **One word, one meaning.** No term has two definitions in this company.
2. **Precision over brevity.** If a common word is ambiguous, use a more precise alternative.
3. **Evolving vocabulary.** New terms are added as the company grows. Old terms are deprecated, never silently redefined.

## 6. Requirements

### 6.1 Core Company Terms

| Term | Definition | NOT This |
|------|-----------|----------|
| **Wonder Forge Studios** | Working name for the company. Configurable placeholder. | Not a final brand name. |
| **Agent OS** | The complete AI operating system: agents, workflows, memory, governance, quality. | Not a single tool or chatbot. |
| **Tiny World Engine** | The reusable Unity game engine framework. Technical infrastructure. | Not a specific game. |
| **Behavior Engine** | The behavioral psychology framework for player engagement design. | Not a code library. It's a design framework. |
| **Tiny World** | The first game product built on the engine. Working title. | Not the company. Not the engine. |

### 6.2 Agent & OS Terms

| Term | Definition | NOT This |
|------|-----------|----------|
| **Agent** | A specialized AI role with defined mission, inputs, outputs, and governance. Operates within the Agent OS. | Not a person. Not a chatbot. Not a single prompt. |
| **Workflow** | A defined multi-step process that orchestrates multiple agents toward a specific outcome. | Not a checklist. Not an ad-hoc task. |
| **Task** | A single unit of work assigned to one agent with clear acceptance criteria. | Not a workflow (which contains multiple tasks). |
| **Memory** | Persistent information stored in the Memory System, organized by type (company, project, feature, etc.). | Not chat history. Not temporary context. |
| **Knowledge** | Documented facts, conventions, and relationships in the Knowledge System. Static reference material. | Not memory (which is dynamic and accumulates). |
| **Prompt Template** | A reusable, versioned prompt structure with variables that agents use for consistent AI invocations. | Not a one-off prompt. Not a conversation. |
| **Autonomy Level** | An agent's earned trust level (L1–L4) determining how much human review their output requires. | Not a permission. Not a rank. |
| **Decision Queue** | The prioritized list of decisions awaiting founder review, managed by the Founder Agent. | Not an inbox. Not a notification feed. |
| **Escalation** | Routing a decision or issue to a higher authority level because it exceeds the current agent's decision authority. | Not a failure. Not a complaint. Escalation is correct behavior. |

### 6.3 Product & Game Terms

| Term | Definition | NOT This |
|------|-----------|----------|
| **Core Loop** | The minute-to-minute repeating gameplay cycle the player engages with most frequently. | Not the meta-loop. Not the full game. |
| **Meta Loop** | Long-term progression systems (collections, upgrades, prestige) that give the core loop meaning over weeks. | Not the core loop. Meta wraps around core. |
| **Session** | One continuous period of player engagement, from app open to app close or background. | Not a "day" of play (which may contain multiple sessions). |
| **HRP (Happy Retained Players)** | North Star Metric. Players with 3+ sessions in 7 days showing positive engagement signals. | Not DAU. Not total users. |
| **LiveOps Event** | A time-limited in-game event with unique content, rewards, and engagement mechanics. | Not a patch. Not an update. Not permanent content. |
| **Feature** | A player-facing capability or system that provides value. Must pass the Seven-Question Gate. | Not a bug fix. Not a refactor. Not an optimization. |
| **Content** | Game data (items, characters, levels, text, events) that populates features. Configuration, not code. | Not a feature. Content fills features. |

### 6.4 Technical Terms

| Term | Definition | NOT This |
|------|-----------|----------|
| **Module** | A self-contained, reusable code unit in the Tiny World Engine with defined APIs and dependencies. | Not a script. Not a MonoBehaviour. A module is an architectural unit. |
| **ScriptableObject** | Unity data container used for configuration, game data, and event channels. The data backbone. | Not a script. Not runtime logic. Data definition. |
| **Event Bus** | The pub/sub system for decoupled communication between modules. | Not direct method calls. Not Unity's SendMessage. |
| **Addressable** | An asset loaded on-demand through Unity's Addressables system, not bundled in the initial build. | Not a Resources folder asset. Not a hardcoded reference. |
| **Build** | A compiled, runnable version of the game for a specific platform. | Not a release (which is a build approved for distribution). |
| **Release** | A build that has passed all quality gates and is approved for distribution to players. | Not a build (which may not be release-ready). |

### 6.5 Business Terms

| Term | Definition | NOT This |
|------|-----------|----------|
| **IAP** | In-App Purchase. A real-money transaction within the game. | Not virtual currency spending. IAP involves real money. |
| **LTV** | Lifetime Value. Predicted total revenue from one player over their entire engagement period. | Not ARPDAU (which is daily). LTV is total. |
| **CPI** | Cost Per Install. What we pay in marketing to acquire one new player. | Not CPM or CPC. CPI is per install specifically. |
| **ARPDAU** | Average Revenue Per Daily Active User. Total daily revenue / DAU. | Not LTV. ARPDAU is a daily snapshot. |
| **Soft Launch** | Limited geographic release to gather real player data before global launch. | Not beta testing. Soft launch is a commercial release in a limited market. |
| **Global Launch** | Full worldwide release across all target markets. | Not soft launch. Global launch is the full release. |

### 6.6 Commonly Confused Pairs

| Term A | Term B | Distinction |
|--------|--------|-------------|
| Feature vs. Content | Feature is a system. Content fills the system. | "Crafting system" is a feature. "Sword recipe" is content. |
| Agent vs. Prompt | Agent is a role with governance. Prompt is a tool the agent uses. | An agent has a lifecycle. A prompt is a template. |
| Memory vs. Knowledge | Memory is dynamic (accumulated). Knowledge is static (documented). | "Player churn rate last month" is memory. "How to calculate churn" is knowledge. |
| Workflow vs. Task | Workflow is multi-step. Task is single-step. | "New Feature Workflow" has 8 tasks. "Write design spec" is one task. |
| Build vs. Release | Build is compiled. Release is approved for players. | All releases are builds. Not all builds are releases. |
| Core Loop vs. Meta Loop | Core is minute-to-minute. Meta is week-to-month. | Core: "plant → grow → harvest." Meta: "unlock new biomes." |

## 7. Acceptance Criteria

- [ ] Every term has one definition. No term appears with different meanings in any document.
- [ ] The "NOT This" column prevents the most common misinterpretations.
- [ ] An agent encountering an ambiguous term can look it up and resolve the ambiguity.
- [ ] Commonly confused pairs are explicitly distinguished.

## 8. KPIs

| KPI | Target | Measurement |
|-----|--------|-------------|
| Terminology consistency across documents | 100% | Documentation audit |
| Vocabulary coverage (terms used without definition) | <5 undefined terms per quarter | Quarterly scan |

## 9. Risks

| Risk | Likelihood | Impact | Mitigation |
|------|-----------|--------|------------|
| Vocabulary too rigid, limiting natural expression | Low | Low | Vocabulary governs precision, not style. Agents can write naturally as long as defined terms are used correctly. |
| New terms emerge faster than vocabulary updates | Medium | Low | Documentation Agent flags new undefined terms. Monthly vocabulary review. |

## 10. Future Expansion

- Full glossary in `11-002: Glossary` with 200+ terms covering all domains.
- Localization vocabulary for international markets.
- Technical API vocabulary for code documentation.

## 11. AI Automation Opportunities

- **Terminology linting.** Automated scan of all documents for terms used inconsistently with their definitions.
- **Vocabulary injection.** Agent prompt templates automatically include relevant vocabulary definitions.

## 12. Open Questions

1. Should we version the vocabulary? (Terms can change meaning as the company evolves.)
2. Should agents be required to flag when they use a term not in the vocabulary?

## 13. Decision History

| Date | Decision | Rationale |
|------|----------|-----------|
| 2026-06-27 | Core vocabulary established with ~50 terms | Covers company, agent, product, technical, and business domains. Extensible. |
| 2026-06-27 | "NOT This" column required | Most terminology confusion comes from near-miss interpretations, not complete misunderstanding. |

## 14. Related Documents

| Doc ID | Title | Relationship |
|--------|-------|-------------|
| 07-004 | Communication Protocol | Vocabulary ensures messages are unambiguous |
| 11-002 | Glossary | Extended glossary built on this vocabulary |
| 11-003 | Naming Convention | Code/asset naming built on this vocabulary |
