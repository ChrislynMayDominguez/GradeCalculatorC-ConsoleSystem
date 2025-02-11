class Program {
  // main method
  static void Main(string[] args)
    // Write your code here
    {
    Console.Write("Enter your name:  ");
    string name = Console.ReadLine();
    Console.WriteLine ("\n------------------\n");

        Console.WriteLine("GRADED CALCULATOR");
        
        Console.Write("PRELIM GRADE:   ");
        int PrelimGrade = Convert.ToInt32(Console.ReadLine());

        Console.Write("MIDTERM GRADE:   ");
       int Midterm = Convert.ToInt32(Console.ReadLine());
        Console.Write("FINAL GRADE:  ");
        int FinalGrade = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine ("\n------------------\n");

        
        
        // Calculate percentage
        double Average = (PrelimGrade + Midterm + FinalGrade) /3;

        // Determine grade
        string grade;
        if (Average >= 100) grade = "A+";
        else if (Average >= 90) grade = "A";
        else if (Average >= 80) grade = "B";
        else if (Average >= 70) grade = "C";
        else if (Average >= 60) grade = "D";
         else if (Average >= 0) grade = "E";
        else grade = "F";

        // Display results
        Console.WriteLine ("Student Name: " + name);
        Console.WriteLine($"Average Grade: {Average:F2}%");
        Console.WriteLine($"Letter Grade: {grade}");
        Console.WriteLine("\n--------------------\n");
    }
}