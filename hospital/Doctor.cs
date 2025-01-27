namespace hospital;

internal class Doctor
{
    private string _name;
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }
    private string _department;
    public string Department
    {
        get { return _department; }
        set { _department = value; }
    }
    private string _seans;
    public string Seans
    {
        get { return _seans; }
        set { _seans = value; }
    }
    private int _id;
    public int Id
    {
        get { return _id; }
        set { _id = value; }
    }

    public Doctor()
    {

    }

    public Doctor(string name,  string department, int id)
    {
        _name = name;
        _department = department;
        _id = id;
    }
    public Doctor(string name, string department, string seans, int id)
    {
        _name = name;
        _department = department;
        _seans=seans;
        _id=id;
    }

    public override string ToString()
    {
        return $"{_name}  {_department} {_id}";
    }
}
