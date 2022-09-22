using System;
namespace homework2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? variable, typeOf;
            Console.WriteLine("Enter a value.");
            variable = Console.ReadLine();
            Console.WriteLine("Enter a variable type: sbyte, bool, short, ushort" +
                "int, uint, long, ulong, float, double, decimal, srting.");
            typeOf = Console.ReadLine();
            switch(typeOf)
            {
                case "sbyte":
                    try
                    {
                        sbyte sbyteVariable = Convert.ToSByte(variable);
                        Console.WriteLine($"{sbyteVariable} is a {sbyteVariable.GetType()}");
                    }
                    catch(System.Exception)
                    {
                        Console.WriteLine($"\"{variable}\" cannot be converted to {typeOf} type.");
                    }
                    break;
                case "bool":
                    try
                    {
                        bool boolVariable = Convert.ToBoolean(variable);
                        Console.WriteLine($"{boolVariable} is a {boolVariable.GetTypeCode()}");
                    }
                    catch (System.Exception)
                    {
                        Console.WriteLine($"\"{variable}\" cannot be converted to {typeOf} type.");
                    }
                    break;
                case "short":
                    try
                    {
                        short shortVariable = Convert.ToInt16(variable);
                        Console.WriteLine($"{shortVariable} is a {shortVariable.GetType()}");
                    }
                    catch (System.Exception)
                    {
                        Console.WriteLine($"\"{variable}\" cannot be converted to {typeOf} type.");
                    }
                    break;
                case "ushort":
                    try
                    {
                        ushort ushortVariable = Convert.ToUInt16(variable);
                        Console.WriteLine($"{ushortVariable} is a {ushortVariable.GetType()}");
                    }
                    catch (System.Exception)
                    {
                        Console.WriteLine($"\"{variable}\" cannot be converted to {typeOf} type.");
                    }
                    break;
                case "int":
                    try
                    {
                        int intVariable = Convert.ToInt32(variable);
                        Console.WriteLine($"{intVariable} is a {intVariable.GetType()}");
                    }
                    catch (System.Exception)
                    {

                        Console.WriteLine($"\"{variable}\" cannot be converted to {typeOf} type.");
                    }
                    break;
                case "uint":
                    try
                    {
                        uint uintVariable = Convert.ToUInt32(variable);
                        Console.WriteLine($"{uintVariable} is a {uintVariable.GetType()}");
                    }
                    catch  (System.Exception)
                    {
                        Console.WriteLine($"\"{variable}\" cannot be converted to {typeOf} type.");
                    }
                    break;
                case "long":
                    try
                    {
                        long longVariable = Convert.ToInt64(variable);
                        Console.WriteLine($"{longVariable} is a {longVariable.GetType()}");
                    }
                    catch (System.Exception)
                    {
                        Console.WriteLine($"\"{variable}\" cannot be converted to {typeOf} type.");
                    }
                    break;
                case "ulong":
                    try
                    {
                        ulong ulongVariable = Convert.ToUInt64(variable);
                        Console.WriteLine($"{ulongVariable} is a {ulongVariable.GetType()}");
                    }
                    catch (System.Exception)
                    {
                        Console.WriteLine($"\"{variable}\" cannot be converted to {typeOf} type.");
                    }
                    break;
                case "float":
                    try
                    {
                        float floatVariable = Convert.ToSingle(variable);
                        Console.WriteLine($"{floatVariable} is a {floatVariable.GetTypeCode()}");
                    }
                    catch (System.Exception)
                    {
                        Console.WriteLine($"\"{variable}\" cannot be converted to {typeOf} type.");
                    }
                    break;
                case "double":
                    try
                    {
                        double doubleVariable = Convert.ToDouble(variable);
                        Console.WriteLine($"{doubleVariable} is a {doubleVariable.GetType()}");
                    }
                    catch (System.Exception)
                    {
                        Console.WriteLine($"\"{variable}\" cannot be converted to {typeOf} type.");
                    }
                    break;
                case "decimal":
                    try
                    {
                        decimal decimalVariable = Convert.ToDecimal(variable);
                        Console.WriteLine($"{decimalVariable} is a {decimalVariable.GetType()}");
                    }
                    catch (System.Exception)
                    {
                        Console.WriteLine($"\"{variable}\" cannot be converted to {typeOf} type.");
                    }
                    break;
                case "string":
                    Console.WriteLine($"{variable} is a {variable.GetType()}");
                    break;
                default:
                    Console.WriteLine("Unknown type");
                    break;                 
            }
            Console.ReadKey();
        }
    }
}
