namespace AssignmentOOP01
{
    public struct SeatLoctaion
    {
        public char Row { get; set; }   
        public int Number { get; set; }

        public SeatLoctaion(char row, int number)
        {
            Row = row;
            Number = number;
        }

        public override string ToString()
        {
            return $"{Row}{Number}";
        }
    }
}
// We Use struct for SeatLocation because it is a simple data structure that represents a specific location in the theater.