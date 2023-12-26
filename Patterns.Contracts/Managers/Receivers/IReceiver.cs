namespace Patterns.Contracts.Managers.Receivers
{
    public interface IReceiver
    {
        Task DoTask();
        Task FixBug();
    }
}