---
document_id: "10-001"
title: "Workflow Engine"
owner: "Automation Agent"
status: "Approved"
version: "1.0"
created: "2026-06-28"
updated: "2026-06-28"
phase: "Phase 1 — Agent Operating System"
priority: "P0"
tags: [workflows, engine, orchestration, automation]
related_documents: ["07-002: System Architecture", "07-004: Communication Protocol", "08-005: Capability Matrix"]
related_agents: ["Automation Agent", "All Agents"]
dependencies: ["07-002: System Architecture"]
---

# Workflow Engine

## 1. Vision
The Workflow Engine is the orchestration layer of the Agent OS. It defines how multi-agent processes execute — which agents participate, in what order, with what inputs, through which quality gates, and with what governance controls. Every repeatable process in the company is a workflow.

## 2. Problem Statement
Without a workflow engine, multi-agent processes are ad-hoc. The founder manually coordinates: "Game Designer, write a spec. Now Unity Architect, review it. Now Programmer, implement it." This doesn't scale. The Workflow Engine automates this coordination.

## 3. Goals
1. Define the workflow definition format (how workflows are described).
2. Define execution semantics (how workflows run).
3. Support sequential, parallel, and conditional steps.
4. Integrate governance gates and quality reviews at defined checkpoints.

## 6. Requirements

### 6.1 Workflow Definition Format

```yaml
workflow:
  id: "WF-NNN"
  name: "Workflow Name"
  trigger: "manual | event | scheduled"
  trigger_condition: "What triggers this workflow"
  owner_agent: "Agent that owns/initiates this workflow"
  estimated_duration: "Time estimate"
  
  steps:
    - step: 1
      name: "Step Name"
      agent: "Responsible Agent (09-NNN)"
      action: "What the agent does"
      inputs: ["List of inputs from previous steps or external"]
      outputs: ["List of outputs this step produces"]
      quality_gate: "none | self-review | technical-review | full-pipeline"
      governance: "none | P-level if decision required"
      on_failure: "retry | skip | escalate | abort"
      
    - step: 2
      parallel: true  # Steps can run in parallel
      substeps:
        - name: "Substep A"
          agent: "Agent A"
        - name: "Substep B"
          agent: "Agent B"
      
    - step: 3
      condition: "Expression that determines if this step runs"
      name: "Conditional Step"
      agent: "Agent"
```

### 6.2 Execution Rules

| Rule | Description |
|------|-------------|
| **Sequential by default** | Steps execute in order unless marked `parallel: true` |
| **Parallel fan-out/fan-in** | Parallel steps start simultaneously; next sequential step waits for all to complete |
| **Conditional execution** | Steps with `condition` execute only if the condition evaluates true |
| **Quality gates block** | A step cannot proceed past its quality gate until the gate passes |
| **Governance gates block** | If governance requires founder decision, the workflow pauses until decided |
| **Failure handling** | Per-step failure policy: retry (same agent), skip (mark incomplete), escalate (to founder), abort (cancel workflow) |
| **Timeout** | Each step has an implicit SLA based on agent SLAs in the Communication Protocol |

### 6.3 Standard Workflow Checkpoints

Every workflow includes these automatic checkpoints:

| Checkpoint | When | Purpose |
|-----------|------|---------|
| **Initiation log** | Workflow starts | Audit trail: who triggered, when, why |
| **Step completion log** | Each step completes | Track progress and timing |
| **Quality gate log** | Each gate evaluates | Record pass/fail and reviewer |
| **Governance log** | Each decision point | Record decision and rationale |
| **Completion log** | Workflow ends | Total time, outcome, agents involved |

### 6.4 Registered Workflows

| ID | Workflow | Trigger | Agents Involved | Doc |
|----|----------|---------|----------------|-----|
| WF-002 | New Feature | Manual (founder/PM) | PM, Designer, Architect, Programmer, QA | `10-002` |
| WF-003 | Bug Fix | Event (bug reported) | QA, Programmer, Code Review | `10-003` |
| WF-004 | Game Mechanic | Manual (designer) | Designer, Behav Psych, Economy, Architect | `10-004` |
| WF-005 | New Document | Manual (any agent) | Requesting Agent, Doc Agent, Quality | `10-005` |
| WF-006 | Marketing Campaign | Manual (marketing) | Marketing, Content, ASO, Analytics | `10-006` |
| WF-007 | LiveOps Event | Scheduled/Manual | LiveOps, Designer, Content, QA | `10-007` |
| WF-008 | Analytics Review | Scheduled (weekly) | Analytics, PM, CEO | `10-008` |
| WF-009 | A/B Test | Manual (PM/Analytics) | Analytics, PM, Designer, Founder | `10-009` |
| WF-010 | Code Review | Event (code submitted) | Code Review, Programmer | `10-010` |
| WF-011 | Unity Implementation | Manual (PM) | Architect, Programmer, Code Review, QA | `10-011` |
| WF-012 | Git Commit | Event (code approved) | Programmer, Automation | `10-012` |
| WF-013 | Release | Manual (PM/Founder) | QA, Security, Performance, Founder | `10-013` |
| WF-014 | Post Mortem | Event (incident/launch) | CEO, PM, relevant domain agents | `10-014` |

## 7. Acceptance Criteria
- [ ] Every workflow can be expressed in the definition format without ambiguity
- [ ] Sequential, parallel, and conditional execution all work correctly
- [ ] Quality gates and governance gates block progression as designed
- [ ] Every workflow execution is fully logged in the audit system
- [ ] Adding a new workflow requires creating one file — no changes to the engine

## 14. Related Documents
| Doc ID | Title | Relationship |
|--------|-------|-------------|
| 07-002 | System Architecture | Engine is the primary Layer 2 component |
| 07-004 | Communication Protocol | Engine uses Task Channel to assign work |
| 10-002 through 10-014 | Individual Workflows | Workflow definitions the engine executes |
