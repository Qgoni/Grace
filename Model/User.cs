using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Windows.Controls;

namespace Grace.Model;
[Table("User")]

public class User
{
    public string Login { get; set; } = null!;
    public PasswordBox Password { get; set; } = null!;
}