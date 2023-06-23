class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.Write("Please enter your first name: ");
        string firstName = Console.ReadLine();

        Console.Write("Please enter your last name: ");
        string lastName = Console.ReadLine();

        Console.Write("Please enter your weight (in kg): ");
        double weight = Convert.ToDouble(Console.ReadLine());

        Console.Write("Please enter your height (in cm): ");
        double height = Convert.ToDouble(Console.ReadLine());

        Patient patient = new Patient(firstName, lastName, weight, height);

        // Prints patient information
        patient.PrintPatientInfo();

        Console.ReadKey();
    }
}
