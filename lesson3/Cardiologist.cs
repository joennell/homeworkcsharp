namespace lesson3;

public class Cardiologist: IDoctor
{
    public int Age { get; set; }

    public string Name { get; set; }

    public int Experience { get; set; }

    public Cardiologist (int age, string name, int experience)
    {
        Age = age;
        Name = name;
        Experience = experience;
    }

    public void GrowUp()
    {
        Age++;
        Console.WriteLine($"Доктор {Name} стал старше на 1 год и теперь ему {Age} лет.");
    }

    public void UpExperience()
    {
        Experience++;
    }

    public void Cure(IPatient patient)
    {
        if (patient.Diseases.Contains(Disease.Hypertension))
        {
            patient.Diseases.Remove(Disease.Hypertension);
            Console.WriteLine($"Доктор {Name} вылечил пациента {patient.Name}");
        }
        else
        {
            Console.WriteLine($"Доктору {Name} нечего лечить у пациента {patient.Name}");
        }
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Доктор {Name}, возраст {Age}, стаж работы {Age} лет.");
    }
}