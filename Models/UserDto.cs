namespace CyberHound_Api.Models
{
    public class UserDto
    {
        public Guid Id { get; set; }
        public string Username { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string? FullName { get; set; }
        // Demo only: store password in-memory. Use hashed passwords in production.
        public string? Password { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
