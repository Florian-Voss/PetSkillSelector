using PetSkillSelector.Abstractions.Skills;
using PetSkillSelector.Stats;

public class IntenseFollowUp(Luck luck, DamageSkill skill) : DamageSkillUpgrade("Intense Follow Up", luck, skill)
{
    public override float GetDamage()
    {
        //increase crit rate of FollowUp
        throw new NotImplementedException();
    }
}