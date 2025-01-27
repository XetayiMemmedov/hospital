namespace hospital;

internal class Seans
{
    public string Name { get; set; }
    public string Patient { get; set; }
    public string Doctor { get; set; } 
    public string Date {  get; set; }
    public int Id { get; set; }
    public Seans()
    {

    }

    public Seans(string name,  string patient, string doctor, string date, int seansid)
    {
        Name = name;
        Patient = patient;
        Doctor = doctor;
        Date = date;
        Id = seansid;

    }
    public override string ToString()
    {
        return $"{Name} {Doctor} {Patient} {Date}";
    }
}
