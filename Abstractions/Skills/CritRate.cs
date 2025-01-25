using PetSkillSelector.Abstractions.Stats;

namespace PetSkillSelector.Abstractions.Skills;
public abstract class CritRate(string name, Stat stat, float baseCritRateFactor, float scalingFactor) : Skill(name, stat)
{
    private float BaseCritRateFactor { get; set; } = baseCritRateFactor;
    private float ScalingFactor { get; set; } = scalingFactor;
    public float GetCritRateFactor(){
        return BaseCritRateFactor + ScalingFactor * Stat.Value / 100;
    }
}