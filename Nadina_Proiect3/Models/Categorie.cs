namespace Nadina_Proiect3.Models
{
    public class Categorie
    {
        public int CategorieId { get; set; }
        public string Denumire { get; set; }
        public ICollection<CategorieProdus> CategoriiProdus { get; set; }
    }
}
