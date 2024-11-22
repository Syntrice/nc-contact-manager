namespace ContactManager.Data
{
    public class DataValidator<T>
    {
        private List<(Predicate<T> Rule, String Message)> _rules;

        public DataValidator()
        {
            _rules = new List<(Predicate<T> Rule, string Message)>();
        }

        public DataValidator(IEnumerable<(Predicate<T> Rule, string Message)> rules)
        {
            _rules = new List<(Predicate<T> Rule, string Message)>(rules);
        }

        public void AddRule(Predicate<T> rule, string description)
        {
            _rules.Add((rule, description));
        }

        public ValidationResult Validate(T value)
        {
            List<string> messages = new List<string>();
            bool isValid = true;
            for (int i = 0; i < _rules.Count; i++)
            {
                if (!_rules[i].Rule(value))
                {
                    messages.Add(_rules[i].Message);
                    isValid = false;
                }
            }

            return new ValidationResult(isValid, messages.ToArray());
        }

    }
}
