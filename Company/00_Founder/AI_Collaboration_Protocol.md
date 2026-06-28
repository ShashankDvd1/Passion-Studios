---
document_id: "00-004"
title: "AI Collaboration Protocol"
owner: "Founder Agent"
status: "Approved"
version: "1.0"
created: "2026-06-27"
updated: "2026-06-27"
phase: "Phase 0 — Constitutional Layer"
priority: "P0"
tags:
  - ai
  - collaboration
  - workflow
  - prompts
  - quality
  - review
related_documents:
  - "00-001: Founder Charter"
  - "00-002: Founder Workflow"
  - "00-003: Decision Framework"
  - "02-003: Operating Principles"
  - "02-004: Quality Standards"
  - "07-001: Agent OS Architecture (Phase 1)"
  - "09-001: Prompt Library Overview (Phase 1)"
related_agents:
  - "Founder Agent"
  - "Prompt Engineering Agent"
  - "Code Review Agent"
  - "All Agents"
dependencies:
  - "00-001: Founder Charter"
  - "00-003: Decision Framework"
---

# AI Collaboration Protocol

## 1. Vision

This protocol defines how the founder and AI agents work together. It is the interaction design for a human-AI organization — covering prompt patterns, review processes, quality gates, feedback loops, and the gradual expansion of AI autonomy as trust builds.

The goal is not to manage AI like employees. It is to design an interface between human judgment and machine capability that amplifies both. The founder provides taste, ethics, and player empathy. AI provides speed, consistency, and tireless execution. The protocol ensures these strengths combine rather than conflict.

## 2. Problem Statement

The founder-AI collaboration has three failure modes:

**Over-direction:** The founder writes prompts so detailed that they might as well have done the work themselves. AI becomes a typing assistant, not a thinking partner.

**Under-direction:** The founder gives vague instructions, receives misaligned output, and spends more time correcting than creating. The AI's speed advantage evaporates in revision cycles.

**No feedback loop:** The founder accepts or rejects AI output without explaining why. The AI (and the prompts that drive it) never improve. Quality plateaus.

This protocol establishes the sweet spot: sufficient context for alignment, sufficient freedom for AI creativity, and structured feedback for continuous improvement.

## 3. Goals

1. Define the prompt → generate → review → integrate pipeline.
2. Establish quality gates at each stage.
3. Create a feedback mechanism that improves AI output quality over time.
4. Define review depth by content type (code, design, content, art).
5. Set expectations for when founder override is appropriate vs. when to trust AI judgment.

## 4. Non-Goals

- This document does not define specific prompts (see `09_AI_Prompts`).
- This document does not define agent architecture (see `07_AI_OS` and `08_Agents`).
- This document does not define coding standards (see `02-004: Quality Standards`).

## 5. Principles

1. **Context is king.** The quality of AI output is directly proportional to the quality of context provided. Invest in context, not in micro-instructions.
2. **Trust but verify.** Default to trusting AI output for P2/P3 work. Verify through sampling, not exhaustive review.
3. **Teach, don't correct.** When AI output misses the mark, update the prompt, the context, or the quality standard — not just the output. Fix the system, not the symptom.
4. **Expand autonomy with evidence.** As an agent demonstrates consistent quality in a domain, reduce review depth and expand decision authority. Earn trust, grant freedom.

## 6. Requirements

### 6.1 The AI Collaboration Pipeline

```
┌─────────────┐     ┌─────────────┐     ┌─────────────┐     ┌─────────────┐     ┌─────────────┐
│   CONTEXT    │────►│   GENERATE  │────►│   REVIEW    │────►│  INTEGRATE  │────►│   LEARN     │
│              │     │             │     │             │     │             │     │             │
│ Requirements │     │ AI produces │     │ Quality     │     │ Approved    │     │ Feedback    │
│ Standards    │     │ output      │     │ gate check  │     │ output      │     │ improves    │
│ Examples     │     │             │     │             │     │ enters      │     │ prompts &   │
│ Constraints  │     │             │     │             │     │ production  │     │ standards   │
└─────────────┘     └─────────────┘     └─────────────┘     └─────────────┘     └─────────────┘
```

#### Stage 1: Context

Every AI task must be accompanied by:
- **What:** Clear deliverable description
- **Why:** The purpose this serves (links to a design principle, feature goal, or business need)
- **Standards:** Reference to the applicable quality standard
- **Examples:** Good and bad examples of similar output
- **Constraints:** Boundaries the output must stay within
- **References:** Relevant documents the agent should consider

#### Stage 2: Generate

The responsible agent produces output using:
- The prompt library (`09_AI_Prompts`) for standardized tasks
- Custom prompts for novel tasks (which get added to the library if successful)
- Self-review against quality standards before submitting for human review

#### Stage 3: Review

| Content Type | Review Depth | Reviewer | Method |
|-------------|-------------|----------|--------|
| **P0 Code** (architecture, core systems) | Full review | Founder | Line-by-line reading. Architecture validation. | 
| **P1 Code** (features, gameplay) | Sampling review | Founder | Review 30% of changes. Focus on patterns, not syntax. |
| **P2 Code** (bug fixes, utilities) | Automated review | Code Review Agent | Automated tests + lint + agent review. Founder informed. |
| **P3 Code** (formatting, docs) | No human review | Code Review Agent | Automated checks only. |
| **Game Design** (features, systems) | Full review for P0/P1 | Founder | Design principles compliance. Emotional design check. |
| **Content** (text, descriptions) | Sampling review | Founder | Tone of voice check. Brand consistency. |
| **Art assets** | Full review | Founder | Visual quality. Style consistency. Brand alignment. |
| **Documentation** | Sampling review | Founder | Accuracy. Cross-reference integrity. |

#### Stage 4: Integrate

Approved output enters the production codebase/documentation through:
- Code: PR merge with automated tests passing
- Design: Document updated, related documents cross-referenced
- Content: Imported into game data pipeline
- Art: Added to asset management system

#### Stage 5: Learn

After integration, capture learning:
- **What worked:** Update the prompt library with successful prompts
- **What didn't:** Document the failure mode and the fix
- **Pattern recognition:** If a correction repeats 3+ times, update the quality standard or the prompt template

### 6.2 Review Quality Standards

When reviewing AI output, the founder applies these criteria:

```
□ Does it serve the stated purpose?
□ Does it follow the applicable quality standard?
□ Does it feel right? (Founder's taste/intuition check)
□ Would I ship this to a player?
□ Does it maintain consistency with existing work?
□ Are there edge cases the AI missed?
□ Is the approach reusable or one-off?
```

**Three outcomes:**
- **Approve:** Output meets standards. Integrate as-is.
- **Revise:** Output is close but needs specific changes. Provide explicit feedback.
- **Reject:** Output is fundamentally misaligned. Do not revise — re-examine the context and prompt.

If reject rate exceeds 20% for any agent or domain, the prompt template, quality standard, or context documents require updating.

### 6.3 Autonomy Ladder

Agent autonomy expands through a trust ladder:

| Level | Name | Review Requirement | Earned By |
|-------|------|--------------------|-----------|
| 1 | **Supervised** | 100% founder review | Default for new agents and domains |
| 2 | **Guided** | 50% founder review (sampling) | 20+ successful outputs with <10% revision rate |
| 3 | **Trusted** | 10% founder review (spot check) | 50+ successful outputs with <5% revision rate |
| 4 | **Autonomous** | Exception-only review | 100+ successful outputs with <3% revision rate |

Each agent starts at Level 1 in every domain and progresses independently per domain. An agent can be Level 3 in documentation but Level 1 in code generation.

### 6.4 Feedback Format

When providing feedback on AI output, use this structure:

```
VERDICT: Approve | Revise | Reject
WHAT WORKED: [specific elements that are correct]
WHAT NEEDS CHANGE: [specific issues with specific corrections]
WHY: [reasoning linked to values, principles, or standards]
SYSTEMIC FIX: [if applicable, what prompt/standard/context should change]
```

This format ensures feedback improves the system, not just the immediate output.

## 7. Acceptance Criteria

- [ ] The pipeline is clear enough that a new AI agent can be onboarded and productive within one task cycle.
- [ ] Review depth scales inversely with trust — more trust means less review, not more.
- [ ] The feedback format generates actionable improvements to prompts and standards.
- [ ] The autonomy ladder incentivizes quality — agents that produce better work get more freedom.
- [ ] The protocol handles all content types (code, design, content, art, docs).

## 8. KPIs

| KPI | Target | Measurement |
|-----|--------|-------------|
| First-pass approval rate | 70%+ across all agents | Review log |
| Revision rate | <20% (declining over time) | Review log |
| Reject rate | <5% | Review log |
| Average autonomy level (across agents) | Level 2+ within 3 months | Autonomy ladder tracking |
| Prompt library growth | 5+ new templates per month | Prompt library audit |
| Time from context to integration (P2 tasks) | <2 hours | Pipeline tracking |

## 9. Risks

| Risk | Likelihood | Impact | Mitigation |
|------|-----------|--------|------------|
| Founder becomes rubber-stamp reviewer | Medium | High | Weekly quality audit. Deep review of 2–3 random items per day. |
| Autonomy ladder progresses too fast | Low | Medium | Revision rate thresholds are strict. One reject resets the ladder for that domain. |
| AI output quality degrades as models change | Medium | Medium | Prompt library includes model-version tags. Test prompts against new models before adoption. |
| Feedback loop too slow (improvements take weeks) | Medium | Low | Real-time prompt updates. Systemic fixes prioritized weekly. |

## 10. Future Expansion

- **Multi-model orchestration.** Different AI models for different tasks (e.g., Claude for design, GPT for code, specialized models for art).
- **Agent-to-agent review.** Higher-autonomy agents review lower-autonomy agents, reducing founder review load.
- **Automated quality scoring.** ML-based quality prediction that pre-screens output before founder review.

## 11. AI Automation Opportunities

- **Review routing.** Founder Agent automatically routes outputs to review based on content type, priority, and agent autonomy level.
- **Feedback aggregation.** Prompt Engineering Agent analyzes feedback patterns to identify systemic prompt improvements.
- **Autonomy tracking.** Automated tracking of each agent's success rate and autonomy ladder position.
- **Quality trend detection.** Alert when an agent's approval rate drops, suggesting prompt or context degradation.

## 12. Open Questions

1. Should agents self-assess their confidence level with each output? (Could help route review attention.)
2. How do we handle creative disagreements where the AI's output is technically correct but doesn't match the founder's taste?
3. What happens when AI models are updated — do autonomy levels reset?

## 13. Decision History

| Date | Decision | Rationale |
|------|----------|-----------|
| 2026-06-27 | Five-stage pipeline adopted | Context → Generate → Review → Integrate → Learn is a complete lifecycle with feedback. |
| 2026-06-27 | Four-level autonomy ladder | Provides granular trust progression. Incentivizes quality through earned freedom. |
| 2026-06-27 | "Teach, don't correct" principle | Fixing individual outputs doesn't scale. Fixing prompts and standards does. |

## 14. Related Documents

| Doc ID | Title | Relationship |
|--------|-------|-------------|
| 00-001 | Founder Charter | Defines what founder reviews vs. what agents handle autonomously |
| 00-002 | Founder Workflow | Schedule within which reviews happen |
| 00-003 | Decision Framework | How to decide when AI output quality disputes arise |
| 02-004 | Quality Standards | Standards that AI output is reviewed against |
| 07-001 | Agent OS Architecture | System infrastructure that supports this pipeline |
| 09-001 | Prompt Library Overview | Prompt templates used in the Generate stage |
