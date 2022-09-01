using System.ComponentModel.DataAnnotations;

namespace npresume2.Model
{
    public class NpRegistration
    {
        [Key]
        public int Npid { get; set; }
        public string Npnameeee { get; set; }
        public string? Email { get; set; }
        public string? Phonenumber { get; set; }
    }
}
