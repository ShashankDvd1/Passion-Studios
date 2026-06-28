---
document_id: "10-010"
title: "Code Review Workflow"
owner: "Code Review Agent"
status: "Approved"
version: "1.0"
created: "2026-06-28"
updated: "2026-06-28"
phase: "Phase 1 — Agent Operating System"
priority: "P0"
tags: [workflow, code-review, engineering]
related_documents: ["10-001: Workflow Engine", "02-004: Quality Standards"]
related_agents: ["Code Review Agent", "Gameplay Programmer Agent"]
dependencies: ["10-001: Workflow Engine"]
---
# Code Review Workflow
## Trigger
Event — Code submitted for review (output from implementation step in any workflow).
## Steps
1. **Self-Review** (Submitting Agent) → Quality Standards checklist applied before submission
2. **Automated Checks** (Code Review Agent) → Coding standards, SOLID compliance, test coverage, no forbidden patterns
3. **Architecture Review** (Code Review Agent) → Module boundaries, dependency direction, reusability assessment
4. **Security Scan** (Security Agent) → If code touches auth, data, or APIs
5. **Feedback** (Code Review Agent) → Approve, Request Changes, or Reject with specific actionable feedback
6. **Revision** (Submitting Agent) → Address feedback, resubmit (if needed)
7. **Final Approval** (Code Review Agent) → Approve for merge
## Governance: P2 for standard code. P1 if architectural changes detected.
## Estimated Duration: 2-4 hours
