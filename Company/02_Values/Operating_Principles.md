---
document_id: "02-003"
title: "Operating Principles"
owner: "CEO Agent"
status: "Approved"
version: "1.0"
created: "2026-06-27"
updated: "2026-06-27"
phase: "Phase 0 — Constitutional Layer"
priority: "P0"
tags:
  - operations
  - workflow
  - process
  - ai-first
  - automation
related_documents:
  - "01-001: Company Vision"
  - "02-001: Core Values"
  - "02-004: Quality Standards"
  - "00-001: Founder Charter"
  - "00-002: Founder Workflow"
  - "00-004: AI Collaboration Protocol"
  - "07-001: Agent OS Architecture (Phase 1)"
related_agents:
  - "All Agents"
  - "Automation Agent"
  - "Documentation Agent"
dependencies:
  - "01-001: Company Vision"
  - "02-001: Core Values"
---

# Operating Principles

## 1. Vision

These principles define how Wonder Forge Studios operates day-to-day. Where Core Values (`02-001`) define what we believe and Design Principles (`02-002`) define how we design, Operating Principles define how we work.

They are the rules of the machine. Every agent, every process, and every workflow must be consistent with these principles. When designing a new process or evaluating whether an existing one works, these principles are the rubric.

## 2. Problem Statement

An AI-native company without explicit operating principles will develop inconsistent workflows. Some agents will prioritize speed over quality. Others will over-engineer solutions. Documentation will drift. Processes will multiply without pruning. The founder will spend time managing process debt instead of building product.

Operating principles prevent this entropy by establishing how the company operates before the company is fully operational.

## 3. Goals

1. Define 10 operating principles that govern daily work.
2. Each principle must be actionable — it should change behavior, not just describe ideals.
3. Principles must be AI-friendly — agents can reference and apply them without interpretation.
4. Principles must resolve process disagreements without founder escalation.

## 4. Non-Goals

- These do not define specific workflows (see `00-002: Founder Workflow` and Phase 1 Agent OS docs).
- These do not define code style or technical standards (see `02-004: Quality Standards`).
- These do not define game design processes (see `02-002: Design Principles`).

## 5. Principles

This section IS the core content of this document.

### Principle 1: Automate First, Manual Second

Before performing any task manually, ask: "Can this be automated?" If the answer is yes and the automation takes less than 3x the manual effort, automate it. Manual processes are technical debt.

**Application:** Code formatting, testing, deployment, report generation, documentation cross-referencing, and metric tracking should all be automated. Manual execution of these tasks is a process failure, not a work ethic.

### Principle 2: Document as You Build

Documentation is not a post-launch activity. It is a concurrent development artifact. Every system, decision, and workflow must be documented at the time of creation — not after. Undocumented systems do not exist.

**Application:** Every code module has an accompanying doc in the Module Registry. Every decision has an entry in the Decision Log (`23_Decisions`). Every agent workflow is documented in `08_Agents`. If it isn't documented, it isn't done.

### Principle 3: Ship Small, Ship Often

Large changes are risky, slow to review, and difficult to debug. Prefer many small, well-defined changes over monolithic releases. Each change should do one thing and do it completely.

**Application:** Features ship incrementally behind feature flags. Content drops weekly, not monthly. Updates are small and frequent. Players should feel the game is continuously evolving, not periodically overhauled.

### Principle 4: Configuration Over Code

Behavior that can be expressed as data should never be expressed as code. Use ScriptableObjects, JSON configs, and data tables to define game behavior. Code defines systems; data defines content.

**Application:** Adding a new item to the game should never require a code change. Adding a new event should require configuring a template, not writing a new event handler. If a designer (or AI) needs an engineer to add content, the system is not data-driven enough.

### Principle 5: Boring Technology Wins

Choose well-understood, battle-tested technologies over cutting-edge alternatives. The excitement should be in the game, not in the tech stack. Novel technology introduces risk without player-visible benefit.

**Application:** Unity 6 (mature). Firebase (proven). C# (well-known). DOTween (reliable). We do not adopt new frameworks because they are trendy. We adopt them when they are proven and solve a specific problem we have.

### Principle 6: Single Source of Truth

Every piece of information must live in exactly one place. If information is duplicated, it will eventually contradict itself. All references point to the canonical source.

**Application:** Economy balance data lives in one ScriptableObject configuration, not in code AND a spreadsheet AND a design doc. If you find information in two places, delete one.

### Principle 7: Fail Fast, Recover Gracefully

Systems should detect failures early and report them clearly. They should also recover without human intervention when possible. A crash is better than silent data corruption. A clear error message is better than a mysterious behavior change.

**Application:** Assertions in development builds. Graceful fallbacks in production builds. Automatic crash reporting. Error messages that tell the developer (or agent) what went wrong AND what to do about it.

### Principle 8: Measure Before Optimizing

Never optimize a system based on intuition. Measure first. Find the actual bottleneck. Optimize the bottleneck. Measure again to confirm improvement. Premature optimization is wasted effort at best and harmful complexity at worst.

**Application:** Profile before refactoring. A/B test before redesigning. Analyze player data before changing game balance. "I think it's slow" is not an optimization justification. "Profiler shows 60ms spent in X" is.

### Principle 9: Design for Deletion

Every feature, system, and module should be designed so it can be cleanly removed without breaking other systems. If removing Feature A breaks Features B, C, and D, the coupling is too tight. Loose coupling enables experimentation — you can try things without the risk of cascading failures.

**Application:** Features communicate through events, not direct references. Modules declare dependencies explicitly. Feature flags allow runtime enable/disable. Kill switches for every LiveOps system.

### Principle 10: Own the Problem, Not the Solution

Agents own outcomes, not implementations. If the initial approach fails, the responsible agent is expected to find an alternative — not escalate and wait. Solutions are disposable; problems are persistent.

**Application:** If the Game Designer Agent's first attempt at a retention mechanic underperforms, the agent doesn't flag "retention mechanic failed." The agent proposes three alternative approaches, evaluates each against the Behavior Engine, and recommends the best option.

## 6. Requirements

1. All agents must reference these principles in their operational workflows.
2. New processes must be evaluated against all 10 principles before adoption.
3. Process retrospectives (weekly) must identify principle violations and correct them.
4. The Agent OS (`07_AI_OS`) must encode these principles as system-level constraints.

## 7. Acceptance Criteria

- [ ] Each principle can be applied as a pass/fail test to any proposed process or workflow.
- [ ] An AI agent can cite a specific principle to justify a process decision.
- [ ] No principle contradicts another under normal operating conditions.
- [ ] The principles cover the full lifecycle: planning → building → shipping → measuring → iterating.
- [ ] A new agent joining the system can read these principles and operate consistently with existing agents.

## 8. KPIs

| KPI | Target | Measurement |
|-----|--------|-------------|
| Automation coverage | 80%+ of repeatable tasks automated | Automation audit |
| Documentation freshness | 95%+ of docs updated within 7 days of system change | Documentation Agent audit |
| Average change size | <200 lines per commit | Git analytics |
| Config-to-code ratio | 70%+ of game behavior defined in configuration | Codebase analysis |
| Mean time to recovery (MTTR) | <1 hour for non-critical issues | Incident log |

## 9. Risks

| Risk | Likelihood | Impact | Mitigation |
|------|-----------|--------|------------|
| "Automate First" creates over-engineering | Medium | Medium | 3x rule — automation must save time within 3 iterations. If not, stay manual. |
| "Document as You Build" slows development velocity | Medium | Low | Templates and AI-generated documentation reduce friction. Documentation is a 5-minute task, not a 5-hour task. |
| "Boring Technology" prevents adoption of genuinely better tools | Low | Medium | Annual tech audit. "Boring" means proven, not stagnant. Upgrade when evidence supports it. |
| Principles conflict in edge cases | Low | Low | Founder resolves rare conflicts. Decision logged in `23_Decisions`. |

## 10. Future Expansion

- **Process maturity model.** Define maturity levels for each principle (ad hoc → defined → measured → optimized).
- **Agent compliance scoring.** Each agent receives a quarterly "operating principles compliance score."
- **Cross-studio standards.** If the engine/platform is licensed, these principles may form part of the licensee operating manual.

## 11. AI Automation Opportunities

- **Process audit automation.** Automation Agent scans all workflows for principle violations (manual tasks that should be automated, undocumented systems, duplicated information).
- **Change size enforcement.** CI/CD pipeline flags commits exceeding size thresholds.
- **Documentation staleness detection.** Documentation Agent alerts when a system changes but its documentation doesn't update within the defined window.
- **Dependency analysis.** Build pipeline detects tight coupling violations ("Design for Deletion").

## 12. Open Questions

1. Should principle compliance be enforced automatically (block non-compliant changes) or advisory (flag and log)?
2. How do we handle the tension between "Ship Small, Ship Often" and "players want meaningful updates"? (Answer may lie in batching small internal changes into themed external updates.)
3. Should these principles apply to the documentation system itself? (Meta-question about docs documenting themselves.)

## 13. Decision History

| Date | Decision | Rationale |
|------|----------|-----------|
| 2026-06-27 | 10 operating principles established | Covers automation, documentation, shipping cadence, data-driven design, tech choices, information management, failure handling, optimization, modularity, and ownership. |
| 2026-06-27 | 3x automation rule adopted | Prevents over-engineering while ensuring worthwhile automation is never skipped. |

## 14. Related Documents

| Doc ID | Title | Relationship |
|--------|-------|-------------|
| 01-001 | Company Vision | Vision that these operations serve |
| 02-001 | Core Values | Values that generated these operational norms |
| 02-004 | Quality Standards | Quality bar that operations must maintain |
| 00-001 | Founder Charter | Governance model these operations function within |
| 00-002 | Founder Workflow | Founder's daily application of these principles |
| 00-004 | AI Collaboration Protocol | How AI agents embody these principles |
| 07-001 | Agent OS Architecture | Technical system that enforces these principles |
