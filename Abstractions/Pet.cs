namespace PetSkillSelector.Abstractions;
public abstract class Pet(string name, List<Stat> stats, List<Skill> skills)
{
    protected string Name { get; set; } = name;
    protected List<Stat> Stats { get; set; } = stats;
    protected List<Skill> Skills { get; set; } = skills;
    public abstract List<Skill> GetBestSkills();
}