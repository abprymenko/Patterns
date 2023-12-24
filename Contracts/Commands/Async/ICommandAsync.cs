namespace Contracts.Commands.Async
{
    public interface ICommandAsync
    {
        Task Execute();
    }
}