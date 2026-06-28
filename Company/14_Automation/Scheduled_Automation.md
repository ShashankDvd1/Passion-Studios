---
document_id: "14-003"
title: "Scheduled Automation"
owner: "Automation Agent"
status: "Approved"
version: "1.0"
created: "2026-06-28"
updated: "2026-06-28"
phase: "Phase 1 — Agent Operating System"
priority: "P1"
tags: [automation, scheduled, cron]
related_documents: ["14-001: Automation Framework"]
related_agents: ["Automation Agent", "Founder Agent", "Analytics Agent"]
dependencies: []
---
# Scheduled Automation
## 1. Vision
Predictable, recurring tasks happen exactly on time, every time, without human intervention.

## 6. Requirements
### 6.1 Standard Schedules (Cron Jobs)
| Job Name | Schedule | Action |
|----------|----------|--------|
| **Morning Brief** | Daily, 08:00 | Founder Agent compiles queue, metrics, overnight events. |
| **Nightly Build** | Daily, 02:00 | Build current `develop` branch, run full regression test suite. |
| **Weekly Analytics** | Monday, 06:00 | Analytics Agent pulls KPI data, generates scorecard. |
| **Memory Pruning** | 1st of Month | Documentation Agent archives expired memory entries. |
| **Stale Doc Check** | 15th of Month | Documentation Agent flags docs not updated in 6 months. |

### 6.2 Maintenance
- Schedules are maintained in a central registry by the Automation Agent.
- Timezones must be standardized to UTC for server actions, converted to Founder's local time for notifications.
