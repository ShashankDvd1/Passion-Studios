---
document_id: "02-002"
title: "Design Principles"
owner: "Game Designer Agent"
status: "Approved"
version: "1.0"
created: "2026-06-27"
updated: "2026-06-27"
phase: "Phase 0 — Constitutional Layer"
priority: "P0"
tags:
  - design
  - philosophy
  - game-design
  - behavioral-design
  - feature-filter
related_documents:
  - "01-001: Company Vision"
  - "02-001: Core Values"
  - "02-005: Ethical Framework"
  - "04-001: Behavior Engine Overview (Phase 2)"
  - "10-001: Game Design Document (Phase 4)"
related_agents:
  - "Game Designer Agent"
  - "Product Manager Agent"
  - "Behavioral Psychology Agent"
  - "UX Agent"
  - "Monetization Director Agent"
dependencies:
  - "01-001: Company Vision"
  - "02-001: Core Values"
---

# Design Principles

## 1. Vision

These principles translate our core values into game design decisions. Where values answer "what kind of company are we?", design principles answer "what kind of experiences do we build?"

Every feature, system, event, and interface in any Wonder Forge Studios game must satisfy these principles. They are not guidelines — they are gates. A feature that violates a design principle does not ship, regardless of how fun it seems in isolation.

These principles are engine-agnostic and game-agnostic. They apply to Tiny World and every future title. Game-specific design rules extend these principles but never contradict them.

## 2. Problem Statement

Game development is an infinite decision space. Without design principles, teams make locally optimal choices that create globally incoherent experiences. A brilliant monetization mechanic might undermine emotional attachment. A clever retention loop might create compulsion instead of wonder. An engaging meta-system might overwhelm casual players.

Design principles reduce this infinite space to a manageable one by eliminating entire categories of bad decisions before they reach production.

For an AI-native studio, this problem is amplified. AI agents generate features, content, and systems at high velocity. Without principles encoded into their prompts and review criteria, output quality becomes inconsistent and misaligned with the studio's identity.

## 3. Goals

1. Establish a universal feature gate — seven questions every feature must answer before entering development.
2. Define the emotional design framework — the specific emotions we design toward and away from.
3. Create principles specific enough that two different designers (human or AI) would make the same decision when applying them.
4. Ensure every principle is testable through player behavior data.

## 4. Non-Goals

- These principles do not define specific game mechanics (see `10_Game_Design`).
- These principles do not define UI/UX patterns (see `11_UI_UX`).
- These principles do not define behavioral psychology models (see `04_Behavior`).
- These principles are not a style guide for art or audio direction.

## 5. Principles

### Principle 1: The World Is the Product

Gameplay exists to strengthen the player's emotional attachment to their world. Every feature must deepen the world's identity, expand its boundaries, or enrich the player's relationship with it.

**Test:** Remove the world. Does the feature still work as a standalone mechanic? If yes, the feature isn't rooted in the world — redesign it.

**Application:** A crafting system should not feel like a generic recipe screen. It should feel like creating something unique for *this* world. The ingredients should come from the world. The results should exist in the world. The act of crafting should feel like an act of world-building.

### Principle 2: Design for Wonder, Not Habit

The player should return because they are genuinely curious, not because a notification manufactured urgency. Wonder is sustainable. Habit is fragile.

**Test:** If we removed all notifications and reminders, would players still want to come back? If the answer is uncertain, the intrinsic motivation is too weak.

**Application:** When a player opens the game after being away, the first thing they should experience is a surprise — something grew, something changed, something new arrived. Never greet a returning player with a task list.

### Principle 3: Every Interaction Creates Emotion

No interaction should be emotionally neutral. Every tap, swipe, discovery, collection, and creation should trigger one of our eleven target emotions.

**Target Emotions:**

| Emotion | Definition | Example Trigger |
|---------|-----------|-----------------|
| Curiosity | "What's over there? What happens if...?" | Fog of war, mysterious locked areas, hints of hidden content |
| Progress | "I'm getting somewhere. My world is growing." | Visual expansion, new unlocks, skill improvement |
| Ownership | "This is mine. I built this." | Customization, naming, unique arrangements |
| Discovery | "I found something! I didn't expect that!" | Hidden collectibles, emergent events, rare encounters |
| Comfort | "This feels cozy. I want to stay." | Ambient sound, warm visuals, low-pressure exploration |
| Surprise | "Whoa! I didn't see that coming." | Random gifts, world events, seasonal changes |
| Identity | "This reflects who I am." | Style choices, avatar expression, world personality |
| Collection | "I need to find them all." | Catalogs, museums, galleries with visible gaps |
| Wonder | "This is beautiful. This is magical." | Scenic moments, animations, atmosphere |
| Mastery | "I've figured this out. I'm good at this." | Skill-based challenges, efficiency optimization |
| Social Connection | "Look what I built. Let's play together." | Visiting friends, gifts, collaborative goals |

**Anti-emotions (never design toward these):**

| Anti-Emotion | Definition | Red Flag |
|-------------|-----------|----------|
| Anxiety | "I'll lose progress if I don't play." | Decaying resources, expiring rewards |
| Guilt | "I should be playing but I'm not." | Neglect mechanics, guilt-trip notifications |
| Frustration | "This is unfair. The game is against me." | RNG-gated progress, pay-to-progress walls |
| Boredom | "There's nothing to do." | Content drought, repetitive loops |
| Regret | "I shouldn't have spent that." | Buyer's remorse, misleading purchases |

### Principle 4: Respect the Player's Time

Every session — whether 30 seconds or 30 minutes — should feel complete and valuable. We never waste the player's time with unnecessary loading, unskippable animations, or artificial wait gates designed to sell skip tokens.

**Test:** Time the path from app launch to meaningful player interaction. If it exceeds 5 seconds on a warm start, it's too slow. If any session feels incomplete without spending money, the design is broken.

**Application:** A player with 2 minutes at a bus stop should be able to open the game, experience something satisfying, and close it feeling good. A player with 30 minutes at home should have depth to explore without hitting empty space.

### Principle 5: Simplicity Is the Final Sophistication

Complex systems must present as simple experiences. The player should never need to read a tutorial to understand a mechanic. If it requires explanation, it requires redesign.

**Test:** Show the feature to someone who has never played the game. If they cannot intuit the interaction within 10 seconds, simplify the presentation (not necessarily the underlying system).

**Application:** An economy with five interconnected currencies is a design failure, regardless of how well-balanced the math is. The player should interact with at most two currencies at any given moment, even if more exist under the hood.

### Principle 6: Systemic Over Scripted

Prefer systems that generate emergent behavior over content that is hand-authored once and consumed once. Systems scale. Scripts deplete.

**Test:** Will this content feel fresh on the 100th encounter? If it is identical every time, it should be a system, not a script.

**Application:** Weather in the world should not be a cosmetic toggle. It should affect which creatures appear, what plants grow, how NPCs behave. The system creates novelty without content creation cost.

### Principle 7: Reusable by Default

Every feature should be designed for the engine, not for the game. If Tiny World is the only game that can use this feature, challenge the abstraction.

**Test:** Can this feature be configured via ScriptableObjects and dropped into a different game genre with different art? If not, separate the game-specific layer from the reusable layer.

**Application:** A "daily gift" system is not a Tiny World feature. It is an engine feature with configurable rewards, schedules, and presentation layers. The engine provides the system; the game provides the content.

## 6. Requirements

### The Seven-Question Feature Gate

Every feature must answer all seven questions before entering development:

1. **Why does it exist?** What player need or business goal does it serve?
2. **What player behavior does it create?** Describe the specific actions players will take.
3. **What emotion does it trigger?** Reference the target emotions table. Name at least one.
4. **How is success measured?** Define the KPI. Define the target. Define the measurement method.
5. **Can it be reused?** How does this feature transfer to the engine for future games?
6. **Can AI generate it?** What parts of this feature can be AI-produced? Content? Configuration? Variants?
7. **Can future games inherit it?** What would need to change for Game #2 to use this feature?

If the answer to question 1 is vague, the feature lacks purpose.
If the answer to question 3 references an anti-emotion, the feature is redesigned.
If the answer to questions 5–7 is "no" for all three, the feature must justify its existence as a one-off.

## 7. Acceptance Criteria

- [ ] Every design principle can be applied as a pass/fail test to a proposed feature.
- [ ] The emotional design framework covers the full range of desirable player states without overlap.
- [ ] The Seven-Question Feature Gate can be completed in under 10 minutes per feature.
- [ ] An AI Game Designer Agent can apply these principles without human clarification.
- [ ] No principle contradicts a core value from `02-001`.

## 8. KPIs

| KPI | Target | Measurement |
|-----|--------|-------------|
| Feature gate pass rate | 70% of initial proposals pass all 7 questions | Feature gate log |
| Anti-emotion detection | 0 shipped features trigger anti-emotions as measured by player feedback | Player sentiment analysis |
| Principle citation in design docs | 100% of feature PRDs reference at least one principle | Documentation audit |
| Reuse score | 80%+ of features are engine-level, not game-specific | Module registry classification |

## 9. Risks

| Risk | Likelihood | Impact | Mitigation |
|------|-----------|--------|------------|
| Principles too restrictive, blocking innovation | Medium | Medium | Principles are gates, not cages. Novel features that satisfy the gate in unexpected ways are celebrated. |
| Emotional design framework feels mechanical when applied literally | Medium | Low | Emotions are design targets, not checklists. A feature doesn't need to trigger all 11. One genuine emotion beats three forced ones. |
| "Reusable by default" slows initial development | High | Medium | Accept 20% overhead on Tiny World development for 80% savings on future games. Track reuse debt explicitly. |
| AI agents apply principles too rigidly | Medium | Medium | Human review of principle application. Periodic recalibration of agent interpretation. |

## 10. Future Expansion

- **Genre-specific extensions.** Each future game may add 2–3 game-specific design principles that extend (never contradict) this set.
- **Player research integration.** As player data accumulates, refine the emotional framework with validated behavioral signals for each emotion.
- **Automated principle testing.** Build analytics events that detect when anti-emotions are likely occurring (rage quits, uninstalls after specific events, complaint patterns).

## 11. AI Automation Opportunities

- **Feature gate automation.** Game Designer Agent runs incoming feature proposals through the Seven-Question Gate and generates a compliance report.
- **Emotion tagging.** Content Creator Agent tags all generated content with target emotions, enabling portfolio analysis of emotional coverage.
- **Anti-emotion detection.** Analytics Agent monitors behavioral signals that correlate with anti-emotions (short angry sessions, uninstalls, negative reviews) and flags potential design principle violations.
- **Reuse scoring.** Unity Architect Agent evaluates new systems for reuse potential and flags game-specific coupling.

## 12. Open Questions

1. Should we weight target emotions differently? (Is Curiosity more important than Mastery for our genre?)
2. How do we handle the tension between "Simplicity" and "Systemic" when systems become complex?
3. Should the Seven-Question Gate be a literal form that agents fill out, or a narrative section in PRDs?

## 13. Decision History

| Date | Decision | Rationale |
|------|----------|-----------|
| 2026-06-27 | Seven design principles established | Covers world-centricity, emotional design, player respect, simplicity, emergence, and reuse. Comprehensive without overlap. |
| 2026-06-27 | Eleven target emotions defined | Derived from founder's emotional design vision (Curiosity, Progress, Ownership, Discovery, Comfort, Surprise, Identity, Collection, Wonder, Mastery, Social Connection). |
| 2026-06-27 | Five anti-emotions codified | Anxiety, Guilt, Frustration, Boredom, Regret explicitly banned from design intent. |

## 14. Related Documents

| Doc ID | Title | Relationship |
|--------|-------|-------------|
| 01-001 | Company Vision | "Worlds over games" vision originates here |
| 02-001 | Core Values | Values this document operationalizes for game design |
| 02-005 | Ethical Framework | Ethics behind the anti-emotion prohibitions |
| 04-001 | Behavior Engine Overview | Psychological models that underpin the emotional framework |
| 10-001 | Game Design Document | First application of these principles to a specific product |
