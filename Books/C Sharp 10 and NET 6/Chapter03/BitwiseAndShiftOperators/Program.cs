using static System.Console;

int a = 10; // 00001010
int b = 6;  // 00000110

WriteLine($"a = {a}, binary is {ToBinaryString(a)}");
WriteLine($"b = {b}, binary is {ToBinaryString(b)}");
WriteLine($"a & b = {a & b}, binary is {ToBinaryString(a & b)}"); // AND bitwise operator; 2-bit column only
WriteLine($"a | b = {a | b}, binary is {ToBinaryString(a | b)}"); // OR bitwise operator; 8, 4, and 2-bit columns
WriteLine($"a ^ b = {a ^ b}, binary is {ToBinaryString(a ^ b)}"); // XOR bitwise operator; 8 and 4-bit columns
WriteLine();

// 01010000 left-shift a by three bit columns
WriteLine($"a << 3 = {a << 3}, binary is {ToBinaryString(a << 3)}");

// multiply a by 8
WriteLine($"a * 8 = {a * 8}, binary is {ToBinaryString(a * 8)}");

// 00000011 right-shift b by one bit column
WriteLine($"b >> 1 = {b >> 1}, binary is {ToBinaryString(b >> 1)}");

// CPUs can perform a bit-shift faster.
// Remember that when operating on integer values, the & and | symbols are bitwise operators, and when operating on
// Boolean values like true and false, the & and | symbols are logical operators.

static string ToBinaryString(int value)
{
    return Convert.ToString(value, toBase: 2).PadLeft(8, '0');
}