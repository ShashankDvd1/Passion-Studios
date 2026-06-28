---
document_id: "02-001"
title: "Core Values"
owner: "Founder"
status: "Approved"
version: "1.0"
created: "2026-06-27"
updated: "2026-06-27"
phase: "Phase 0 — Constitutional Layer"
priority: "P0"
tags:
  - values
  - culture
  - foundation
  - decision-filter
related_documents:
  - "01-001: Company Vision"
  - "02-002: Design Principles"
  - "02-003: Operating Principles"
  - "02-004: Quality Standards"
  - "02-005: Ethical Framework"
  - "00-001: Founder Charter"
related_agents:
  - "All Agents"
dependencies:
  - "01-001: Company Vision"
---

# Core Values

## 1. Vision

Values are not motivational posters. They are decision-making algorithms.

When two reasonable people disagree about a feature, a priority, or an approach — values break the tie. When an AI agent faces ambiguity and the founder is unavailable — values guide the decision. When we evaluate a partnership, a hire, or a market opportunity — values filter the options.

These six values are the operating system of our culture. Every agent, every document, and every decision must be consistent with them. If a value never causes us to say "no" to something we want, it is not a real value — it is a platitude. Each value below includes what it demands we do AND what it demands we refuse.

## 2. Problem Statement

Companies without explicit values make decisions inconsistently. The founder's intuition works for the first 50 decisions, but by decision 500, context is lost, edge cases multiply, and AI agents have no heuristic to fall back on. Implicit values create implicit disagreements.

Without codified values, AI agents will optimize for the most obvious metric (revenue, engagement, output volume) rather than the nuanced balance that makes a company worth building.

## 3. Goals

1. Provide six values that are specific enough to resolve real disagreements.
2. Give every value a "this means we DO" and "this means we DON'T" behavioral definition.
3. Ensure values are machine-readable — AI agents can reference and apply them.
4. Create a hiring filter, feature filter, and partnership filter from the same value set.
5. Make values memorable and non-generic — these should be ours, not interchangeable with any other company.

## 4. Non-Goals

- These values do not prescribe specific design decisions (see `02-002: Design Principles`).
- These values do not define operational processes (see `02-003: Operating Principles`).
- These values are not a code of conduct or HR policy. They are strategic decision filters.

## 5. Principles

Values themselves are the principles. See Section 6.

## 6. Requirements

### The Six Core Values

---

### Value 1: Worlds Over Games

**Definition:** We build places players want to inhabit, not problems players need to solve. The world is the product. Gameplay serves the world.

**This means we DO:**
- Design environments that feel alive, evolving, and personally owned
- Prioritize ambient discovery over directed objectives
- Invest in systems that make the world feel persistent and responsive
- Ask "does this make the world feel more real?" before "does this increase session time?"

**This means we DON'T:**
- Build level-based progression as the primary structure
- Design gameplay that could exist without the world context
- Treat the world as a backdrop for mechanics
- Ship features that break the illusion of a living world

**Decision test:** *If we removed the world and kept only the mechanics, would the game still be worth playing? If yes, the world isn't doing enough.*

---

### Value 2: Wonder Over Compulsion

**Definition:** Players should return because they feel curiosity and warmth — never because we manufactured anxiety or obligation.

**This means we DO:**
- Design "I wonder what happened" moments for returning players
- Create genuine surprises and delightful discoveries
- Respect the player's time and attention
- Make every session feel complete, even short ones

**This means we DON'T:**
- Use loss aversion as a primary retention mechanic (expiring rewards, decaying progress)
- Design systems that punish absence
- Create FOMO-driven engagement loops
- Optimize for session frequency at the expense of session quality

**Decision test:** *If a player takes a week off and returns, do they feel welcomed back or punished for leaving?*

---

### Value 3: Trust Over Extraction

**Definition:** Long-term player trust generates more lifetime revenue than short-term extraction. We earn money by creating value, not by exploiting psychology.

**This means we DO:**
- Price fairly and transparently
- Make free-to-play genuinely free to enjoy
- Offer purchases that feel like genuine value, not relief from artificial pain
- Build monetization that players would recommend to friends

**This means we DON'T:**
- Create pay-to-win advantages
- Use manipulative pricing (fake discounts, artificial urgency on purchases)
- Gate core content behind paywalls
- Target vulnerable players (whales) with exploitative spending patterns

**Decision test:** *Would we feel comfortable if a journalist published our monetization design in detail? If not, redesign it.*

---

### Value 4: Leverage Over Labor

**Definition:** Every hour of human effort should produce disproportionate output. We choose tools, architectures, and processes that multiply impact — not ones that require brute force.

**This means we DO:**
- Automate everything that doesn't require human judgment
- Build reusable systems before building game-specific features
- Invest in AI tooling, templates, and frameworks that accelerate future work
- Measure productivity by output quality, not hours worked

**This means we DON'T:**
- Manually perform tasks that can be reliably automated
- Build one-off solutions when a reusable system would take only marginally longer
- Conflate busyness with progress
- Resist new tools because existing ones are "good enough"

**Decision test:** *Will this approach still be the right choice when we're building Game #5? If not, invest in the reusable version now.*

---

### Value 5: Data Over Debate

**Definition:** When opinions conflict, design an experiment. Let player behavior decide. Strong opinions, loosely held — and held only until evidence arrives.

**This means we DO:**
- Define success metrics before building features
- Run A/B tests for any design decision where reasonable people disagree
- Track the metrics that matter (retention, satisfaction, LTV) not vanity metrics (downloads, pageviews)
- Change our minds when data contradicts our assumptions

**This means we DON'T:**
- Ship features without measurable success criteria
- Let seniority or loudness determine design outcomes
- Ignore data because it contradicts our preferences
- Over-index on short-term metrics at the expense of long-term player health

**Decision test:** *Can we articulate what data would change our mind about this decision? If not, we're not being data-driven — we're being stubborn.*

---

### Value 6: Small Over Big

**Definition:** Constraints force creativity. A small team with the right tools will always out-innovate a large team with the wrong process. We are small by design, not by circumstance.

**This means we DO:**
- Celebrate simplicity and elegance in solutions
- Scope ruthlessly — cut features that don't earn their complexity
- Move fast by keeping the team small and the tools powerful
- Make decisions quickly because coordination costs are low

**This means we DON'T:**
- Add headcount as the default solution to capacity problems
- Build complex systems when simple ones would serve
- Create processes that require more than two people to execute
- Envy larger studios' resources — we envy their problems less

**Decision test:** *Does this decision increase our complexity faster than it increases our capability? If yes, find a simpler path.*

## 7. Acceptance Criteria

- [ ] Each value has a clear behavioral definition with DO and DON'T examples.
- [ ] Each value includes a decision test that can be applied mechanically.
- [ ] No two values contradict each other in normal operating conditions.
- [ ] An AI agent can reference a specific value to justify or reject a proposed action.
- [ ] The values are distinct from generic corporate values — swapping our name for another company's name should make at least 3 values feel wrong.

## 8. KPIs

| KPI | Target | Measurement |
|-----|--------|-------------|
| Value citation in decision logs | Every P0/P1 decision cites at least one value | Decision log audit (23_Decisions) |
| Value conflict resolution | Values resolve 80%+ of design disagreements without founder escalation | Escalation tracking |
| Player sentiment alignment | Player reviews reflect our values (words like "wonder," "trust," "fair") | Sentiment analysis on reviews |
| Value consistency across docs | 0 contradictions between any document and core values | Quarterly consistency audit |

## 9. Risks

| Risk | Likelihood | Impact | Mitigation |
|------|-----------|--------|------------|
| Values too idealistic, ignored in practice | Medium | High | Decision tests make values actionable. Quarterly audit checks for value drift. |
| "Trust Over Extraction" limits revenue | Low | Medium | Trust builds LTV. Short-term revenue sacrifice is long-term investment. Track LTV, not just ARPDAU. |
| Values become outdated as company evolves | Low | Medium | Annual values review. Decision History tracks any amendments. |
| AI agents misinterpret value intent | Medium | Medium | Behavioral examples (DO/DON'T) reduce ambiguity. Prompt templates reference specific values. |

## 10. Future Expansion

- **Hiring filter.** When hiring humans, use values as interview criteria. Each value maps to behavioral interview questions.
- **Partner evaluation.** Publishers, brand partners, and ad networks must pass a values compatibility check.
- **Multi-game consistency.** All future games inherit these values. Game-specific values may extend but never contradict these.

## 11. AI Automation Opportunities

- **Value compliance checking.** An agent can audit feature proposals, PRDs, and design documents against these values and flag violations.
- **Decision log enrichment.** Automatically suggest which values are relevant to each logged decision.
- **Player review analysis.** NLP analysis of player reviews to measure how well our values manifest in player perception.
- **Onboarding quiz generation.** Generate scenario-based questions to test whether new agents (or future humans) understand the values.

## 12. Open Questions

1. Should values be weighted (some more important than others) or are they all equal?
2. How do we handle genuine conflicts between values (e.g., "Data Over Debate" says test it, but "Trust Over Extraction" says don't even test exploitative mechanics)?
3. Should players ever see our values? (Transparency as a brand asset?)

## 13. Decision History

| Date | Decision | Rationale |
|------|----------|-----------|
| 2026-06-27 | Six values selected | Covers product (Worlds, Wonder), ethics (Trust), operations (Leverage, Data), and identity (Small). MECE for decision-making. |
| 2026-06-27 | Behavioral definitions required | Values without DO/DON'T examples are unenforceable. Every value must be actionable. |

## 14. Related Documents

| Doc ID | Title | Relationship |
|--------|-------|-------------|
| 01-001 | Company Vision | Values operationalize the vision into daily decisions |
| 02-002 | Design Principles | Translates values into game design-specific rules |
| 02-003 | Operating Principles | Translates values into workflow and process rules |
| 02-004 | Quality Standards | Defines the quality bar that values like "Leverage Over Labor" demand |
| 02-005 | Ethical Framework | Deep dive into "Trust Over Extraction" for monetization specifically |
| 00-001 | Founder Charter | Founder is the ultimate guardian of these values |
| 00-003 | Decision Framework | Values are the first filter in the decision-making process |
