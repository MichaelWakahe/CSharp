using static System.Console;
using static System.Convert;

/*
Converting is also known as casting, and it has two varieties: implicit and explicit. Implicit casting happens 
automatically, and it is safe, meaning that you will not lose any information.

Explicit casting must be performed manually because it may lose information, for example, the precision of a number. By 
explicitly casting, you are telling the C# compiler that you understand and accept the risk.
*/

int a = 10;
double b = a; // an int can be safely cast into a double
WriteLine(b);

double c = 9.8;
// int d = c; // compiler gives an error for this line
int d = (int)c;
WriteLine(d); // d is 9 losing the .8 part
WriteLine();
    
long e = 10; 
int f = (int)e;
WriteLine($"e is {e:N0} and f is {f:N0}"); 

e = long.MaxValue;
f = (int)e;
WriteLine($"e is {e:N0} and f is {f:N0}");

e = 5_000_000_000;
f = (int)e;
WriteLine($"e is {e:N0} and f is {f:N0}\n");

double g = 9.8;
int h = ToInt32(g); // a method of System.Convert
WriteLine($"g is {g} and h is {h}");
// One difference between casting and converting is that converting rounds the double value 9.8 up to 10 instead of
// trimming the part after the decimal point.


// Understanding the default rounding rules
double[] doubles = new[]
    { 9.49, 9.5, 9.51, 10.49, 10.5, 10.51 };

foreach (double n in doubles)
{
    WriteLine($"ToInt32({n}) is {ToInt32(n)}");
}
/*
It always rounds down if the decimal part is less than the midpoint .5.
It always rounds up if the decimal part is more than the midpoint .5.
It will round up if the decimal part is the midpoint .5 and the non-decimal part is odd, but it will round down if the non-decimal part is even.
This rule is known as Banker's Rounding, and it is preferred because it reduces bias by alternating when it rounds up or down.
*/

// Taking control of rounding rules
// You can take control of the rounding rules by using the Round method of the Math class.
WriteLine("\nUsing Math.Round");
foreach (double n in doubles)
{
    WriteLine(format:
        "Math.Round(value: {0}, digits: 0, mode: MidpointRounding.AwayFromZero) is {1}",
        arg0: n,
        arg1: Math.Round(value: n, digits: 0,
            mode: MidpointRounding.AwayFromZero));
}

// Converting from any type to a string
WriteLine("\nConverting from any type to a string");
int number = 12;
WriteLine(number.ToString());

bool boolean = true;
WriteLine(boolean.ToString());

DateTime now = DateTime.Now;
WriteLine(now.ToString());

object me = new();
WriteLine(me.ToString());


WriteLine("\nConverting from a binary object to a string");
// allocate array of 128 bytes 
byte[] binaryObject = new byte[128];

// populate array with random bytes 
(new Random()).NextBytes(binaryObject);

WriteLine("Binary Object as bytes:");

foreach (int index in binaryObject)
{
    Write($"{index:X} ");
}
WriteLine();

// convert to Base64 string and output as text
string encoded = ToBase64String(binaryObject);
WriteLine($"Binary Object as Base64: {encoded}");


WriteLine("\nParsing from strings to numbers or dates and times");
int age = int.Parse("27");
DateTime birthday = DateTime.Parse("4 July 1980");

WriteLine($"I was born {age} years ago.");
WriteLine($"My birthday is {birthday}.");
WriteLine($"My birthday is {birthday:D}."); // 'D' is a format codes such to output only the date part using the long date format.


Write("\nHow many eggs are there? ");
int count;
string? input = ReadLine(); 

if (int.TryParse(input, out count))
{
    WriteLine($"There are {count} eggs.");
}
else
{
    WriteLine("I could not parse the input.");
}
