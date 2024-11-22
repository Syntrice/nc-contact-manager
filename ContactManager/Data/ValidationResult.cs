namespace ContactManager.Data
{

    public class ValidationResult
    {
        public bool IsValid { get; }
        public string[] Messages { get; }

        public ValidationResult(bool isValid, string[] messages)
        {
            IsValid = isValid;
            Messages = messages;
        }

        public static ValidationResult Success()
        {
            return new ValidationResult(true, new string[0]);
        }
    }
}
