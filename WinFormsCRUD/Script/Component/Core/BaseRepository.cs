namespace WinFormsCRUD.Script.Component.Core;

public abstract class BaseRepository
{
    public event EventHandler DataChanged;
    protected void NotifyDataChanged() => DataChanged?.Invoke(this, EventArgs.Empty);
}
