namespace Contracts
{
    public interface IReceiver
    {
        Task DoTask();
        Task FixBug();
    }
}