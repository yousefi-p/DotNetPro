namespace PhoneBook
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Main());


        }

        public class Contact
        {
            public string First_Name { get; set; }
            public string Last_Name { get; set;}
            public string HomeNumber { get; set; }
            public string CellPhone { get; set; }
            public string OfficeNumber { get; set;}
            public string Address { get; set; }
        }
    }
}