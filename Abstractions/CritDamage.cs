namespace PetSkillSelector.Abstractions;
public abstract class CritDamage(string name, Stat stat, uint baseCritDmg, double scalingRate) : Skill(name, stat)
{
    public uint BaseCritDmg { get; set; } = baseCritDmg;
    public double ScalingRate { get; set; } = scalingRate;
}