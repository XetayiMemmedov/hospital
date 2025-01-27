using System;

namespace hospital;

internal class DataContext
{
    public Patient [] Patients { get; set; }= new Patient[100];
    public Doctor[] Doctors { get; set; } = new Doctor[100];
    public Department[] Departments { get; set; }=new Department[100];
    public Seans[] Seanses { get; set; }= new Seans[100];

    private int _patientIndex = 0;
    private int _doctorIndex = 0;
    private int _departmentIndex = 0;
    private int _seansIndex = 0;
    #region patients
    public void AddPatient()
    {
        Console.Write("Firstname:");
        string firstName=Console.ReadLine();
        Console.Write("Lastname:");
        string lastName=Console.ReadLine();
        var patient = new Patient(firstName, lastName, _patientIndex);
        {
            Patients[_patientIndex++] = patient;
        }
       
    }
    public void PrintPatient()
    {
        Console.Write("Enter patient id:");
        string Idstring = Console.ReadLine();
        Console.WriteLine(new string('-', 70));
        if (!int.TryParse(Idstring, out int id) || !((id >= 0) && (id < _patientIndex)))
        {
            Console.WriteLine("not found");
        }
        Console.WriteLine($"{"Firstname",-20} {"Lastname",-20} {"Doctor",-20} {"Seans",10}");
        id = int.Parse(Idstring);
        var patient = Patients[id];
        Console.WriteLine($"{patient.FirstName,-20} {patient.LastName,-20} {patient.Doctor,-20} {patient.Seans,-10}");
        Console.WriteLine(new string('-', 70));

    }
    public void PrintPatients()
    {
        Console.WriteLine(new string('-', 70));

        Console.WriteLine($"{"Firstname",-20} {"Lastname",-20} { "Doctor",-20} {"Seans",10}");
        for (int i = 0; i < _patientIndex; i++)
        {
            var patient = Patients[i];
            Console.WriteLine($"{patient.FirstName,-20} {patient.LastName,-20} {patient.Doctor,-20} {patient.Seans,-10}");
        }
        Console.WriteLine(new string('-', 70));

    }
    #endregion
    #region doctors
    public void AddDoctor()
    {
        Console.Write("Name:");
        string name = Console.ReadLine();
        Console.Write("Department:");
        string department = Console.ReadLine();

        var doctor = new Doctor(name, department, _doctorIndex);
        {
            Doctors[_doctorIndex++] = doctor;
        }

    }
    public void PrintDoctor()
    {
        Console.Write("Enter doctor id:");
        string Idstring = Console.ReadLine();
        Console.WriteLine(new string('-', 70));
        if (!int.TryParse(Idstring, out int id) || !((id >= 0) && (id < _doctorIndex)))
        {
            Console.WriteLine("not found");
        }
        Console.WriteLine($"{"Name",-20} {"Department",-20} {"Seans",10}");
        id = int.Parse(Idstring);
        var doctor = Doctors[id];
        Console.WriteLine($"{doctor.Name,-20} {doctor.Department,-20} {doctor.Seans,-10}");
        Console.WriteLine(new string('-', 70));
    }
    public void PrintDoctors()
    {
        Console.WriteLine(new string('-', 70));

        Console.WriteLine($"{"Name",-20} {"Department",-20} {"Seans",10}");
        for (int i = 0; i < _doctorIndex; i++)
        {
            var doctor = Doctors[i];
            Console.WriteLine($"{doctor.Name,-20} {doctor.Department,-20} {doctor.Seans,-10}");
        }
        Console.WriteLine(new string('-', 70));

    }
    #endregion
    #region department
    public void AddDepartment()
    {
        Console.Write("Name:");
        string name = Console.ReadLine();
        Console.Write("Doctor:");
        string doctor = Console.ReadLine();
        //Console.Write("Seans:");
        //string seans = Console.ReadLine();

        var department = new Department(name, doctor, _departmentIndex);
        {
            Departments[_departmentIndex++] = department;
        }

    }
    public void PrintDepartment()
    {
        Console.Write("Enter department id:");
        string Idstring = Console.ReadLine();
        Console.WriteLine(new string('-', 70));
        if (!int.TryParse(Idstring, out int id) || !((id >= 0) && (id < _departmentIndex)))
        {
            Console.WriteLine("not found");
        }
        Console.WriteLine($"{"Name",-20} {"Doctor",-20} {"Seans",10}");
        id = int.Parse(Idstring);
        var department = Departments[id];
        Console.WriteLine($"{department.Name,-20} {department.Doctor,-20} {department.Seans,-10}");
        Console.WriteLine(new string('-', 70));
    }
    public void PrintDepartments()
    {
        Console.WriteLine(new string('-', 70));

        Console.WriteLine($"{"Name",-20} {"Doctors",-20} {"Seans",10}");
        for (int i = 0; i < _departmentIndex; i++)
        {
            var department = Departments[i];
            Console.WriteLine($"{department.Name,-20} {department.Doctor,-20} {department.Seans,-10}");
        }
        Console.WriteLine(new string('-', 70));

    }
    #endregion
    public void AddSeans()
    {
        Console.Write("Name:");
        string name = Console.ReadLine();
        Console.WriteLine("Choose patients below:");
        PrintPatients();
        Console.WriteLine("Choose patient id:");
        string stringId = Console.ReadLine();
        if (!int.TryParse(stringId, out int patientid) || !((patientid >= 0 && patientid < _patientIndex)))
        {
            Console.WriteLine("Enter the correct id");
            return;
        }
        Console.WriteLine("Choose doctor below:");
        PrintDoctors();
        Console.WriteLine("Choose doctor id:");
        stringId = Console.ReadLine();
        if (!int.TryParse(stringId, out int doctorid) || !((doctorid >= 0 && doctorid < _patientIndex)))
        {
            Console.WriteLine("Enter the correct id");
            return;
        }
        Console.WriteLine("enter date(01.01.2025):");
        string date = Console.ReadLine();
        var patient = Patients[patientid];
        var doctor = Doctors[doctorid];
        var seans = new Seans(name, [patient],[doctor],date, _seansIndex);
        Seanses[_seansIndex++] = seans;
        patient.Doctor = doctor.Name;
        doctor.Seans = seans.Name;


    }
    public void PrintSeanses()
    {
        Console.WriteLine(new string('-', 50));

        Console.WriteLine($"{"Date",-10} {"Doctors",-20} {"Patients",20}");
        foreach (var seans in Seanses)
        {
            if (seans == null) continue;
            Console.WriteLine(new string('-', 50));
            Console.WriteLine(seans.Name);
            Console.WriteLine(seans.Doctors);
            Console.WriteLine($"{seans.Date,-10} {seans.Doctors,-20} {seans.Patients,-20}");
        }
        Console.WriteLine(new string('-', 50));

    }
}