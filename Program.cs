namespace StackTask
{
	internal class Program
	{
		static void Main(string[] args)
		{
			MyStack<int> stack = new MyStack<int>();
			stack.Push(1);
			stack.Push(2);
			stack.Push(3);
			
			foreach (int i in stack)
			{
                Console.WriteLine(i);
            }
			Console.WriteLine();
			Console.WriteLine(stack.Peek());
			Console.WriteLine();
            stack.Pop();
			foreach (int i in stack)
			{
				Console.WriteLine(i);
			}
            




        }
	}
}