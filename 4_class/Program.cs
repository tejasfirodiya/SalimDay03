
//var aa = new A(10, 20);
//Console.WriteLine(aa.Add());
//Console.WriteLine(aa.Sub());
//Console.WriteLine(aa.Div());
//Console.WriteLine(aa.Mul());

//public class A
//{
//    public int a; 
//    public int b;

//    public A(int aa, int bb)
//    {
//        a = aa;
//        b = bb;
//    }

//    public int Add()
//    {
//        return a + b;
//    }
//    public int Sub()
//    {
//        return a - b;
//    }
//    public int Div()
//    {
//        return a / b;
//    }
//    public int Mul()
//    {
//        return a * b;
//    }
//}

//Console.WriteLine("=================================================");

Student std1 = new Student(101, "Tejas1", "Nagar1", 7040481685);
Student std2 = new Student(102, "Tejas2", "Nagar2", 040481685);
Student std3 = new Student(103, "Tejas3", "Nagar3", 40481685);

std1.display();
std1.Update("TSF",8830062194);
std1.display();
std2.display();
std3.display();

//std1.Name = "Tejas Firodiya";
//std2.Phone = 5555555;
//std3.Address = "Ahmedngar";

std1.display();
std2.display();
std3.display();
string s=Student.CollegeName;
Console.WriteLine(s);

class Student
{
    private int Id;
    private string Name;
    private string Address;
    private long Phone;
    public static string CollegeName = "MIT";

    public Student(int id,string name,string address,long phone)
    {
        this.Id = id;
        this.Name = name;
        this.Address = address;
        this.Phone = phone;
    }

    public void display()
    {
        Console.WriteLine($"\nId : {Id}, Name : {Name}, Address : {Address}, Phone : {Phone}, CollegeName : {CollegeName}");
    }

    public void Update(string name,long phone)
    {
        this.Name = name;
        this.Phone = phone;
        Console.WriteLine("\nName & Phone number Updated Successfully");
    }

}

//Console.WriteLine("=================================================");
