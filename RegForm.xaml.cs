using System;
using System.Linq;
using System.Windows;
using Grace.Model;
namespace Grace;

public partial class RegForm
{
    private readonly DbUsers _db = new DbUsers(@"Server=DESKTOP-0I5TVMN\SQLEXPRESS;Database=UserPassword");
    public RegForm()
    {
        InitializeComponent();
    }

    private void Registration_OnClick(object sender, RoutedEventArgs e)
    {
        try
        {
            _db.Users.Add(new User
            { 
                Login = TextBoxLogReg.Text,
                Password = TextPassBoxReg
            });
            _db.SaveChanges();
        }
        catch (Exception exception)
        {
            MessageBox.Show(exception.Message);
        }
    }
}