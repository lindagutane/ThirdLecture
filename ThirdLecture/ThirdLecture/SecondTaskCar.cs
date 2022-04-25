namespace ThirdLecture
{
    public class SecondTaskCar
    {
        public string? CarBrand { get; set; }
        public string? CarModel { get; set; }
        public string? CarNumberPlate { get; set; }
        public int CarSpeed { get; set; }

        public void Drive()
        {
            CarSpeed = 20;
            Console.WriteLine($"Drive, your speed is {CarSpeed}");
        }

        public void IncreaseSpeed()
        {
            CarSpeed += 20;
            Console.WriteLine($"Increase speed, your speed is {CarSpeed}");
        }

        public void StopDriving()
        {
            CarSpeed = 0;
            Console.WriteLine($"Stop driving, your speed is {CarSpeed}");
        }

        public void BeepBeep()
        {
            Console.WriteLine("beep beep");
        }
    }
}
