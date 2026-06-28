---
document_id: "08-005"
title: "Capability Matrix"
owner: "CTO Agent"
status: "Approved"
version: "1.0"
created: "2026-06-27"
updated: "2026-06-27"
phase: "Phase 1 — Agent Operating System"
priority: "P0"
tags:
  - agents
  - capabilities
  - matrix
  - assignment
  - overlap
related_documents:
  - "07-003: Agent Registry"
  - "08-001: Agent Lifecycle"
  - "08-006: Agent Template"
  - "10-001: Workflow Engine"
related_agents:
  - "CTO Agent"
  - "All Agents"
dependencies:
  - "07-003: Agent Registry"
---

# Capability Matrix

## 1. Vision

The Capability Matrix maps every company capability to its responsible agent. Given any task, the matrix answers: "Who does this?" It also reveals gaps (capabilities no agent covers) and overlaps (capabilities claimed by multiple agents). Both are organizational risks.

## 2. Problem Statement

Without a capability matrix, task assignment relies on guesswork. The founder mentally maps "I need a design spec" to "Game Designer Agent" — but what about economy balance? Behavioral hook design? UI flow design? Each lives with a different agent, and the boundaries are unclear without an explicit map.

## 3. Goals

1. Map all company capabilities to responsible agents.
2. Identify gaps (unowned capabilities) and overlaps (shared capabilities).
3. Enable the Workflow Engine to auto-assign tasks based on capability type.
4. Update automatically when agents are created, evolved, or retired.

## 4. Non-Goals

- This does not rate agent skill levels (all active agents are assumed capable in their domain).
- This does not define how agents execute capabilities (that's in agent definitions).

## 5. Principles

1. **One owner per capability.** Every capability has exactly one primary agent. Secondary agents may contribute but don't own.
2. **Gaps are risks.** An unowned capability will be poorly served. Identify and resolve gaps quarterly.
3. **Overlaps are waste.** Two agents owning the same capability creates confusion. Resolve by clarifying boundaries.

## 6. Requirements

### 6.1 Capability Matrix

| Capability | Primary Agent | Secondary Agent(s) | Domain |
|-----------|--------------|-------------------|--------|
| **PRODUCT** | | | |
| Product vision & strategy | Product Manager (09-003) | CEO (09-002) | Product |
| Feature ideation & prioritization | Product Manager (09-003) | Game Designer (09-004) | Product |
| Game mechanic design | Game Designer (09-004) | Behav. Psych (09-005) | Product |
| Level/content design | Game Designer (09-004) | Content Creator (09-016) | Product |
| Player motivation modeling | Behav. Psych (09-005) | Game Designer (09-004) | Product |
| Retention architecture | Behav. Psych (09-005) | Analytics (09-011) | Product |
| User flow design | UX Agent (09-006) | UI Agent (09-018) | Product |
| Accessibility design | UX Agent (09-006) | — | Product |
| Economy design & balancing | Economy Agent (09-012) | Game Designer (09-004) | Product |
| Currency system design | Economy Agent (09-012) | Monetization (09-013) | Product |
| **ENGINEERING** | | | |
| Engine architecture | Unity Architect (09-007) | — | Engineering |
| Module design & APIs | Unity Architect (09-007) | Gameplay Prog (09-008) | Engineering |
| Gameplay implementation | Gameplay Prog (09-008) | Unity Architect (09-007) | Engineering |
| UI implementation | UI Agent (09-018) | Gameplay Prog (09-008) | Engineering |
| Backend/Firebase design | Backend Agent (09-009) | — | Engineering |
| Server-side logic | Backend Agent (09-009) | Security (09-021) | Engineering |
| Data security & encryption | Security Agent (09-021) | Backend (09-009) | Engineering |
| Anti-cheat systems | Security Agent (09-021) | — | Engineering |
| Performance optimization | Performance Agent (09-022) | Unity Architect (09-007) | Engineering |
| Memory/battery profiling | Performance Agent (09-022) | — | Engineering |
| Code quality review | Code Review Agent (09-023) | — | Engineering |
| Architecture review | Unity Architect (09-007) | Code Review (09-023) | Engineering |
| **CREATIVE** | | | |
| Narrative & text content | Content Creator (09-016) | Game Designer (09-004) | Creative |
| Event narrative design | Content Creator (09-016) | LiveOps (09-010) | Creative |
| Visual identity & art direction | Art Director (09-017) | — | Creative |
| Asset specifications | Art Director (09-017) | UI Agent (09-018) | Creative |
| UI visual design | UI Agent (09-018) | Art Director (09-017) | Creative |
| Screen layout & navigation | UI Agent (09-018) | UX Agent (09-006) | Creative |
| Sound design | Audio Agent (09-019) | — | Creative |
| Music direction | Audio Agent (09-019) | — | Creative |
| Audio implementation | Audio Agent (09-019) | Gameplay Prog (09-008) | Creative |
| **BUSINESS** | | | |
| LiveOps event planning | LiveOps Agent (09-010) | Game Designer (09-004) | Business |
| LiveOps calendar management | LiveOps Agent (09-010) | Product Manager (09-003) | Business |
| Analytics architecture | Analytics Agent (09-011) | Backend (09-009) | Business |
| KPI tracking & reporting | Analytics Agent (09-011) | — | Business |
| A/B test design | Analytics Agent (09-011) | Product Manager (09-003) | Business |
| Monetization strategy | Monetization Agent (09-013) | Economy (09-012) | Business |
| IAP catalog design | Monetization Agent (09-013) | — | Business |
| Ad monetization | Monetization Agent (09-013) | — | Business |
| Marketing strategy | Marketing Agent (09-014) | CEO (09-002) | Business |
| Community management | Marketing Agent (09-014) | — | Business |
| User acquisition | Marketing Agent (09-014) | ASO (09-015) | Business |
| App Store optimization | ASO Agent (09-015) | Marketing (09-014) | Business |
| Store listing management | ASO Agent (09-015) | — | Business |
| **OPERATIONS** | | | |
| Test strategy & planning | QA Agent (09-020) | — | Operations |
| Release validation | QA Agent (09-020) | Code Review (09-023) | Operations |
| Bug triage & tracking | QA Agent (09-020) | Gameplay Prog (09-008) | Operations |
| Prompt library management | Prompt Eng Agent (09-024) | — | Operations |
| Prompt optimization | Prompt Eng Agent (09-024) | — | Operations |
| Market research | Research Agent (09-025) | CEO (09-002) | Operations |
| Competitive analysis | Research Agent (09-025) | Product Manager (09-003) | Operations |
| Technology scouting | Research Agent (09-025) | Innovation (09-028) | Operations |
| Process automation | Automation Agent (09-026) | — | Operations |
| CI/CD pipeline | Automation Agent (09-026) | Backend (09-009) | Operations |
| Documentation maintenance | Documentation Agent (09-027) | — | Operations |
| Cross-reference integrity | Documentation Agent (09-027) | — | Operations |
| Innovation & experiments | Innovation Agent (09-028) | Research (09-025) | Operations |
| **LEADERSHIP** | | | |
| Founder decision queue | Founder Agent (09-001) | — | Leadership |
| Founder schedule management | Founder Agent (09-001) | — | Leadership |
| Strategic oversight | CEO Agent (09-002) | Founder Agent (09-001) | Leadership |
| Stakeholder management | CEO Agent (09-002) | — | Leadership |

### 6.2 Gap Analysis

| Potential Gap | Status | Resolution |
|--------------|--------|-----------|
| Localization / i18n | **GAP** | Not yet needed. Address when preparing for international markets. |
| Legal / compliance management | **GAP** | Founder handles currently. Future Legal Agent when compliance complexity increases. |
| Player support / customer service | **GAP** | Not yet needed pre-launch. Address during soft launch phase. |
| Data science / ML modeling | **GAP** | Analytics Agent covers basic analysis. Dedicated ML capabilities needed at scale. |
| DevOps / infrastructure | **PARTIAL** | Automation Agent covers CI/CD. Backend Agent covers Firebase. Full DevOps may be needed at scale. |

### 6.3 Overlap Analysis

| Overlap Area | Agents Involved | Resolution |
|-------------|----------------|-----------|
| UI design vs. UX design | UI Agent + UX Agent | UX owns flows and accessibility. UI owns visual implementation. UX is upstream. |
| Economy vs. Monetization | Economy + Monetization | Economy owns in-game balance. Monetization owns real-money transactions. Economy is the ceiling Monetization works within. |
| Game design vs. Behavioral psychology | Game Designer + Behav. Psych | Game Designer owns mechanics. Behav. Psych owns psychological models. Behav. Psych provides frameworks, Game Designer applies them. |
| Marketing vs. ASO | Marketing + ASO | Marketing owns strategy and channels. ASO owns store presence specifically. ASO is a specialized subset of Marketing. |

## 7. Acceptance Criteria

- [ ] Every known company capability is mapped to exactly one primary agent.
- [ ] Gaps are identified and have a resolution plan (even if "address later").
- [ ] Overlaps are identified and have clear boundary definitions.
- [ ] Given any task description, the matrix identifies the responsible agent unambiguously.

## 8. KPIs

| KPI | Target | Measurement |
|-----|--------|-------------|
| Capability coverage | 100% of active capabilities mapped | Quarterly review |
| Gaps identified | 0 critical gaps | Gap analysis |
| Overlap conflicts | 0 unresolved overlaps | Overlap analysis |
| Task misassignment rate | <5% | Workflow audit |

## 9. Risks

| Risk | Likelihood | Impact | Mitigation |
|------|-----------|--------|------------|
| Matrix becomes stale as agents evolve | Medium | Medium | Updated at every agent lifecycle transition. Documentation Agent audits quarterly. |
| New capabilities emerge between reviews | Medium | Low | Any agent can flag an unowned capability. Founder Agent queues for resolution. |

## 10. Future Expansion

- **Skill level ratings.** Rate agents on capability proficiency (basic/intermediate/expert).
- **Auto-assignment.** Workflow Engine uses the matrix to automatically assign tasks to the right agent.
- **Cross-project matrix.** Different games may weight capabilities differently.

## 11. AI Automation Opportunities

- **Auto-update on lifecycle events.** When an agent is created, evolved, or retired, auto-update the matrix.
- **Gap detection.** Scan workflows for task types that don't map to any agent capability.
- **Overlap detection.** Flag when two agents produce similar outputs for the same workflow.

## 12. Open Questions

1. Should secondary agents be automatically consulted when primary agents work on a shared capability?
2. How do we handle capabilities that don't fit neatly into one domain?

## 13. Decision History

| Date | Decision | Rationale |
|------|----------|-----------|
| 2026-06-27 | Primary/Secondary ownership model adopted | Every capability has one owner (accountability). Secondaries provide input without confusion. |
| 2026-06-27 | Five gaps identified and accepted | Localization, Legal, Player Support, Data Science, and full DevOps are not needed at current stage. Planned for future phases. |

## 14. Related Documents

| Doc ID | Title | Relationship |
|--------|-------|-------------|
| 07-003 | Agent Registry | Registry lists agents; Capability Matrix lists what they do |
| 08-001 | Agent Lifecycle | Matrix updated at each lifecycle transition |
| 08-006 | Agent Template | Agent responsibilities section maps to matrix entries |
| 10-001 | Workflow Engine | Engine uses matrix for task assignment |
