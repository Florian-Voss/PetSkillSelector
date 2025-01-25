using PetSkillSelector.Abstractions.Skills;
using PetSkillSelector.Stats;
namespace PetSkillSelector.Skills;
public class IntensePainbloom(Intelligence intelligence, Painbloom painbloom) : DamageTalentUpgrade("Intense Painbloom", intelligence, painbloom)
{
    public override float GetDamage()
    {
        return Talent.GetDamage() * 0.4f;
    }
}