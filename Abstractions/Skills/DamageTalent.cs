using PetSkillSelector.Abstractions.Stats;

namespace PetSkillSelector.Abstractions.Skills;
public abstract class DamageTalent(string name, Stat stat, uint baseDmg, float scalingFactor) : DamageSkill(name, stat)
{
    private uint BaseDamage { get; set; } = baseDmg;
    private float ScalingFactor { get; set; } = scalingFactor;
    public override float GetDamage(){
        return BaseDamage + ScalingFactor * Stat.Value;
    }
}
