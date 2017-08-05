using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NLog;
using System.Configuration;

namespace nlog1
{
    class Program
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        static void Main(string[] args)
        {
            bool terminado = false;
            string appSettings_version = ConfigurationManager.AppSettings["version"];

            Console.WriteLine("Version {0}",appSettings_version);
            
            Console.Out.WriteLine("Hit ESC to exit");

            do
            {
                if (Console.KeyAvailable)
                {
                    if (Console.ReadKey(true).Key == ConsoleKey.Escape)
                    {
                        //...
                        terminado = true;
                    }
                }
                logger.Trace("Trace: The chatter of people on the street");
                logger.Debug("Debug: Where are you going and why?");
                logger.Info("Info: What bus station you're at.");
                logger.Warn("Warn: You're playing on the phone and not looking up for your bus");
                logger.Error("Error: You get on the wrong bus.");
                logger.Fatal("Fatal: You are run over by the bus.");

            }
            while (!terminado);
        }
    }
}




/*
<nlog xmlns="http://www.nlog-project.org/schemas/NLog.xsd"
      xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance">

  <targets async="true">
    <target name="gmail" xsi:type="Mail"
            smtpServer="smtp.gmail.com"
            smtpPort="587"
            smtpAuthentication="Basic"
            smtpUserName="ikernaix@gmail.com"
            smtpPassword="miclave"
            enableSsl="true"
            from="ikernaix@gmail.com"
            to="ikernaix@gmail.com"
            cc=""
          />
  </targets>

  <rules>
    <logger name="*" minlevel="Debug" writeTo="gmail" />
  </rules>
</nlog>
*/