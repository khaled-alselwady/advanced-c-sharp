using System;

#region Publisher Subscriber Design Pattern
public class OrderEventArgs : EventArgs
{
    public int OrderID { get; }
    public double OrderTotalPrice { get; }
    public string ClientEmail { get; }

    public OrderEventArgs(int orderID, double orderTotalPrice, string clientEmail)
    {
        OrderID = orderID;
        OrderTotalPrice = orderTotalPrice;
        ClientEmail = clientEmail;
    }
}

public class Order
{
    public event EventHandler<OrderEventArgs> OnOrderCreated;

    public void Create(int orderID, double orderTotalPrice, string orderEmail)
    {
        Console.WriteLine("New Order created; now will notify everyone by raising the event.\n");

        if (OnOrderCreated != null)
            OnOrderCreated(this, new OrderEventArgs(orderID, orderTotalPrice, orderEmail));
    }
}

public class EmailService
{
    public void Subscribe(Order order)
    {
        order.OnOrderCreated += _HandleNewOrder;
    }

    public void UnSubscribe(Order order)
    {
        order.OnOrderCreated -= _HandleNewOrder;
    }

    private void _HandleNewOrder(object sender, OrderEventArgs e)
    {
        Console.WriteLine($"----------Email Service--------");
        Console.WriteLine($"Email Service Object Received a new order event");
        Console.WriteLine($"Order ID: {e.OrderID}");
        Console.WriteLine($"Order Price: {e.OrderTotalPrice}");
        Console.WriteLine($"Email: {e.ClientEmail}");
        Console.WriteLine($"\nSend an email");
        Console.WriteLine($"--------------------------------");
        /*
         here you write the code to send the email to the client 
         */
        Console.WriteLine();
    }
}

public class SMSService
{
    public void Subscribe(Order order)
    {
        order.OnOrderCreated += _HandleNewOrder;
    }

    public void UnSubscribe(Order order)
    {
        order.OnOrderCreated -= _HandleNewOrder;
    }

    private void _HandleNewOrder(object sender, OrderEventArgs e)
    {
        Console.WriteLine($"------------SMS Service--------");
        Console.WriteLine($"SMS Service Object Received a new order event");
        Console.WriteLine($"Order ID: {e.OrderID}");
        Console.WriteLine($"Order Price: {e.OrderTotalPrice}");
        Console.WriteLine($"Email: {e.ClientEmail}");
        Console.WriteLine($"\nSend SMS");
        Console.WriteLine($"--------------------------------");
        /*
         here you write the code to send the SMS to the client 
         */
        Console.WriteLine();
    }
}

public class ShippingService
{
    public void Subscribe(Order order)
    {
        order.OnOrderCreated += _HandleNewOrder;
    }

    public void UnSubscribe(Order order)
    {
        order.OnOrderCreated -= _HandleNewOrder;
    }

    private void _HandleNewOrder(object sender, OrderEventArgs e)
    {
        Console.WriteLine($"---------Shipping Service-------");
        Console.WriteLine($"Shipping Service Object Received a new order event");
        Console.WriteLine($"Order ID: {e.OrderID}");
        Console.WriteLine($"Order Price: {e.OrderTotalPrice}");
        Console.WriteLine($"Email: {e.ClientEmail}");
        Console.WriteLine($"\nHandel Shipping");
        Console.WriteLine($"--------------------------------");
        /*
         here you write the code to handle shipping to the client 
         */
        Console.WriteLine();
    }
}
#endregion

public class Program
{
    static void Main(string[] args)
    {
        Order order = new Order();

        EmailService emailService = new EmailService();

        SMSService smsService = new SMSService();

        ShippingService shippingService = new ShippingService();

        emailService.Subscribe(order);
        smsService.Subscribe(order);
        shippingService.Subscribe(order);
        shippingService.UnSubscribe(order);

        order.Create(10, 540, "Ahmed@Gmail.com");

        Console.ReadLine();
    }
}

