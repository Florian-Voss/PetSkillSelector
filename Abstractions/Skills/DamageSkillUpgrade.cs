using PetSkillSelector.Abstractions.Stats;

namespace PetSkillSelector.Abstractions.Skills;
public abstract class DamageSkillUpgrade(string name, Stat stat, DamageSkill skill) : DamageSkill(name, stat)
{
    protected DamageSkill Skill { get; set; } = skill;
}