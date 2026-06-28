---
document_id: "05-016"
title: "Save System"
owner: "Backend Agent"
status: "Approved"
version: "1.0"
created: "2026-06-28"
updated: "2026-06-28"
phase: "Phase 3 — Tiny World Platform"
priority: "P0"
tags: [architecture, unity, save, data, persistence]
related_documents: []
related_agents: ["Backend Agent", "Unity Architect Agent"]
dependencies: []
---

# Save System

## 2. Purpose
To serialize the entire state of the living world, the player, and all progression into a secure, robust format that can be saved locally or synced to the cloud.

## 3. Responsibilities
- Gather state data from all registered `IDataProvider` systems.
- Serialize the composite data to JSON/Binary.
- Deserialize and distribute data back to systems upon load.
- Handle save file versioning and migrations.

## 4. Dependencies
- (Foundation System, relies on Unity C# features like `Newtonsoft.Json`).

## 5. Reusable Interfaces
- `IDataProvider`: Implemented by any manager that needs to save state (e.g., `InventoryManager`, `TimeManager`). Requires `SaveData()` and `LoadData()` methods.

## 6. Configuration Model
N/A. Operates on pure data structures.

## 7. Future Expansion
Cloud saving via Firebase or Unity Gaming Services. Conflict resolution between local and cloud saves.

## 8. Relationship with HX Platform
Protects the "Ownership" and "Comfort" emotions. A corrupted save file is the most catastrophic emotional failure a game can have.

## 9. Relationship with Agent OS
The Save System uses strict POCO (Plain Old C# Object) data models, which coding agents can easily serialize without worrying about Unity's complex `MonoBehaviour` serialization quirks.

## 10. Unity Representation
- **Manager:** `SaveManager` operates independently of the Unity scene hierarchy.
- **Format:** JSON for development (readable), compressed Binary (BSON/MessagePack) for production.

## 11. C# Architecture
- `SaveManager`
- `GameStatePayload` (The master container class).
- `SaveMigrationUtility` (Handles upgrading old save files to new schema versions).

## 12. Data Model
```csharp
public class GameStatePayload {
    public string version;
    public TimeSaveData time;
    public PlayerSaveData player;
    public WorldStateData world;
    // ...
}
```

## 13. Unity Folder Mapping
`Assets/Scripts/Runtime/TinyWorldPlatform/Persistence/`

## 14. AI Implementation Plan
- **Responsible Agent:** Backend Agent
- **Implementation Order:** 15
- **Review Agent:** Unity Architect Agent
- **Expected Deliverables:** Serialization pipeline, file I/O operations, `IDataProvider` registration.

## 15. Performance Considerations
- **Async I/O:** Writing to disk must be done asynchronously (`Task.Run` or `FileStream.WriteAsync`) so it does not freeze the main Unity thread, allowing seamless auto-saving.
- **Memory Allocation:** Serializing a massive JSON string generates heavy GC. Use stream-based serializers (like `JsonTextWriter`) rather than serializing the entire object to a string in memory first.

## 16. Testing Strategy
- Save/Load cycle test: Create a complex world state, save it to memory, load it into a fresh instance, and assert that all fields match perfectly.
- Corruption test: Attempt to load a malformed JSON file and verify the system catches the exception and falls back to a backup save.

## 17. Editor Tooling
- `Save File Inspector`: An editor window to view, edit, and delete the current save file without having to dig through Windows AppData folders.

## 18. AI Code Generation Notes
Implement a robust backup system. Before writing a new save file, copy the old one to `save.bak`. If writing fails halfway through, restore the backup. Never leave the player with a 0-byte corrupted file.

## 19. Known Risks
- Adding a new field to a data model and forgetting to handle the null case when loading an old save file.

## 20. Acceptance Criteria
- [ ] Entire game state serializes and deserializes accurately.
- [ ] Disk writing is asynchronous and does not cause frame drops.
- [ ] Corrupted files are handled gracefully via backups.

## 21. Validation Checklist
- [ ] Are we using stream-based serialization to minimize memory allocation?
- [ ] Is there a clear migration path for schema updates?
