namespace Nadina_Proiect3.Models
{
    public class Produs
    {
        public int ProdusId { get; set; }
        public int CategorieId { get; set; }
        public int Cod { get; set; }
        public string Denumire { get; set; }
        public decimal Pret { get; set; }
        public string Material { get; set; }
        public string Culoare { get; set; }
        public ICollection<CategorieProdus> CategoriiProdus { get; set; }
    }
}
