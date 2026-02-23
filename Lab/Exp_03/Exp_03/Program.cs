using System;

// ======================
// S — Single Responsibility Principle (SRP)
// ======================
class User { }

class UserRepository
{
    public void Save(User user)
    {
        Console.WriteLine("User saved to database");
    }
}

class UserEmailService
{
    public void SendEmail(User user)
    {
        Console.WriteLine("Email sent to user");
    }
}

// ======================
// O — Open/Closed Principle (OCP)
// ======================
interface IDiscount
{
    double GetDiscount(double amount);
}

class StudentDiscount : IDiscount
{
    public double GetDiscount(double amount) => amount * 0.9;
}

class SeniorDiscount : IDiscount
{
    public double GetDiscount(double amount) => amount * 0.8;
}

// ======================
// L — Liskov Substitution Principle (LSP)
// ======================
abstract class Bird
{
    public abstract void Eat();
}

class Sparrow : Bird
{
    public override void Eat()
    {
        Console.WriteLine("Sparrow eating");
    }
}

// ======================
// I – Interface Segregation Principle (ISP)
// ======================
interface IWork
{
    void Work();
}

interface IEat
{
    void Eat();
}

class HumanWorker : IWork, IEat
{
    public void Work()
    {
        Console.WriteLine("Human working");
    }

    public void Eat()
    {
        Console.WriteLine("Human eating");
    }
}

class RobotWorker : IWork
{
    public void Work()
    {
        Console.WriteLine("Robot working");
    }
}

// ======================
// D – Dependency Inversion Principle (DIP)
// ======================
interface IMessageService
{
    void Send(string message);
}

class EmailService : IMessageService
{
    public void Send(string message)
    {
        Console.WriteLine("Email Sent: " + message);
    }
}

class Notification
{
    private IMessageService service;

    public Notification(IMessageService service)
    {
        this.service = service;
    }

    public void Notify(string message)
    {
        service.Send(message);
    }
}

// ======================
// MAIN PROGRAM
// ======================
class Program
{
    static void Main(string[] args)
    {
        // SRP
        User user = new User();
        UserRepository repo = new UserRepository();
        repo.Save(user);

        UserEmailService emailService = new UserEmailService();
        emailService.SendEmail(user);

        // OCP
        IDiscount discount = new StudentDiscount();
        Console.WriteLine("Discounted Price: " + discount.GetDiscount(1000));

        // LSP
        Bird bird = new Sparrow();
        bird.Eat();

        // ISP
        HumanWorker human = new HumanWorker();
        human.Work();
        human.Eat();

        RobotWorker robot = new RobotWorker();
        robot.Work();

        // DIP
        IMessageService messageService = new EmailService();
        Notification notification = new Notification(messageService);
        notification.Notify("Hello SOLID Principles!");

        Console.ReadLine();
    }
}