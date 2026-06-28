---
document_id: "10-013"
title: "Release Workflow"
owner: "QA Agent"
status: "Approved"
version: "1.0"
created: "2026-06-28"
updated: "2026-06-28"
phase: "Phase 1 — Agent Operating System"
priority: "P0"
tags: [workflow, release, deployment]
related_documents: ["10-001: Workflow Engine", "02-004: Quality Standards"]
related_agents: ["QA Agent", "Security Agent", "Performance Agent", "Founder Agent", "ASO Agent"]
dependencies: ["10-001: Workflow Engine"]
---
# Release Workflow
## Trigger
Manual — Product Manager or Founder initiates a release.
## Steps
1. **Release Candidate** (Automation Agent) → Create release branch, build RC
2. **Regression Testing** (QA Agent) → Full regression suite on RC build
3. **Performance Validation** (Performance Agent) → Full profiling on target devices
4. **Security Audit** (Security Agent) → Final security check (data, auth, APIs)
5. **Store Listing Update** (ASO Agent) → Update what's new, screenshots if needed
6. **Release Notes** (Content Creator Agent) → Player-facing release notes in brand voice
7. **Founder Sign-Off** (Founder) → P0 governance — founder plays RC and approves
8. **Submission** (Automation Agent) → Submit to App Store / Google Play
9. **Post-Release Monitoring** (Analytics Agent) → Crash rates, reviews, KPI impact for 48 hours
10. **Release Retrospective** (Product Manager Agent) → What went well, what to improve
## Governance: P0 — Founder must approve every release.
## Estimated Duration: 3-5 days
