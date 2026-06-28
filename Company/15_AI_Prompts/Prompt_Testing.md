---
document_id: "15-005"
title: "Prompt Testing"
owner: "Prompt Engineering Agent"
status: "Approved"
version: "1.0"
created: "2026-06-28"
updated: "2026-06-28"
phase: "Phase 1 — Agent Operating System"
priority: "P1"
tags: [prompts, testing, qa]
related_documents: ["15-001: Prompt Engineering Framework"]
related_agents: ["Prompt Engineering Agent"]
dependencies: []
---
# Prompt Testing
## 1. Vision
No prompt is deployed to an agent without passing a test suite. Testing ensures changes to instructions don't break expected output formats or cause regression in agent reasoning.

## 6. Requirements
### 6.1 Test Suites
Each prompt template has an associated test suite with:
1. **Positive Cases:** Expected inputs that should generate standard, successful outputs.
2. **Negative Cases:** Ambiguous, conflicting, or out-of-bounds inputs that the prompt must reject or handle gracefully.
3. **Format Checks:** Automated parsing of the test output to verify JSON/YAML/Markdown compliance.

### 6.2 Testing Workflow
- When a prompt is modified, the Prompt Engineering Agent runs the test suite.
- If the output format breaks or negative constraints are violated, the prompt change is rejected.
- Only prompts that score 100% on their format tests are promoted to production.
