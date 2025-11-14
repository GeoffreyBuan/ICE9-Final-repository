namespace ICE9
{
    internal static class Program
    {
        
        
        public enum FormType
        {
            Splash,
            Start,
            Next,
            Final,
            About
        }
        public static List<Form> Forms;

            public static SplashForm SplashForm;
            public static SelectionForm SelectionForm;
            public static NextForm NextForm;
            public static FinalForm FinalForm;
            public static AboutForm AboutForm;
            [STAThread]
            static void Main()
            {
            SplashForm = new SplashForm();
            SelectionForm = new SelectionForm();
            NextForm = new NextForm();
            FinalForm = new FinalForm();
            AboutForm = new AboutForm();
            Forms =
            [
             SplashForm,
             SelectionForm,
             NextForm,
            FinalForm,
            NextForm,
             AboutForm
             ] ;
            ApplicationConfiguration.Initialize();
                Application.Run(new SelectionForm());
            }
        }
    }
