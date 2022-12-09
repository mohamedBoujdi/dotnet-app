//Créer la classe Account
namespace FIRSTAPP.Entity;
    public class Account
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Balance { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string Phone { get; set; }
    public string Address { get; set; }
    public string Role { get; set; }
    public string Status { get; set; }
    public DateTime CreatedAt { get; set; }
    public Account()
    {
        CreatedAt = DateTime.Now;
    }
    public Account(int id, string name, double balance, string email, string password, string phone, string address, string role, string status)
    {
        Id = id;
        Name = name;
        Balance = balance;
        Email = email;
        Password = password;
        Phone = phone;
        Address = address;
        Role = role;
        Status = status;
        CreatedAt = DateTime.Now;
    }
}

