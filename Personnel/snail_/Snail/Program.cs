//code réalisé par APT
//SNAIL
Console.Clear();
Console.CursorVisible = false;

Snail snail = new Snail(ConsoleColor.Magenta);


while (snail.isAlive())
{
    snail.Hide();
    snail.Move();
    snail.Show();
    Thread.Sleep(100);
}
/// <summary>
/// //////////////////////////////////////////////////////////////////////////////////////////////
/// </summary>

public class Snail
{
    /// <attributes>

    private int _life = 50;
    private int _x = 0;
    private int _y = 0;


    private const string SNAIL = "_@_ö";
    private const string NO_SNAIL = "     ";
    private const string DEAD_SNAIL = "____";


    public Snail()
    {
        _x = 1;
        _y = 10;
    }

    /// <function isAlive>

    public bool isAlive()
    {
        return _life > 0;
    }


    /// <function Move>

    public static void Move() 
    {
        _x++;

    }


    /// <function Show>

    public static void Show()
    {

    }

    /// <function Hide>

    public static void Hide()
    {

    }


}

/*
Console.Clear();
Console.CursorVisible = false;

Snail snail = new Snail(ConsoleColor.Blue);

while (snail.isAlive())
{
    snail.hide();
    snail.move();
    snail.show();
    Thread.Sleep(100);
}
Console.ReadKey();

/// <summary>
/// Class representing a snail
/// </summary>
public class Snail
{
    private int _x;
    private int _y;
    private ConsoleColor _color;
    private int _energy = 50;

    private const string SNAIL = "_@_ö";
    private const string NO_SNAIL = "    ";
    private const string DEAD_SNAIL = "____";

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="color"></param>
    public Snail(ConsoleColor color)
    {
        _x = 1;
        _y = 10; // default birth place for snails
        _color = color;
    }

    /// <summary>
    /// Tells if the snail is stil alive
    /// </summary>
    /// <returns></returns>
    public bool isAlive()
    {
        return _energy > 0;
    }

    /// <summary>
    /// Move the beast
    /// </summary>
    public void move()
    {
        _x++; // moving left to right only at this stage
        _energy--; // moving costs energy
    }

    /// <summary>
    /// Make the snail disappear
    /// </summary>
    public void hide()
    {
        Console.SetCursorPosition(_x, _y);
        Console.Write(NO_SNAIL);
    }

    /// <summary>
    /// Show the snail according to its state
    /// </summary>
    public void show()
    {
        Console.ForegroundColor = _color;
        Console.SetCursorPosition(_x, _y);
        if (this.isAlive())
        {
            Console.Write(SNAIL);
        }
        else
        {
            Console.Write(DEAD_SNAIL);
        }
    }

}*/