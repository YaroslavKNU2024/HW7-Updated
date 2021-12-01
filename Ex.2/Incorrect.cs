using System;

namespace task22
{
    // Порушується open / closed principle
    // Before
    class Email
    {
        public String Theme { get; set; }
        public String From { get; set; }
        public String To { get; set; }
    }
    class EmailSender
    {
        public void Send(Email email)
        {
            // ... sending...
            Console.WriteLine("Email from '" + email.From + "' to '" + email.To + "' was send");
        }
    }
}
