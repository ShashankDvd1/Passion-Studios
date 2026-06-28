---
document_id: "04-018"
title: "Experience Metrics"
owner: "Analytics Agent"
status: "Approved"
version: "1.0"
created: "2026-06-28"
updated: "2026-06-28"
phase: "Phase 2 — Human Experience Engine"
priority: "P1"
tags: [hx, metrics, data, kpi]
related_documents: ["01-004: Success Definition"]
related_agents: ["Analytics Agent"]
dependencies: []
---

# Experience Metrics

## 1. Vision
We cannot optimize what we do not measure. While traditional metrics (DAU, ARPDAU) measure business health, Experience Metrics measure the emotional and psychological health of the player base.

## 2. Behavioral Theory
Traditional metrics are lagging indicators; a player's emotional state shifts long before they actually stop playing. By measuring experience directly, we can predict and prevent churn.

## 3. Psychological Foundation
- **Affective computing principles:** Using behavioral proxy data to infer emotional states.
- **Survey Psychology:** Asking the right questions at the right time without interrupting flow.

## 4. Design Principles
### Core Experience Metrics:
1. **Happy Retained Players (HRP):** Our North Star. (Players who log in 3+ days a week and have a positive sentiment score).
2. **Session Health Index (SHI):** A composite score measuring if sessions end naturally or abruptly (rage quit).
3. **Curiosity Index:** The rate at which players are discovering new mechanics or areas relative to their time in game.
4. **Social Cohesion Score:** The volume of positive asynchronous interactions.

## 5. Implementation Guidelines
- **Telemetry:** Track not just *what* the player clicks, but *how long* they hesitate before clicking.
- **In-Game Sentiment:** Use micro-surveys (1 question, 1 click, e.g., a smiley face scale) integrated naturally into the world, not as intrusive pop-ups.

## 6. Player Journey
- Metrics must be segmented by player lifecycle (e.g., the expected SHI for a D1 player is very different from a D90 player).

## 7. Behavioral KPIs
- Survey response rates.
- Correlation coefficient between SHI and D30 retention.

## 8. Success Metrics
- Ability to accurately predict churn 7 days in advance based on Experience Metrics.

## 9. Common Mistakes
- **Optimizing for the Metric:** If we make the micro-survey mandatory to progress, response rates go up, but data quality becomes garbage (players just click randomly to close it).
- **Ignoring the Qual:** Data tells you *what* happened; qualitative feedback tells you *why*.

## 10. Ethical Considerations
All behavioral tracking must be strictly anonymized. We track aggregate cohorts, never individual players.

## 11. Future Expansion
Advanced sentiment analysis on community platforms (Discord, Reddit) integrated directly into the Experience Metrics dashboard.

## 12. Cross References
- `04-019: Experience_Experiment_Framework.md`

## 13. Related Agents
- Analytics Agent (Owner)
- UX Agent

## 14. Related Documents
- `01-004: Success Definition`

## 15. Validation Checklist
- [ ] Is this metric a leading indicator (predictive) or a lagging indicator?
- [ ] Is the data collection method non-intrusive?
- [ ] Is the data fully anonymized?

## 16. Decision History
- **v1.0 (2026-06-28):** Initial creation. Defined Happy Retained Players (HRP) and Session Health Index (SHI).

## 17. Version
v1.0

## 18. Status
Approved
