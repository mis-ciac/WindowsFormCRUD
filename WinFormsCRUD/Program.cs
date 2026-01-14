using System.Configuration;
using WinFormsCRUD.Script.Component.Profile;
using WinFormsCRUD.Script.Globals;
using WinFormsCRUD.Script.Manager;

namespace WinFormsCRUD;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        ConnectionConfig.ConnectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;

        var _mainForm = new Form1();
        var _eventSubscriptionManager = new EventSubscriptionManager();
        var _profileRepository = new ProfileRepository();
        var _profileService = new ProfileService(_profileRepository);
        var _profileController = new ProfileController(_mainForm, _profileService, _eventSubscriptionManager);

        
        Application.Run(_mainForm);

        /*try
        {
            ConnectionConfig.ConnectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;

            var _mainForm = new Form1();
            var _eventSubscriptionManager = new EventSubscriptionManager();
            var _profileRepository = new ProfileRepository();
            var _profileService = new ProfileService(_profileRepository);
            var _profileController = new ProfileController(_mainForm, _profileService, _eventSubscriptionManager);

            ApplicationConfiguration.Initialize();
            Application.Run(_mainForm);

        }
        catch (Exception ex)
        {
            File.WriteAllText("error.log", ex.ToString());
        }*/




    }
}