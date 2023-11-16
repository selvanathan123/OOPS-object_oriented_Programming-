using OOPS_Object_oriented_Programming_;

class OOPS
{

    // Main Method 
    static public void Main(String[] args)
    {

        //Abstraction
        Order Aorder = new Order();
        Aorder.OrderNo = "1000";
        Aorder.OrderCountry = "India";
        Aorder.OrderType = "Fixed";

        Aorder.CreateOrder();
        Aorder.UpdateOrder();
        Aorder.DeleteOrder();

        Console.WriteLine();

        //Encapsulation
        Order Eorder = new Order();

        Eorder.CreateOrder1();

        Console.WriteLine();

        Student stud = new Student();
        stud.Firstname = "selva";
        stud.Lastname = "nathan";

        Details studd = new Details();
        studd.Address = "Main Road";
        studd.State = "Puducherry";
        studd.Country = "India";
        studd.StudentDetails();

    }
}