using System.Numerics;
using System.Runtime.CompilerServices;

namespace Spiral;

public class Spiral
{
    private enum direction
    {
        right,
        down,
        left,
        up
    }

    private direction _dir = direction.right;
    
    private int delta;
    private int x;
    
    private bool[,] field;
    private Vec2 pos = new Vec2(0,0);

    private int limit;
    private int step = 1;

    
    public Spiral(int delta, int x)
    {
        this.delta = delta;
        this.x = x;
        field = new bool[x, x]; // Používám 2d pole abych si mohle lépe zvizualovat pozice.
        this.x -= 1; //Tento int budu používat jako limit a proto musím odečíst 1. Aby nebyl out of range.
    }

    private void FillField() // Vyplníme pole false.
    {
        for (int i = 0; i < field.GetLength(0); i++)
        {
            for (int j = 0; j < field.GetLength(1); j++)
            {
                field[i, j] = true;
            }
        }
    }

    public void FindEnd()
    {
        if (x <= delta) // Jestli se x dostalo pod deltu tak se ukonší rekurze.
        {
            DrawSpiral();
            Console.WriteLine($"Poslední pozice v spirále jsou {pos.x} a {pos.y}");
        }
        else
        {
            Move();
            FindEnd();
        }
    }

    public void Move()
    {
        //Záleží na směru podle toho kam jse náš kurzor pude pohybovat
        
        field[pos.x, pos.y] = true; //Zapíšeme si do pole že jsme na této pozici byli.

        switch (_dir)
        {
            case direction.right: //Doprava
                pos.x++;
                if(pos.x >= x) // Pokud jsme na limitu tak se změní směr a limit se zmenší.
                {
                    _dir = direction.down;
                    x -= delta;
                }
                break;
            case direction.down:
                pos.y++;
                if(pos.y >= x) // Pokud jsme na limitu tak se změní směr a limit se zmenší.
                {
                    _dir = direction.left;
                    x -= delta;
                }
                break;
            case direction.left:
                pos.x--;
                if(pos.x <= field.GetLength(0) - x) // Pokud jsme na limitu tak se změní směr a limit se zmenší.
                {
                    _dir = direction.up;
                    x -= delta;
                }
                break;
            case direction.up:
                pos.y--;
                if(pos.y <= field.GetLength(0) - x) // Pokud jsme na limitu tak se změní směr a limit se zmenší.
                {
                    _dir = direction.right;
                    x -= delta;
                }
                break;
            
        }
    }

    public void DrawSpiral()
    {
        for (int x = 0; x < field.GetLength(0); x++)
        {
            for (int y = 0; y < field.GetLength(1); y++)
            {
                if(field[y,x] == true) Console.Write("#");
                else Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}