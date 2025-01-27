namespace hospital;

internal class Patient
{
    private string _firstname;
    public string FirstName
    {
        get { return _firstname; }
        set { _firstname = value; }
    }
    private string _lastname;
    public string LastName
    {
        get { return _lastname; }
        set { _lastname = value; }
    }
    private int _id;
    public int Id
    {
        get { return _id; }
        set { _id = value; }
    }
    private string _doctor;
    public string Doctor
    {
        get { return _doctor; }
        set { _doctor = value; }
    }
    private string _seans;
    public string Seans
    {
        get { return _seans; }
        set { _seans = value; }
    }
    public Patient()
    {

    }

    public Patient(string firstname, string lastname, int id)
    {
        _firstname = firstname;
        _lastname = lastname;
        _id = id;
    }
    public Patient(string firstname, string lastname, int id, string doctor)
    {
        _firstname = firstname;
        _lastname = lastname;
        _id = id;

    }

    public override string ToString()
    {
        return $"{_firstname} {_lastname} {_id}";
    }



}


