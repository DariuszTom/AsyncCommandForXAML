using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AsyncCommandForXAML.Commands
{
    /// <summary>
    /// Defines a command that executes an asynchronous method.
    /// </summary>
    public interface IAsyncCommand : ICommand
    {
        /// <summary>
        /// Gets a value indicating whether a task executed by this command is still running.
        /// </summary>
        IEnumerable<Task> RunningTasks
        {
            get;
        }

        /// <inheritdoc cref="ICommand.CanExecute" />
        bool CanExecute();

        /// <summary>
        /// Defines an asynchronous method to be called when the command is invoked. 
        /// </summary>
        /// <returns>Returns an asynchronous operation.</returns>
        Task ExecuteAsync();
    }
}
