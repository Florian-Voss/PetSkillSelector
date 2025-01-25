using PetSkillSelector.Abstractions.Pets;
using PetSkillSelector.Abstractions.Skills;
using PetSkillSelector.Abstractions.Stats;

namespace PetSkillSelector.Pets;
public class SnowpeakRoc(List<Stat> stats, List<Skill> skills) : Pet("Snowpeak Roc", stats, skills)
{
    public override List<Skill> GetBestSkills()
    {
        throw new NotImplementedException();
    }
}