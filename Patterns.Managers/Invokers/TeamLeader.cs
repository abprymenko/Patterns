namespace Patterns.Managers.Invokers
{
    #region Usings
    using Patterns.Contracts.Managers.Commands.Async;
    using Patterns.Contracts.Managers.Invokers;
    #endregion

    #region TeamLeader
    /// <summary>
    /// Command initiator. Invokes a command to execute a specific request.
    /// </summary>
    internal class TeamLeader : IInvoker
    {
        #region Private : Fields
        protected readonly IStartCommandAsync? _startCommandAsync;
        protected readonly IApproveCommandAsync? _approveCommandAsync;
        #endregion

        #region Public : Constructor
        public TeamLeader(IStartCommandAsync? startCommandAsync,
                          IApproveCommandAsync? approveCommandAsync)
        {
            _startCommandAsync = startCommandAsync;
            _approveCommandAsync = approveCommandAsync;
        }
        #endregion

        #region Public : Methods
        public virtual async Task AssignmentTask()
        {
            try
            {
                if (_startCommandAsync is null)
                    throw new ArgumentNullException(nameof(_startCommandAsync));
                await _startCommandAsync.Execute();
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
                if (_approveCommandAsync is null)
                    throw new ArgumentNullException(nameof(_approveCommandAsync));
                await _approveCommandAsync.Execute();
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