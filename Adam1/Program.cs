using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using Microsoft.SPOT;
using Microsoft.SPOT.Hardware;
using SecretLabs.NETMF.Hardware;
using SecretLabs.NETMF.Hardware.Netduino;

namespace Adam1
{
    public class Program
    {
        public static void Main()
        {
            // write your code here
            OutputPort led = new OutputPort(Pins.ONBOARD_LED, false);
            /*while (true)
            {
                led.Write(true); // turn on the LED
                Thread.Sleep(250); // sleep for 250ms
                led.Write(false); // turn off the LED
                Thread.Sleep(250); // sleep for 250ms
            }*/

        }

    }
}
