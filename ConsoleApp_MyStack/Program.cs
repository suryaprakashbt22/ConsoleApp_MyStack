// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using ConsoleApp_MyStack;

Console.WriteLine("My Stack Class Implementation!\n");

Console.WriteLine("Enter the size of stack:");
int N=int.Parse(Console.ReadLine());    

Stack myStack = new Stack(N);
bool continueLoop = true;
while (continueLoop)
{
    Console.WriteLine("Choose Operation:\n\t1.PUSH\n\t2.POP\n\t3.DISPLAY\n\t4.EXIT");
    int choice = int.Parse(Console.ReadLine());
    switch (choice)
    {
        case 1:
            Console.WriteLine("Enter the No. :");
            int x = int.Parse(Console.ReadLine());
            myStack.Push(x);
            break;
        case 2:
            Console.WriteLine("Element {0} Popped", myStack.Pop());
            break;
        case 3:
            //Console.WriteLine("Elements in the Stack:")
            myStack.PrintStack();
            break;
        case 4:
            Console.WriteLine("Closing Program.");
            continueLoop = false;
            break;
        default:
            Console.WriteLine("Invalid Choice"); break;
    }
}
Console.WriteLine("To Clone this stack into a new Stack: Press Y.");
char cloneChoice = Convert.ToChar(Console.ReadLine());  
if(cloneChoice == 'Y' || cloneChoice == 'y')
{
    clonedStack newClonedStk = new clonedStack();
    newClonedStk.clone(myStack);

}



