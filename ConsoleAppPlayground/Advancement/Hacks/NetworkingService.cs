using NativeWifi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPlayground.Advancement.Hacks
{
    public class NetworkingService
    {
        public void Main() 
        {
            GetAllNetworks();
        }

        // get all the available networks:
        public void GetAllNetworks() 
        {
            WlanClient client = new WlanClient();
            foreach (WlanClient.WlanInterface wlanIface in client.Interfaces)
            {
                // Lists all available networks
                Wlan.WlanAvailableNetwork[] networks = wlanIface.GetAvailableNetworkList(0);
                foreach (Wlan.WlanAvailableNetwork network in networks)
                {
                    Console.WriteLine("Found network with SSID {0}.", GetStringForSSID(network.dot11Ssid));
                }
            }
        }

        private string GetStringForSSID(Wlan.Dot11Ssid dot11Ssid)
        {
            return Encoding.ASCII.GetString(dot11Ssid.SSID, 0, (int)dot11Ssid.SSIDLength);
        }
    }
}
