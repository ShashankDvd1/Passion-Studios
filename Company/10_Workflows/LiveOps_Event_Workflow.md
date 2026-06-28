---
document_id: "10-007"
title: "LiveOps Event Workflow"
owner: "LiveOps Agent"
status: "Approved"
version: "1.0"
created: "2026-06-28"
updated: "2026-06-28"
phase: "Phase 1 — Agent Operating System"
priority: "P1"
tags: [workflow, liveops, events]
related_documents: ["10-001: Workflow Engine"]
related_agents: ["LiveOps Agent", "Game Designer Agent", "Content Creator Agent", "QA Agent", "Economy Agent"]
dependencies: ["10-001: Workflow Engine"]
---
# LiveOps Event Workflow
## Trigger
Scheduled (per LiveOps calendar) or Manual (special events).
## Steps
1. **Event Design** (LiveOps Agent) → Event type, duration, mechanics, reward tier structure
2. **Content Creation** (Content Creator Agent) → Narrative, flavor text, character dialogue
3. **Economy Validation** (Economy Agent) → Reward values within balance parameters
4. **Configuration** (Gameplay Programmer Agent) → ScriptableObjects and Remote Config setup
5. **QA Validation** (QA Agent) → Event testing, edge cases, timer validation
6. **Go Live** (Automation Agent) → Deploy via Remote Config at scheduled time
7. **Live Monitoring** (Analytics Agent) → Real-time participation and economy metrics
8. **Post-Event Analysis** (LiveOps Agent + Analytics Agent) → Performance vs. targets, learnings
## Governance: P2 for template events. P1 for new event types.
## Estimated Duration: 3-7 days (design to go-live)
