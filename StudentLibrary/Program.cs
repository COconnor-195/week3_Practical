using StudentLibrary;

class program {  


    static void Main(String[]args)
    {
        Student student1 = new Student();
        Student student2 = new Student("Jane Doe", 16);

        student1.Display();
        student2.Display();

        student1.GetOlder();
        student2.GetOlder();

        Console.WriteLine("Impelmenting student older");

        student1.Display();
        student2.Display();


    }








}