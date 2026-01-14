using WinFormsCRUD.Script.Component.Data;
using WinFormsCRUD.Script.Manager;

namespace WinFormsCRUD.Script.Component.Profile;

public class ProfileController
{
    private readonly ProfileService _profileService;
    private readonly Form1 _mainForm;
    private readonly EventSubscriptionManager _subscriptionManager;
    public ProfileController(Form1 mainForm, ProfileService profileService, EventSubscriptionManager subcriptionManager)
    {
        _mainForm = mainForm;
        _profileService = profileService;
        _subscriptionManager = subcriptionManager;

        _subscriptionManager.Subscribe(
                new List<Action> {
                       () => _mainForm.OnSaveButtonClicked += SaveProfile,
                       () => _mainForm.OnUpdateButtonClicked += UpdateProfile,
                       () => _mainForm.OnDeleteButtonClicked += DeleteProfile,
                       () => _profileService.SubscribeToDataChanged(DataChanged)
                    }
            );

        _subscriptionManager.UnSubscribe(
            new List<Action> {
                       () => _mainForm.OnSaveButtonClicked -= SaveProfile,
                       () => _mainForm.OnUpdateButtonClicked -= UpdateProfile,
                       () => _mainForm.OnDeleteButtonClicked -= DeleteProfile,
                       () => _profileService.UnsubscribeFromDataChanged(DataChanged)
                }
        );

        _mainForm.Initialize(_profileService.GetProfile());
    }
    public void SaveProfile(object? sender, Employee? employee) => _profileService.SaveProfile(employee);
    public void UpdateProfile(object? sender, Employee? employee) => _profileService.UpdateProfile(employee);
    public void DeleteProfile(object? sender, Employee? employee) => _profileService.DeleteProfile(employee);
    public IReadOnlyCollection<Employee> GetProfile(Employee employee) => _profileService.GetProfile();

    private void DataChanged(object? sender, EventArgs e)
    {
        _mainForm.Initialize(_profileService.GetProfile());
    }
}
