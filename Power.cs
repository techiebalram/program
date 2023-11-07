public class Power
{
    public int Poweralculation(int value, int power)
    {
        if (power == 0 )  
            return 1 ; 
        else if (power == 1 )  
            return value ;  
        else  
            return Poweralculation(value , power - 1 ) * value ;   
    }
}