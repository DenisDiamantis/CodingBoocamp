public readonly struct Marvel
{
    private readonly string _characterName;

    public string CharacterName { get { return _characterName; } }

    public void PrintCharacterName()
    {
        Console.WriteLine(CharacterName);
    }

    public Marvel(string characterName) { _characterName = characterName; }
}
