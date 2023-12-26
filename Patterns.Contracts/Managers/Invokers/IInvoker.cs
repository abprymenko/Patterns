namespace Patterns.Contracts.Managers.Invokers
{
    public interface IInvoker
    {
        Task AssignmentTask();
        Task ApproveTask();
    }
}