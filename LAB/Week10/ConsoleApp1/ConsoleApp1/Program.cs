using System;
using System.Drawing;

public class Shape
{
    protected int length, width;
    public void setWitdh(int w)
    {
        width = w;
    }
    public void setlength(int l)
    {
        length = l ;
    }

}

public class Rectangle : Shape
{
    public int RArea()
    {
        return length*width;
    }
}
public class Box: Shape
{
    int height;
    public void SetHight(int h)
    {
        height = h;
    }
    public int BArea()
    {
        return length*width*height;
    }
}
public class A
{
    public static void Main() {
        Rectangle r = new Rectangle();
        r.setWitdh(5);
        r.setlength(6);
        int A = r.RArea();
        Console.WriteLine("Rectangle Area =" + A);
        Box b = new Box();
        b.setlength(6);
        b.setWitdh(10);
        b.SetHight(10);
        Console.WriteLine("Box Area =" +b.BArea);

    }

}