namespace ConsoleApp2;

public class Rectangle
{
    public int A { get; set; }

    public int B { get; set; }

    public int Score()
    {
        return A * B; 
        
    }
    
    public Rectangle(int a, int b)
    {
        A = a;
        B = b;
    }
}
