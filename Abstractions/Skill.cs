namespace PetSkillSelector.Abstractions;
public abstract class Skill
{
    public string Name { get; private set; }
    public Stat Stat { get; private set; }
    public Skill(string name, Stat stat)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(name, nameof(name));
        ArgumentNullException.ThrowIfNull(stat, nameof(stat));
        Name = name;
        Stat = stat;
    }
}
