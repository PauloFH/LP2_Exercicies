using The_Account_Class;

// Test constructor and ToString()
Account a1 = new Account("A101", "Tan Ah Teck", 88);
Console.WriteLine(a1);  // ToString();

Account a2 = new Account("A102", "Kumar"); // default balance
Console.WriteLine(a2);

// Test Getters
Console.WriteLine("ID: " + a1.Id);
Console.WriteLine("Name: " + a1.Name);
Console.WriteLine("Balance: " + a1.Balance);

// Test Credit() and Debit()
a1.Credit(100);
Console.WriteLine(a1);

a1.Debit(50);
Console.WriteLine(a1);

a1.Debit(500);  // Debit() error
Console.WriteLine(a1);

// Test Transfer()
a1.TransferTo(a2, 100);
Console.WriteLine(a1);
Console.WriteLine(a2);