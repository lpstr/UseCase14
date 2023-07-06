namespace UseCase14.Models
{
    public class UnitsViewModel
    {
        public string UnitType { get; set; }
        public double Value { get; set; }
        public bool Reverse { get; set; }
        public string ConvertedValue { get; set; }

        // Display Names for dropdown options
        public string InchesToCentimeters { get; set; }
        public string CentimetersToInches { get; set; }
        public string PoundsToKilograms { get; set; }
        public string KilogramsToPounds { get; set; }
        public string LitersToOunces { get; set; }
        public string OuncesToLiters { get; set; }
    }
}
