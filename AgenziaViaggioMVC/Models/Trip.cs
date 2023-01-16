namespace AgenziaViaggioMVC.Models {
    [Table(nameof(Trip))]
    public class Trip {

        [Key]
        public int Id { get; set; }

        [MaxLength(64, ErrorMessage = "Il titolo non può essere più lungo di 64 caratteri")]
        public string Title { get; set; }

        [MaxLength(256, ErrorMessage = "La descrizione non può essere più lunga di 256 caratteri")]
        public string Description { get; set; }

        [MaxLength(128)]
        [StartsWith("https://", "./img/")]
        [EndsWith(".png", ".jpg", ".jpeg", ".webp")]
        public string ImageUrl { get; set; }

        [Range(0, int.MaxValue)]
        public int DaysDuration { get; set; }

        [Range(0, int.MaxValue)]
        public int Destinations { get ; set; }

        [Range(0, double.MaxValue)]
        public double CostPerPerson { get; set; }
    }
}
