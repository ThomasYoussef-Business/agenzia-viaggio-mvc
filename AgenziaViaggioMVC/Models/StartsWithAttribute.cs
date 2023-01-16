namespace AgenziaViaggioMVC.Models {
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
    sealed public class StartsWithAttribute : ValidationAttribute {
        public string[] ValidEnds { get; init; }
        public StartsWithAttribute(params string[] validStarts) {
            ValidEnds = validStarts;
        }

        protected override ValidationResult IsValid(object? value, ValidationContext validationContext) {
            if (value is not string castedValue) { return new ValidationResult("Il valore inserito non è una valida stringa."); }

            foreach (string validEnd in ValidEnds) {
                if (castedValue.StartsWith(validEnd)) { return ValidationResult.Success; }
            }

            return new ValidationResult($"Il valore inserito non inizia con una delle seguenti stringhe:" +
                $"{string.Join(", ", ValidEnds)}");
        }
    }
}
