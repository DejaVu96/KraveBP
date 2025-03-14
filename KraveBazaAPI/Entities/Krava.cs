using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KraveBazaAPI.Entities
{
    public class Krava
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RedniBroj { get; set; } 
        public int Id { get; set; }
        public DateTime? DatumRodjenja { get; set; }
        public string? ImeMajke { get; set; }
        public DateTime? Vakcina3Dana{ get; set; }
        public DateTime? Vakcina10Dana { get; set; }
        public DateTime? DatumOsemenjavanja { get; set; }
        public DateTime? Provera { get; set; }
        public DateTime? SteonostPregled { get; set; }
        public DateTime? Zasusivanje { get; set; }
        public DateTime? TeljenjeTermin { get; set; }
        public DateTime? TeljenjeDatum { get; set; }
        public DateTime? Injekcija { get; set; }
        public DateTime? MoguceOsemenjavanje { get; set; }
    }
}
