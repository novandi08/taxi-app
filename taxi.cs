public class Taxi{
	public string DriverName;
	public stiing OnDuty;
	public char NumPassenger;

	//method
	public void TaxiInfo(){
		Console.WriteLine("DriveName: ", DriverName);
		Console.WriteLine("OnDuty: ", OnDuty);
		Console.WriteLine("Number Of Passenger:", NumPassenger)
	}

	public void PickUpPassenger(){
		Console.WriteLine("{0} Sedang Menjemput Penumpang", DriverName);
	}

	public void dropOffPassenger(){
		Console.WriteLine("{0} Selesai Mengantar Penumpang", DriverName);
	}
}

	





 


