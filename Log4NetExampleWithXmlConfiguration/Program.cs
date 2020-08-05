using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using log4net.Config;
using log4net;

namespace Log4NetExampleWithXmlConfiguration {
    class Program {
        protected static readonly ILog log = LogManager.GetLogger(typeof(Program));
        static void Main(string[] args) {
            XmlConfigurator.Configure();
            log.Warn("sadi the great");
        }
    }
}
