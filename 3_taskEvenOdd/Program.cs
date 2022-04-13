Console.WriteLine("Which number you want : \n1.Even \n2.Odd ");
int NumType = int.Parse(Console.ReadLine());

Console.Write("How many number you want : ");
int NumCount = int.Parse(Console.ReadLine());

int cnt = 0;

if (CheckEvenOdd(i))
{
    Console.WriteLine(i);
}

bool CheckEvenOdd(int i)
{
    while (cnt != NumCount)
    {
        if (i % 2 == 0)
            return true;
        cnt++;
        i++;
    }
    return false;
}
//CheckEvenOdd();

//void CheckEvenOdd()
//{
//    if(NumType == 1)
//    {
//        while(i<=(NumCount*2))
//        {
//            if(i%2==0)
//                Console.WriteLine(i);
//            i++;
//        }
//    }

//    if (NumType == 2)
//    {
//        while (i <= (NumCount*2))
//        {
//            if (i % 2 == 1)
//                Console.WriteLine(i);
//            i++;
//        }
//    }
//}
