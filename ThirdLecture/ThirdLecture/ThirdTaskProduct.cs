namespace ThirdLecture
{
    public class ThirdTaskProduct
    {
        public ThirdTaskProduct(double lenght, double width, double weight)
        {
            Lenght = lenght;
            Width = width;
            Weight = weight;
        }

        public double Lenght { get; }
        public double Width { get; }
        public double Weight { get; }

        public void Description()
        {
            Console.WriteLine($"Lūdzu, norādies preces garumu, platumu un svaru");
        }

        public void ProductParametrs(double Lenght, double Width, double Weight)
        {
            Console.WriteLine($"Preces garums ir {Lenght}, platums ir {Width}, svars ir {Weight}");
        }

    }
}
