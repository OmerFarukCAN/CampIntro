using OOP3;

internal class Program
{
    private static void Main(string[] args)
    {
        IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
        TasitKrediManager tasitKrediManager = new TasitKrediManager();
        KonutKrediManager konutKrediManager = new KonutKrediManager();

        ILoggerService dataBaseLoggerService = new DatabaseLoggerService();
        ILoggerService fileLoggerService = new FileLoggerService();
        ILoggerService emailLoggerService = new EmailLoggerService();

        List<ILoggerService> loggerServices = new List<ILoggerService>() { dataBaseLoggerService, fileLoggerService };

        BasvuruManager basvuruManager = new BasvuruManager();
        basvuruManager.BasvuruYap(ihtiyacKrediManager, loggerServices);
        basvuruManager.BasvuruYap(tasitKrediManager, new List<ILoggerService> { new EmailLoggerService() });
        basvuruManager.BasvuruYap(konutKrediManager, new List<ILoggerService> { new EmailLoggerService(), new DatabaseLoggerService() });

        Console.WriteLine("-------------------------");

        List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager, tasitKrediManager };
        basvuruManager.KrediOnBilgilendirmesiYap(krediler);
    }
}