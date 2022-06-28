namespace Joels_Rom_Tools
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var testWorkflow = new Workflows.CombineBinsWorkflow(@"D:\Sony Playstation\Air Combat\Air Combat (USA).cue",
                @"D:\Sony Playstation\Air Combat\Air Combat New.cue",
                @"D:\Sony Playstation\Air Combat\Air Combat New.bin");

            Task.Run(()=>testWorkflow.StartAsync(null,null)).Wait();

            //// To customize application configuration such as set high DPI settings or default font,
            //// see https://aka.ms/applicationconfiguration.
            //ApplicationConfiguration.Initialize();
            //Application.Run(new Form1());
        }
    }
}