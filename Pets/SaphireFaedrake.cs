using PetSkillSelector.Abstractions;

namespace PetSkillSelector.Pets;
public class SaphireFaedrake(List<Stat> stats, List<Skill> skills) : Pet("Saphire Faedrake", stats, skills)
{
    public override List<Skill> GetBestSkills()
    {
        throw new NotImplementedException();
    }
}