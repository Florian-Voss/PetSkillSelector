namespace PetSkillSelector
{
    public class Stat
    {
        public string Name { get; private set; }
        public uint Value { get; private set; }
        public Stat(string name, uint value)
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(name, nameof(name));
            Name = name;
            Value = value;
        }
    }
}