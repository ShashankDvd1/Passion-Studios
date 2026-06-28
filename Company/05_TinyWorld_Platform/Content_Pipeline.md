---
document_id: "05-019"
title: "Content Pipeline"
owner: "Automation Agent"
status: "Approved"
version: "1.0"
created: "2026-06-28"
updated: "2026-06-28"
phase: "Phase 3 — Tiny World Platform"
priority: "P1"
tags: [architecture, unity, pipeline, tools, assets]
related_documents: []
related_agents: ["Automation Agent", "Art Director Agent"]
dependencies: []
---

# Content Pipeline

## 2. Purpose
To define the automated flow of data and assets from external sources (Google Sheets, Maya, AI generation) into Unity-ready `ScriptableObjects` and `Addressables`, minimizing manual data entry.

## 3. Responsibilities
- Provide tools to ingest CSV/JSON data into Unity.
- Automate the assignment of Addressable labels.
- Validate asset integrity before builds.

## 4. Dependencies
- Unity Addressables.
- Unity AssetPostprocessor.

## 5. Reusable Interfaces
- `IContentImporter`: Interface for scripts that parse specific data formats.

## 6. Configuration Model
N/A. This is an Editor-only workflow definition.

## 7. Future Expansion
Direct integration with cloud databases (e.g., PlayFab) so balance tweaks can be pushed to live games without requiring a new client download.

## 8. Relationship with HX Platform
Ensures that the sheer volume of content required to satisfy the "Collection" and "Curiosity" systems can actually be produced by a small team without burnout.

## 9. Relationship with Agent OS
The Automation Agent runs this pipeline. If the Game Designer Agent balances 500 items in a spreadsheet, the Automation Agent pulls that sheet and updates all 500 `ScriptableObjects` in Unity automatically.

## 10. Unity Representation
- **Editor Scripts:** Heavy reliance on `AssetDatabase` and `ScriptableObject.CreateInstance`.
- **Validation:** Unit tests that run automatically on compilation.

## 11. C# Architecture
- `CSVToScriptableObjectImporter` (Editor script)
- `AddressableGroupAssigner` (Editor script)
- `ContentValidator` (Editor script)

## 12. Data Model
- N/A (Operates on existing data models).

## 13. Unity Folder Mapping
`Assets/Scripts/Editor/TinyWorldPlatform/Pipeline/`

## 14. AI Implementation Plan
- **Responsible Agent:** Automation Agent
- **Implementation Order:** 18
- **Review Agent:** Unity Architect Agent
- **Expected Deliverables:** Editor scripts for CSV parsing and Addressable tagging.

## 15. Performance Considerations
- The import pipeline runs in the Editor, so runtime performance is unaffected. However, the importer must be optimized so it doesn't freeze the Editor for 5 minutes when pulling data.

## 16. Testing Strategy
- Feed the importer a malformed CSV file and verify it throws a clear, readable error instead of silently corrupting data.

## 17. Editor Tooling
- `Master Importer Dashboard`: A single window where developers can click "Sync All Data" to pull the latest balancing numbers.

## 18. AI Code Generation Notes
Use `AssetDatabase.StartAssetEditing()` and `AssetDatabase.StopAssetEditing()` to wrap large loops of ScriptableObject creation/modification. This prevents Unity from rebuilding the asset database after every single file, speeding up imports by 100x.

## 19. Known Risks
- Merge conflicts if a designer edits a ScriptableObject directly in Unity while another designer edits the master spreadsheet. (Rule: The spreadsheet is always the source of truth; Editor overrides will be overwritten).

## 20. Acceptance Criteria
- [ ] Spreadsheets can be synced to ScriptableObjects with one click.
- [ ] New assets are automatically grouped into the correct Addressable buckets.

## 21. Validation Checklist
- [ ] Are we using `StartAssetEditing` to optimize the import?
- [ ] Is there a validation pass that flags missing references?
