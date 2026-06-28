# Master Launch Checklist: Tiny World MVP

**Objective:** Ship a commercially viable MVP to the Google Play Store in 30 Days.
**Status:** 🔄 Execution Mode (Week 1)

## 1. Engineering (Week 1-3)
| Task ID | Category | Priority | Owner Agent | Dependencies | Status | Due Week | Acceptance Criteria | Validation Gate |
|---------|----------|----------|-------------|--------------|--------|----------|---------------------|-----------------|
| `ENG-01` | Core | P0 | Unity Architect | None | 🔄 In Progress | W1 | Unity 6 Project Initialized in `UnityProject/` | Technical |
| `ENG-02` | Core | P0 | Unity Architect | `ENG-01` | [ ] Pending | W1 | `Runtime Core` and `BootManager` active | Technical |
| `ENG-03` | Systems | P0 | Backend Agent | `ENG-02` | [ ] Pending | W1 | Local JSON Save/Load functions correctly | QA |
| `ENG-04` | Systems | P0 | Unity Architect | `ENG-02` | [ ] Pending | W1 | Decoupled `Event Bus` active | Technical |
| `ENG-05` | UI | P1 | UX Agent | `ENG-04` | [ ] Pending | W2 | MVC UI Framework active (Thumb-zone ready) | UX |
| `ENG-06` | Systems | P1 | Product Manager | `ENG-04` | [ ] Pending | W2 | Remote Config fetched on boot | Technical |
| `ENG-07` | Meta | P0 | Analytics Agent | `ENG-02` | [ ] Pending | W3 | Firebase/Unity Analytics SDK initialized | Analytics |
| `ENG-08` | Meta | P0 | Monetization Agent | `ENG-02` | [ ] Pending | W3 | Rewarded Ads SDK initialized | Technical |
| `ENG-09` | Perf | P0 | Unity Architect | All ENG | [ ] Pending | W4 | Target FPS hit, 0B allocation in Update | Performance |

## 2. Product (Week 1-2)
| Task ID | Category | Priority | Owner Agent | Dependencies | Status | Due Week | Acceptance Criteria | Validation Gate |
|---------|----------|----------|-------------|--------------|--------|----------|---------------------|-----------------|
| `PROD-01` | Gameplay | P0 | Product Manager | `ENG-01` | [ ] Pending | W1 | Basic Resource Collection (Placeholder art) | Product |
| `PROD-02` | Gameplay | P0 | Product Manager | `ENG-04` | [ ] Pending | W1 | Inventory updates on collection | Product |
| `PROD-03` | Gameplay | P0 | Product Manager | `ENG-01` | [ ] Pending | W2 | One Companion interacts and levels up | Product |
| `PROD-04` | Gameplay | P0 | Product Manager | `PROD-03` | [ ] Pending | W2 | Core Loop functioning (Harvest->Reward) | Founder |
| `PROD-05` | Meta | P1 | Product Manager | `ENG-03` | [ ] Pending | W2 | Offline progression calculates correctly | QA |
| `PROD-06` | Meta | P1 | Product Manager | `ENG-06` | [ ] Pending | W3 | Daily Reward triggers once per 24hr | QA |

## 3. QA & Compliance (Week 1-4)
| Task ID | Category | Priority | Owner Agent | Dependencies | Status | Due Week | Acceptance Criteria | Validation Gate |
|---------|----------|----------|-------------|--------------|--------|----------|---------------------|-----------------|
| `QA-01` | Testing | P0 | QA Agent | `ENG-01` | [ ] Pending | W1 | Weekly Playable Build Pipeline created | Technical |
| `QA-02` | Testing | P1 | QA Agent | `PROD-04` | [ ] Pending | W3 | Core Loop tested on min-spec Android | QA |
| `COMP-01`| Legal | P0 | Project Manager | None | [ ] Pending | W3 | Privacy Policy & TOS generated | Founder |
| `COMP-02`| Legal | P0 | UX Agent | `COMP-01` | [ ] Pending | W3 | GDPR Consent Modal displays on first boot | Legal |

## 4. Publishing & Marketing (Week 3-4)
| Task ID | Category | Priority | Owner Agent | Dependencies | Status | Due Week | Acceptance Criteria | Validation Gate |
|---------|----------|----------|-------------|--------------|--------|----------|---------------------|-----------------|
| `PUB-01` | Store | P0 | Product Manager | `PROD-04` | [ ] Pending | W3 | App Icon & Feature Graphic created | Founder |
| `PUB-02` | Store | P1 | Product Manager | `PROD-04` | [ ] Pending | W4 | Screenshots & Short/Full Description | Founder |
| `PUB-03` | Release | P0 | Unity Architect | All | [ ] Pending | W4 | Android `.aab` package signed & built | Technical |
| `MKT-01` | ASO | P1 | Product Manager | None | [ ] Pending | W4 | ASO Checklist complete | Marketing |

## 5. LiveOps & Post-Launch (Week 4)
| Task ID | Category | Priority | Owner Agent | Dependencies | Status | Due Week | Acceptance Criteria | Validation Gate |
|---------|----------|----------|-------------|--------------|--------|----------|---------------------|-----------------|
| `LIVE-01` | Ops | P1 | Analytics Agent | `ENG-07` | [ ] Pending | W4 | Analytics Dashboard tracking Core Loop | Analytics |
| `POST-01` | Strategy | P2 | Project Manager | None | [ ] Pending | W4 | V1.1 Roadmap / Content Expansion Plan | Founder |

---

### Completeness Review
- [ ] Are any launch requirements missing from this list? (AI Agents must continuously audit and append tasks).
