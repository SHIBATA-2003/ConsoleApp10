using System;
public class box
{
    static void Main()
    {
        Console.WriteLine("直方体");
        Box box = new Box(InputFloat("幅を入力"), InputFloat("高さを入力"), InputFloat("奥行きを入力"));

        Console.WriteLine("円柱");
        Cylinder cyl = new Cylinder(InputFloat("底面の半径を入力"), InputFloat("高さを入力"));

        Console.WriteLine("球");
        Sphere sph = new Sphere(InputFloat("半径を入力"));

        Console.WriteLine("三角柱");
        TriangularPrism tri = new TriangularPrism(InputFloat("高さを入力"), InputFloat("三角形の高さを入力"), InputFloat("底辺の長さを入力"));

        Console.WriteLine("直方体の表面積 = " + box.GetSurfaceB()+"体積="+box.GetVolumeB());
        Console.WriteLine("円柱の表面積 = " + cyl.GetSurfaceC()+" 体積 = " + cyl.GetVolumeC());
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
    private float width;
    private float height;
    private float depth;
    public Box(float w, float h, float d)
    {
        this.width = w;
        this.height = h;
        this.depth = d;
    }
    public Box(float w = 1)
    {
        this.width = w;
        this.height = w;
        this.depth = w;
    }
    public float GetVolumeB()
    {
        return width * height * depth;
    }
    public float GetSurfaceB()
    {
        return (width * height + height * depth + depth * width) * 2;
    }
}
class Cylinder
{
    private float radius;
    private float height;
    public Cylinder(float r, float h)
    {
        this.radius = r;
        this.height = h;
       
    }
    public Cylinder(float r = 1)
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
        return 2*MathF.PI*radius*radius+2*MathF.PI*radius*height;
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
        return 4*height * height * MathF.PI;
    }
    public float GetVolumeS()
    {
        return  4* MathF.PI * height * height * height/3;
    }
}
class TriangularPrism
{
    private float heigh;
    private float dept;
    private float side;
    public TriangularPrism (float c, float v,float s)
    {
        this.heigh = c;
        this.dept = v;
        this.side = s;

    }
    public TriangularPrism(float c= 1)
    {
        this.heigh = c;
        this.dept = c;
        this.side= c;
    }
    public float GetVolumeT()
    {
        return (dept*side/2)*heigh;
    }
    public float GetSurfaceT()
    {
        float si = (side * side);
        float de =  (dept*dept);
     return (float)((dept*side)+ heigh*((Math.Sqrt(si+de))+dept+side));
    }
}