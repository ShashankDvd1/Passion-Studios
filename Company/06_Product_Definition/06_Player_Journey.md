---
document_id: "06-006"
title: "Player Journey"
owner: "Behavioral Psychology Agent"
status: "Approved"
version: "1.1"
created: "2026-06-28"
updated: "2026-06-28"
phase: "Phase 4 — Product Definition Platform"
priority: "P0"
---

# 06. Player Journey

## 2. Purpose
To map the complete chronological experience of a player from the first time they see an ad (Day 0) to their 1-year anniversary (Veteran Player), focusing entirely on emotional milestones and psychological transitions.

## 3. Vision
The journey must evolve. A player should not be doing the exact same tasks on Day 30 as they did on Day 1. The game must transition from tactical (chopping wood) to strategic (automating farms) to social/expressive (decorating and showing off).

## 4. Problem Statement
**Player Problem:** Many simulation games have a great first week but become repetitive grinds by month two because the journey stagnates.

## 5. Goals
- Define emotional targets for every phase of the player lifecycle.
- Map when specific mechanics unlock (`05-013: Discovery_System`).

## 6. Non Goals
- Writing the exact tutorial script (Handled in `27_Tutorial.md`).

## 7. Dependencies
- `05_Player_Personas.md`
- `04-013: Retention_Framework.md`

## 8. Related Platforms
- HX Engine (Retention)

## 9. Related Agents
- Behavioral Psychology Agent
- Game Designer Agent

## 10. Related Feature IDs
- `FEAT-PROG-01` (Progression System hooks)

## 11. User Stories
- **As a D30 player...** I want tools to automate my daily chores... **So that...** I can focus on high-level meta goals rather than grinding basic resources.

## 12. Acceptance Criteria
- [ ] Journey maps directly to the retention targets.
- [ ] Every stage contains the 11 Founder-mandated data points.

## 13. KPIs
- D1, D7, D14, D30, D60, D90 Retention %.

## 14. Analytics Events
- `journey_milestone_reached`

## 15. Unity Mapping
- `ProgressionManager` controls the unlocking of journey milestones.

## 16. Implementation Notes
The Game Designer Agent uses this to balance XP curves so players hit these milestones on the correct real-world days.

## 17. Testing Strategy
- Long-term playtesting (or AI fast-forward simulation) to verify pacing.

## 18. Risks
- Pacing is too fast, players burn through 3 months of content in 3 days.

## 19. Future Expansion
- D365+ Journey (The "Elder Game").

## 20. Automation Hooks
- Analytics Agent flagging players who are progressing significantly faster or slower than expected.

## 21. Definition of Done
- Journey timeline approved.

## 22. Review Checklist
- [x] Founder
- [x] Product Manager Agent
- [x] Game Designer Agent
- [x] Human Experience Agent
- [x] Unity Architect Agent
- [x] Analytics Agent
- [x] Monetization Agent
- [x] QA Agent
- [x] Documentation Agent

## 23. Decision History
- v1.1: Expanded to cover full lifecycle (Store to Veteran).
- v1.0: Initial journey mapped.

## 24. Traceability
- **Feature -> Analytics:** Tracked in `Analytics_Event_Registry.md`.

---

# The Lifecycle

### 1. Store Impression
- **Player Goal:** Find something relaxing to play.
- **Emotional Goal:** Curiosity, Relief ("This looks cozy").
- **Business Goal:** High CTR (Click-Through Rate).
- **Expected Player Actions:** Watch the 15-second trailer.
- **HX Principles Used:** Contrast (Peaceful visuals vs loud competitive games).
- **LWP Systems Used:** N/A.
- **Analytics Events:** `ad_impression`, `ad_click`.
- **Success Metrics:** CTR > 2%.
- **Churn Risks:** Trailer looks too generic or misleading.
- **Recovery Strategy:** A/B test ad creatives matching core personas.
- **LiveOps Opportunities:** Seasonal ad campaigns (e.g., Winter Cozy Theme).

### 2. Store Visit
- **Player Goal:** Validate the game is actually good and not P2W.
- **Emotional Goal:** Trust.
- **Business Goal:** High Conversion Rate (CVR).
- **Expected Player Actions:** Read reviews, check "In-App Purchases" list.
- **HX Principles Used:** Transparency.
- **LWP Systems Used:** N/A.
- **Analytics Events:** `store_page_view`, `install_clicked`.
- **Success Metrics:** CVR > 30%.
- **Churn Risks:** Low star rating, listed P2W currency packs.
- **Recovery Strategy:** Reply to all negative reviews with human empathy.
- **LiveOps Opportunities:** Update screenshots for current live events.

### 3. Install & First Launch
- **Player Goal:** Start playing immediately.
- **Emotional Goal:** Anticipation.
- **Business Goal:** Minimize drop-off before gameplay.
- **Expected Player Actions:** Accept TOS, download assets.
- **HX Principles Used:** Delight (Cute loading animation).
- **LWP Systems Used:** Save System (Init).
- **Analytics Events:** `first_open`, `assets_downloaded`.
- **Success Metrics:** >95% transition from install to gameplay.
- **Churn Risks:** Massive initial download size, forced account creation.
- **Recovery Strategy:** Background downloading during a playable intro.
- **LiveOps Opportunities:** N/A.

### 4. First Minute
- **Player Goal:** Understand the core verbs (Move, Interact).
- **Emotional Goal:** Competence.
- **Business Goal:** Establish the core loop.
- **Expected Player Actions:** Walk, pick up an item.
- **HX Principles Used:** Clarity, Autonomy Support.
- **LWP Systems Used:** Player System, Interaction System.
- **Analytics Events:** `tutorial_step_1_complete`.
- **Success Metrics:** 100% completion of first verb.
- **Churn Risks:** Clunky controls.
- **Recovery Strategy:** Adjust movement acceleration/friction.
- **LiveOps Opportunities:** N/A.

### 5. First Session (10-15 minutes)
- **Player Goal:** Achieve the first meaningful milestone (e.g., plant first crop, build tent).
- **Emotional Goal:** Accomplishment, Wonder.
- **Business Goal:** Secure Day 1 Retention.
- **Expected Player Actions:** Complete the FTUE (First Time User Experience).
- **HX Principles Used:** The Zeigarnik Effect (Leaving a task unfinished so they want to return).
- **LWP Systems Used:** Progression System, Discovery System.
- **Analytics Events:** `ftue_complete`, `first_session_end`.
- **Success Metrics:** >70% of players complete FTUE.
- **Churn Risks:** Information overload.
- **Recovery Strategy:** Progressive disclosure (hide advanced UI).
- **LiveOps Opportunities:** Starter pack offer (Cosmetic only).

### 6. Day 1
- **Player Goal:** See the results of their First Session actions.
- **Emotional Goal:** Validation ("My crops grew!").
- **Business Goal:** Establish the daily habit.
- **Expected Player Actions:** Harvest crops, meet a new NPC.
- **HX Principles Used:** Habit Formation (Cue -> Routine -> Reward).
- **LWP Systems Used:** Offline System (Catch-up math), Time System.
- **Analytics Events:** `d1_retention_success`.
- **Success Metrics:** D1 Retention > 45%.
- **Churn Risks:** Nothing changed while they were gone.
- **Recovery Strategy:** Guarantee a high-delight event on D1 login.
- **LiveOps Opportunities:** N/A.

### 7. Day 3
- **Player Goal:** Expand their capabilities (new tools, larger inventory).
- **Emotional Goal:** Growth.
- **Business Goal:** Monetization introduction (Optional/Cosmetic).
- **Expected Player Actions:** Upgrade a tool, customize their avatar.
- **HX Principles Used:** Competence and Progression.
- **LWP Systems Used:** Customization System, Inventory System.
- **Analytics Events:** `d3_retention_success`, `first_upgrade`.
- **Success Metrics:** D3 Retention > 35%.
- **Churn Risks:** Grind wall (requiring too much wood/stone).
- **Recovery Strategy:** Rebalance resource gathering curves.
- **LiveOps Opportunities:** Introduce a minor weekend event.

### 8. Day 7
- **Player Goal:** Establish a long-term goal (e.g., building a real house instead of a tent).
- **Emotional Goal:** Ownership.
- **Business Goal:** Secure medium-term retention.
- **Expected Player Actions:** Participate in a weekly cycle/event.
- **HX Principles Used:** The IKEA Effect (Valuing what they built).
- **LWP Systems Used:** Event System, Object System (Housing).
- **Analytics Events:** `d7_retention_success`, `house_built`.
- **Success Metrics:** D7 Retention > 20%.
- **Churn Risks:** Lack of clear mid-term goals.
- **Recovery Strategy:** Add a "Quest Board" for structured goals.
- **LiveOps Opportunities:** Push notifications for weekly tournaments.

### 9. Day 14
- **Player Goal:** Optimize their layout and routines.
- **Emotional Goal:** Mastery.
- **Business Goal:** Increase Session Health Index.
- **Expected Player Actions:** Reorganizing the farm, building sprinklers/automation.
- **HX Principles Used:** Flow State.
- **LWP Systems Used:** World Simulation (complex interactions).
- **Analytics Events:** `d14_retention_success`, `automation_placed`.
- **Success Metrics:** D14 Retention > 15%.
- **Churn Risks:** Chore fatigue (doing the same manual labor as D1).
- **Recovery Strategy:** Ensure automation tools unlock exactly here.
- **LiveOps Opportunities:** First major seasonal event exposure.

### 10. Day 30
- **Player Goal:** Complete their first major collection/compendium page.
- **Emotional Goal:** Satisfaction, Identity.
- **Business Goal:** Convert non-payers to payers via deep emotional investment.
- **Expected Player Actions:** Donating rare items, interacting deeply with NPCs.
- **HX Principles Used:** Completionism, Relatedness (NPC friendship).
- **LWP Systems Used:** Collection System, NPC System.
- **Analytics Events:** `d30_retention_success`, `collection_completed`.
- **Success Metrics:** D30 Retention > 10%.
- **Churn Risks:** Running out of core content.
- **Recovery Strategy:** Shift focus from mechanical progression to social/cosmetic progression.
- **LiveOps Opportunities:** Monthly Battle Pass / Season Pass rollover.

### 11. Day 60
- **Player Goal:** Deep cosmetic expression and world mastery.
- **Emotional Goal:** Pride.
- **Business Goal:** Maximize ARPDAU among the loyal cohort.
- **Expected Player Actions:** Redecorating, participating in high-level LiveOps.
- **HX Principles Used:** Expression (Self-Determination Theory).
- **LWP Systems Used:** Customization System (Advanced).
- **Analytics Events:** `d60_retention_success`.
- **Success Metrics:** >70% of D30 players make it to D60.
- **Churn Risks:** Meta-game exhaustion.
- **Recovery Strategy:** Introduce "Prestige" or expansion areas.
- **LiveOps Opportunities:** Exclusive veteran cosmetic rewards.

### 12. Day 90
- **Player Goal:** Social dominance / Community leadership.
- **Emotional Goal:** Belonging.
- **Business Goal:** Turn players into organic evangelists.
- **Expected Player Actions:** Sharing screenshots, helping new players, waiting for content updates.
- **HX Principles Used:** Reciprocal Altruism.
- **LWP Systems Used:** Asynchronous Multiplayer (if applicable).
- **Analytics Events:** `d90_retention_success`.
- **Success Metrics:** High Net Promoter Score (NPS).
- **Churn Risks:** Content drought.
- **Recovery Strategy:** Heavy reliance on LiveOps and UGC (User Generated Content).
- **LiveOps Opportunities:** Major Expansion drop.

### 13. Veteran Player (D365+)
- **Player Goal:** Routine comfort and nostalgia.
- **Emotional Goal:** Comfort.
- **Business Goal:** Long-term LTV and brand loyalty for future studio games.
- **Expected Player Actions:** Logging in during seasonal events, maintaining their space.
- **HX Principles Used:** Nostalgia, Safe Haven.
- **LWP Systems Used:** Season System.
- **Analytics Events:** `1_year_anniversary`.
- **Success Metrics:** Years-long engagement.
- **Churn Risks:** Real-life schedule changes.
- **Recovery Strategy:** Ensure "catch-up" mechanics are very forgiving if they leave for 6 months.
- **LiveOps Opportunities:** Yearly anniversary festivals.
