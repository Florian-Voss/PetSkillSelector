using PetSkillSelector.Abstractions.Skills;
using PetSkillSelector.Abstractions.Stats;
using PetSkillSelector.Skills;
using PetSkillSelector.Stats;

public class AdvancedFollowUp(Luck luck, FollowUp followUp) : DamageSkillUpgrade("Advanced Follow Up", luck, followUp)
{
    private const float BaseFactor = 0.2f;
    private const float ScalingFactor = 0.1333191489361702f;
    public override float GetDamage()
    {
        var followUpDmg = Skill.GetDamage();
        var damageFactor = BaseFactor + ScalingFactor * Stat.Value / 100;
        var damage = followUpDmg * damageFactor;
        return damage;
    }
}