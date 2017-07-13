using System;

public class DebugMon
{
    //Takes a variable that is passed to it and outputs the contents so that its value can be debug'd
    //would be nice to create a dynamic class that figures out what the variable type is and then does something with it
    //so if I pass an array it sends it to teh array instead of the int method.

    //method needs to take an unknown variable of any type or generate a method for each variable type to be debugged
    **Add bool switch 1 or 0 to main method entry point for class if 1 go ahead if 2 ignore
    public void ValVariable(object value)
    {
        if (value != null)
        {
            Console.WriteLine("Nothing to do here program will exit.");
            Console.ReadKey();
        }
        else
        {
            //what type is the variable
            if (value is string)
            {
                //if value.GetType() = 
                //if string or array of strings then do

                DebugString(value);

                //DebugArray(value);

            }
            else if (value is int)
            {
                Console.WriteLine("## Debug value Integer ## Echo Value: " + value);
            }
            else
            {
                Console.WriteLine(".");
            }
        }
    }

    private void DebugArray(object value)
    {
        Console.WriteLine("## Debug value Array of Strings ## Echo Value: " + value);
    }

    private void DebugString(object value)
    {
        Console.WriteLine("## Debug value String ## Echo Value: " + value);
    }

    private void DebugInt(object value)
    {

    }

}
