using static System.Console;
/*
 In C# 6.0 and later, the using statement can be used not only to import a namespace but also to further simplify our
 code by importing a static class.
 
 The above import means that we don't need to use the `Console` type name throughout the code.
*/ 

int numberOfApples = 12;
decimal pricePerApple = 0.35M;

WriteLine(
    format: "{0} apples costs {1:C}",
    arg0: numberOfApples,
    arg1: pricePerApple * numberOfApples);

string formatted = string.Format(
    format: "{0} apples costs {1:C}",
    arg0: numberOfApples,
    arg1: pricePerApple * numberOfApples);

//WriteToFile(formatted); // writes the string into a file

WriteLine($"{numberOfApples} apples costs {pricePerApple * numberOfApples:C}\n");

string applesText = "Apples";
int applesCount = 1234;

string bananasText = "Bananas";
int bananasCount = 56789;

WriteLine(
    format: "{0,-10} {1,6}",
    arg0: "Name",
    arg1: "Count");

WriteLine(
    format: "{0,-10} {1,6:N0}",
    arg0: applesText,
    arg1: applesCount);

WriteLine(
    format: "{0,-10} {1,6:N0}",
    arg0: bananasText,
    arg1: bananasCount);
    
Write("Type your first name and press ENTER: ");
string? firstName = ReadLine();

Write("Type your age and press ENTER: ");
string? age = ReadLine();

WriteLine($"Hello {firstName}, you look good for {age}.");

Write("Press any key combination: ");
ConsoleKeyInfo key = ReadKey();
WriteLine();
WriteLine("Key: {0}, Char: {1}, Modifiers: {2}",
    arg0: key.Key,
    arg1: key.KeyChar,
    arg2: key.Modifiers);
