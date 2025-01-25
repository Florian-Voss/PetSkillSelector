// See https://aka.ms/new-console-template for more information
using System.Reflection;
using System.Text.RegularExpressions;
using PetSkillSelector.Abstractions.Pets;
using PetSkillSelector.Abstractions.Skills;
using PetSkillSelector.Abstractions.Stats;
using PetSkillSelector.Pets;
using PetSkillSelector.Skills;
using PetSkillSelector.Stats;

List<string> petNames = GetPetNames();
string petName = string.Empty;
Console.WriteLine("What pet would you like to gain a skillbuild for? Choose From:");
Console.WriteLine(string.Join(Environment.NewLine, petNames));
while (!PetNameInputIsValid(petName))
{
    petName = Console.ReadLine() ?? string.Empty;
    if (string.IsNullOrWhiteSpace(petName))
    {
        Console.WriteLine("Your input was empty, try again");
        continue;
    }
    if (!PetNameInputIsValid(petName))
    {
        Console.WriteLine($"Pet name '{petName}' is invalid, try again");
        continue;
    }
    petName = SanitizePetName(petName);
}
List<Stat> petStats = [];
List<string> statNames = GetStatNames(petName);
foreach (var statName in statNames)
{
    string statInput = string.Empty;
    Console.WriteLine($"Insert {statName} value");
    bool statValueIsValid = false;
    uint statValue = 0;
    while (!statValueIsValid)
    {
        statInput = Console.ReadLine() ?? string.Empty;
        if (string.IsNullOrWhiteSpace(statInput))
        {
            Console.WriteLine("Your input was empty, try again");
            continue;
        }
        if (!uint.TryParse(statInput, out statValue) || statValue == 0){
            Console.WriteLine("Input must be a positive integer number greater than 0, try again");
            continue;
        }
        statValueIsValid = true;
    }
    petStats.Add(CreateStat(statName, statValue));
}
List<Skill> petSkills = GetPetSkills(petName, petStats);
Pet pet = CreatePet(petSkills, petStats);

var saphireFaedrakeTest = (SaphireFaedrake)pet;
Console.WriteLine(saphireFaedrakeTest.GetHighestDamageFactor());
// var bestSkills = pet.GetBestSkills();
// Console.WriteLine("The Best possible Skills ordered by their effectiveness in descending order are:");
// Console.WriteLine(string.Join(Environment.NewLine), bestSkills);

Pet CreatePet(List<Skill> petSkills, List<Stat> petStats) => petName switch
{
    "saphirefaedrake" => new SaphireFaedrake(petStats, petSkills),
    "seraphicfaedrake" => new SeraphicFaedrake(petStats, petSkills),
    "shadowfaedrake" => new ShadowFaedrake(petStats, petSkills),
    "berserkfaedrake" => new BerserkFaedrake(petStats, petSkills),
    "blademanticore" => new BladeManticore(petStats, petSkills),
    "bruinbear" => new BruinBear(petStats, petSkills),
    "frostbear" => new FrostBear(petStats, petSkills),
    "goldenroc" => new GoldenRoc(petStats, petSkills),
    "icelizard" => new IceLizard(petStats, petSkills),
    "moonbear" => new MoonBear(petStats, petSkills),
    "nightroc" => new NightRoc(petStats, petSkills),
    "sandlizard" => new SandLizard(petStats, petSkills),
    "shadowmanticore" => new ShadowManticore(petStats, petSkills),
    "snowpeakroc" => new SnowpeakRoc(petStats, petSkills),
    "stripedbear" => new StripedBear(petStats, petSkills),
    "thunderlizard" => new ThunderLizard(petStats, petSkills),
    "venomouslizarad" => new VenomousLizard(petStats, petSkills),
    _ => throw new ArgumentException($"pet name '{petName}' is invalid")
};
Stat CreateStat(string statName, uint statValue) => statName switch
{
    "Intelligence" => new Intelligence(statValue),
    "Agility" => new Agility(statValue),
    "Endurance" => new Endurance(statValue),
    "Luck" => new Luck(statValue),
    "Strength" => new Strength(statValue),
    "Spirit" => new Spirit(statValue),
    _ => throw new ArgumentException(null, nameof(statName)),
};
bool PetNameInputIsValid(string petName)
{
    return petNames
        .Select(petname => string.Concat(petname.Split(' ')))
        .Any(petname => petname.Equals(string.Concat(petName.Split(' ')), StringComparison.CurrentCultureIgnoreCase));
}
string SanitizePetName(string petName) => string.Concat(petName.ToLower().Split(' '));
List<string> GetPetNames(){
    List<string> petNames = [
        ..Assembly.GetExecutingAssembly()
        .GetTypes()
        .Where(type => type.IsSubclassOf(typeof(Pet)))
        .Select(type => type.Name)
    ];
    var formattedPetNames = petNames
        .Select(petName => string.Concat(
            petName.Select((c, index) => 
                index > 0 && char.IsUpper(c) 
                    ? " " + c 
                    : c.ToString()
            )
        )).ToList();
    return formattedPetNames;
}
List<Skill> GetPetSkills(string petName, List<Stat> petStats){
    List<Skill> skills = [];
    switch (petName){
        case "saphirefaedrake":
            var intelligence = petStats.OfType<Intelligence>().First();
            var spirit = petStats.OfType<Spirit>().First();
            var luck = petStats.OfType<Luck>().First();
            var painbloom = new Painbloom(intelligence);
            var followUp = new FollowUp(intelligence, painbloom);
            skills.Add(painbloom);
            skills.Add(new AdvancedPainbloom(spirit, painbloom));
            skills.Add(new IntensePainbloom(intelligence, painbloom));
            skills.Add(followUp);
            skills.Add(new AdvancedFollowUp(luck, followUp));
            skills.Add(new MagicFortune(luck));
            //skills.Add(new ElementalHarmony(intelligence, new MagicFortune(luck), [.. skills.OfType<DamageSkill>()]));
            skills.Add(new MagicSpirits(spirit, new MagicFortune(luck), [.. skills.OfType<DamageSkill>()]));
            skills.Add(new Resonance(spirit, [..skills.OfType<DamageSkill>()]));
        break;
        default: throw new NotImplementedException();
    }
    return skills;
}
List<string> GetStatNames(string petName) => petName switch
{
    "saphirefaedrake" => ["Intelligence", "Spirit", "Luck"],
    "seraphicfaedrake" => ["Intelligence", "Spirit", "Luck"],
    "shadowfaedrake" => ["Intelligence", "Spirit", "Luck"],
    "berserkfaedrake" => ["Strength", "Agility", "Luck"],
    "blademanticore" => ["Strength", "Agility", "Luck"],
    "bruinbear" => ["Strength", "Agility", "Endurance", "Luck"],
    "frostbear" => throw new NotImplementedException(),
    "goldenroc" => ["Strength", "Agility", "Luck"],
    "icelizard" => ["Intelligence", "Spirit", "Luck"],
    "moonbear" => ["Strength", "Agility", "Endurance", "Luck"],
    "nightroc" => ["Strength", "Agility", "Luck"],
    "sandlizard" => ["Strength", "Agility", "Endurance", "Intelligence", "Spirit", "Luck"],
    "shadowmanticore" => ["Strength", "Agility", "Luck"],
    "snowpeakroc" => ["Strength", "Agility", "Luck"],
    "stripedbear" => throw new NotImplementedException(),
    "thunderlizard" => ["Intelligence", "Spirit", "Luck"],
    "venomouslizarad" => ["Strength", "Agility", "Endurance", "Luck"],
    _ => throw new ArgumentException($"pet name '{petName}' is invalid")
};
