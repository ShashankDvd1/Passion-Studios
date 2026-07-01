# Problem Statement: Tiny World - Echoes

## Executive Summary
**Wonder Forge Studios** requires a foundational, commercially viable mobile game to establish its AI-native development pipeline and build the underlying "Wonder Forge Game OS." The goal is to rapidly ship an MVP within a strict 15-day timeline that prioritizes emotional player connection and high retention, while aggressively cutting development risks like 3D collision and complex pathfinding.

## The Core Problem
Modern mobile games rely heavily on aggressive engagement tactics, endless tapping, and manufactured friction. Players often experience burnout. Furthermore, traditional "city builder" or "hyper-casual" games either take too long to build (causing missed launch windows) or lack the depth required to foster genuine emotional attachment.

The problem is **how to build a game in 15 days that feels deeply emotional, monetizes ethically, and forces the studio to build reusable architecture (Inventory, Economy, Progression).**

## The Solution: Tiny World - Echoes
"Tiny World: Echoes" solves this by relying on the **Tamagotchi Effect** combined with a sleek, UI-driven aesthetic. The player acts as the "overwatch" for a stranded, microscopic drone named Spark.

### The Creative Loop
1. **The Signal (Narrative):** The player communicates with Spark via a dashboard UI. Spark requests to explore a new area but needs supplies.
2. **The Harvest (Simulation):** Spark goes on expeditions that take real-world time (offline progression). While exploring, Spark passively transmits "Raw Data" (resources) back to the player.
3. **The Forge (Economy/Crafting):** The player uses the Inventory and Crafting systems to turn Raw Data into upgrades (e.g., a flashlight, a better battery).
4. **The Connection (Emotion):** The player beams the upgrade to Spark. Spark sends a heartfelt message and a beautiful 2D snapshot of the newly discovered area.

## Business & Technical Constraints
- **Platform:** Android (Google Play).
- **Engine:** Unity (Used strictly for UI, Visuals, and MonoBehaviours, while core logic remains in pure C#).
- **Timeline:** 15-day MVP launch.
- **Development Philosophy:** AI-assisted Vibe Coding (80% Building / 20% Planning).
- **Engineering Rules:** Mobile-optimized, zero-allocation where possible, event-driven, and highly decoupled. The architecture must extract reusable systems into the "Game OS" naturally.

## Definition of Success
The MVP will be considered successful when it:
1. Ships to the Google Play Store within the 15-day window.
2. Proves the emotional core (players returning to check on Spark).
3. Successfully establishes the Wonder Forge Game OS infrastructure (Event Bus, Runtime Core, Save Systems, Inventory).
4. Monetizes effectively through "Heroic" Rewarded Ads (e.g., watching an ad to clear a storm and save Spark).
