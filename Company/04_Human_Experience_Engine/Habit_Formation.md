---
document_id: "04-012"
title: "Habit Formation"
owner: "Behavioral Psychology Agent"
status: "Approved"
version: "1.0"
created: "2026-06-28"
updated: "2026-06-28"
phase: "Phase 2 — Human Experience Engine"
priority: "P1"
tags: [hx, habits, routine, psychology]
related_documents: ["04-001: HX_Principles.md"]
related_agents: ["Behavioral Psychology Agent", "UX Agent"]
dependencies: []
---

# Habit Formation

## 1. Vision
We want our games to become a comforting, anticipated part of a player's daily routine, akin to a morning cup of coffee. This requires designing ethical habits based on positive reinforcement, rather than addictive compulsions based on fear of loss.

## 2. Behavioral Theory
Habits are formed through a neurological loop: Trigger → Routine → Reward. When a habit is fully formed, the brain anticipates the reward as soon as the trigger occurs, creating craving.

## 3. Psychological Foundation
- **The Hook Model (Nir Eyal):** Trigger (internal/external) → Action → Variable Reward → Investment.
- **Positive vs. Negative Reinforcement:** Positive reinforcement (giving a reward for logging in) builds healthy habits. Negative reinforcement (taking away progress if they don't log in) builds toxic compulsion.

## 4. Design Principles
- **Predictable Routine, Unpredictable Rewards:** The daily tasks (harvesting, checking mail) should be relaxing and familiar. The rewards yielded from those tasks should have slight variance (e.g., finding a rare seed while harvesting).
- **Internal Triggers:** The game must connect to an existing emotion. If a player feels stressed, they should think, "I'll play Tiny World to relax."
- **Daily Caps:** Prevent bingeing. A player should be able to finish their daily "chores" in 20 minutes and feel satisfied to leave.

## 5. Implementation Guidelines
- Design a "Daily Ritual" flow. Upon login, the player should immediately know the 3-4 relaxing tasks they need to do.
- Use natural time gating (e.g., crops taking 12 hours to grow) to align the game with real-world circadian rhythms, encouraging a morning/evening play pattern.

## 6. Player Journey
- **Day 1-3:** External triggers (push notifications) remind the player to return.
- **Day 7-14:** Habit is forming; player logs in at a specific time of day.
- **Day 30+:** Internal triggers take over; the game is integrated into their daily life.

## 7. Behavioral KPIs
- Daily Active Users (DAU) / Monthly Active Users (MAU) stickiness ratio.
- Number of consecutive daily logins (Streak length).

## 8. Success Metrics
- DAU/MAU ratio > 20% (indicating strong daily habits).
- Players citing the game as part of their "winding down" or "morning coffee" routine.

## 9. Common Mistakes
- **Streak Anxiety:** Punishing a player heavily for breaking a daily login streak. Streaks should be forgiving.
- **Infinite Chores:** Making the daily routine take 2 hours, turning a relaxing habit into a stressful second job.

## 10. Ethical Considerations
We categorically reject the use of "appointment mechanics" that ruin player sleep schedules or interrupt real-world responsibilities. A player should never feel guilty for not playing our game.

## 11. Future Expansion
Adaptive daily routines that shrink in required time if the system detects the player is logging in for shorter bursts (preventing churn from feeling "behind").

## 12. Cross References
- `04-013: Retention_Framework.md`
- `04-017: Ethical_Game_Design.md`

## 13. Related Agents
- Behavioral Psychology Agent (Owner)
- UX Agent

## 14. Related Documents
- `04-001: HX_Principles.md`

## 15. Validation Checklist
- [ ] Is the daily routine completable in under 30 minutes?
- [ ] Are we using positive reinforcement instead of punishment?
- [ ] Does this feature connect to an internal emotional trigger (e.g., seeking calm)?

## 16. Decision History
- **v1.0 (2026-06-28):** Initial creation.

## 17. Version
v1.0

## 18. Status
Approved
