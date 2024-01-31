using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class ApplicationManager
    {
        // parametre Interface type ı olarak yollandığı için ona bağlı olan 
        // hangi class yollandıysa hesaplamayı ona göre yapabilir.
        // Method Injection
        public void MakeApplication(ICreditManager creditManager, ILoggerService loggerService)
        {
            // application evaluation
            // code blocks

            creditManager.Calculate();
            loggerService.Log();
        }

        public void GiveCreditInformation(List<ICreditManager> credits)
        {
            foreach (var credit in credits)
            {
                credit.Calculate();
            }
        }

    }
}
