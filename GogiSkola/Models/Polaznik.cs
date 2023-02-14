using System.ComponentModel.DataAnnotations;

namespace GogiSkola.Models
{
    public class Polaznik
    {
        [Key]
        public int Id { get; set; }

        public string FullName { get; set; }

        public string Bio { get; set; }

        public string ProfileURL { get; set; }


    }
}
