using System.ComponentModel;

namespace projet_ASP
{
    public class Game
    {
        public int Id { get; set; }
        [DisplayName("Titre du jeu")]
        public string Titre { get; set; }
        [DisplayName("Année de sortie")]
        
        public int AnneeSortie { get; set; }
        public string Genre { get; set; }
        public string Resume { get; set; }
    }
}
