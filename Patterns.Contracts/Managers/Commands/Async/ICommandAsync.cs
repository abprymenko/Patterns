namespace Patterns.Contracts.Managers.Commands.Async
{
    public interface ICommandAsync
    {
        Task Execute();
    }
}