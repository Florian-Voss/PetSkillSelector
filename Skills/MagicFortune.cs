using PetSkillSelector.Abstractions.Skills;
using PetSkillSelector.Stats;

public class MagicFortune(Luck luck) : CritRate("Magic Fortune", luck, 0.167f, 0.1111063829787234f)
{
}