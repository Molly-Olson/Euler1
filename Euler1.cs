using System.Runtime.InteropServices;
using System.Linq;

List<int> wholeNumbers = Enumerable.Range(1, 999).ToList();

Stack<int> multiples = new Stack<int> ();

foreach (int i in wholeNumbers) // define i first ya dingleberry
{
    if (i % 3 == 0 || i % 5 == 0)
    { // now that you have the multiples of 3 OR 5 put them somewhere (new stack? created above?)
        multiples.Push(i);
        // don't want hundreds of lines Console.WriteLine(i); // Write would have them all on one line where line added separates them on diff lines
    }
    // print results of new stack (multiples) done above
    // add the sum of ints in multiples
}
    int sumOfMultiples = 0;
    foreach (int number in multiples)
{
    sumOfMultiples = sumOfMultiples + number; // kinda like i++ but you're adding more than 1 each time, add the previous value from the stack
}
Console.WriteLine(sumOfMultiples);
