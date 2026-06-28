---
document_id: "08-002"
title: "Agent Creation Guide"
owner: "CTO Agent"
status: "Approved"
version: "1.0"
created: "2026-06-27"
updated: "2026-06-27"
phase: "Phase 1 — Agent Operating System"
priority: "P0"
tags:
  - agents
  - creation
  - guide
  - onboarding
  - template
related_documents:
  - "08-001: Agent Lifecycle"
  - "08-006: Agent Template"
  - "07-003: Agent Registry"
  - "08-005: Capability Matrix"
  - "00-004: AI Collaboration Protocol"
  - "15-001: Prompt Engineering Framework"
related_agents:
  - "CTO Agent"
  - "Founder Agent"
  - "Prompt Engineering Agent"
dependencies:
  - "08-001: Agent Lifecycle"
  - "08-006: Agent Template"
---

# Agent Creation Guide

## 1. Vision

Creating a new agent should be a systematic, repeatable process — not an ad-hoc exercise. This guide walks through every step from identifying the need to activating the agent in the OS. A well-created agent starts producing quality output immediately; a poorly created agent generates revision cycles for weeks.

## 2. Problem Statement

Without a creation guide, each new agent is built differently. Some have detailed missions, others have vague ones. Some have comprehensive prompt templates, others have minimal instructions. The inconsistency creates unpredictable output quality and makes agent maintenance difficult.

## 3. Goals

1. Define a step-by-step process for creating any agent.
2. Ensure consistency: every agent created through this process meets the same quality bar.
3. Reduce creation time to under 4 hours from concept to active status.
4. Include validation steps that catch common creation mistakes.

## 4. Non-Goals

- This guide does not define the agent template structure (see `08-006: Agent Template`).
- This guide does not cover agent evolution or retirement (see `08-001`, `08-003`).

## 5. Principles

1. **Mission clarity above all.** If you cannot state the agent's mission in one sentence, the agent is not well-defined enough to create.
2. **Examples are worth a thousand rules.** The "Example Tasks" and "Example Outputs" sections of an agent definition are the most valuable. Invest time here.
3. **Start narrow, expand later.** Give the agent a tight scope initially. Expansion is a version 2.0 activity, not a version 1.0 requirement.

## 6. Requirements

### 6.1 Creation Process (8 Steps)

---

#### Step 1: Identify the Need (15 minutes)

Answer these questions before proceeding:

| Question | Required Answer |
|----------|----------------|
| What gap does this agent fill? | A specific capability no existing agent provides |
| What tasks will this agent perform? | At least 3 concrete example tasks |
| Which workflows will this agent participate in? | At least 1 workflow from `10_Workflows/` |
| Does any existing agent overlap? | Check the Capability Matrix (`08-005`). If overlap exists, justify the new agent vs. expanding the existing one. |
| How frequently will this agent be used? | Daily / Weekly / Monthly / On-demand |

If any answer is vague, the need is not clear enough. Refine before proceeding.

---

#### Step 2: Write the Proposal (15 minutes)

Create a one-paragraph proposal:

```
Agent Name: [Name]
Mission: [One sentence]
Gap Filled: [What can't be done today without this agent]
Expected Tasks: [3-5 examples]
Expected Frequency: [Daily/Weekly/Monthly]
Workflows: [Which workflows this agent joins]
```

Submit for founder approval (P1 decision per `00-003`).

---

#### Step 3: Define Identity & Mission (30 minutes)

Using the Agent Template (`08-006`), fill in:

- **Identity:** Full name, agent ID (from Registry), domain assignment.
- **Mission:** One sentence. Must pass the "could another agent do this?" test — if yes, the mission overlaps.
- **Purpose:** 2–3 sentences expanding the mission. Why this agent exists, what value it creates.
- **Responsibilities:** Numbered list. Each responsibility maps to a specific output type. No vague responsibilities like "support development."

---

#### Step 4: Define Inputs, Outputs & Dependencies (30 minutes)

- **Required Context:** What information does this agent need to do its job? (Memory types, documents, other agent outputs)
- **Inputs:** What does the agent receive? Task assignments, data, specifications.
- **Outputs:** What does the agent produce? Documents, code, analyses, recommendations. Be specific about format and quality expectations.
- **Dependencies:** Which other agents must complete work before this agent can start? Which documents must this agent reference?

---

#### Step 5: Define Authority & Governance (20 minutes)

- **Decision Authority:** What can this agent decide autonomously (P2/P3)? What requires escalation (P0/P1)?
- **KPIs:** 3–5 measurable success metrics with specific targets.
- **Success Metrics:** What does "good" look like?
- **Failure Modes:** What are the 3 most likely ways this agent fails? What are the mitigations?
- **Escalation Rules:** When does this agent stop and ask for help?

---

#### Step 6: Create Prompt Template (60 minutes)

This is the most important step. The prompt template is the agent's "brain."

Using the Prompt Engineering Framework (`15-001`):

```
## System Prompt Structure

1. IDENTITY: Who the agent is. Role, mission, personality.
2. CONTEXT: What the agent knows. Company values, design principles, relevant standards.
3. TASK: What the agent must do in this specific invocation.
4. CONSTRAINTS: What the agent must NOT do. Boundaries, ethical limits, scope limits.
5. OUTPUT FORMAT: Exact structure of expected output.
6. EXAMPLES: 2-3 examples of excellent output for representative tasks.
7. QUALITY CHECKLIST: Self-review criteria the agent applies before submitting.
```

**Critical rule:** The prompt template must inject relevant context from the Knowledge System and Memory System. Do not rely on the AI model's training data for company-specific information.

---

#### Step 7: Test with Sample Tasks (60 minutes)

Run the agent through 3–5 representative tasks:

| Test | Purpose |
|------|---------|
| **Happy path task** | Standard task the agent will handle most frequently |
| **Edge case task** | Unusual or ambiguous task testing the agent's boundaries |
| **Scope boundary task** | Task that is close to but outside the agent's scope — should the agent escalate or attempt? |
| **Quality stress test** | Task requiring high quality output — does the agent meet the quality standards? |
| **Cross-reference task** | Task requiring information from memory or other documents — does the agent properly reference context? |

For each test, evaluate:
- Does the output meet quality standards (`02-004`)?
- Does the agent stay within its defined scope?
- Does the agent escalate when appropriate?
- Is the output format correct?
- Would a founder approve this on first pass?

---

#### Step 8: Activate & Register (15 minutes)

1. Save the complete agent definition to `09_Agent_Definitions/[Agent_Name].md`.
2. Register in the Agent Registry (`07-003`) with all schema fields.
3. Update the Capability Matrix (`08-005`) with the new agent's capabilities.
4. Add the agent to relevant workflow definitions in `10_Workflows/`.
5. Create initial prompt template in `15_AI_Prompts/`.
6. Set autonomy level to L1 (Supervised).
7. Schedule first quarterly review date.

---

### 6.2 Creation Checklist

```
□ Need identified and validated against Capability Matrix
□ Proposal approved by founder
□ Mission statement: one sentence, no overlap with existing agents
□ Responsibilities: numbered, specific, output-mapped
□ Inputs and outputs: concrete formats defined
□ Dependencies: all upstream agents and documents identified
□ Decision authority: P-levels assigned for all decision types
□ KPIs: 3-5 measurable metrics with targets
□ Failure modes: top 3 identified with mitigations
□ Prompt template: follows 7-section structure
□ Sample tasks: 3-5 tests passed
□ Founder reviewed sample outputs
□ Agent definition saved to 09_Agent_Definitions/
□ Registered in Agent Registry
□ Capability Matrix updated
□ Workflow references added
□ Autonomy level set to L1
□ First review date scheduled
```

### 6.3 Common Creation Mistakes

| Mistake | Consequence | Prevention |
|---------|------------|-----------|
| Mission too broad | Agent produces unfocused, mediocre output across too many domains | One-sentence mission. "Could another agent do this part?" test. |
| No example outputs | AI model has no quality reference and produces generic results | Minimum 2 examples in prompt template. Examples are the quality bar. |
| Missing context injection | Agent reinvents company knowledge instead of referencing it | Required Context section must list all memory types and documents the agent needs. |
| Vague KPIs | No way to measure if agent is performing well | Every KPI has a number. "Improve quality" is not a KPI. "90% first-pass approval rate" is. |
| No failure mode analysis | Failures are discovered in production, not during creation | Top 3 failure modes identified before activation. Mitigations defined. |

## 7. Acceptance Criteria

- [ ] A person unfamiliar with the Agent OS can follow this guide and create a functional agent.
- [ ] The 8-step process takes less than 4 hours total.
- [ ] The creation checklist catches 90%+ of common mistakes before activation.
- [ ] Every agent created through this guide produces approved output within 5 tasks.

## 8. KPIs

| KPI | Target | Measurement |
|-----|--------|-------------|
| Agent creation time | <4 hours | Lifecycle tracking |
| First-5-task approval rate | >60% | Agent health metrics |
| Creation checklist compliance | 100% of new agents | Checklist audit |
| Rework rate (agents needing major revision within 30 days) | <20% | Lifecycle tracking |

## 9. Risks

| Risk | Likelihood | Impact | Mitigation |
|------|-----------|--------|------------|
| Guide followed mechanically without thought | Medium | Medium | Step 7 (testing) catches mechanical creation. Bad outputs force revision. |
| Guide too complex, discourages agent creation | Low | Medium | 8 steps with time estimates. Total: <4 hours. Manageable. |
| Prompt template quality determines everything | High | High | Step 6 is the longest step for a reason. Prompt Engineering Agent reviews all templates. |

## 10. Future Expansion

- **Agent creation wizard.** Interactive tool that walks through each step with validation.
- **Template generation.** AI generates draft agent definitions based on a mission statement, then human refines.
- **Automated testing.** Test suite that evaluates agent outputs against quality standards automatically.

## 11. AI Automation Opportunities

- **Capability gap detection.** OS identifies unserved tasks and drafts agent proposals.
- **Prompt template drafting.** Prompt Engineering Agent generates initial prompt templates based on mission and responsibilities.
- **Automated registration.** Upon completion of the definition file, auto-register in Registry and Capability Matrix.

## 12. Open Questions

1. Should there be a "lightweight agent" creation path for simple, single-task agents?
2. Can the testing step be partially automated using the Quality Pipeline?
3. Should agents be created in pairs (e.g., a "creator" agent and its "reviewer" agent)?

## 13. Decision History

| Date | Decision | Rationale |
|------|----------|-----------|
| 2026-06-27 | 8-step creation process adopted | Covers the full creation lifecycle from need identification to activation. |
| 2026-06-27 | 4-hour time target set | Balances thoroughness with practicality. A founder should be able to create an agent in half a day. |
| 2026-06-27 | Prompt template is the longest step | The quality of the prompt template determines 80%+ of agent output quality. Investment here has the highest ROI. |

## 14. Related Documents

| Doc ID | Title | Relationship |
|--------|-------|-------------|
| 08-001 | Agent Lifecycle | Lifecycle stages this guide implements (Proposed → Created → Active) |
| 08-006 | Agent Template | The template structure every agent definition follows |
| 07-003 | Agent Registry | Where the new agent is registered upon activation |
| 08-005 | Capability Matrix | Matrix updated with new agent's capabilities |
| 15-001 | Prompt Engineering Framework | Standards for prompt template creation in Step 6 |
| 00-004 | AI Collaboration Protocol | Autonomy ladder the new agent enters at Level 1 |
