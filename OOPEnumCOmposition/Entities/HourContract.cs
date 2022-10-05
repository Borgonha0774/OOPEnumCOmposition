
namespace OOPEnumComposition.Entities
{
    internal class HourContract
    {
        public DateTime Date { get; set; }

        public double ValuePerHour { get; set; }

        public int Hour { get; set; }


        public HourContract()
        {
        }

        public HourContract(DateTime data, double valuePerHour, int hour)
        {
            Date = data;
            ValuePerHour = valuePerHour;
            Hour = hour;
        }


        public double TotalValue()
        {
            return ValuePerHour * Hour;
        }
    }
}
