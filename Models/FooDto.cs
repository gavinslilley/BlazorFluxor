namespace BlazorFluxor.Models
{
    public class FooDto
    {
        public int Id { get; set; }

        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }

        public bool Completed { get; set; }

        public string? IPAddress { get; set; }
    }
}