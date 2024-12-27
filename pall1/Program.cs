class Student
{
    public string Name { get; set; }
    public double AverageScore { get; set; }
    public int kurs { get; set; }

    public double CalculateQ()
    {
        return 0.2 * AverageScore * kurs;
    }

    public double CalculateQp(bool P)
    {
        double Q = CalculateQ();
        if (P)
        {
            return 2 * Q;
        }
        else
        {
            return 0.9 * Q;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student student = new Student
        {
            Name = "Карпов",
            AverageScore = 4.5,
            kurs = 2
        };

        bool P = true;
        double Qp = student.CalculateQp(P);

        Console.WriteLine($"Qp для студента {student.Name}: {Qp}");
    }
}
