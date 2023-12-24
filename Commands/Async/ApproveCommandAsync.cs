namespace Commands.Async
{
    #region Usings
    using Contracts;
    using Contracts.Commands.Async;
    using Extensions;
    #endregion

    #region ApproveCommandAsync
    internal class ApproveCommandAsync : BaseCommand, IApproveCommandAsync
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
                Console.WriteLine("Do anything else...");
                Thread.Sleep(TimeSpan.FromMinutes(1));
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