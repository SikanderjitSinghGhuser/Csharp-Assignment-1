public class Patient
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public double Weight { get; set; } // in kg
    public double Height { get; set; } // in cm

    // Custom constructor
    public Patient(string firstName, string lastName, double weight, double height)
    {
        FirstName = firstName;
        LastName = lastName;
        Weight = weight;
        Height = height;
    }

    public string CalculateBloodPressure(int systolic, int diastolic)
    {
        if (systolic < 120 && diastolic < 80) return "Normal";
        if (systolic < 130 && diastolic < 80) return "Elevated";
        if (systolic < 140 || (diastolic >= 80 && diastolic < 90)) return "High blood pressure (Hypertension) Stage 1";
        if (systolic >= 140 || diastolic >= 90) return "High blood pressure (Hypertension) Stage 2";
        if (systolic > 180 || diastolic > 120) return "Hypertensive Crisis (consult your doctor immediately)";

        return "Blood pressure range not recognized, please consult your doctor.";
    }

    public double CalculateBMI()
    {
        // Convert height from cm to meters
        double heightInMeters = Height / 100;
        return Weight / (heightInMeters * heightInMeters);
    }

    public string CalculateBMIStatus()
    {
        double bmi = CalculateBMI();
        if (bmi >= 25) return "Overweight";
        if (bmi >= 18.5) return "Normal (In the healthy range)";
        return "Underweight";
    }

    public void PrintPatientInfo()
    {
        Console.WriteLine("Full Name: " + FirstName + " " + LastName);
        Console.WriteLine("Weight: " + Weight + " kg");
        Console.WriteLine("Height: " + Height + " cm");
        Console.WriteLine("Blood pressure: " + CalculateBloodPressure(120, 80)); // I've used 120 and 80 as an example, you should replace this with the appropriate values
        Console.WriteLine("BMI: " + CalculateBMI());
        Console.WriteLine("BMI Status: " + CalculateBMIStatus());
    }
}
