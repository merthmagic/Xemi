namespace Xemi.Core.Configuration
{
    public class XemiEnvConfig
    {
        private readonly IConfigResolver _resolver;

        private const string ENGINE_TYPE_CONFIG_KEY = "Xemi:EngineType";

        public XemiEnvConfig()
        {
            _resolver = ConfigResolver.Current;
        }

        public string EngineType
        {
            get { return _resolver.GetConfig(ENGINE_TYPE_CONFIG_KEY); }
        }
    }
}