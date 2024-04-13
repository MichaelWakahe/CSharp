using static System.Console;

bool a = true;
bool b = false;
WriteLine($"AND  | a     | b    ");
WriteLine($"a    | {a & a,-5} | {a & b,-5} ");
WriteLine($"b    | {b & a,-5} | {b & b,-5} ");
WriteLine();
WriteLine($"OR   | a     | b    ");
WriteLine($"a    | {a | a,-5} | {a | b,-5} ");
WriteLine($"b    | {b | a,-5} | {b | b,-5} ");
WriteLine();
WriteLine($"XOR  | a     | b    ");
WriteLine($"a    | {a ^ a,-5} | {a ^ b,-5} ");
WriteLine($"b    | {b ^ a,-5} | {b ^ b,-5} ");

// Conditional logical operators are like logical operators, but you use two symbols instead of one, for example, &&
// instead of &, or || instead of |.
// Conditional logical operators are also known as short-circuiting Boolean operators.
WriteLine();
WriteLine($"a && DoStuff() = {a && DoStuff()}");    
WriteLine($"b && DoStuff() = {b && DoStuff()}");    // You can see a change in behaviour when you use `&`

static bool DoStuff()
{
    WriteLine("I am doing some stuff.");
    return true;
}