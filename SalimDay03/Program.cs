Console.WriteLine("=============================================================");
Console.WriteLine("\t\t\tFunctions\t\t\t");
Console.WriteLine("=============================================================");

//accessSpecifier return_type func_name (para1, para2, .....){ }
Console.WriteLine("\t\t\tFind even and odd number\t\t\t");

Console.Write("Enter no : ");
int Num = int.Parse(Console.ReadLine());

if (IsOddeven(Num))
{
    Console.WriteLine("Even");
}
else
{
    Console.WriteLine("Odd");
}

bool IsOddeven(int Num)
{
    if (Num % 2 == 0)
        return true;
    else
        return false;
}

Console.WriteLine("=============================================================");