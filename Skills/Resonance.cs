using PetSkillSelector.Abstractions.Skills;
using PetSkillSelector.Stats;

public class Resonance(Spirit spirit, List<DamageSkill> skills) : DamageEnhancement("Resonance", spirit, 0.1f, 0.0667088607594937f, skills){

}