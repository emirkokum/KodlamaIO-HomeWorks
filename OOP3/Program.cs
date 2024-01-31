using OOP3;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        ICreditManager personalCreditManager = new PersonalCreditManager();
        ICreditManager vehicleCreditManager = new VehicleCreditManager();
        ICreditManager housingCreditManager = new HousingCreditManager();

        ILoggerService databaseLoggerService = new DatabaseLoggerService();
        ILoggerService fileLoggerService = new FileLoggerService();
        
        ApplicationManager applicationManager = new ApplicationManager();

        // applicationManager.MakeApplication(housingCreditManager, fileLoggerService);
        // Console.WriteLine("----------------");
        applicationManager.MakeApplication(vehicleCreditManager, databaseLoggerService);


        List<ICreditManager> creditList = new List<ICreditManager>() {personalCreditManager, housingCreditManager, vehicleCreditManager };

        //applicationManager.GiveCreditInformation(creditList);

    }
}