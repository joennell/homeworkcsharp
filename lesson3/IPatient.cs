namespace lesson3;

public interface IPatient : IGrowable
{
    string Name { get; set; }
    List<Disease> Diseases { get; set; }
    void DisplayInfo();
}