using System;
using System.Xml;

public class DebugMon
{
    //Takes a variable that is passed to it and outputs the contents so that its value can be debug'd
    //would be nice to create a dynamic class that figures out what the variable type is and then does something with it
    //so if I pass an array it sends it to teh array instead of the int method.

    //method needs to take an unknown variable of any type or generate a method for each variable type to be debugged
    //**Add bool switch 1 or 0 to main method entry point for class if 1 go ahead if 2 ignore
    public bool TurnOnDebug()
    {
        bool debugOnOff = null;
        Console.WriteLine("bool should be nulls " + debugOnOff);

        //code from https://support.microsoft.com/en-gb/help/307548/
        XmlTextReader reader = new XmlTextReader("Config.xml");

        while (reader.Read())
        {
            switch (reader.NodeType)
            {
                case XmlNodeType.Element: // The node is an element.
                    Console.Write("<" + reader.Name);

                    while (reader.MoveToNextAttribute()) // Read the attributes.
                        Console.Write(" " + reader.Name + "='" + reader.Value + "'");
                    Console.WriteLine(">");
                    break;
                case XmlNodeType.Text: //Display the text in each element.
                    Console.WriteLine(reader.Value);
                    break;
                case XmlNodeType.EndElement: //Display the end of the element.
                    Console.Write("</" + reader.Name);
                    Console.WriteLine(">");
                    break;
            }
        }

        debugOnOff = false;
        Console.WriteLine("bool should be false " + debugOnOff);

        return debugOnOff;
    }

    public void ValVariable(object value)
    {
        //check if we have debugging turned on or not
        if (TurnOnDebug() != true)
        {
            //do nothing
            Console.WriteLine("Nothing to do here program will exit.");
            Console.ReadKey();
        }
        else
        {
            //perform required actions
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
