using PetSkillSelector.Abstractions.Skills;
using PetSkillSelector.Stats;

public class ElementalHarmony(Intelligence intelligence, CritRate critRate, List<DamageSkill> skills) : CritDamage(
        "Elemental Harmony", intelligence, 0.333f, 0.2221764705882353f, critRate, skills
    )
{

}