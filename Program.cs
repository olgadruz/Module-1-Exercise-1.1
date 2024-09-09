using System.Runtime.CompilerServices;

namespace PersonalInfo;

class PersonalInfo
{
    public static void Main(string[] args)
    {
        var fullname = ContactName("Robert", "Hall");
        var databirth = birthdate("2/27/1949");
        var wpnumber = wpn("000-444-0101");
        var cnumber = cp("000-444-0189");
        Console.WriteLine(fullname);
        Console.WriteLine(databirth);
        Console.WriteLine("work" + wpnumber);
        Console.WriteLine("cell" + cnumber);
    }

    private static string ContactName(string firstname, string lastname)
    {
        return firstname + ' ' + lastname;
    }
    private static string birthdate(string data)
    {
        return data;
    }
    private static string wpn(string wnumber)
    {
        return wnumber;
    }
    private static string cp(string cpnumber)
    {
        return cpnumber;
    }
}

