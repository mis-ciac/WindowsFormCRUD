using WinFormsCRUD.Script.Component.Data;

namespace WinFormsCRUD.Script.Component.Profile;

public class ProfileService
{
    private readonly ProfileRepository _profileRepository;

    public ProfileService(ProfileRepository profileRepository)
    {
        _profileRepository = profileRepository;
    }

    public void SaveProfile(Employee? employee)
    {
        if (employee == null) return;

        _profileRepository.SaveProfile(employee);
    }
    public void UpdateProfile(Employee? employee)
    {
        if (employee == null) return;

        _profileRepository.UpdateProfile(employee);
    }
    public void DeleteProfile(Employee? employee)
    {
        if (employee == null) return;

        _profileRepository.DeleteProfile(employee);
    }

    public IReadOnlyCollection<Employee> GetProfile() => _profileRepository.GetAllProfile();
    public void SubscribeToDataChanged(EventHandler handler) => _profileRepository.DataChanged += handler;
    public void UnsubscribeFromDataChanged(EventHandler handler) => _profileRepository.DataChanged -= handler;

    
}
