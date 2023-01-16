namespace AgenziaViaggioMVC.Models {
    [Table(nameof(Trip))]
    public class Trip {

        [Key]
        public int Id { get; set; }

        [MaxLength(64, ErrorMessage = "Il titolo non può essere più lungo di 64 caratteri")]
        public string Title { get; set; }

        [MaxLength(256, ErrorMessage = "La descrizione non può essere più lunga di 256 caratteri")]
        public string Description { get; set; }

        [MaxLength(128, ErrorMessage = "L'URL dell'immagine non può essere più lungo di 128 caratteri")]
        [StartsWith("https://", "./img/", ErrorMessage = "L'URL provveduto deve iniziare con \"https://\" oppure \"./img/\"")]
        [EndsWith(".png", ".jpg", ".jpeg", ".webp", ErrorMessage = "L'URL provveduto deve finire con"
                                                                   + @""".png"", "".jpg"","".jpeg"" oppure "".webp""")]
        public string ImageUrl { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "La durata del viaggio non può avere un valore negativo")]
        
        public int DaysDuration { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Il viaggio non può avere un numero di destinazioni negativo")]
        public int Destinations { get ; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Il prezzo della vacanza non può essere negativo")]
        public double CostPerPerson { get; set; }
    }
}
