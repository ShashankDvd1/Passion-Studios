---
document_id: "10-003"
title: "Bug Fix Workflow"
owner: "QA Agent"
status: "Approved"
version: "1.0"
created: "2026-06-28"
updated: "2026-06-28"
phase: "Phase 1 — Agent Operating System"
priority: "P0"
tags: [workflow, bugfix, qa, engineering]
related_documents: ["10-001: Workflow Engine", "02-004: Quality Standards"]
related_agents: ["QA Agent", "Gameplay Programmer Agent", "Code Review Agent"]
dependencies: ["10-001: Workflow Engine"]
---

# Bug Fix Workflow

## Trigger
Event — Bug reported by QA Agent, player feedback, analytics anomaly, or crash report.

## Steps

### Step 1: Bug Triage (QA Agent)
- **Action:** Classify bug severity (P0 Critical, P1 Major, P2 Minor, P3 Cosmetic), reproduce, document
- **Inputs:** Bug report, reproduction steps, device/OS info
- **Outputs:** Triaged bug ticket with severity, repro steps, expected vs. actual behavior
- **Quality Gate:** Self-review
- **Governance:** P0 bugs escalate to founder immediately

### Step 2: Root Cause Analysis (Gameplay Programmer Agent)
- **Action:** Investigate and identify root cause
- **Inputs:** Bug ticket, relevant source code, logs
- **Outputs:** Root cause analysis, proposed fix approach
- **Quality Gate:** Self-review
- **Governance:** P2 (within technical domain)

### Step 3: Fix Implementation (Gameplay Programmer Agent)
- **Action:** Implement the fix
- **Inputs:** Root cause analysis, coding standards
- **Outputs:** Fix code, updated unit tests, regression test
- **Quality Gate:** Self-review → Code Review Agent
- **Governance:** P1 if fix changes architecture; P2 for standard fixes

### Step 4: Fix Verification (QA Agent)
- **Action:** Verify fix resolves the bug and introduces no regressions
- **Inputs:** Fixed build, original repro steps, regression test suite
- **Outputs:** Verification report, regression results
- **Quality Gate:** Full pipeline
- **Governance:** P2

### Step 5: Merge & Deploy
- **Action:** Merge fix, schedule for next release
- **Governance:** P0 bugs → hotfix release path (founder approval). P1-P3 → normal release cycle.

## Estimated Duration
P0: <24 hours. P1: <3 days. P2-P3: Next sprint.
