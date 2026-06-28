---
document_id: "01-002"
title: "Studio Identity"
owner: "CEO Agent"
status: "Approved"
version: "1.0"
created: "2026-06-27"
updated: "2026-06-27"
phase: "Phase 0 — Constitutional Layer"
priority: "P0"
tags:
  - brand
  - identity
  - positioning
  - voice
  - culture
related_documents:
  - "01-001: Company Vision"
  - "01-003: Competitive Advantage"
  - "02-001: Core Values"
  - "02-002: Design Principles"
  - "18-001: Marketing Strategy (Phase 7)"
  - "12-001: Visual Identity (Phase 5)"
related_agents:
  - "CEO Agent"
  - "Marketing Agent"
  - "Art Director Agent"
  - "Community Manager Agent"
dependencies:
  - "01-001: Company Vision"
  - "02-001: Core Values"
---

# Studio Identity

## 1. Vision

Studio identity is not a logo. It is the personality that shows up in every player interaction, every app store listing, every community post, every game mechanic, and every business conversation. Before the brand is finalized, we must define what the brand *feels* like.

Wonder Forge Studios (working name) should feel like a studio run by people who genuinely love the worlds they create — because it is. The identity should communicate craft, warmth, wonder, and a quiet confidence that never tips into arrogance. We are the studio that treats players like friends, not like metrics.

When the brand name is finalized, every element described here transfers. The identity is permanent. The name is a vessel.

## 2. Problem Statement

Indie game studios typically fall into two identity traps:

**The Invisible Studio.** No brand identity at all. Players know the game but not the maker. This limits cross-promotion, community building, and portfolio leverage. Every new game starts from zero brand equity.

**The Corporate Studio.** Polished but generic. Indistinguishable from a hundred other mobile publishers. Players feel nothing toward the studio. No loyalty transfers between titles.

The identity we define here must make players think: "Oh, this is from the same studio that made [their favorite game]. I trust them." That transfer of trust is the single most valuable brand asset a portfolio studio can build.

## 3. Goals

1. Define the studio's personality traits, tone of voice, and emotional register.
2. Establish brand positioning relative to competitors and the broader market.
3. Create a naming and identity framework that survives the transition from working name to final brand.
4. Ensure all player-facing communication (in-game, store listing, social, support) speaks with a consistent voice.
5. Build a brand that players can have a relationship with, not just a transactional awareness of.

## 4. Non-Goals

- This document does not finalize the studio name, logo, or visual brand system. Those are outputs of a branding process that happens later.
- This document does not define marketing strategy or channels (see `18_Marketing`).
- This document does not define art direction for games (see `12_Art`).

## 5. Principles

1. **Personality is consistent across contexts.** Whether the player is reading an app store description, an in-game tooltip, a push notification, or a social media post — the voice should feel like the same person wrote it.
2. **Warmth without condescension.** We are friendly, not childish. Playful, not silly. We respect the player's intelligence while keeping things accessible.
3. **Confidence without arrogance.** We are proud of what we build, but we never punch down at competitors or talk over our players.
4. **Actions over claims.** We never say "we care about players." We demonstrate it through design decisions, ethical monetization, and genuine community engagement. Players are smart enough to see through performative compassion.

## 6. Requirements

### 6.1 Brand Personality Traits

The studio has five personality traits, ranked by prominence:

| Rank | Trait | Definition | How It Shows Up |
|------|-------|-----------|-----------------|
| 1 | **Whimsical** | A sense of magic, wonder, and delightful surprise. Not chaotic — charmingly unexpected. | Game aesthetics, update names, surprise mechanics, Easter eggs |
| 2 | **Caring** | Genuine concern for the player's experience and wellbeing. Not performative — demonstrated through design choices. | Ethical monetization, thoughtful onboarding, "welcome back" moments, accessibility |
| 3 | **Crafted** | Attention to detail. Every pixel, every word, every interaction feels intentional. Quality you can feel. | Polish, animation smoothness, micro-interactions, no placeholder content |
| 4 | **Curious** | Always exploring, always asking "what if?" A restless creativity that keeps products fresh. | Regular content updates, experimental features, community-driven exploration |
| 5 | **Honest** | Transparent about what we do and why. No hidden agendas. No dark patterns. What you see is what you get. | Clear pricing, published odds, authentic communications, admitting mistakes publicly |

### 6.2 Tone of Voice

| Context | Tone | Example |
|---------|------|---------|
| In-game UI text | Warm, concise, playful | "Your garden grew three new flowers while you were away!" (not "3 items ready for collection") |
| App Store description | Inviting, evocative, confident | "Build a tiny world that's entirely yours — and discover what happens when you're not looking." |
| Push notifications (opt-in) | Gentle, curious, never urgent | "Something new is blooming in your world 🌸" (never "Your crops are dying! Come back NOW!") |
| Social media | Authentic, behind-the-scenes, community-forward | Showing development process, celebrating player creations, asking for input |
| Support responses | Empathetic, solution-focused, human | "That sounds frustrating — here's what we can do..." (never "As per our policy...") |
| Patch notes | Honest, specific, grateful | "You asked for a way to rearrange your garden — now you can! Thanks for the great idea, [community member]." |
| Error messages | Friendly, non-blaming, helpful | "Hmm, something went sideways. We're looking into it. Your world is safe." |

### 6.3 Brand Positioning Statement

**For** mobile-first players who want to relax, create, and discover,
**Wonder Forge Studios** builds tiny living worlds that feel personal, magical, and genuinely respectful of their time and trust.
**Unlike** hyper-casual publishers that treat players as interchangeable ad impressions, or mega-studios that gate content behind aggressive monetization,
**Our games** create emotional attachment through behavioral design, evolving worlds, and ethical monetization — so players stay because they want to, never because they feel they have to.

### 6.4 Studio Tagline Candidates (Working)

These are directional, not final:
- "Tiny Worlds. Big Hearts."
- "Worlds Worth Returning To."
- "Where Worlds Come Alive."
- "Small Studio. Living Worlds."

Final tagline to be determined during branding phase.

### 6.5 Name Configurability

Until the brand name is finalized:
- All documentation references the studio as "Wonder Forge Studios" (working name).
- All code, systems, and configurations use a `STUDIO_NAME` constant or environment variable.
- No name is hardcoded into technical systems, UI frameworks, or engine code.
- The name transition plan includes: documentation find-replace, asset updates, store listing changes, social media migration.

## 7. Acceptance Criteria

- [ ] A new team member (human or AI) can read this document and write in-game text, a social media post, and a support response that all feel like the same brand.
- [ ] The personality traits are specific enough that two writers would produce tonally similar content independently.
- [ ] The brand positioning statement clearly differentiates from the top 10 competitors in the cozy/casual genre.
- [ ] All examples in the tone of voice table are usable as templates, not just illustrations.
- [ ] The studio name can be changed in under one business day across all systems and documentation.

## 8. KPIs

| KPI | Target | Measurement |
|-----|--------|-------------|
| Brand voice consistency (internal audit) | 90%+ of communications match the defined tone | Quarterly content audit |
| Player-attributed studio recognition | 30%+ of players know the studio name by Month 6 | In-game survey |
| Cross-title brand transfer | 20%+ of Game #2 early adopters cite Game #1 affinity | Attribution survey |
| Community sentiment | 4.5+ average rating on store listings | Store analytics |
| Support satisfaction | 90%+ positive CSAT on support interactions | Support ticket analysis |

## 9. Risks

| Risk | Likelihood | Impact | Mitigation |
|------|-----------|--------|------------|
| Working name "Wonder Forge Studios" leaks into permanent brand assets | Medium | Low | Strict configurability rules. Automated audit for hardcoded names. |
| Brand personality feels inconsistent across AI-generated content | Medium | Medium | Tone of voice examples embedded in all content generation prompts. Regular consistency audits. |
| "Whimsical" interpreted as childish, alienating 25-40 audience | Low | Medium | Whimsy ≠ immaturity. Reference examples: Pixar, Nintendo, Studio Ghibli. Sophisticated wonder. |
| Brand identity too similar to competitors (Supercell, etc.) | Low | Medium | Differentiate through honesty and ethical positioning, not aesthetic similarity. |

## 10. Future Expansion

- **Visual identity system.** Once brand name is finalized, develop logo, color palette, typography, and visual language in a dedicated brand book.
- **Audio branding.** Studio sonic identity — a sound that players associate with our games (like the Netflix "tudum" or the Pixar lamp).
- **Community identity.** What do our players call themselves? Emergent community identity deepens brand attachment.
- **Multi-game brand architecture.** How do individual game brands relate to the studio brand? Endorsed? Sub-branded? Independent?

## 11. AI Automation Opportunities

- **Tone of voice checker.** A Content Creator Agent can evaluate any text (UI, marketing, support) against the tone guidelines and suggest revisions.
- **Brand consistency audit.** Documentation Agent can scan all player-facing text across games for tone violations.
- **Community voice monitoring.** Marketing Agent can analyze community discussions to detect brand perception drift.
- **Name migration automation.** A script-based approach to global find-replace when the studio name is finalized.

## 12. Open Questions

1. When should formal brand naming begin? After Tiny World reaches soft launch? Earlier?
2. Should the studio have a mascot character? (Common in the cozy game space, but risks being derivative.)
3. How prominent should the studio brand be within games? (Splash screen? Settings page? Integrated into game world?)

## 13. Decision History

| Date | Decision | Rationale |
|------|----------|-----------|
| 2026-06-27 | Working name "Wonder Forge Studios" adopted | Placeholder until formal branding. Captures craft ("Forge") and magic ("Wonder"). Configurable throughout all systems. |
| 2026-06-27 | Five personality traits ranked by prominence | Whimsical leads because it is most differentiating. Honest anchors because it is most trust-building. |
| 2026-06-27 | Name configurability made a hard requirement | Brand name will change. Engineering for this change now prevents costly migration later. |

## 14. Related Documents

| Doc ID | Title | Relationship |
|--------|-------|-------------|
| 01-001 | Company Vision | Vision that the brand identity must embody |
| 01-003 | Competitive Advantage | How the brand communicates our advantages |
| 02-001 | Core Values | Values that the brand personality must reflect |
| 02-002 | Design Principles | Design philosophy that the brand promises to players |
| 12-001 | Visual Identity | Future document that translates this identity into visual design |
| 18-001 | Marketing Strategy | How the brand identity is deployed in market |
