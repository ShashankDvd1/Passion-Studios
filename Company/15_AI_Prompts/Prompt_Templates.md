---
document_id: "15-002"
title: "Prompt Templates"
owner: "Prompt Engineering Agent"
status: "Approved"
version: "1.0"
created: "2026-06-28"
updated: "2026-06-28"
phase: "Phase 1 — Agent Operating System"
priority: "P1"
tags: [prompts, templates, standardization]
related_documents: ["15-001: Prompt Engineering Framework"]
related_agents: ["Prompt Engineering Agent"]
dependencies: ["15-001: Prompt Engineering Framework"]
---
# Prompt Templates
## 1. Vision
Standardized structures for different types of agent invocations, ensuring consistent output parsing.

## 6. Requirements
### 6.1 Template Types
| Template Type | Use Case | Output Format |
|---------------|----------|---------------|
| **Decision Prompt** | When an agent must make or recommend a decision | JSON Decision Record |
| **Generation Prompt** | When creating content, code, or design | Markdown with strict sections |
| **Review Prompt** | When auditing another agent's work | JSON Pass/Fail with feedback |
| **Routing Prompt** | When deciding where a task belongs | Single ID string |

### 6.2 The Review Prompt Template
```
You are reviewing a submission as the {{agent_name}}.

TASK: Review the following {{item_type}} against standard: {{standard_ref}}.

SUBMISSION:
{{submission_text}}

CONSTRAINTS:
1. Provide actionable feedback. No vague statements.
2. If rejecting, cite the specific rule violated.

OUTPUT FORMAT:
{
  "status": "APPROVED|REJECTED|REVISION_REQUESTED",
  "feedback": ["Point 1", "Point 2"],
  "violated_rules": ["Rule ID 1"] // Empty if approved
}
```
