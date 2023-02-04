using InvoicePlatform;

var connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=invoiceDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

ADO ado = new ADO(connectionString);
