---
document_id: "02-004"
title: "Quality Standards"
owner: "QA Agent"
status: "Approved"
version: "1.0"
created: "2026-06-27"
updated: "2026-06-27"
phase: "Phase 0 — Constitutional Layer"
priority: "P0"
tags:
  - quality
  - standards
  - code
  - design
  - review
  - testing
related_documents:
  - "00-001: Founder Charter"
  - "00-004: AI Collaboration Protocol"
  - "02-001: Core Values"
  - "02-002: Design Principles"
  - "02-003: Operating Principles"
  - "06-001: Project Structure (Phase 5)"
related_agents:
  - "QA Agent"
  - "Code Review Agent"
  - "All Agents (quality compliance)"
dependencies:
  - "02-001: Core Values"
  - "02-003: Operating Principles"
---

# Quality Standards

## 1. Vision

Quality standards define the bar below which nothing ships. In an AI-native company, these standards serve a dual purpose: they guide AI agents during generation, and they provide objective criteria for human review during the review stage of the collaboration pipeline (`00-004`).

These are not aspirational goals — they are minimum requirements. Output that meets these standards ships. Output that does not is revised or rejected. There is no gray area.

The standards cover four domains: Code, Design, Content, and Documentation. Each domain has specific, testable criteria.

## 2. Problem Statement

AI-generated output has a characteristic quality profile: it is often broadly competent but subtly wrong. Code compiles but has hidden coupling. Design documents are well-structured but miss edge cases. Content is grammatically correct but tonally off. Documentation is comprehensive but stale within weeks.

Without explicit quality standards calibrated to these specific failure modes, AI output will slowly degrade the codebase, the design coherence, and the documentation integrity. The degradation is gradual enough to miss day-to-day but devastating at scale.

## 3. Goals

1. Define objective, testable quality criteria for Code, Design, Content, and Documentation.
2. Calibrate standards to the specific failure modes of AI-generated output.
3. Create standards that AI agents can self-check against before submitting for review.
4. Establish quality gates that are fast to evaluate (minutes, not hours).
5. Distinguish between "must fix before shipping" and "should improve but can ship."

## 4. Non-Goals

- These standards do not define specific coding patterns (future `06_Unity` docs).
- These standards do not define art quality (future `12_Art` docs).
- These standards do not define audio quality (future `13_Audio` docs).
- Standards for those domains will extend this document, not replace it.

## 5. Principles

1. **Standards are gates, not ceilings.** Meeting the standard is the minimum. Exceeding it is celebrated. Falling below it is unacceptable.
2. **Testable over subjective.** Where possible, standards should be binary (pass/fail), not graduated (1–10 scale).
3. **AI-calibrated.** Standards address the specific ways AI output tends to fail, not just generic best practices.
4. **Living standards.** As AI capabilities improve and failure modes shift, standards update quarterly.

## 6. Requirements

### 6.1 Code Quality Standards

#### Must-Pass (Block shipping if violated)

| Standard | Test | AI Failure Mode Addressed |
|----------|------|--------------------------|
| **Compiles without errors** | CI/CD build pass | AI occasionally generates code with syntax errors or missing references |
| **All unit tests pass** | Automated test suite | AI may break existing functionality while adding new features |
| **No hardcoded values** | Static analysis scan | AI frequently embeds magic numbers, strings, and configuration as literals |
| **No circular dependencies** | Dependency analysis | AI tends to create tight coupling between modules |
| **Follows naming conventions** | Lint check | AI may use inconsistent naming across files |
| **No memory leaks in managed resources** | Profiler check (sampling) | AI may create event subscriptions without cleanup |
| **Error handling exists for all external calls** | Code review | AI often generates "happy path" only code |
| **No TODO/HACK/FIXME without linked issue** | Grep scan | AI generates placeholder comments without follow-through |

#### Should-Pass (Flag but can ship with justification)

| Standard | Test | AI Failure Mode Addressed |
|----------|------|--------------------------|
| **Cyclomatic complexity <10 per method** | Static analysis | AI generates complex methods instead of composing simple ones |
| **Max 200 lines per file** | Line count | AI tends toward monolithic files |
| **XML doc comments on all public APIs** | Lint check | AI sometimes skips documentation on public interfaces |
| **No more than 3 parameters per method** | Static analysis | AI generates methods with excessive parameters instead of using objects |
| **ScriptableObject used for all configuration** | Code review | AI may inline configuration in code |
| **Events used for cross-module communication** | Architecture review | AI tends toward direct references between modules |

#### Unity-Specific Standards

| Standard | Test |
|----------|------|
| No `Find()` or `FindObjectOfType()` in production code | Grep scan |
| No `Update()` for logic that can be event-driven | Code review |
| Object pooling for frequently instantiated objects | Architecture review |
| Addressables for all non-critical asset loading | Asset analysis |
| No `async void` except for Unity event methods | Static analysis |
| Null checks on all serialized references | Runtime validation |

### 6.2 Design Quality Standards

| Standard | Test | Applicable To |
|----------|------|--------------|
| Feature passes the Seven-Question Gate (`02-002`) | Gate document filled | All features |
| Target emotion identified and justified | Design review | All player-facing features |
| No anti-emotion triggered by design | Design review + player testing | All player-facing features |
| Success metric defined with target value | PRD review | All features |
| Edge cases documented (what if player has 0? What if player has max?) | PRD review | All systems |
| Economy impact assessed | Economy Agent review | Any feature involving resources |
| Reuse assessment completed | Engine review | All new systems |
| Accessibility considered | UX Agent review | All UI and interaction design |

### 6.3 Content Quality Standards

| Standard | Test | Applicable To |
|----------|------|--------------|
| Matches brand tone of voice (`01-002`) | Content review | All player-facing text |
| No placeholder text in production builds | Automated scan | All text assets |
| Localization-ready (no hardcoded strings) | Build check | All text |
| Grammar and spelling error-free | Automated check | All text |
| Culturally sensitive (no region-specific assumptions) | Content review | All text and imagery |
| Under character limit for UI containers | UI rendering test | All in-game text |

### 6.4 Documentation Quality Standards

| Standard | Test | Applicable To |
|----------|------|--------------|
| YAML frontmatter valid and complete | Schema validation | All documents |
| All 14 required sections present | Template check | All documents |
| Related documents cross-referenced with valid doc_ids | Link check | All documents |
| No information duplicated from another document | Manual review (sampling) | All documents |
| Updated within 7 days of related system change | Staleness check | All documents |
| Decision history updated with any changes | Diff review | All documents |

### 6.5 Severity Classification

| Severity | Definition | Action |
|----------|-----------|--------|
| **Blocker** | Must-pass standard violated | Cannot ship. Fix immediately. |
| **Critical** | Should-pass standard violated with no justification | Should fix before ship. Justify if deferring. |
| **Major** | Should-pass standard violated with justification | Log as tech debt. Schedule fix within 2 sprints. |
| **Minor** | Style or preference issue | Fix if convenient. No tracking required. |

## 7. Acceptance Criteria

- [ ] Every standard is testable — pass or fail, no subjective judgment required.
- [ ] AI agents can self-evaluate against 80%+ of standards before submitting for review.
- [ ] The full quality check for a typical PR takes <15 minutes.
- [ ] Standards address the specific failure modes of AI-generated output, not just generic best practices.
- [ ] Severity classification is clear and non-overlapping.

## 8. KPIs

| KPI | Target | Measurement |
|-----|--------|-------------|
| Blocker escape rate (blockers that reach production) | 0% | Post-release audit |
| Must-pass compliance rate | 100% on all merged code | CI/CD reporting |
| Should-pass compliance rate | 90%+ | Code review metrics |
| Documentation freshness | 95%+ current within 7-day window | Automated staleness check |
| Average defect density | <2 bugs per 1000 lines of AI-generated code | Bug tracking analysis |
| First-pass quality rate | 70%+ (improving over time) | AI Collaboration Protocol metrics |

## 9. Risks

| Risk | Likelihood | Impact | Mitigation |
|------|-----------|--------|------------|
| Standards too strict, slowing development | Medium | Medium | Distinguish must-pass from should-pass. Only blockers stop shipping. |
| Standards not strict enough, quality degrades | Low (initially) | High | Quarterly standard review. Tighten standards as AI output improves. |
| AI agents learn to "game" standards (technically passing but missing intent) | Medium | Medium | Founder taste review catches intent misalignment. Update standards to close loopholes. |
| Automated checks give false sense of security | Medium | Medium | Automated checks + sampling-based human review. Never rely solely on automation. |

## 10. Future Expansion

- **Art quality standards.** Visual consistency, resolution requirements, animation smoothness, color palette compliance.
- **Audio quality standards.** Format specs, compression targets, spatial audio requirements, volume normalization.
- **Performance quality standards.** Frame rate, memory, load time, battery impact targets per device tier.
- **Security quality standards.** Data handling, encryption, authentication, anti-cheat requirements.

## 11. AI Automation Opportunities

- **Pre-commit quality gate.** Automated CI/CD pipeline runs all must-pass checks before code can be merged.
- **Self-review agent.** Code Review Agent applies all standards before output reaches founder.
- **Documentation freshness bot.** Automated alerts when documents exceed the 7-day staleness window.
- **Quality trend dashboard.** Track quality metrics over time to identify improving and degrading areas.
- **Standard gap detection.** When a bug escapes to production, automatically identify which standard should have caught it and propose a new standard.

## 12. Open Questions

1. Should quality standards be different for prototype/experimental code vs. production code?
2. How do we handle the tension between "Ship Small, Ship Often" and thorough quality checks?
3. Should there be a "quality debt budget" — a maximum amount of deferred should-pass violations before a quality sprint is mandatory?

## 13. Decision History

| Date | Decision | Rationale |
|------|----------|-----------|
| 2026-06-27 | Four-domain quality framework adopted | Code, Design, Content, Documentation covers all output types in Phase 0. Art, Audio, Performance added in later phases. |
| 2026-06-27 | Must-pass vs. should-pass distinction | Binary "all standards are equal" approach would either lower the bar or block shipping. Two tiers provide appropriate nuance. |
| 2026-06-27 | AI-specific failure modes integrated | Standards address how AI actually fails, not how humans fail. Different failure modes require different checks. |

## 14. Related Documents

| Doc ID | Title | Relationship |
|--------|-------|-------------|
| 00-001 | Founder Charter | Founder enforces quality bar through review |
| 00-004 | AI Collaboration Protocol | Quality standards are the criteria for the Review stage |
| 02-001 | Core Values | "Leverage Over Labor" demands automation of quality checks |
| 02-003 | Operating Principles | "Fail Fast, Recover Gracefully" shapes error handling standards |
| 06-001 | Project Structure | Unity-specific standards extend as architecture docs are created |
