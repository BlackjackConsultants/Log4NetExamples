using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Log4NetExamples {
    class Program {
        static void Main(string[] args) {
            log4net.Config.BasicConfigurator.Configure();
            log4net.ILog log = log4net.LogManager.GetLogger(typeof(Program));

            log.Debug("Hello World!");
            log.Info("I'm a simple log4net tutorial.");
            log.Warn("... better be careful ...");
            log.Error("ruh-roh: an error occurred");
            log.Fatal("OMG we're dooooooomed!");

            Console.ReadLine();  // so you can read the output   

        }
    }
}
