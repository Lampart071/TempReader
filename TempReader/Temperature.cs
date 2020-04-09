namespace TempReader
{
    public class Temperature
    {
        public string Date { get; }
        public string Time { get; }
        public float Temp1 { get; }
        public float Temp2 { get; }

        public Temperature(string date, string time, float temp1, float temp2)
        {
            this.Date = date;
            this.Time = time;
            this.Temp1 = temp1;
            this.Temp2 = temp2;
        }
    }
}