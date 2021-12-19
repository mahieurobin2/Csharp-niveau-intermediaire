namespace formationintermediate3
{
    public class Calculator
    {
        public interface Add(params int[] numbers)
        {
        var sum = 0;
        foreach (var number in numbers)
        {
            sum += number;
        }
        return sum;   
    }

