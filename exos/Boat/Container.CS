using static System.Net.Mime.MediaTypeNames;
using System.Text;

namespace Boat
{
    class Container : IContainer
    {
        public Container(int id, float weight, bool isRefrigerated, List<string> merchandise, string color)
        {
            this.Id = id;
            this.Weight = weight;
            this.IsRefrigerated = isRefrigerated;
            this.Merchandise = merchandise;
            this.Color = color;
        }
        public int Id { get; set; }
        public float Weight { get; set; }
        public bool IsRefrigerated { get; set; }
        public List<string> Merchandise { get; set; }
        public string Color { get; set; }


        // Méthodes pour le container
        public void ViewContent() // Voir le contenu du container
        {
            Console.WriteLine("Le container contient : " + content);
        }  
        public void AddMerchandise(string item) { } // Ajouter un élément dans le container
    }

}