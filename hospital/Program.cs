namespace hospital
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * commands
             * 1. add student
             */
            var datacontext= new DataContext();
            string command;
            do
            {
                Console.Write("Enter command(exit for quit):");
                command = Console.ReadLine();
                switch (command.ToLower())
                {
                    case "add patient":
                        datacontext.AddPatient();
                        break;
                    case "print patients":
                        datacontext.PrintPatients();
                        break;
                    case "print patient":
                        datacontext.PrintPatient();
                        break;
                    case "add doctor":
                        datacontext.AddDoctor();
                        break;
                    case "print doctors":
                        datacontext.PrintDoctors();
                        break;
                    case "print doctor":
                        datacontext.PrintDoctor();
                        break;
                    case "add department":
                        datacontext.AddDepartment();
                        break;
                    case "print departments":
                        datacontext.PrintDepartments();
                        break;
                    case "print department":
                        datacontext.PrintDepartment();
                        break;
                    case "add seans":
                        datacontext.AddSeans();
                        break;
                    case "print seanses":
                        datacontext.PrintSeanses();
                        break;
                    default: 
                        Console.WriteLine("Enter the correct command");
                        break;


                }
            }
            while (command !="exit");
        }
    }
}
