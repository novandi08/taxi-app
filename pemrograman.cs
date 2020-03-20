using System;
using System.Collction.Generic;
using System.Ling;
using System.Threading.tasks;

namespace TugasClassDanObject
{
	class premrograman
	{
		static void main(string[] args)
		{
			Taxi taxi = new taxi();
			taxi.DriverName = "novandi";
			taxi.OnDuty = true;
			taxi.NumPassenger = 10;

			taxi.Taxiinfo();
			taxi.PickUpPassenger();
			taxi.DropOffPassenger();

			Console.ReadyKey();



		}
	}
}



