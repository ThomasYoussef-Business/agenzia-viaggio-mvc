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
        public string ImageUrl { get; set; }
        [Range(0, int.MaxValue)]
        public int DaysDuration { get; set; }
        [Range(0, int.MaxValue)]
        public int Destinations { get ; set; }
        [Range(0, double.MaxValue)]
        public double CostPerPerson { get; set; }
    }
}
