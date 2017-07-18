using System;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using System.Xml;

public class DebugMon
{
    //Takes a variable that is passed to it and outputs the contents so that its value can be debug'd
    //would be nice to create a dynamic class that figures out what the variable type is and then does something with it
    //so if I pass an array it sends it to teh array instead of the int method.


    //class main entry method
    public void DebugVariable(object value)
    {
    //method needs to take an unknown variable of any type or generate a method for each variable type to be debugged
    //**Add bool switch 1 or 0 to main method entry point for class if 1 go ahead if 2 ignore
    public bool TurnOnDebug()
    {
        bool debugOnOff = false;
        //Console.WriteLine("bool should be false " + debugOnOff);
        //get xml file as per debug folder for build
        string xmlFile = File.ReadAllText(@"Config.xml");

        //assign that file to teh xmldoc constructor
        XmlDocument xmldoc = new XmlDocument();
        xmldoc.LoadXml(xmlFile);
        XmlNodeList nodeList = xmldoc.GetElementsByTagName("debugSwitch");

        //go throguh all nodes find debugSwitch and assign as relevant
        foreach (XmlNode node in nodeList)
        {
            if (node.InnerText == "false")
            {
                debugOnOff = false;
            }
            else if (node.InnerText == "true")
            {
                debugOnOff = true;
            }
        }

        //return the debug switch as bool
        return debugOnOff;
    }

    public void ValVariable(object value)
    {

        //check if we have debugging turned on or not
        if (TurnOnDebug() != true)
        {
            //do nothing

            Console.WriteLine("Debugging is turned off.");
            //Console.ReadKey();
        }
        else
        {
            //this should really be a seperate class or line of code for validation.

            //perform required actions
            if (value == null)
            {
                Console.WriteLine("The variable requesting debug is empty.");

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
                    DebugString(value);
                }
                else if (value is int)
                {
                    DebugInt(value);
                }
                else if (value is string[])
                {
                    DebugStringArray(value);
                }
                else
                {
                    Console.WriteLine("## Variable cannot be debugged ##");

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

    private void DebugString(object value)
    {
        Console.WriteLine("## Debug value String ## Echo Value: " + value);
    }

    private void DebugStringArray(object value)
    {
        //for(int n=0; n < )
            Console.WriteLine("## Debug value Array of Strings ## Echo Value: " + value);
    }

    private void DebugInt(object value)
    {
        Console.WriteLine("## Debug value Integer ## Echo Value: " + value);
    }

    //method needs to take an unknown variable of any type or generate a method for each variable type to be debugged
    //**Add bool switch 1 or 0 to main method entry point for class if 1 go ahead if 2 ignore
    public bool TurnOnDebug()
    {
        bool debugOnOff = false;
        //Console.WriteLine("bool should be false " + debugOnOff);
        //get xml file as per debug folder for build
        string xmlFile = File.ReadAllText(@"Config.xml");

        //assign that file to teh xmldoc constructor
        XmlDocument xmldoc = new XmlDocument();
        xmldoc.LoadXml(xmlFile);
        XmlNodeList nodeList = xmldoc.GetElementsByTagName("debugSwitch");

        //go throguh all nodes find debugSwitch and assign as relevant
        foreach (XmlNode node in nodeList)
        {
            if (node.InnerText == "false")
            {
                debugOnOff = false;
            }
            else if (node.InnerText == "true")
            {
                debugOnOff = true;
            }
        }

        //return the debug switch as bool
        return debugOnOff;
    }

}
