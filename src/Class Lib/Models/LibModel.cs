using System;

namespace ClassLib.Models
{
    public class LibModel
    {
        public LibModel()
        {
        }

        public LibModel(string partNumber, string description)
        {
            PartNumber = partNumber ?? throw new ArgumentNullException(nameof(partNumber));
            Description = description ?? throw new ArgumentNullException(nameof(description));

            DisplayName = $"{PartNumber} - {Description}";
        }

        public LibModel(string displayName, string partNumber, string description)
        {
            DisplayName = displayName ?? throw new ArgumentNullException(nameof(displayName));
            PartNumber = partNumber ?? throw new ArgumentNullException(nameof(partNumber));
            Description = description ?? throw new ArgumentNullException(nameof(description));
        }

        public string? Description { get; set; }
        public string? DisplayName { get; set; }
        public Guid Id { get; } = Guid.NewGuid();
        public string? PartNumber { get; set; }
    }
}