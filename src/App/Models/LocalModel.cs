namespace App.Models
{
    public class LocalModel
    {
        public LocalModel()
        {
        }

        public LocalModel(string givenName, string surname)
        {
            GivenName = givenName ?? throw new ArgumentNullException(nameof(givenName));
            Surname = surname ?? throw new ArgumentNullException(nameof(surname));

            DisplayName = $"{this.Surname}, {this.GivenName}";
        }

        public LocalModel(string displayName, string givenName, string surname)
        {
            DisplayName = displayName ?? throw new ArgumentNullException(nameof(displayName));
            GivenName = givenName ?? throw new ArgumentNullException(nameof(givenName));
            Surname = surname ?? throw new ArgumentNullException(nameof(surname));
        }

        public string? DisplayName { get; set; }
        public string? GivenName { get; set; }
        public Guid Id { get; } = Guid.NewGuid();
        public string? Surname { get; set; }
    }
}