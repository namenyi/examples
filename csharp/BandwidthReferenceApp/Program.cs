﻿using System;
using Controllers;
using Enviroment;

using static Eagle.Server;


namespace BandwidthExample
{
    class Program
    {

        static void Main(string[] args)
        {

			Properties.configure("./local.props");

			port("8080");

			MessageController.listMedia();

			MessageController.listenReplyToMessage();

        	VoiceController.letsPlayAGame();
        	VoiceController.callMeMessage();
        	VoiceController.gatherAndTransfer();
		
            Console.Read();

        }

		
      
    }
}
