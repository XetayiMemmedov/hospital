namespace hospital;

internal class Seans
{
    public string Name { get; set; }
    public Patient[] Patients { get; set; } = new Patient[10];
    public Doctor[] Doctors { get; set; } = new Doctor[10];
    public string Date {  get; set; }
    public int Id { get; set; }
    public Seans()
    {

    }

    public Seans(string name,  Patient [] patients, Doctor[] doctors, string date, int seansid)
    {
        Name = name;
        Patients = patients;
        Doctors = doctors;
        Date = date;
        Id = seansid;

    }
    public override string ToString()
    {
        return $"{Name} {Date}";
    }
}
