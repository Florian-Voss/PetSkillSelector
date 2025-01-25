using PetSkillSelector.Abstractions.Stats;

namespace PetSkillSelector.Abstractions.Skills;
public abstract class Skill(string name, Stat stat)
{
    public string Name { get; private set; } = string.IsNullOrWhiteSpace(name) ? throw new ArgumentException($"{nameof(name)} is required") : name;
    protected Stat Stat { get; private set; } = stat is null ? throw new ArgumentNullException($"{nameof(stat)} is required") : stat;
}
