namespace WinFormsCRUD.Script.Manager;

public class EventSubscriptionManager
{
    private readonly List<Action> _unsubscribeActions = new List<Action>();
    private bool _isDisposed;

    /// <summary>
    /// Registers a subscription by performing the subscribe action and saving the corresponding unsubscribe action.
    /// </summary>
    /// <param name="subscribeActions">The action to subscribe to an event.</param>
    /// <param name="unsubscribeAction">The action to unsubscribe from that event.</param>
    public void Subscribe(List<Action> subscribeActions)
    {
        foreach (var subscription in subscribeActions)
        {
            subscription?.Invoke();
        }
    }

    public void UnSubscribe(List<Action> unsubscribeAction) => _unsubscribeActions.AddRange(unsubscribeAction);

    /// <summary>
    /// Unsubscribes from all registered events.
    /// </summary>
    public void Dispose()
    {
        if (!_isDisposed)
        {
            // Execute all unsubscription actions.
            foreach (var unsubscribe in _unsubscribeActions)
            {
                unsubscribe();
            }
            _unsubscribeActions.Clear();
            _isDisposed = true;
        }
    }
}
