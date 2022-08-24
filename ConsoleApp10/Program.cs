using System;
public class box
{
    static void Main()
    {
        Box box = new Box(InputFloat("半径を入力"), InputFloat("高さを入力"), InputFloat("底辺の長さを入力"));
        Console.WriteLine("円柱の表面積 = " + box.GetSurfaceC()+" 体積 = " + box.GetVolumeC());
        Console.WriteLine("球の表面積 = " + box.GetSurfaceS() + " 体積 = " + box.GetVolumeS());
        Console.WriteLine("円柱の表面積 = " + box.GetSurfaceT() + " 体積 = " + box.GetVolumeT());
    }

    static float InputFloat(string su)
    {
        float input;
        while (true)
        {
            Console.WriteLine(su);
            if (float.TryParse(Console.ReadLine(), out input))
            {
                return input;
            }
        }
    }
}
class Box
{
    private float radius;
    private float height;
    private float depth;
    public Box(float r, float h, float d)
    {
        this.radius = r;
        this.height = h;
        this.depth = d;
       
    }
    public Box(float r = 1)
    {
        this.radius = r;
        this.height = r;
        this.depth = r;
    }
    public float GetVolumeC()
    {
        return (float)(radius *radius*3.14*height);
    }
    public float GetSurfaceC()
    {
        return ((float)(radius *3.14 *height* 2));
    }
    public float GetSurfaceS()
    {
        return ((float)(radius * radius * 3.14  * 4));
    }
    public float GetVolumeS()
    {
        return ((float)(4/3 * 3.14 * radius*radius*radius));
    }
    public float GetVolumeT()
    {
        return (depth*height)/2*height;
    }
    public float GetSurfaceT()
    {
        double x = height * height + depth / 2 * depth / 2;
        x = System.Math.Sqrt(x);
        return (float)(depth * height + height * (depth + x + x));
    }
}