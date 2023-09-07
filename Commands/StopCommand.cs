namespace Commands
{
    #region Usings
    using Contracts;
    #endregion

    #region StopCommand
    /// <summary>
    /// Concrete implementation of the command, implements the Execute() method.
    /// </summary>
    internal class StopCommand : BaseCommand, IStopCommand
    {
        #region Constructor : Public
        public StopCommand(IReceiver receiver) : base(receiver) {}
        #endregion

        #region Methods : Public
        public void Execute()
        {
            _receiver.StopTask();
        }
        #endregion
    }
    #endregion
}