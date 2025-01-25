using PetSkillSelector.Abstractions.Pets;
using PetSkillSelector.Abstractions.Skills;
using PetSkillSelector.Abstractions.Stats;

public class SeraphicFaedrake(List<Stat> stats, List<Skill> skills) : Pet("Seraphic Faedrake", stats, skills)
{
    public override List<Skill> GetBestSkills()
    {
        throw new NotImplementedException();
    }
}