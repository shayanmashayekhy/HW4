public class Person
{ 
    public string? Name { get; set; }
    public string? Id { get; set; }
    public string? LasteName { get; set; }
    public string? Fathersname { get; set; }
    public int Age { get; set; }
    public string? Phonenumber { get; set; }
    public string? Birthday { get; set; }
    public int Height { get; set; }
    public int Weight { get; set; }
    public string? Adress { get; set; }


    public Person(string? name, string? id, string? adress, string? phonenumber, string? fathersname, string? lastename, int age, int height, int weight)
    {
        Name = name;
        Id = id;
        Adress = adress;
        Phonenumber = phonenumber;
        Fathersname = fathersname;
        LasteName = lastename;
        Age = age;
        Height = height;
        Weight = weight;
    }

    





}


