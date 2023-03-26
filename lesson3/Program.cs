namespace lesson3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Patient patient = new Patient(34, "Васильев Л.Н.", new List<Disease> {Disease.Myopia, Disease.Diabetes});
            patient.DisplayInfo();
            patient.GrowUp();

            Patient patient2 = new Patient(55, "Иванов И.И.", new List<Disease> {Disease.Diabetes, Disease.Hypertension});
            patient2.DisplayInfo();
            patient2.GrowUp();
            
            Ophthalmologist ophthalmologist = new Ophthalmologist(40, "Козлова Г.М.", 10);
            ophthalmologist.DisplayInfo();
            ophthalmologist.Cure(patient);
            ophthalmologist.Cure(patient2);
            ophthalmologist.GrowUp();
            ophthalmologist.UpExperience();
            
            Cardiologist cardiologist = new Cardiologist(47, "Волков А.А.", 17);
            cardiologist.DisplayInfo();   
            cardiologist.Cure(patient);   
            cardiologist.Cure(patient2);  
            cardiologist.GrowUp();        
            cardiologist.UpExperience();  
        }
    }
}

