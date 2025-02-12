﻿namespace Sales.Orders.Create;

public class Request
{
    public int CustomerID { get; set; }
    public int ProductID { get; set; }
    public int Quantity { get; set; }
    public Guid GuidTest { get; set; }
}

public class Response
{
    public int OrderID { get; set; }
    public string? Message { get; set; }
    public string? AnotherMsg { get; set; }
    public Guid GuidTest { get; set; }
}
