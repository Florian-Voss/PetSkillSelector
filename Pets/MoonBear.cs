using PetSkillSelector.Abstractions.Pets;
using PetSkillSelector.Abstractions.Skills;
using PetSkillSelector.Abstractions.Stats;

namespace PetSkillSelector.Pets;
public class MoonBear(List<Stat> stats, List<Skill> skills) : Pet("Moon Bear", stats, skills)
{
    public override List<Skill> GetBestSkills()
    {
        throw new NotImplementedException();
    }
}