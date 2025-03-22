public class Player : Character
{
    private string description;
    private int exp;
    private int gold;

    public string Description { get; private set; }
    public int Exp { get; private set; }
    public int Gold { get; private set; }

    public Player(string name, int level, int atk, int def, int hp, int critical, string description, int exp, int gold) : base(name, level, atk, def, hp, critical)
    {
        Description = description;
        Exp = exp;
        Gold = gold;
    }
}
