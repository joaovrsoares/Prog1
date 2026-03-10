namespace WebApplication1.Models
{
    public class Flower
    {
        public string Type { get; set; } = string.Empty;
        public string Color { get; set; } = string.Empty;
        public int Petals { get; set; }
        public double Size { get; set; }
        public bool IsFragrant { get; set; }

        public bool Validate()
        {
            if (string.IsNullOrEmpty(Type) || string.IsNullOrEmpty(Color) || Petals <= 0 || Size <= 0)
            {
                return false;
            }
            return true;
        }
    }
}
