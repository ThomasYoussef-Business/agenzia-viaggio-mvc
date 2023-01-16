namespace AgenziaViaggioMVC.Models {
    [Table(nameof(Trip))]
    public class Trip {

        [Key]
        public int Id { get; set; }

        [MaxLength(64)]
        public string Title { get; set; }

        [MaxLength(256)]
        public string Description { get; set; }

        [Url]
        [MaxLength(128)]
        [EndsWith(".png", ".jpg", ".jpeg", ".webp")]
        public string ImageUrl { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "La durata del viaggio non può avere un valore negativo")]
        
        public int DaysDuration { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Il viaggio non può avere un numero di destinazioni negativo")]
        public int Destinations { get ; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Il prezzo della vacanza non può essere negativo")]
        public double CostPerPerson { get; set; }
    }
}
