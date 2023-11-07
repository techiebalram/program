public class A
{
   public virtual void Print()
   {
        Console.WriteLine("Base Class");
   }
}

public class B : A
{
   public override void Print()
   {
     Console.WriteLine("Child class");
   }
}