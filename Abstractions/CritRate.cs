namespace PetSkillSelector.Abstractions;
public abstract class CritRate(string name, uint baseCritRate, double scalingRate, Stat stat) : Skill(name, stat)
{
    public uint BaseCritRate { get; set; } = baseCritRate;
    public double ScalingRate { get; set; } = scalingRate;
}