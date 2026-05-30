using OnlineOrdering;

Address address1 = new Address("742 Evergreen Terrace", "Springfield", "IL", "USA");
Customer customer1 = new Customer("Homer Simpson", address1);

Order order1 = new Order(customer1);
order1.AddProduct(new Product("Wireless Mouse", "WM-101", 29.99, 1));
order1.AddProduct(new Product("USB-C Hub", "UC-204", 45.00, 2));
order1.AddProduct(new Product("Desk Lamp", "DL-305", 18.50, 3));

Console.WriteLine("===================================");
Console.WriteLine(order1.GetPackingLabel());
Console.WriteLine();
Console.WriteLine(order1.GetPackingLabel());
Console.WriteLine();
Console.WriteLine($"Oder Total: ${order1.GetTotalCost():F2}  (includes $5 USA shipping)");

Console.WriteLine();

Address address2 = new Address("10 Downing Street", "London", "England", "UK");
Customer customer2 = new Customer("James Bond", address2);

Order order2 = new Order(customer2);
order2.AddProduct(new Product("Laptop Stand", "LS-512", 39.99, 1));
order2.AddProduct(new Product("Mechanical Keyboard", "MK-007", 119.95, 1));

Console.WriteLine("==============================================");
Console.WriteLine(order2.GetPackingLabel());
Console.WriteLine();
Console.WriteLine(order2.GetShippingLabel());
Console.WriteLine();
Console.WriteLine($"Order Total: ${order2.GetTotalCost():F2}  (includes $35 international shipping)");
Console.WriteLine("==============================================");
