public class SwappingNumbers
{
    public void WithoutVariable()
    {
        int a= 10;

        int b =20;

        a = a+b;
        b = a-b;
        a =a-b;

        Console.Write($"value of a {a} and b {b}");
    }
}