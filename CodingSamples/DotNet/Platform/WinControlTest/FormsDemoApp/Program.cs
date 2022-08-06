namespace FormsDemoApp;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
     //initialize a single thread apartment for the main thread
    //which is required by a component object which does not perform thread
    //synchronization to avoid its performance over-head. Such an apartment
    //contains exactly one thread which can directly consume an interface
    //exposed by an object activated within that apartment while other threads
    //must do so by sending messages to this thread.
    [STAThread] 
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        Application.Run(new MainForm()); //display MainForm and start message-dispatch loop
    }    
}