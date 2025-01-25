using PetSkillSelector.Abstractions.Stats;

namespace PetSkillSelector.Abstractions.Skills;
public abstract class DamageTalentUpgrade(string name, Stat stat, DamageTalent talent) : DamageSkill(name, stat)
{
    protected DamageTalent Talent { get; set; } = talent;
}