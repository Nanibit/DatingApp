namespace API.Entities;

public class AppUser
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public required string DisplayName { get; set; }
    public required string Email { get; set; }
    // Almacenar un hash de contraseñas
    public required byte[] PasswordHash { get; set; }
    // Almacenar matriz para Salt - poner el hash aleatorio
    public required byte[] PasswordSalt { get; set; }
}