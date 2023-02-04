using ADODemoConsoleApp;

var connectionString = "Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog = company; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";

ADODemo demo=new ADODemo(connectionString);
demo.RunSelectAllFromEmployees();
Console.WriteLine("-----------------------------------------------------------------------------------");
demo.RunSelectDefinedColumnSet("first_name", "email");
Console.WriteLine("-----------------------------------------------------------------------------------");
//demo.InsertEmployee();
Console.WriteLine("-----------------------------------------------------------------------------------");
//demo.InsertManyEmployeesDemo();