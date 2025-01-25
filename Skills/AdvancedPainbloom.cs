using PetSkillSelector.Abstractions.Skills;
using PetSkillSelector.Abstractions.Stats;
using PetSkillSelector.Stats;
namespace PetSkillSelector.Skills;
public class AdvancedPainbloom(Spirit spirit, Painbloom talent) : DamageTalentUpgrade("Advanced Painbloom", spirit, talent)
{
    public override float GetDamage()
    {
        var multiplier = Stat.Value / 155;
        var painbloomDamage = Talent.GetDamage();
        return multiplier == 0 ? 0 : painbloomDamage * multiplier;
    }
}