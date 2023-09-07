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
        protected readonly IStartCommand? _stopCommand;
        protected readonly IStopCommand? _startCommand;
        #endregion

        #region Public : Constructor
        public TeamLeader(IStartCommand? stopCommand,
                          IStopCommand? startCommand)
        {
            _startCommand = startCommand;
            _stopCommand = stopCommand;
        }
        #endregion

        #region Public : Methods
        public virtual void AssignmentTask()
        {
            _startCommand?.Execute();
        }
        public virtual void ApproveTask()
        {
            _stopCommand?.Execute();
        }
        #endregion
    }
    #endregion
}