namespace Commands
{
    #region Usings
    using Contracts;
    #endregion

    #region StartCommand class
    /// <summary>
    /// Concrete implementation of the command, implements the Execute() method.
    /// </summary>
    internal class StartCommand : BaseCommand, IStartCommand
    {
        #region Public : Constructor
        public StartCommand(IReceiver receiver) : base(receiver){}
        #endregion

        #region Public : Methods
        public virtual void Execute()
        {
            _receiver.StartTask();
        }
        #endregion
    }
    #endregion
}