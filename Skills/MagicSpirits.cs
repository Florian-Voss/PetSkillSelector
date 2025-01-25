using PetSkillSelector.Abstractions.Skills;
using PetSkillSelector.Stats;

public class MagicSpirits(Spirit spirit, CritRate critRate, List<DamageSkill> skills) : CritDamage("Magic Spirits", spirit, 0.333f, 0.2222151898734177f, critRate, skills){

}