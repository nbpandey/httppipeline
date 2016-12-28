using System.Runtime.InteropServices;

namespace DemoApp
{
    public class RuntimeMessage : IMesssage
    {
        public string Info()
        {
            return $@"
                    OS Description:       {RuntimeInformation.OSDescription}
                    OS Architecture:      {RuntimeInformation.OSArchitecture}
                    Framework:            {RuntimeInformation.FrameworkDescription}
                    Process Architecture: {RuntimeInformation.ProcessArchitecture}";
        }
    }
}