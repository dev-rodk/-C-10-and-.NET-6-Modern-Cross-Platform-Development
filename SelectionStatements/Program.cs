using static System.Console;

////Exploring logical operators
//bool a = true;
//bool b = false;
//WriteLine($"AND | a | b ");
//WriteLine($"a | {a & a,-5} | {a & b,-5} ");
//WriteLine($"b | {b & a,-5} | {b & b,-5} ");
//WriteLine();
//WriteLine($"OR | a | b ");
//WriteLine($"a | {a | a,-5} | {a | b,-5} ");
//WriteLine($"b | {b | a,-5} | {b | b,-5} ");
//WriteLine();
//WriteLine($"XOR | a | b ");
//WriteLine($"a | {a ^ a,-5} | {a ^ b,-5} ");
//WriteLine($"b | {b ^ a,-5} | {b ^ b,-5} ");


////Exploring conditional logical operators

//static bool DoStuff()
//{
//    WriteLine("I`m doing some stuff!");
//    return true;
//}

//WriteLine("");
//WriteLine($"A && DoStuff() = {a && DoStuff()}");
//WriteLine($"B && DoStuff() = {b && DoStuff()}");


//string password = "ninja";

//if (password.Length < 8)
//{
//    WriteLine("Your password is too short. Use at least 8 characters.");
//}
//else
//{
//    WriteLine("Your password is strong.");
//}

//Pattern matching (Introduzido a partir do C# 7.0) 

object o = "3";
int j = 4;

if (o is int i)
{
    WriteLine($"{i} x {j} = {i * j}");
}
else
{
    WriteLine("o is not an int so it cannot multiply!");
}

//Branching with the switch statement

int number = (new Random()).Next(1, 7);
WriteLine($"My random number is {number}");


switch (number)
{
    case 1:
        WriteLine("One");
        break; // jumps to end of switch statement
    case 2:
        WriteLine("Two");
        goto case 1;
    case 3: // multiple case section
    case 4:
        WriteLine("Three or four");
        goto case 1;
    case 5:
        goto A_label;
 default:
        WriteLine("Default");
        break;
} // end of switch statement


WriteLine("After end of switch");
A_label:
WriteLine($"After A_label");


//Pattern matching with the switch statement