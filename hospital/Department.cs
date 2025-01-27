using System;

namespace hospital;

internal class Department
{
    private string _name;
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }
    private string _doctor;
    public string Doctor
    {
        get { return _doctor; }
        set { _doctor = value; }
    }
    private int _id;
    public int Id
    {
        get { return _id; }
        set { _id = value; }
    }
    private string _seans;
    public string Seans
    {
        get { return _seans; }
        set { _seans = value; }
    }
    public Department()
    {
    }
    public Department(string name, string doctor, int id)
    {
        _name = name;
        _doctor = doctor;
        _id = id;
        //_seans = seans;

    }

    public override string ToString()
    {
        return $"{_name} {_doctor} {_id} {_seans}";
    }
}
