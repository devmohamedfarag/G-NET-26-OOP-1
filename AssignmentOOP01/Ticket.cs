namespace AssignmentOOP01

{
    public class Ticket
    {
        public string? MovieName { get; set; }
        public TicketType Type { get; set; }
        public SeatLoctaion Seat { get; set; }
        private double Price { get; set; }

        public Ticket(string? movieName, TicketType type, SeatLoctaion seatNumber, double price)
        {
            MovieName = movieName;
            Type = type;
            Seat = seatNumber;
            Price = price;
        }

        public Ticket(string movieName)
                                   : this(movieName, TicketType.Standard, new SeatLoctaion('A', 1), 50)
        {
        }

        public double CalcTotal(double taxPercent)
        {
            return Price + (Price * taxPercent / 100);
        }

        public void ApplyDiscount(ref double discountAmount)
        {
            if (discountAmount > 0 && discountAmount <= Price)
            {
                Price -= discountAmount;
                discountAmount = 0;
            }
        }

        public void PrintTicket(double taxPercent)
        {
            Console.WriteLine($"Movie: {MovieName}");
            Console.WriteLine($"Type: {Type}");
            Console.WriteLine($"Seat: {Seat}");
            Console.WriteLine($"Price: {Price:C}");
            Console.WriteLine($"Total ({taxPercent}% tax) : {CalcTotal(taxPercent):F2}");
        }
    }
}
