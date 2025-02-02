using PetSkillSelector.Abstractions.Pets;
using PetSkillSelector.Abstractions.Skills;
using PetSkillSelector.Abstractions.Stats;

namespace PetSkillSelector.Pets;
public class SaphireFaedrake(List<Stat> stats, List<Skill> skills) : Pet("Saphire Faedrake", stats, skills)
{
    public override List<Skill> GetBestSkills()
    {
        throw new NotImplementedException();
    }
    public uint GetHighestDamageFactor() => (uint)Skills.OfType<DamageSkill>().Sum(skill => skill.GetDamage());
}