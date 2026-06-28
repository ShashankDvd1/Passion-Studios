---
document_id: "08-006"
title: "Agent Template"
owner: "CTO Agent"
status: "Approved"
version: "1.0"
created: "2026-06-27"
updated: "2026-06-27"
phase: "Phase 1 — Agent Operating System"
priority: "P0"
tags:
  - agents
  - template
  - standard
  - creation
related_documents:
  - "08-001: Agent Lifecycle"
  - "08-002: Agent Creation Guide"
  - "07-003: Agent Registry"
  - "15-001: Prompt Engineering Framework"
related_agents:
  - "CTO Agent"
  - "All Agents (subject to template)"
dependencies:
  - "08-002: Agent Creation Guide"
---

# Agent Template

## 1. Vision

Every agent in the Agent OS follows the same structural template. This ensures consistency, enables automated processing, and makes every agent definition immediately understandable by any reader — human or AI.

## 2. Problem Statement

Without a standard template, agent definitions vary wildly. Some have detailed prompt templates, others have none. Some define failure modes, others assume everything works. Inconsistency creates unpredictable agent quality and makes lifecycle management impossible.

## 3. Goals

1. Define the mandatory structure for every agent definition.
2. Ensure every section provides actionable information, not filler.
3. Make the template usable as both a human reference and an AI context injection source.

## 4. Non-Goals

- This does not fill in the template for specific agents (see `09_Agent_Definitions/`).
- This does not define the prompt engineering framework (see `15_AI_Prompts/`).

## 5. Principles

1. **Completeness.** Every section must be filled. Empty sections are not acceptable — if truly not applicable, state why.
2. **Conciseness.** Agent definitions should be 600–900 words. Dense, not verbose.
3. **Machine-parseable.** Structured for automated context injection into AI prompts.

## 6. Requirements

### 6.1 Agent Definition Template

Every file in `09_Agent_Definitions/` must follow this exact structure:

```yaml
---
agent_id: "09-NNN"
agent_name: "Agent Name"
domain: "Product | Engineering | Business | Operations | Creative"
status: "Active | Created | Review | Retired"
version: "X.Y"
created: "YYYY-MM-DD"
updated: "YYYY-MM-DD"
autonomy_level: "L1 | L2 | L3 | L4"
owner: "Who manages this agent's lifecycle"
related_documents: []
dependencies: []
---
```

Followed by these mandatory sections:

---

#### Section 1: Identity
Agent name, ID, domain. One line each.

#### Section 2: Mission
One sentence. What this agent exists to do. Must be unique across all agents.

#### Section 3: Purpose
2–3 sentences expanding the mission. Why this agent exists. What value it creates for the company. What would break if this agent didn't exist.

#### Section 4: Responsibilities
Numbered list of 5–10 specific responsibilities. Each maps to a concrete output type. No vague items like "support the team."

#### Section 5: KPIs
3–5 measurable metrics with specific targets. Format: Metric | Target | Measurement Method.

#### Section 6: Decision Authority
Table mapping decision types to P-levels. What can this agent decide alone (P2/P3)? What requires escalation (P0/P1)?

#### Section 7: Required Context
List of memory types, documents, and data this agent needs to do its job. What must be injected into the agent's prompt for each task.

#### Section 8: Inputs
What this agent receives. Task types, data formats, specifications. From whom (which agents or workflows).

#### Section 9: Outputs
What this agent produces. Document types, code artifacts, analyses, recommendations. To whom (which quality gate, which downstream agent).

#### Section 10: Dependencies
Which agents must complete work before this agent can start. Which documents this agent references. Which systems this agent requires.

#### Section 11: Memory Access
Which memory layers this agent reads from and writes to. Read/Write permissions per memory type.

#### Section 12: Communication Rules
Which channels this agent uses. Message types it sends and receives. SLAs it must meet.

#### Section 13: Review Checklist
Self-review checklist this agent applies before submitting output. 5–10 items specific to the agent's domain.

#### Section 14: Success Metrics
What "excellent" looks like for this agent. Qualitative description complementing the quantitative KPIs.

#### Section 15: Failure Modes
Top 3 ways this agent fails. For each: description, likelihood, impact, mitigation.

#### Section 16: Automation Opportunities
What parts of this agent's work can be further automated. Future capability expansion.

#### Section 17: Prompt Template
The core prompt structure for this agent. Includes: Identity block, Context injection points, Task description format, Constraints, Output format, Quality checklist, Example references.

#### Section 18: Prompt Variables
Variables that change per invocation. Format: `{{variable_name}}` with description and example values.

#### Section 19: Example Tasks
3–5 representative tasks showing the range of work this agent handles.

#### Section 20: Example Outputs
2–3 examples of excellent output, annotated with what makes them excellent.

#### Section 21: Escalation Rules
Specific conditions under which this agent must escalate. References the Decision Framework (`00-003`).

#### Section 22: Related Documents
Table of all documents this agent must be aware of. Doc ID | Title | Relationship.

### 6.2 Section Sizing Guide

| Section | Target Length | Critical Level |
|---------|-------------|----------------|
| Mission | 1 sentence | Critical — defines the agent |
| Purpose | 2-3 sentences | Critical |
| Responsibilities | 5-10 items | Critical |
| KPIs | 3-5 metrics | Critical |
| Prompt Template | 15-30 lines | Critical — the agent's brain |
| Example Outputs | 2-3 examples | Critical — quality calibration |
| All other sections | 3-10 lines each | Important but supporting |

## 7. Acceptance Criteria

- [ ] Every section in the template is filled for every agent in `09_Agent_Definitions/`.
- [ ] Agent definitions average 600–900 words (dense, not padded).
- [ ] The prompt template section alone is sufficient to invoke the agent for a basic task.
- [ ] Example outputs calibrate quality expectations unambiguously.

## 8. KPIs

| KPI | Target | Measurement |
|-----|--------|-------------|
| Template compliance | 100% of agents follow the template | Template audit |
| Section completeness | 0 empty sections across all agents | Section scan |
| Average definition length | 600-900 words | Word count |

## 9. Risks

| Risk | Likelihood | Impact | Mitigation |
|------|-----------|--------|------------|
| Template too rigid for unique agents | Low | Low | Template requires all sections but doesn't constrain content within sections. |
| 22 sections seems excessive | Medium | Low | Each section is 3-10 lines. Total: 600-900 words. Density, not verbosity. |

## 10. Future Expansion

- **Template versioning.** As the OS evolves, the template may gain or lose sections.
- **Interactive creation.** Template wizard that walks through each section with validation.
- **Auto-generation.** Given a mission statement, auto-generate a draft definition.

## 11. AI Automation Opportunities

- **Template compliance checker.** Automated scan of all agent definitions for section completeness.
- **Draft generation.** Prompt Engineering Agent generates initial definitions from mission + responsibilities.

## 12. Open Questions

1. Should Example Outputs be stored in the agent definition or in a separate examples folder?
2. Should the template include a "Changelog" section for version history within the document?

## 13. Decision History

| Date | Decision | Rationale |
|------|----------|-----------|
| 2026-06-27 | 22-section template adopted | Covers identity, governance, operations, quality, and reference. Every section serves agent creation or runtime operation. |
| 2026-06-27 | 600-900 word target | Dense enough to be comprehensive. Short enough to be maintainable. Matches founder-specified AI agent doc length. |

## 14. Related Documents

| Doc ID | Title | Relationship |
|--------|-------|-------------|
| 08-001 | Agent Lifecycle | Template is used during the Created stage |
| 08-002 | Agent Creation Guide | Guide walks through filling this template |
| 07-003 | Agent Registry | Registry metadata derived from template headers |
| 15-001 | Prompt Engineering Framework | Standards for the Prompt Template section |
