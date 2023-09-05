namespace SnappEntities
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string BankAccountNumber { get; set; }
        private int WalletId { get; set; }
        public float WalletTotal { get; set; }
    }

    public class Customer : Person
    {
        public bool OrderCar(string customerPhoneNumber) { }
        public bool CancelOrder(string driverPhoneNumber) { }
        public bool ChargeWallet(int walletId, float walletTotal, float amount) { }
        public bool Withdraw(string bankAccountNumber, float walletTotal) { }
    }

    public class Driver : Person
    {
        public string CarModel { get; set; }
        public string CarNumber { get; set; }
        public int DrivingLicenseNumber { get; set; }
        public int CarManufacturyYear { get; set; }
        public string CarManufactoryName { get; set; }

        public bool AcceptRequest(string driverPhoneNumber) { }
        public bool CancelRequest(string customerPhoneNumber) { }
        public bool Withdraw(string bankAccountNumber, float walletTotal) { }
    }

    public class Journey
    {
        public string StartLong { get; set; }
        public string StartLat { get; set; }
        public string EndLong { get; set; }     
        public string EndLat { get; set; }
        public int CustomerId { get; set; }
        public string DriverId { get; set; }

        public float ClaculateJourneyPrice(string startLong, string startLat, string endLong, string endLat) { }
        public void RecordJourney(int customerId, int driverId, float journeyPrice) { }
    }
}