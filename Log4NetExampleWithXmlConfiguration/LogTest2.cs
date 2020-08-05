using log4net;
using log4net.Config;

namespace Log4NetExampleWithXmlConfiguration {
static public class LogTest2
{
	private static readonly ILog logger = LogManager.GetLogger(typeof(LogTest2));
	
	static LogTest2()
	{
		DOMConfigurator.Configure();
	}

	static void Main(string[] args)
	{
		logger.Debug("Here is a debug log.");
		logger.Info("... and an Info log.");
		logger.Warn("... and a warning.");
		logger.Error("... and an error.");
		logger.Fatal("... and a fatal error.");
	}
}
}
