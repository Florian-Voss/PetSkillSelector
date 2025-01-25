using PetSkillSelector.Abstractions.Stats;

namespace PetSkillSelector.Abstractions.Skills;
public abstract class DamageEnhancement(string name, Stat stat, float baseDamageEnhancementFactor, float scalingFactor, List<DamageSkill> skills) : DamageSkill(name, stat)
{
    private List<DamageSkill> Skills { get; set; } = skills;
    private float BaseDamageEnhancementFactor { get; set; } = baseDamageEnhancementFactor;
    private float ScalingFactor { get; set; } = scalingFactor;
    public override float GetDamage()
    {
        var baseDamage = Skills.Sum(skill => skill.GetDamage());
        var enhancedDamage = baseDamage + baseDamage * GetDamageEnhancementFactor();
        return enhancedDamage;
    }
    private float GetDamageEnhancementFactor(){
        return BaseDamageEnhancementFactor + ScalingFactor * Stat.Value/100;
    }
}