namespace WebApplication1.Models.Requests
{
    public class HelloWorldInput
    {
        public string Name { get; set; }
        public string Greeting { get; set; }
        public HelloWorldInput()
        {

            Name = "Buddy, I am free! You have released me from my prison due to your mistake!";
            Greeting = "Hello World";

        }

    }
}