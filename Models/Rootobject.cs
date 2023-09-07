namespace WeatherApp.Models
{
    public class Rootobject
    {
        public Location? Location { get; set; }
        public Current? Current { get; set; }
        public Forecast? forecast { get; set; }
    }
}
