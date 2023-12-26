namespace Patterns.Managers.Commands.Async
{
    #region Usings
    using Patterns.Extensions;
    using Patterns.Contracts.Managers.Commands.Async;
    using Patterns.Contracts.Managers.Receivers;
    #endregion

    #region ApproveCommandAsync
    internal class ApproveCommandAsync : BaseCommandAsync, IApproveCommandAsync
    {
        #region Public : Constructor
        public ApproveCommandAsync(IReceiver receiver) : base(receiver)
        {
        }
        #endregion

        #region Public : Methods
        public virtual async Task Execute()
        {
            try
            {
                Console.WriteLine("The team leader has started to approve the task");
                Console.WriteLine("Approving the task...");
                Thread.Sleep(TimeSpan.FromSeconds(30));
                var hasBug = false;
                hasBug = hasBug.CheckAnswer("Has the code bug?[Y/N]: ");
                if (hasBug)
                    await _receiver.FixBug();
                Console.WriteLine("The team leader has finished to approve the task");
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion
    }
    #endregion
}