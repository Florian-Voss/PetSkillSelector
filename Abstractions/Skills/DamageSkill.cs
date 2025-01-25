using PetSkillSelector.Abstractions.Skills;
using PetSkillSelector.Abstractions.Stats;

public abstract class DamageSkill(string name, Stat stat) : Skill(name, stat){
    public abstract float GetDamage();
}