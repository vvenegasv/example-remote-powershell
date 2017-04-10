using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ExampleRemotePowershell.Client
{
    class Program
    {
        static void Main(string[] args)
        {

            Write(">> Ingrese el computador destino: ");
            var computerName = ReadLine().Trim();
            Write(">> Ingrese usuario a utilizar la conexión: ");
            var userName = ReadLine().Trim();

            var script = PowershellResource.PowershellScript;
            script = script.Replace("{computername}", computerName);
            script = script.Replace("{username}", userName);

            using (PowerShell powershell = PowerShell.Create())
            {                
                powershell.AddScript(script);
                var responses = powershell.Invoke();

                foreach(var response in responses)
                {
                    if(response != null)
                    {
                        WriteLine(response.BaseObject);
                    }
                }
            }

            WriteLine("proceso finalizado. presione cualquier tecla para finalizar");
            ReadKey();
        }
    }
}
