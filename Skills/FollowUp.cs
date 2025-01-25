using System.Xml.Schema;
using PetSkillSelector.Abstractions.Skills;
using PetSkillSelector.Abstractions.Stats;
using PetSkillSelector.Stats;
namespace PetSkillSelector.Skills;
public class FollowUp(Intelligence intelligence, DamageTalent talent) : DamageSkillUpgrade("Follow Up", intelligence, talent)
{
    const float BaseDmgFactor = 0.25f;
    const float ScalingFactor = 0.1667058823529412f;
    public override float GetDamage()
    {
        var baseSkillDmg = Skill.GetDamage();
        return baseSkillDmg * 0.4f * (BaseDmgFactor + ScalingFactor * Stat.Value/100);
    }
}