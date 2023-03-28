namespace ClickerMain
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            int playerHealth = 100, playerDamage = 2, critChance = 0, level = 1, enemyLevel = 1, enemyReward = 100;

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            ApplicationConfiguration.Initialize();
            
            int timer = playerHealth / 20;
            Application.Run(new DefeatClickerForm(timer, playerHealth, playerDamage, critChance, level, enemyLevel, enemyReward));
            
        }    
    }
}