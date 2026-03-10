namespace WebApplication1.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string? EmailAddress { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        public bool Validate()
        {
            if (
                string.IsNullOrEmpty(EmailAddress)
                || string.IsNullOrEmpty(FirstName)
                || string.IsNullOrEmpty(LastName)
            )
            {
                return false;
            }

            return true;
        }
    }
}
