using PetSkillSelector.Abstractions.Stats;

namespace PetSkillSelector.Abstractions.Skills;
public abstract class CritDamage(string name, Stat stat, float baseCritDmgFactor, float scalingFactor, CritRate critRate, List<DamageSkill> skills) : DamageSkill(name, stat)
{
    private float BaseCritDamageFactor { get; set; } = baseCritDmgFactor;
    private float ScalingFactor { get; set; } = scalingFactor;
    private CritRate CritRate { get; set; } = critRate;
    private List<DamageSkill> Skills { get; set; } = skills;
    public override float GetDamage()
    {
        var baseDamage = Skills.Sum(skill => skill.GetDamage());
        var additionalCritDamage = baseDamage * CritRate.GetCritRateFactor() * GetCritDamageFactor();
        return additionalCritDamage;
    }
    private float GetCritDamageFactor(){
        return BaseCritDamageFactor + ScalingFactor * Stat.Value / 100;
    }
}