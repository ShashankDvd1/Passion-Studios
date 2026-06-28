---
document_id: "15-008"
title: "Prompt Optimization"
owner: "Prompt Engineering Agent"
status: "Approved"
version: "1.0"
created: "2026-06-28"
updated: "2026-06-28"
phase: "Phase 1 — Agent Operating System"
priority: "P1"
tags: [prompts, optimization, improvement]
related_documents: ["15-007: Prompt Evaluation", "18-002: AB Test Standards"]
related_agents: ["Prompt Engineering Agent"]
dependencies: ["15-007: Prompt Evaluation"]
---
# Prompt Optimization
## 1. Vision
A systematic process for improving underperforming prompts based on evaluation data.

## 6. Requirements
### 6.1 Optimization Workflow
1. **Identify:** Select prompts with <80% First-Pass Approval Rate.
2. **Analyze:** Review the specific Quality Gate feedback that caused rejections (e.g., "Always forgets the emotion target").
3. **Hypothesize:** Propose a prompt change to fix the issue (e.g., "Make emotion target a mandatory JSON field").
4. **Test:** Run against the Prompt Testing suite (`15-005`).
5. **A/B Test (Optional):** For critical agents, run the old and new prompt in parallel for 10 tasks to verify improvement.
6. **Deploy:** Update version and deploy.

### 6.2 Model-Specific Optimization
- If the underlying AI model changes (e.g., GPT-4 to GPT-5 or Claude 3 to 3.5), all P0/P1 agent prompts enter the optimization workflow to ensure the new model interprets constraints correctly.
