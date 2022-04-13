//Function with paramater & with return type
//Function with paramater & without return type
//Function without paramater & with return type
//Function without paramater & without return type

//int Myfunc1(int a)
//{
//    Console.WriteLine("Hello");
//    return 10;
//}

//var A = Myfunc1(20);

//int Myfunc2(float a)
//{
//    Console.WriteLine("Hello");
//    return 10;
//}

//var B = Myfunc2(20);

//void Myfunc3()
//{
//    Console.WriteLine("Hello");
//    //return ;
//}

//Myfunc3();
//Console.WriteLine("=============================================================");

//Console.WriteLine("\t\t\tPrime number using function\t\t\t");
//Console.WriteLine("Enter num : ");
//int Num = int.Parse(Console.ReadLine());

//if(IsPrime(Num))
//{
//    Console.WriteLine($"{Num} is Prime");
//}
//else
//{
//    Console.WriteLine($"{Num} is not Prime");
//}

//bool IsPrime(int Num)
//{
//    for(int i=2;i<Num;i++)
//    {
//        if(Num%2==0)
//        {
//            return false;
//        }
//    }
//    return true;
//}
//Console.WriteLine("=============================================================");

Console.WriteLine("\t\t\tfind even and odd from 1-100 using function\t\t\t");

int no = 1;

while (no <= 100)
{
    if (IsEvenOdd(no))
        Console.WriteLine($"{no} is Even");
    else
        Console.WriteLine($"{no} is Odd");

    bool IsEvenOdd(int no)
    {
        if (no % 2 == 0)
            return true;
        else
            return false;
    }
    no++;
} 
