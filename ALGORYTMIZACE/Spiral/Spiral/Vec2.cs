namespace Spiral;

public class Vec2
{
    //Udělal jsem si svuj vlastni vector protože c# Vector2 je má jako float a ty by mohli vracet nesprávné výpočty.
    
    public int x;
    public int y;

    public Vec2(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
}