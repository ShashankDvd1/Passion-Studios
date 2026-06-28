---
document_id: "04-019"
title: "Experience Experiment Framework"
owner: "Analytics Agent"
status: "Approved"
version: "1.0"
created: "2026-06-28"
updated: "2026-06-28"
phase: "Phase 2 — Human Experience Engine"
priority: "P1"
tags: [hx, experiments, validation, testing]
related_documents: ["18-001: Experiment Framework"]
related_agents: ["Analytics Agent", "Product Manager Agent"]
dependencies: ["18-001: Experiment Framework"]
---

# Experience Experiment Framework

## 1. Vision
This is a specialized extension of the company-wide Experiment Framework (`18-001`). While Phase 1 experiments test mechanical changes (e.g., "Does moving the button increase clicks?"), this framework tests emotional hypotheses (e.g., "Does this narrative change increase empathy?").

## 2. Behavioral Theory
Emotional changes are harder to quantify than mechanical changes. We must use behavioral proxies (metrics that correlate with emotions) to validate our hypotheses.

## 3. Psychological Foundation
- **A/B Testing Behavioral Shifts:** Testing not just conversion rates, but shifts in how players spend their time (e.g., spending more time decorating vs. farming).

## 4. Design Principles
### The Experience Hypothesis
**If we** [change an experiential element]
**Then** players will feel [Target Emotion],
**Which will cause them to** [change behavior],
**Measured by** [Experience Metric].

*Example:*
**If we** make the raining audio softer and add a cozy fire crackle,
**Then** players will feel *Calm*,
**Which will cause them to** stay logged in longer during rain events,
**Measured by** a 10% increase in Session Length during rainy weather.

## 5. Implementation Guidelines
- Inherit all statistical rigor (sample sizes, durations, guardrail KPIs) from `18-002: AB Test Standards`.
- Always include a qualitative guardrail (e.g., checking Discord sentiment for the treatment group).

## 6. Player Journey
- Experience experiments are particularly useful for validating onboarding (testing for *Curiosity* and *Competence*) and long-term meta-loops (testing for *Ownership*).

## 7. Behavioral KPIs
- Number of Experience Experiments run per sprint.
- Win rate of emotional hypotheses.

## 8. Success Metrics
- Measurable shifts in the Session Health Index (SHI) driven by validated experiments.

## 9. Common Mistakes
- **Testing the Unmeasurable:** Creating a hypothesis like "Players will love this more" without defining a measurable behavioral proxy.
- **Ignoring the Core Framework:** Failing to use a control group because "it's just a feeling." Feelings must still be measured scientifically.

## 10. Ethical Considerations
We do not run psychological experiments designed to test negative emotions (e.g., "Let's see if making them lose items increases anxiety-driven logins").

## 11. Future Expansion
Integration with real-time biometric testing during structured playtests (eye-tracking, heart rate).

## 12. Cross References
- `18-001: Experiment Framework`
- `04-018: Experience_Metrics.md`

## 13. Related Agents
- Analytics Agent (Owner)
- Product Manager Agent

## 14. Related Documents
- `18-003: Hypothesis Template`

## 15. Validation Checklist
- [ ] Does the hypothesis explicitly name a Target Emotion?
- [ ] Is there a measurable behavioral proxy?
- [ ] Does this inherit the statistical rules from 18-002?

## 16. Decision History
- **v1.0 (2026-06-28):** Initial creation. Built as an extension to Phase 1 experimentation.

## 17. Version
v1.0

## 18. Status
Approved
