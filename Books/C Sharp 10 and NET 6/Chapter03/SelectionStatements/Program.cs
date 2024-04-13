using static System.Console;

string password = "ninja";

if (password.Length < 8)
{
    WriteLine("Your password is too short. Use at least 8 characters.");
}
else
{
    WriteLine("Your password is strong.");
}
WriteLine();

// add and remove the "" to change the behavior
object obj = "3";

int j = 4;

// The if statement can use the is keyword in combination with declaring a local variable to make your code safer
if (obj is int i)   
{
    WriteLine($"{i} x {j} = {i * j}");
}
else
{
    WriteLine("obj is not an int so it cannot multiply!");
}
WriteLine();

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
    case 3:
    case 4:
        WriteLine("Three or four");
        goto case 1;
    case 5:
        // go to sleep for half a second
        System.Threading.Thread.Sleep(500);
        goto A_label;
    default:
        WriteLine("Default");
        break;
} // end of switch statement

WriteLine("After end of switch");
A_label:
WriteLine($"After A_label\n");

// Good Practice: You can use the goto keyword to jump to another case or a label. The goto keyword is frowned upon by
// most programmers but can be a good solution to code logic in some scenarios. However, you should use it sparingly.


// string path = "/Users/markjprice/Code/Chapter03";
string path = @"C:\temp";

Write("Press R for readonly or W for write: ");
ConsoleKeyInfo key = ReadKey();
WriteLine();

Stream? s;

if (key.Key == ConsoleKey.R)
{
    s = File.Open(
        Path.Combine(path, "file.txt"),
        FileMode.OpenOrCreate,
        FileAccess.Read);
}
else
{
    s = File.Open(
        Path.Combine(path, "file.txt"),
        FileMode.OpenOrCreate,
        FileAccess.Write);
}

string message;

switch (s)
{
    case FileStream writeableFile when s.CanWrite:
        message = "The stream is a file that I can write to.";
        break;
    case FileStream readOnlyFile:
        message = "The stream is a read-only file.";
        break;
    case MemoryStream ms:
        message = "The stream is a memory address.";
        break;
    default: // always evaluated last despite its current position
        message = "The stream is some other type.";
        break;
    case null:
        message = "The stream is null.";
        break;
}

WriteLine(message);