---
document_id: "02-005"
title: "Ethical Framework"
owner: "Founder"
status: "Approved"
version: "1.0"
created: "2026-06-27"
updated: "2026-06-27"
phase: "Phase 0 — Constitutional Layer"
priority: "P0"
tags:
  - ethics
  - monetization
  - player-trust
  - policy
  - governance
related_documents:
  - "01-001: Company Vision"
  - "02-001: Core Values"
  - "02-002: Design Principles"
  - "17-001: Monetization Strategy (Phase 6)"
  - "21-001: Legal Compliance (Phase 7)"
related_agents:
  - "Founder Agent"
  - "Monetization Director Agent"
  - "Product Manager Agent"
  - "Behavioral Psychology Agent"
  - "QA Agent"
dependencies:
  - "01-001: Company Vision"
  - "02-001: Core Values"
---

# Ethical Framework

## 1. Vision

This framework defines the ethical boundaries that constrain every system, feature, and business decision at Wonder Forge Studios. It is not a legal compliance document — it is a product design document. Ethics are not a constraint on our business; they are a competitive advantage.

In an industry rife with manipulative monetization, dark patterns, and player exploitation, a studio that genuinely respects its players builds something most competitors cannot: trust. Trust converts to organic growth, positive reviews, long retention, and lifetime value that predatory designs cannot match over a five-year horizon.

This framework operationalizes the "Trust Over Extraction" core value (`02-001`) into specific, enforceable rules.

## 2. Problem Statement

Mobile free-to-play games have an earned reputation for exploitation. Loot boxes designed to trigger gambling responses. Energy systems that manufacture artificial scarcity. Notifications designed to create anxiety. Spending funnels that target vulnerable individuals.

These practices work in the short term. They fail in the long term — through regulation, player backlash, negative press, and the constant churn of players who feel deceived.

An AI-native studio faces an additional ethical dimension: AI agents optimizing for engagement and revenue will naturally converge on exploitative patterns unless explicitly constrained. An AI told to "maximize retention" will discover dark patterns independently. The ethical framework must be embedded in agent instructions, not merely documented in a file humans read.

## 3. Goals

1. Define clear ethical boundaries that every agent and system must respect.
2. Classify practices into three categories: Required, Permitted, and Prohibited.
3. Create an ethical review checklist that can be applied to any feature.
4. Ensure monetization design earns revenue through value creation, not through psychological exploitation.
5. Protect vulnerable player populations (minors, compulsive spenders) through systemic safeguards.

## 4. Non-Goals

- This is not a legal compliance document (see `21_Legal`). Legal compliance is the floor. This framework is the ceiling.
- This does not define specific monetization mechanics (see `17_Monetization`).
- This does not define specific privacy implementation (handled in `14_Backend` and `21_Legal`).

## 5. Principles

1. **Players are people, not revenue units.** Every decision must consider the human being holding the phone. Would we be comfortable if our own family members experienced this design?
2. **Transparency earns trust.** Players should always understand what they are getting, what it costs, and what the odds are. Hidden information is hidden manipulation.
3. **Voluntary spending only.** The free experience must be genuinely satisfying. Spending money should enhance joy, not relieve frustration.
4. **Protect the vulnerable.** Minors, compulsive spenders, and neurodiverse players require additional protection beyond what we provide to the general population.
5. **When in doubt, choose the player.** If a design decision has an uncertain ethical impact, default to the option that is better for the player, even at a revenue cost.

## 6. Requirements

### 6.1 Practice Classification

#### Required Practices (Must implement)

| Practice | Rationale |
|----------|-----------|
| Disclose all randomized reward probabilities | Players deserve to know their odds. Many jurisdictions now legally require this. |
| Spending confirmation for purchases above $10 | Prevent accidental or impulsive high-value purchases |
| Session length awareness (gentle, non-punitive) | "You've been playing for an hour — your world will be here when you get back!" |
| Parental controls and age-appropriate content | COPPA compliance is legal minimum. We exceed it. |
| Clear refund path | Make it easy for players to undo purchase mistakes. Frictionless refunds build trust. |
| Opt-in notifications only | Never default to push notifications. Let players choose what they want to hear about. |
| Offline functionality for core features | The game should not become unusable without internet. |

#### Permitted Practices (Allowed with guidelines)

| Practice | Guidelines |
|----------|-----------|
| Rewarded ads | Must be genuinely optional. Reward must be meaningful but not so large that opting out feels punishing. Maximum frequency: configurable, start at 5/day. |
| Cosmetic monetization | Cosmetics must not convey gameplay advantage. Must not create social pressure through exclusivity shaming. |
| Season pass / battle pass | Must be completable with reasonable play (not requiring daily sessions for entire duration). Free tier must feel genuinely valuable. |
| Limited-time content | Must not create severe FOMO. Content can return in future rotations. Never "last chance forever." |
| Personalized offers | Must not target based on spending vulnerability signals. Must not increase prices based on spending history. |
| Dual currency systems | Soft currency earned through play. Premium currency purchased or earned slowly. Conversion must feel fair, not punitive. |

#### Prohibited Practices (Never implement)

| Practice | Rationale |
|----------|-----------|
| Pay-to-win mechanics | Violates Core Value #3 (Trust Over Extraction). Destroys competitive fairness. |
| Loot boxes with purchasable keys | Gambling-adjacent. Exploits variable reward psychology for revenue extraction. |
| Artificial energy systems designed to sell refills | Manufactured scarcity that punishes engagement. Contradicts "Respect the Player's Time." |
| Punishment for absence (decaying resources, dying crops/pets) | Creates guilt and anxiety. Violates anti-emotion rules in Design Principles. |
| Fake discounts or artificial urgency timers | Deceptive pricing. Would not survive journalist scrutiny. |
| Targeted whale hunting (escalating offers to high spenders) | Exploits vulnerable individuals. Predatory. |
| Dark pattern UI (hidden costs, confusing currency, misleading buttons) | Deceptive design erodes trust irreversibly. |
| Notification manipulation (guilt-trips, loss-framing, false urgency) | "Your village misses you!" is emotional manipulation disguised as engagement. |
| Child-targeted spending prompts | Legal and ethical red line. Zero tolerance. |
| Selling gameplay advantages (faster progress, stronger items, exclusive power) | Pay-to-win by another name. Same prohibition. |

### 6.2 Ethical Review Checklist

Every player-facing feature must pass this checklist before shipping:

```
□ Does this feature respect the player's time?
□ Does this feature function without spending money?
□ If monetized, does spending feel like buying value or buying relief?
□ Would this feature survive a critical journalist's investigation?
□ Would we be comfortable if our players were our own children?
□ Does this feature create a target emotion or an anti-emotion?
□ Is the player fully informed about costs, odds, and outcomes?
□ Does this feature work for the most vulnerable player, not just the average one?
□ If a player showed this to a friend, would they recommend the game or warn against it?
```

If any answer is negative, the feature requires redesign before shipping.

### 6.3 Vulnerable Player Protections

| Population | Protection |
|-----------|-----------|
| Minors (under 16) | No monetization prompts. Parental consent for social features. Age-appropriate content. COPPA compliance. |
| Compulsive spenders | Spending pattern detection. Voluntary spending limits. Cooling-off periods after rapid successive purchases. |
| Neurodiverse players | Configurable visual effects (reduce motion, color adjustments). Clear UI without sensory overload. |
| Players with limited time | Every session must feel complete regardless of length. No mechanics that require 30+ uninterrupted minutes. |

## 7. Acceptance Criteria

- [ ] Every prohibited practice is unambiguous — no edge cases that could be argued either way.
- [ ] Every permitted practice has specific guidelines, not just blanket approval.
- [ ] The ethical review checklist can be completed in under 5 minutes per feature.
- [ ] An AI agent can classify a proposed feature as Required/Permitted/Prohibited without human interpretation.
- [ ] Vulnerable player protections are systemic (built into the platform) not advisory (relying on individual judgment).

## 8. KPIs

| KPI | Target | Measurement |
|-----|--------|-------------|
| Ethical review checklist compliance | 100% of shipped features pass all 9 questions | Pre-release audit |
| Player trust score (reviews mentioning fairness/trust) | Top quartile vs. competitors | Review sentiment analysis |
| Refund rate | Below industry average | Store analytics |
| Spending concentration (% revenue from top 1% spenders) | Below 40% (industry avg is 50-70%) | Revenue analytics |
| Regulatory complaints | Zero | Legal monitoring |
| Average spending per session | Within 1 std. dev of player median | Spending distribution analysis |

## 9. Risks

| Risk | Likelihood | Impact | Mitigation |
|------|-----------|--------|------------|
| Ethical constraints reduce short-term revenue | High | Medium | Accepted trade-off. Track LTV (3-month, 6-month, 12-month) to prove long-term superiority. |
| Competitors with exploitative monetization outperform on top-line revenue | High | Low | Different game. We compete on sustainability, not peak extraction. |
| AI agents find loopholes in ethical rules | Medium | High | Prohibited practices list is explicit. Ethical review checklist is mandatory. Regular audits. |
| Player expectations calibrated by exploitative games (expect "premium = power") | Medium | Medium | Educate through onboarding. Make cosmetic value proposition compelling. |
| Regulatory landscape changes (stricter or more lenient) | Medium | Low | Our framework already exceeds current regulation. Changes are unlikely to require us to become less ethical. |

## 10. Future Expansion

- **Ethical certification.** As the framework matures, formalize it into a certifiable standard other studios can adopt.
- **Player ethics dashboard.** Give players visibility into our ethical commitments. Radical transparency as brand differentiator.
- **AI ethics auditing.** As AI agents become more autonomous, build automated ethical compliance testing into the CI/CD pipeline.

## 11. AI Automation Opportunities

- **Automated ethical screening.** Monetization Director Agent runs every new IAP, offer, and pricing change through the ethical review checklist.
- **Spending pattern detection.** Analytics Agent monitors for compulsive spending signals and triggers automated protections.
- **Dark pattern detection.** UX Agent scans UI flows for unintentional dark patterns (confusing button placement, hidden costs, misleading language).
- **Regulatory monitoring.** Research Agent tracks global regulatory changes affecting mobile game monetization.

## 12. Open Questions

1. Should we publish our ethical framework publicly? Transparency could be a powerful brand differentiator, but also exposes our constraints to competitors.
2. What spending threshold should trigger the compulsive spending detection system? ($50/day? $100/day? Relative to player history?)
3. Should we implement a "regret window" — a period after purchase where players can undo any transaction with one tap?

## 13. Decision History

| Date | Decision | Rationale |
|------|----------|-----------|
| 2026-06-27 | Three-tier practice classification adopted | Required/Permitted/Prohibited is clear and enforceable. Avoids the gray area of "discouraged but allowed." |
| 2026-06-27 | Loot boxes explicitly prohibited | Even if legal in most jurisdictions, they conflict with our Trust Over Extraction value and create regulatory risk. |
| 2026-06-27 | Whale hunting explicitly prohibited | Revenue concentration in top 1% of spenders is a business risk and an ethical failure. Target broad-based spending. |

## 14. Related Documents

| Doc ID | Title | Relationship |
|--------|-------|-------------|
| 01-001 | Company Vision | Ethics are a core component of the company vision |
| 02-001 | Core Values | "Trust Over Extraction" is the value this framework operationalizes |
| 02-002 | Design Principles | Anti-emotion framework aligns with ethical prohibitions |
| 17-001 | Monetization Strategy | Monetization design must comply with this framework |
| 21-001 | Legal Compliance | Legal requirements form the floor beneath this ethical ceiling |
