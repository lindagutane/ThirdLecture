namespace ThirdLecture
{
     public class FourthTaskPerson
     {
        public FourthTaskPerson()
        {
        }

        public string Name { get; set; }

        public string Surname { get; set; }

        public DateTime BirthDate { get; set; }

        public string Hoby { get; set; }

        public bool IsFemale { get; set; }

        public int GetAge()
        {
            return DateTime.Now.Year - BirthDate.Year;
        }

        public void Greeting()
        {
            Console.WriteLine($"Hello my name is: {Name} {Surname} and I am {GetAge} years old! I like to {Hoby} and I am female: {IsFemale}");
        }
    }
}