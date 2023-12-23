namespace Invokers
{
    #region Usings
    using Contracts;
    #endregion

    #region TeamLeader class
    /// <summary>
    /// Command initiator. Invokes a command to execute a specific request.
    /// </summary>
    internal class TeamLeader : IInvoker
    {
        #region Private : Fields
        protected readonly IStartCommand? _startCommand;
        protected readonly IStopCommand? _stopCommand;
        #endregion

        #region Public : Constructor
        public TeamLeader(IStartCommand? startCommand,
                          IStopCommand? stopCommand)
        {
            _startCommand = startCommand;
            _stopCommand = stopCommand;
        }
        #endregion

        #region Public : Methods
        public virtual async Task AssignmentTask()
        {
            try
            {
                if(_startCommand is null)
                    throw new ArgumentNullException(nameof(_startCommand));
                await _startCommand.Execute();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public virtual async Task ApproveTask()
        {
            try
            {
                if(_stopCommand is null)
                    throw new ArgumentNullException(nameof(_stopCommand));
                await _stopCommand.Execute();
                Console.WriteLine("Approving the task...");
                Thread.Sleep(TimeSpan.FromMinutes(1));
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