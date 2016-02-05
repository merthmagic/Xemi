# Xemi

Lightweight application platform for web apps focus on e-business.

[![Build status](https://ci.appveyor.com/api/projects/status/yolxx52mwfnl66pn?svg=true)](https://ci.appveyor.com/project/yimlu/xemi)

### Engine Initialize Process
1. Setup env config via `ConfigResolver.SetResolver` if a custom config resolver is required
2. Run `EngineContext.Initialize` method

The `EngineContext` will read configurations from `XemiEnvConfig` and create the instance of `IDependencyManager` which will do the IoC job,and then create a `IEngine` instance.`IEngine` instance will run module initialize methods and startup tasks automatically.