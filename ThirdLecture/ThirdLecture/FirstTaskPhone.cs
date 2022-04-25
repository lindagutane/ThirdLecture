namespace ThirdLecture
{
    public class FirstTaskPhone
    {
        public double SizeInch { get; set; }
        public string? Brand { get; set; }
        public string? Model { get; set; }


        public void Call()
        {
            Console.WriteLine("Call");
        }

        public void WriteSMS()
        {
            Console.WriteLine($"This message container phone {SizeInch}, {Brand} and {Model}");
        }
    }
}
