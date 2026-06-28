---
document_id: "04-020"
title: "Playtesting Framework"
owner: "QA Agent"
status: "Approved"
version: "1.0"
created: "2026-06-28"
updated: "2026-06-28"
phase: "Phase 2 — Human Experience Engine"
priority: "P1"
tags: [hx, playtesting, qualitative, feedback]
related_documents: ["04-018: Experience_Metrics.md"]
related_agents: ["QA Agent", "UX Agent", "Game Designer Agent"]
dependencies: []
---

# Playtesting Framework

## 1. Vision
Data tells us *what* players are doing; playtesting tells us *why*. The Playtesting Framework ensures we regularly put the game in the hands of real humans and observe their emotional reactions in real-time.

## 2. Behavioral Theory
Self-reporting is flawed. Players often say they want one thing but enjoy another. Observational playtesting bridges the gap between stated preference and revealed preference.

## 3. Psychological Foundation
- **Think-Aloud Protocol:** Having players vocalize their internal thoughts while playing to capture real-time cognitive load and emotional state.
- **Observer Effect:** Mitigating the fact that players act differently when they know they are being watched.

## 4. Design Principles
- **Observe, Don't Guide:** Never tell a playtester how to solve a problem. If they get stuck, the UX has failed.
- **Test for Emotion, Not Just Bugs:** Ask "How did that moment make you feel?" instead of just "Did that button work?"
- **Diverse Cohorts:** Test with hardcore players, casual players, and non-gamers to get a full spectrum of cognitive models.

## 5. Implementation Guidelines
- Conduct internal playtests weekly (studio team playing new builds).
- Conduct external playtests monthly (recruited players matching target demographics).
- Record screen and webcam (with consent) to sync facial expressions with on-screen events.

## 6. Player Journey
- Focus specific playtests on specific journey milestones (e.g., a "D1 Onboarding Test" vs. a "D30 Meta Loop Test").

## 7. Behavioral KPIs
- Number of critical UX flaws identified and resolved prior to launch.
- Tester sentiment scores pre- and post-session.

## 8. Success Metrics
- Zero "obvious" UX failures discovered on launch day.
- High correlation between playtester sentiment and eventual global release sentiment.

## 9. Common Mistakes
- **Defending the Design:** Arguing with a playtester who says a feature is confusing. The player is always right about their own confusion.
- **Testing Too Late:** Waiting until Beta to do the first external playtest, when changes are too expensive to make.

## 10. Ethical Considerations
Playtesters must be compensated fairly for their time, give informed consent for recording, and have their PII protected.

## 11. Future Expansion
Automated AI playtesters (Simulated Users) to run millions of edge-case scenarios overnight, freeing up human playtesters to focus purely on emotional feedback.

## 12. Cross References
- `04-018: Experience_Metrics.md`
- `04-002: Player_Psychology.md`

## 13. Related Agents
- QA Agent (Owner)
- UX Agent
- Game Designer Agent

## 14. Related Documents
- `04-001: HX_Principles.md`

## 15. Validation Checklist
- [ ] Is the playtest focused on observation rather than instruction?
- [ ] Are we testing for emotional resonance, not just functionality?
- [ ] Is player data protected and anonymized?

## 16. Decision History
- **v1.0 (2026-06-28):** Initial creation.

## 17. Version
v1.0

## 18. Status
Approved
