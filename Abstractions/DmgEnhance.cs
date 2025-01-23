namespace PetSkillSelector.Abstractions;
public abstract class DmgEnhance(string name, Stat stat, uint baseDmgEnhancement, double scalingRate) : Skill(name, stat)
{
    public uint BaseDmgEnhancement { get; set; } = baseDmgEnhancement;
    public double ScalingRate { get; set; } = scalingRate;
}