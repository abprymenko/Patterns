namespace Contracts
{
    public interface IReceiver
    {
        Task StartTask();
        void StopTask();
    }
}