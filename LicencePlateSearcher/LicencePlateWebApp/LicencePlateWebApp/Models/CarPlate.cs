using System.ComponentModel.DataAnnotations;

namespace LicencePlateWebApp.Models
{
    public class CarPlate
    {
        public int? Id { get; set; }

        [MinLength(7, ErrorMessage = "Only allow alphanumeric characters from the user: [A-Z], [0-9] and the - dash symbol and lenghts of the plate is 7 character with dash symbol")]
        [MaxLength(7)]
        public string Plate { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }
    }
}
