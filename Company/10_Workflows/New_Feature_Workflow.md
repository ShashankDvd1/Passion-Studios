---
document_id: "10-002"
title: "New Feature Workflow"
owner: "Product Manager Agent"
status: "Approved"
version: "1.0"
created: "2026-06-28"
updated: "2026-06-28"
phase: "Phase 1 — Agent Operating System"
priority: "P0"
tags: [workflow, feature, product, development]
related_documents: ["10-001: Workflow Engine", "02-002: Design Principles"]
related_agents: ["Product Manager Agent", "Game Designer Agent", "Unity Architect Agent", "Gameplay Programmer Agent", "QA Agent", "Founder Agent"]
dependencies: ["10-001: Workflow Engine"]
---

# New Feature Workflow

## Trigger
Manual — Founder requests a feature, or Product Manager Agent identifies a feature opportunity from analytics/research.

## Steps

### Step 1: Feature Brief (Product Manager Agent)
- **Action:** Write PRD with Seven-Question Gate evaluation
- **Inputs:** Founder direction, player analytics, behavioral models, competitive research
- **Outputs:** Feature PRD with RICE score, success metrics, and gate evaluation
- **Quality Gate:** Self-review → Consistency review
- **Governance:** P1 — Founder approves feature scope before design begins

### Step 2: Behavioral Model (Behavioral Psychology Agent)
- **Action:** Design the behavioral engagement model for the feature
- **Inputs:** Approved PRD, player behavior data
- **Outputs:** Engagement model, emotion map, ethical assessment
- **Quality Gate:** Self-review → Technical review (ethical compliance)
- **Governance:** P1 if ethical flag raised, else P2

### Step 3: Game Design Spec (Game Designer Agent)
- **Action:** Create detailed game design specification
- **Inputs:** Approved PRD, behavioral model, economy constraints
- **Outputs:** Design spec (mechanics, rules, balance, content templates, edge cases)
- **Quality Gate:** Self-review → Technical review
- **Governance:** P2 (within approved scope)

### Step 4: Economy Assessment (Economy Agent)
- **Action:** Evaluate economic impact and design resource flows
- **Inputs:** Design spec, current economy state
- **Outputs:** Economy impact report, balance recommendations
- **Quality Gate:** Self-review
- **Governance:** P1 if new currency or major balance change

### Step 5: Technical Design (Unity Architect Agent)
- **Action:** Design technical architecture for the feature
- **Inputs:** Design spec, economy requirements, engine module registry
- **Outputs:** Technical design doc, module design, API definitions
- **Quality Gate:** Self-review → Technical review
- **Governance:** P1 if new architectural pattern

### Step 6: UX Flow Design (UX Agent) — *parallel with Step 5*
- **Action:** Design user flows and interaction patterns
- **Inputs:** Design spec, accessibility requirements
- **Outputs:** Flow diagrams, wireframes, interaction specs
- **Quality Gate:** Self-review

### Step 7: UI Design (UI Agent)
- **Action:** Design visual UI for the feature
- **Inputs:** UX flows, art direction guidelines, technical constraints
- **Outputs:** UI mockups, component specifications
- **Quality Gate:** Self-review → Consistency review (Art Director)

### Step 8: Implementation (Gameplay Programmer Agent)
- **Action:** Implement the feature in Unity/C#
- **Inputs:** Technical design, UI specs, design spec
- **Outputs:** Source code, ScriptableObjects, unit tests
- **Quality Gate:** Full pipeline — Self-review → Code Review Agent → Technical review
- **Governance:** P2

### Step 9: QA Validation (QA Agent)
- **Action:** Test the feature against acceptance criteria
- **Inputs:** Implementation, design spec acceptance criteria
- **Outputs:** Test results, bug reports, release recommendation
- **Quality Gate:** Full pipeline
- **Governance:** P1 if critical bugs found

### Step 10: Founder Review (Founder)
- **Action:** Playtest the feature and provide approval or feedback
- **Inputs:** Working build, design spec, QA report
- **Outputs:** Approval or revision feedback
- **Governance:** P1 — Founder final approval

## Estimated Duration
5-10 business days depending on feature complexity.

## Failure Handling
- Step failure → retry with feedback. If 2nd failure → escalate to founder.
- Any ethical flag → workflow pauses until founder resolves.
- Scope change detected → workflow restarts from Step 1 with updated PRD.
