namespace lesson3;

public interface IDoctor: IGrowable
{
    string Name { get; set; }
    int Experience { get; set; }
    
    void UpExperience();
    void Cure(IPatient patient);
    void DisplayInfo();
}
    