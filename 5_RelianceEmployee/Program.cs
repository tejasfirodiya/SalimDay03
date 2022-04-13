EmpRegistration emp = new EmpRegistration(101, "Tejas1", "Nagar1", 7040481685);
emp.display();
emp.Update();
emp.display();

class EmpRegistration
{
    int _id;
    string _name;
    string _address;
    long _phone;
    public static string Organisation = "Reliance";

    public EmpRegistration(int Id, string Name, string Address, long Phone)
    {
        this._id = Id;
        this._name = Name;
        this._address = Address;
        this._phone = Phone;
    }

    public void display()
    {
        Console.WriteLine($"\nId : {_id}, Name : {_name}, Address : {_address}, Phone : {_phone}");
    }

    public void Update()
    {
        Console.Write("\nWhat you want to update : \n1.Id \n2.Name \n3.Address \n4.Phone\n");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.Write("Enter Id : ");
                int id = int.Parse(Console.ReadLine());
                this._id = id;
                break;
            case 2:
                Console.Write("Enter Name : ");
                string name = Console.ReadLine();
                this._name = name;
                break;
            case 3:
                Console.Write("Enter Address : ");
                string add = Console.ReadLine();
                this._address = add;
                break;
            case 4:
                Console.Write("Enter Phone : ");
                long phone = long.Parse(Console.ReadLine());
                this._phone = phone;
                break;
            default:
                Console.Write("wrong Input. Please check input!!!");
                break;
        }
    }
}