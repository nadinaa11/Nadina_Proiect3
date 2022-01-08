namespace Nadina_Proiect3.Models
{
    public class CategorieProdus
    {
        public int CategorieProdusId { get; set; }
        public int ProdusId { get; set; }
        public Produs Produs { get; set; }
        public int CategorieId { get; set; }
        public Categorie Categorie { get; set; }
    }
}
