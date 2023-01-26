using stackTask;

public class Test
{
    public static void Main(string[] args)
    {
        MyStack<int> stack = new MyStack<int>();
        Console.Write("Empty stack: ");
        stack.Print();
        Console.Write("Stack after pushing (42, 43, 44): ");
        stack.Push(42);
        stack.Push(43);
        stack.Push(44);
        stack.Print();
        Console.Write("Pop then push the top: ");
        stack.Pop();
        stack.Push(stack.Peak());
        stack.Print();
        Console.Write("Clear stack: ");
        stack.Clear();
        stack.Print();
    }
}