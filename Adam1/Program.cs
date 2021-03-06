﻿using System;
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
        // An output port allows you to write (send a signal) to a pin
        static OutputPort _led = new OutputPort(Pins.ONBOARD_LED, false);
        // An input port reads the signal from a pin
        static InputPort _button = new InputPort(Pins.ONBOARD_BTN, true, Port.ResistorMode.Disabled);
        
        public static void Main()
        {
            // write your code here

            // turn the LED off initially
            _led.Write(false);

            // smooth noise out over 5 milliseconds
            Cpu.GlitchFilterTime = new TimeSpan(0, 0, 0, 0, 5);

            // run forever
            while (true)
            {
                // set the onboard LED output to be the input of the button
                _led.Write(_button.Read());
            }

        }
    }
}
