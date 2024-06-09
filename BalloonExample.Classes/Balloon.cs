namespace BalloonExample.Classes;

public class Balloon
{
    private int _health;
    private readonly string _colour;
    private readonly string _defenceItem;

    public Balloon(string colour, string defenceItem)
    {
        _health = 100;
        _colour = colour;
        _defenceItem = defenceItem;
    }

    public void ChangeHealth(int healthChange)
    {
        _health += healthChange;
    }

    public string GetDefenceItem()
    {
        return _defenceItem;
    }

    public bool CheckHealth()
    {
        return _health <= 0;
    }
}
