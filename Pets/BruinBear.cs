using PetSkillSelector.Abstractions.Pets;
using PetSkillSelector.Abstractions.Skills;
using PetSkillSelector.Abstractions.Stats;

namespace PetSkillSelector.Pets;
public class BruinBear(List<Stat> stats, List<Skill> skills) : Pet("Bruin Bear", stats, skills)
{
    public override List<Skill> GetBestSkills()
    {
        throw new NotImplementedException();
    }
}