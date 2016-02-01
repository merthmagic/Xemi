namespace Xemi.Core.Configuration
{
    public interface IConfigResolver
    {
        string GetConfig(string key);
    }
}