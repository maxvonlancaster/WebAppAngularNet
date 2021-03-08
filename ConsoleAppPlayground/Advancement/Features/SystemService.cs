using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPlayground.Advancement.Features
{
    public class SystemService
    {
        public void Main() 
        {
            GetSystemInfo();
        }

        public void GetSystemInfo() 
        {
            // Windows Management Instrumentation (WMI) consists of a set of extensions to the Windows Driver 
            // Model that provides an operating system interface through which instrumented components provide 
            // information and notification. WMI is Microsoft's implementation of the Web-Based Enterprise 
            // Management (WBEM) and Common Information Model (CIM) standards from the Distributed Management 
            // Task Force (DMTF).
            Console.WriteLine("Displaying os info: ");
            ManagementObjectSearcher mos = new ManagementObjectSearcher("select * from Win32_OperatingSystem");
            foreach (ManagementObject managementObject in mos.Get())
            {
                if (managementObject["Caption"] != null)
                {
                    Console.WriteLine("Operating System Name  :  " 
                        + managementObject["Caption"].ToString());   //Display operating system caption
                }
                if (managementObject["OSArchitecture"] != null)
                {
                    Console.WriteLine("Operating System Architecture  :  " 
                        + managementObject["OSArchitecture"].ToString());   //Display operating system architecture.
                }
                if (managementObject["CSDVersion"] != null)
                {
                    Console.WriteLine("Operating System Service Pack   :  " 
                        + managementObject["CSDVersion"].ToString());     //Display operating system version.
                }

                foreach (var property in managementObject.Properties) 
                {
                    Console.WriteLine(property.Name + ": " + property.Value);
                }
            }
        }

        public void GetProcessorInfo() 
        {
            RegistryKey processor_name = Registry.LocalMachine
                .OpenSubKey(@"Hardware\Description\System\CentralProcessor\0", RegistryKeyPermissionCheck.ReadSubTree);   
            //This registry entry contains entry for processor info.

            if (processor_name != null)
            {
                if (processor_name.GetValue("ProcessorNameString") != null)
                {
                    Console.WriteLine(processor_name.GetValue("ProcessorNameString"));   //Display processor info.
                }
            }
        }
    }
}
