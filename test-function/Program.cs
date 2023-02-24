using test_function;

foreach(var i in new int[] { int.MinValue, -15, -10, -9, -4, -1, 0, 1, 2, 3, 5,8, 10, int.MaxValue } ) { 

    try
    {
        Console.WriteLine(NewFunction.AFunction(i));
    } 
    catch
    {
        Console.WriteLine("It threw an exception!");
    }
}