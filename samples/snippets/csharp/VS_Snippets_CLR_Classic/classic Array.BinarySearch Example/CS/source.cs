// <Snippet1>
using System;

public class SamplesArray
{
    public static void Main()
    {
        // Creates and initializes a new Array.
        Array myIntArray = Array.CreateInstance(typeof(int), 5);

        myIntArray.SetValue(8, 0);
        myIntArray.SetValue(2, 1);
        myIntArray.SetValue(6, 2);
        myIntArray.SetValue(3, 3);
        myIntArray.SetValue(7, 4);

        // Do the required sort first
        Array.Sort(myIntArray);

        // Displays the values of the Array.
        Console.WriteLine( "The int array contains the following:" );
        PrintValues(myIntArray);

        // Locates a specific object that does not exist in the Array.
        object myObjectOdd = 1;
        FindMyObject( myIntArray, myObjectOdd );

        // Locates an object that exists in the Array.
        object myObjectEven = 6;
        FindMyObject(myIntArray, myObjectEven);
    }

    public static void FindMyObject(Array myArr, object myObject)
    {
        int myIndex=Array.BinarySearch(myArr, myObject);
        if (myIndex < 0)
        {
            Console.WriteLine("The object to search for ({0}) is not found. The next larger object is at index {1}.", myObject, ~myIndex );
        }
        else
        {
            Console.WriteLine("The object to search for ({0}) is at index {1}.", myObject, myIndex );
        }
    }

    public static void PrintValues(Array myArr)
    {
        int i = 0;
        int cols = myArr.GetLength(myArr.Rank - 1);
        foreach (object o in myArr)
        {
            if ( i < cols )
            {
                i++;
            }
            else
            {
                Console.WriteLine();
                i = 1;
            }
            Console.Write( "\t{0}", o);
        }
        Console.WriteLine();
    }
}
// This code produces the following output.
//
//The int array contains the following:
//        2       3       6       7       8
//The object to search for (1) is not found. The next larger object is at index 0
//
//The object to search for (6) is at index 2.
// </Snippet1>
