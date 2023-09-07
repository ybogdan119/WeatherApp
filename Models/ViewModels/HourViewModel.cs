namespace WeatherApp.Models.ViewModels
{
    public class HourViewModel
    {
        public string Time { get; set; } = string.Empty;
        public float Temperature { get; set; }
        public string TimeOfDay => DateTime.Parse(Time).ToString("HH:mm");
    }
}
