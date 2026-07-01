# Product Requirements Document (PRD)
**Product:** Tiny World: Echoes (MVP)
**Document Version:** 1.0
**Target Launch:** 15 Days from Development Start
**Platform:** Android (Mobile)

---

## 1. Product Vision
"Tiny World: Echoes" is a cozy, narrative-driven idle game where the player acts as the remote handler for "Spark," a tiny drone exploring a microscopic ruined world. The game relies entirely on a sleek UI dashboard, real-time waiting mechanics, and emotional nurturing rather than reflex-based gameplay or 3D avatars.

## 2. Target Audience
*   Casual gamers looking for a relaxing, low-stress daily routine.
*   Players who enjoy nurturing mechanics (Tamagotchi, Neko Atsume).
*   Players who appreciate aesthetic, atmospheric narrative games (Lifeline).

## 3. Core Gameplay Loop
1.  **Narrative Prompt:** Spark asks for guidance on where to explore.
2.  **Expedition (Waiting):** Spark explores for a set amount of real-world time (e.g., 30 mins, 2 hours, 8 hours).
3.  **Resource Harvesting:** During expeditions, Spark transmits raw resources to the player (e.g., *Scrap*, *Energy Shards*, *Strange Dust*).
4.  **The Forge (Crafting):** The player combines resources to craft key items (e.g., *Luminescent Lantern*, *Signal Booster*).
5.  **Resolution:** The player sends the crafted item to Spark, unlocking a new narrative beat and a collectible 2D "Snapshot" of the world.

## 4. MVP Feature Set

### 4.1. Dashboard Interface
*   **Comms Log:** A scrolling text window where Spark sends messages and the player selects multiple-choice responses.
*   **Status Indicators:** Visual bars showing Spark's current expedition progress (time remaining) and status.

### 4.2. Inventory & Resource System
*   A backend system to track quantities of gathered resources.
*   A visual UI grid/list showing currently owned items and raw materials.

### 4.3. The Forge (Crafting System)
*   A menu where players can see blueprints.
*   If the player has the required resources in their inventory, they can tap to craft the item.
*   Crafted items act as "keys" to progress the narrative to the next zone.

### 4.4. The Gallery (Collectibles)
*   A dedicated UI screen that acts as an album.
*   Stores the beautiful 2D illustrations (Snapshots) that Spark sends back after successful expeditions.

### 4.5. Offline Progression & Save System
*   The game must calculate time passed while the app was closed.
*   When the player opens the app, a "Welcome Back" screen summarizes the resources Spark found or informs them that the expedition is complete.

## 5. Monetization Strategy (Heroic Ads)
To ensure profitability without alienating players, ads will be framed as helping Spark:
*   **Time Skip:** "Spark is caught in a dust storm. Watch an Ad to boost the signal and clear the storm instantly (Skips 30 mins of waiting)."
*   **Resource Doubler:** "Spark found a dense resource node! Watch an Ad to double the materials gathered while you were away."

## 6. Technical Requirements
*   **Engine:** Unity (Universal Render Pipeline).
*   **Architecture:** Wonder Forge Game OS (Pure C# logic, heavily decoupled).
*   **Data Driven:** All wait times, resource costs, and dialogue must be defined in `ScriptableObjects` (ConfigService) so they can be balanced without recompiling code.
*   **Zero-Allocation:** The Event Bus must be used for all UI updates to ensure a smooth 60fps on low-end Android devices.

## 7. Out of Scope for MVP
To protect the 15-day timeline, the following are strictly forbidden:
*   3D Character movement or pathfinding.
*   Grid-based building placement.
*   Multiplayer, leaderboards, or cloud saves.
*   Complex branching dialogue trees (keep narrative linear for MVP).
*   Combat mechanics.
