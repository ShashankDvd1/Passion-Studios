---
document_id: "17-006"
title: "Founder Review Standards"
owner: "Founder Agent"
status: "Approved"
version: "1.0"
created: "2026-06-28"
updated: "2026-06-28"
phase: "Phase 1 — Agent Operating System"
priority: "P0"
tags: [quality, review, founder]
related_documents: ["17-001: Quality Pipeline", "00-002: Founder Workflow"]
related_agents: ["Founder Agent"]
dependencies: ["17-001: Quality Pipeline"]
---
# Founder Review Standards
## 1. Vision
The final, human gate. By the time work reaches this stage, it should be technically perfect and consistent. The Founder's job is solely to assess "Is this the game I want to make?"

## 6. Requirements
### 6.1 What Requires Founder Review?
- **P0 / P1 Tasks:** Must have explicit Founder sign-off.
- **Agent Prompts:** Any MAJOR version change to an agent's prompt.
- **Releases:** The final Release Candidate before App Store submission.

### 6.2 The Review Interface
The Founder does not hunt for tasks to review. The Founder Agent compiles all items awaiting Founder Review into the **Decision Queue** and presents them in a standardized format:
- What is being reviewed?
- Which agents reviewed it previously?
- What are the outstanding risks?
- Options (Approve, Request Changes, Reject).

### 6.3 Minimizing Founder Bottleneck
If an item sits in the Founder Review queue for >72 hours, the CEO Agent will evaluate if it can safely act as a proxy decision-maker (per Unavailability Protocol) to unblock development.
