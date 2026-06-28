# Content Registry

This registry tracks the specific Game Data Content configured within the generic systems. This acts as the Single Source of Truth for all ScriptableObject content, ensuring AI agents know exactly which assets exist across the entire platform.

| Content ID | Category | Feature ID | Required Unity Asset | ScriptableObject | Localization Key | Analytics Event | Unlock Condition | Rarity | Version | Owner Agent | QA Status |
|---|---|---|---|---|---|---|---|---|---|---|---|
| ITM-001 | Item | FEAT-INV-01 | `Spr_WoodLog` | `ItemDef_WoodLog` | `ITEM_WOOD_LOG` | `item_looted_wood` | None | Common | v1.0 | Economy Agent | Draft |
| DEC-001 | Decoration | FEAT-001 | `Pfb_Chair_Oak` | `DecorDef_OakChair` | `DECOR_OAK_CHAIR` | `placed_oak_chair` | Reached Level 2 | Uncommon | v1.0 | Product Manager | Draft |
| PET-001 | Companion | FEAT-PET-01 | `Pfb_Dog_Shiba` | `PetDef_Shiba` | `PET_SHIBA` | `adopted_shiba` | Quest QST-005 | Rare | v1.0 | Game Designer | Draft |
