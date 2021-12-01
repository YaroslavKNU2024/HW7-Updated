using System;

namespace task2
{
    //After 
    interface IEmailProcessor
    {
        void Send(string from, string to, string theme);
    }

    class Sender: IEmailProcessor
    {
        public void Send(string from, string to, string theme) => Console.WriteLine("From: " + from + ". To: " + to + ". sent: " + theme);
    }

    class SendEmail
    {
        public void Send(Email email, IEmailProcessor processor) => processor.Send(email.From, email.To, email.Theme);
    }
    class Email
    {
        public string Theme { get; set; }
        public string From { get; set; }
        public string To { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Email e1 = new Email() { From = "Me", To = "Vasya", Theme = "Who are you?" };
            Email e2 = new Email() { From = "Vasya", To = "Me", Theme = "vacuum cleaners!" };
            Email e3 = new Email() { From = "Kolya", To = "Vasya", Theme = "No! Thanks!" };
            Email e4 = new Email() { From = "Vasya", To = "Me", Theme = "washing machines!" };
            Email e5 = new Email() { From = "Me", To = "Vasya", Theme = "Yes" };
            Email e6 = new Email() { From = "Vasya", To = "Petya", Theme = "+2" };

            SendEmail es = new SendEmail();
            IEmailProcessor logger = new Sender();
            es.Send(e1, logger);
            es.Send(e2, logger);
            es.Send(e3, logger);
            es.Send(e4, logger);
            es.Send(e5, logger);
            es.Send(e6, logger);

        }
    }
}
