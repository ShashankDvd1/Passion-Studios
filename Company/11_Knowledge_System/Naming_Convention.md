---
document_id: "11-003"
title: "Naming Convention"
owner: "Documentation Agent"
status: "Approved"
version: "1.0"
created: "2026-06-28"
updated: "2026-06-28"
phase: "Phase 1 — Agent Operating System"
priority: "P1"
tags: [naming, convention, standards]
related_documents: ["11-002: Glossary", "02-003: Operating Principles"]
related_agents: ["Documentation Agent", "Unity Architect Agent", "Gameplay Programmer Agent"]
dependencies: ["11-002: Glossary"]
---

# Naming Convention

## 1. Vision
Everything in the company has a name — documents, agents, folders, code files, classes, variables, assets, events, memory entries. Consistent naming eliminates ambiguity and makes the system navigable without a guide.

## 6. Requirements

### 6.1 Document Naming
| Element | Convention | Example |
|---------|-----------|---------|
| Folder | `NN_Snake_Case` with numeric prefix | `07_AI_OS`, `09_Agent_Definitions` |
| Document | `Title_Case.md` | `Agent_Lifecycle.md`, `New_Feature_Workflow.md` |
| Document ID | `NN-NNN` (folder-sequence) | `07-001`, `09-015`, `16-003` |

### 6.2 Agent Naming
| Element | Convention | Example |
|---------|-----------|---------|
| Agent name | `[Domain] Agent` or `[Role] Agent` | `Game Designer Agent`, `QA Agent` |
| Agent ID | `09-NNN` (sequential within 09) | `09-004`, `09-023` |
| Agent file | `Agent_Name.md` in `09_Agent_Definitions/` | `Game_Designer_Agent.md` |

### 6.3 Workflow Naming
| Element | Convention | Example |
|---------|-----------|---------|
| Workflow name | `[Action] [Subject] Workflow` | `New Feature Workflow`, `Bug Fix Workflow` |
| Workflow ID | `WF-NNN` | `WF-002`, `WF-013` |

### 6.4 Code Naming (C#/Unity)
| Element | Convention | Example |
|---------|-----------|---------|
| Namespace | `CompanyName.ModuleName` | `WonderForge.Crafting` |
| Class | PascalCase | `CraftingSystem`, `RecipeValidator` |
| Interface | IPascalCase | `ICraftable`, `IRewardable` |
| Method | PascalCase | `ValidateRecipe()`, `GrantReward()` |
| Variable (private) | _camelCase | `_recipeCount`, `_isActive` |
| Variable (local) | camelCase | `recipeCount`, `isActive` |
| Constant | UPPER_SNAKE_CASE | `MAX_INVENTORY_SIZE` |
| ScriptableObject | PascalCase + SO suffix | `RecipeDataSO`, `EventConfigSO` |
| Event | On + PascalCase | `OnCraftingComplete`, `OnRewardGranted` |
| Enum | PascalCase | `CraftingState { Idle, InProgress, Complete }` |

### 6.5 Asset Naming
| Element | Convention | Example |
|---------|-----------|---------|
| Sprite | `type_name_variant_size` | `icon_flower_red_64`, `bg_forest_night` |
| Prefab | `PascalCase` matching class | `CraftingStation`, `FloatingReward` |
| Audio | `type_context_variant` | `sfx_tap_confirm`, `music_garden_calm` |
| Animation | `subject_action` | `character_idle`, `button_press` |
| Scene | `PascalCase` | `MainMenu`, `GameWorld`, `LoadingScreen` |

### 6.6 Memory Entry Naming
| Element | Convention | Example |
|---------|-----------|---------|
| Memory ID | `MEM-TYPE-YYYY-MM-DD-NNN` | `MEM-DEC-2026-07-15-001` |
| Memory title | Descriptive phrase | "D7 retention decline root cause analysis" |

### 6.7 Git Branch Naming
| Branch Type | Convention | Example |
|------------|-----------|---------|
| Feature | `feature/short-description` | `feature/weather-system` |
| Bugfix | `fix/short-description` | `fix/currency-overflow` |
| Release | `release/vX.Y.Z` | `release/v1.2.0` |
| Hotfix | `hotfix/short-description` | `hotfix/crash-on-launch` |

## 7. Acceptance Criteria
- [ ] Every naming category has a defined convention with examples
- [ ] Code naming matches C# community standards (Microsoft .NET conventions)
- [ ] No naming conflicts between conventions

## 14. Related Documents
| Doc ID | Title | Relationship |
|--------|-------|-------------|
| 11-002 | Glossary | Terms used in names |
| 02-003 | Operating Principles | "Single Source of Truth" supports consistent naming |
