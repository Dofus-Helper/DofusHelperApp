using SQLite;
 // NEED TO HASH WHEN WE NEED USER
public class Users
{
    [PrimaryKey, AutoIncrement]
    public int id { get; set; }

    [Unique]
    public string email { get; set; }

    public string password { get; set; }

    // Optionally, add a method to set the password that automatically hashes it
    // public void SetPassword(string password)
    // {
    //     this.Password = HashPassword(password);
    // }

    // private string HashPassword(string password)
    // {
    //     // Use a suitable hashing method here, e.g., BCrypt
    //     return BCrypt.Net.BCrypt.HashPassword(password);
    // }

    // Method to verify a password against the stored hash
    // public bool VerifyPassword(string password)
    // {
    //     return BCrypt.Net.BCrypt.Verify(password, this.Password);
    // }
}