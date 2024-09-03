namespace TesteTarget.Questions;

public class Question2Solver
{
    public bool EhFibonacci(int num)
    {
        int a = 0, b = 1, next = 0;

        while (next < num)
        {
            next = a + b;
            a = b;
            b = next;
        }
        
        return next == num || num == 0;
    }
}