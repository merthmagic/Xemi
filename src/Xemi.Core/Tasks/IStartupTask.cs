namespace Xemi.Core.Tasks
{
    public interface IStartupTask
    {
        void Execute();

        int Order { get; }
    }
}