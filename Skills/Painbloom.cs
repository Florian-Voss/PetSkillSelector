using PetSkillSelector.Abstractions;

namespace PetSkillSelector.Skills;
public class Painbloom(string name, Stat stat) : Talent(name, stat)
{
    public const uint BaseDmg = 140;
    public const float ScalingRate = 0.933F;
}
