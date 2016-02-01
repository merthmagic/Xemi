using System;
using System.Configuration;
using System.Runtime.CompilerServices;
using Xemi.Core.Configuration;
using Xemi.Core.Utils;

namespace Xemi.Core
{
    public class EngineContext
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        public static IEngine Initialize(bool forceRecreate = false)
        {
            if (Singleton<IEngine>.Instance == null || forceRecreate)
            {
                Singleton<IEngine>.Instance = CreateEngineInstance(EnvConfiguration);
            }
            return Singleton<IEngine>.Instance;
        }

        public static IEngine CreateEngineInstance(XemiEnvConfig envConfig)
        {
            if (envConfig == null || string.IsNullOrEmpty(envConfig.EngineType))
                throw new ApplicationException(
                    "Intialize failure cause the context can not get a proper engine type from configuration.");

            var engineType = Type.GetType(envConfig.EngineType);

            if (engineType == null)
                throw new ConfigurationErrorsException(string.Format("The engine type '{0}' can not be found.", envConfig.EngineType));
            if (!typeof(IEngine).IsAssignableFrom(engineType))
                throw new ConfigurationErrorsException(string.Format("The engine type '{0}' doesn't implement 'Xemi.Core.IEngine'", envConfig.EngineType));

            return Activator.CreateInstance(engineType) as IEngine;
        }

        public static IEngine Current
        {
            get
            {
                if (Singleton<IEngine>.Instance == null)
                    Initialize();
                return Singleton<IEngine>.Instance;
            }
        }

        public static XemiEnvConfig EnvConfiguration
        {
            get
            {
                if (Singleton<XemiEnvConfig>.Instance == null)
                    LoadEnvConfiguration();
                return Singleton<XemiEnvConfig>.Instance;
            }
        }

        private static void LoadEnvConfiguration()
        {
            Singleton<XemiEnvConfig>.Instance = new XemiEnvConfig();
        }

        public static XemiEnvConfig EnvConfig
        {
            get
            {
                if (Singleton<XemiEnvConfig>.Instance == null)
                    LoadEnvConfiguration();
                return Singleton<XemiEnvConfig>.Instance;
            }
        }
    }
}
