namespace StringDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Firstname = "Ajay";
            var lastname = "Chougule";

            var fullname = (Firstname + " " +lastname );
            var myfullname = string.Format("My Name is {0} {1}", Firstname, lastname);

            var name = new string[3]{ "Ajay", "Renuka", "Nutan" };

            var formattednames = String.Join(", ", name);

            var text = @"Hi Ajay
            Look into a following paths;
            c:\Folder1\Folder2
            c:\Folder3\Folder4";
            Console.WriteLine(myfullname);
            Console.WriteLine(formattednames);
            Console.WriteLine(text);
            
            
        }
    }
}
