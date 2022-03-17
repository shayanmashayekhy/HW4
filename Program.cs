
List<Person?> people = new List<Person?>();

Person? currentPerson = null;

Console.WriteLine("Please Register in App");
Register();
string? crfile;

void Register()
{
    Console.WriteLine();
    Console.WriteLine("Please Enter Your Name : ");
    var name = Console.ReadLine();

    Console.WriteLine("Please Enter Your Laste Name :");
    var lastename = Console.ReadLine();

    Console.WriteLine("Please Enter Your Fathersname :");
    var fathersname = Console.ReadLine();

    Console.WriteLine("Please Enter Your ID :");
    var id = Console.ReadLine();

    Console.WriteLine("Please Enter Your Age : ");
    var age = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Please Enter Your Height : ");
    var height = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Please Enter Your Weight : ");
    var weight = Convert.ToInt32(Console.ReadLine());


    Console.WriteLine("Please Enter Your Adress :");
    var adress = Console.ReadLine();


    Console.WriteLine("Please Enter Yuor Phone Number :");
    var phonenumber = Console.ReadLine();


    Person newPerson = new Person(name, id, adress, phonenumber, fathersname, lastename, age, height, weight);
    currentPerson = newPerson;
    people.Add(newPerson);
    Action();


}

void Action()
{
    Console.Write("Do You want Save Your Information ?");
    var info = Console.ReadKey();
    if (info.Key == ConsoleKey.Y)
    {
        //Save();
    }
    else
    {
        Logout();

    }
}


/*void Save()
{
    Console.WriteLine("Please Specify Where File Create ?");
    crfile = Console.ReadLine();
    if (crfile == null)
    {
        Save();
    }

   var file = File.CreateText($"{ crfile}.csv");
    if (File.Exists(crfile))
    {
        Console.WriteLine("File White This Name is Exist in your location");
    }
    
    file.Close();





}*/

void Logout()
{
    Console.WriteLine("Bye");
}



