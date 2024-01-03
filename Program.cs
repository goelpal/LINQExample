int[] myInts = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };


//Without LINQ
/*foreach(var item in myInts)
{
    if(item>3)
        Console.WriteLine(item);
}*/

//With LINQ

var SelectedItems = myInts.Where(items => items > 4);

foreach(var item in SelectedItems)
{ Console.WriteLine(item); }

int newSum = myInts.Sum();
Console.WriteLine("The sum of numbers is :" +newSum);

int SelectedSum = SelectedItems.Sum();
Console.WriteLine("The sum of seelcted numbers is :" + SelectedSum);

