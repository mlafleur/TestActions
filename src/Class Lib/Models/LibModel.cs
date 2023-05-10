using System;

namespace ClassLib.Models
{
    /// <summary>
    /// Represents a model in the lib example project
    /// </summary>
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

        /// <summary>
        /// Description of the part
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// Name to render for display
        /// </summary>
        public string? DisplayName { get; set; }

        /// <summary>
        /// Internal unique identifyer for the part
        /// </summary>
        public Guid Id { get; } = Guid.NewGuid();

        /// <summary>
        /// Unique part name
        /// </summary>
        public string? PartNumber { get; set; }
    }
}