namespace PetSkillSelector.Abstractions;
public abstract class TalentUpgrade(string name, Stat stat, Talent talent) : Skill(name, stat)
{
    public Talent Talent { get; set; } = talent;
}