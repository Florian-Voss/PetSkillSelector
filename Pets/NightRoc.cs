using PetSkillSelector.Abstractions.Pets;
using PetSkillSelector.Abstractions.Skills;
using PetSkillSelector.Abstractions.Stats;

namespace PetSkillSelector.Pets;
public class NightRoc(List<Stat> stats, List<Skill> skills) : Pet("Night Roc", stats, skills)
{
    public override List<Skill> GetBestSkills()
    {
        throw new NotImplementedException();
    }
}