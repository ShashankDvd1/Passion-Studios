---
document_id: "00-FOUNDER"
title: "Founder Context"
owner: "Founder"
status: "Permanent Studio Memory"
priority: "P0 - Highest Priority Context"
---

# Founder Context

> **DIRECTIVE:** Every AI agent must load and reference this document before executing any task. It is the permanent memory and highest-priority context document in Wonder Forge Studios.

## 1. Why Wonder Forge Exists
To build a sustainable, AI-native game studio capable of repeatedly shipping successful, behaviorally driven games. We do not just build games; we build emotional engines and the reusable platforms that power them.

## 2. Founder Vision
Wonder Forge is not a game studio that occasionally uses AI. We are an **AI-native game studio**. The *Wonder Forge Game OS* is our competitive advantage. The AI workflow is our force multiplier. The games are proof that the platform works.

## 3. Long-Term Goals
- **The KPI:** Ship 5 games in the next 12 months, with at least one reaching sustainable profitability.
- Establish a highly reusable (70–90% shared code) Unity engineering platform.

## 4. Studio Philosophy
- Execute autonomously.
- Group related work into meaningful milestones.
- Escalate only for strategic decisions, scope changes, or blockers.
- Planning supports shipping. Shipping creates the company.

## 5. Product Philosophy
- Build games that players *choose* to return to, avoiding manipulative dark patterns.
- Rely on Behavioral Product Design (Anticipation, Curiosity, Ownership, Surprise).
- Every 10–15 seconds, the player should experience a meaningful emotional moment or decision.

## 6. AI Philosophy
- AI agents are senior members of the implementation team, responsible for coding, testing, automating, and maintaining the Knowledge Graph.
- Agents must proactively ask: *"What would a world-class mobile game studio prepare next that we have not yet addressed?"* and append it to the backlog.

## 7. Design Principles
- **Studio Experience Guidelines (SEG):** Clarity First, One-Hand Friendly, Accessibility by Default.
- **Privacy & Ethics:** Respectful notifications, privacy by design, and ethical monetization (Cosmetics and Rewarded Ads over Pay-to-Win).

## 8. Tiny World Vision
- Our flagship commercial product. A cozy, living world platform where the player feels they are visiting a persistent place that remembers them.

## 9. MVP Philosophy
- **Ship first. Keep scope intentionally small.**
- Build only the systems explicitly required to launch the 30-day MVP on the Google Play Store.
- If a feature is not required for the MVP, it belongs in the post-launch backlog.

## 10. Shipping Philosophy
- **80/20 Rule:** 20% Planning, 80% Building.
- Every week must end with a playable build.
- Documentation follows implementation; it must never block implementation.

## 11. Decision Hierarchy
Before executing any task, ask:
1. Does it help us ship?
2. Does it improve player experience, retention, or monetization?
3. Does it become reusable studio technology?
*(If the answer is "No", defer it to the backlog).*

## 12. Quality Standards
- Strict 0-byte memory allocation in `Update()` loops (60FPS targeting).
- Crash-free sessions and stable architecture.
- Fully decoupled, Headless Systems (Data/Logic completely separated from UI/Audio/VFX).

## 13. Non-Negotiable Principles
- **No Lost Work:** Previous Phases (0-4) are locked reference material. Do not rewrite them; use them to guide implementation.
- **Validate Before Extracting:** Do not build speculative Game OS architecture. Build it for Tiny World first, validate it, and *then* extract it to the Game OS.
- **Gameplay Never Waits:** Never wait for final art. Use Unity primitives and placeholders so engineering can proceed immediately.
