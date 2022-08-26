using System;
public class box
{
    static void Main()
    {
        Console.WriteLine("円柱");
        Box box = new Box(InputFloat("底面の半径を入力"), InputFloat("高さを入力"));
        Console.WriteLine("球");
        Sphere sph = new Sphere(InputFloat("半径を入力"));
        Console.WriteLine("三角柱");
        TriangularPrism tri = new TriangularPrism(InputFloat("高さを入力"), InputFloat("三角形の高さを入力"), InputFloat("底辺の長さを入力"));
        Console.WriteLine("円柱の表面積 = " + box.GetSurfaceC()+" 体積 = " + box.GetVolumeC());
        Console.WriteLine("球の表面積 = " + sph.GetSurfaceS() + " 体積 = " + sph.GetVolumeS());
        Console.WriteLine("三角柱の表面積 = " + tri.GetSurfaceT() + " 体積 = " + tri.GetVolumeT());
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
    public Box(float r, float h)
    {
        this.radius = r;
        this.height = h;
       
    }
    public Box(float r = 1)
    {
        this.radius = r;
        this.height = r;
    }
    public float GetVolumeC()
    {
        return radius *radius*MathF.PI*height;
    }
    public float GetSurfaceC()
    {
        return radius *MathF.PI *height* 2;
    }

}
class Sphere
{
    private float height;
    public Sphere(float Z)
    {
        this.height = Z;

    }
    public float GetSurfaceS()
    {
        return height * height * MathF.PI * 4;
    }
    public float GetVolumeS()
    {
        return 4 / 3 * MathF.PI * height * height * height;
    }
}
class TriangularPrism
{
    private float heigh;
    private float dept;
    public TriangularPrism (float c, float v,float m)
    {
        this.heigh = c;
        this.dept = v;

    }
    public TriangularPrism(float n= 1)
    {
        this.heigh = n;
        this.dept = n;
    }
    public float GetVolumeT()
    {
        return (dept * heigh) / 2 * heigh;
    }
    public float GetSurfaceT()
    {
        double x = heigh * heigh+ dept / 2 * dept / 2;
        x = System.Math.Sqrt(x);
        return (float)(dept * heigh + heigh * (dept + x + x));
    }
}