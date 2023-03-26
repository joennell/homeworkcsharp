namespace lesson3;

public class Patient : IPatient
{
    public Patient(int age, string name, List<Disease> diseases)
    {
        Age = age;
        Name = name;
        Diseases = diseases;
    }

    public int Age { get; set; }

    public string Name { get; set; }

    public List<Disease> Diseases { get; set; }

    public void GrowUp()
    {
        Age++;
        Console.WriteLine($"Пациент {Name} стал старше на 1 год и теперь ему {Age} лет.");
    }

    public void DisplayInfo()
    {
        string diseaseList = string.Join(", ", Diseases.ToArray());
        Console.WriteLine($"Пациент {Name}, возраст {Age}, болезни: {diseaseList}.");
    }
}