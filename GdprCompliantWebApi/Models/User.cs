namespace GdprCompliantWebApi.Models
{
    public class User
    {
        public string? Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool Consent { get; set; }
    }
}
