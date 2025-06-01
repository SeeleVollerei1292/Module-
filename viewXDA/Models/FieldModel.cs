namespace viewXDA.Models
{
    public class FieldModel
    {
        public string Name { get; set; }
        public string District { get; set; }
        public string ImageUrl { get; set; }
        public string Distance { get; set; } = "0.0 km";
        public double Rating { get; set; } = 0;
        public string OpenHours { get; set; } = "05:00 - 22:00";
    }
}
