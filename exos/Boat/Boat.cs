using static System.Net.Mime.MediaTypeNames;
using System.Text;

namespace Boat
{
    class Boat : IBoat
    {
        public Boat(string name, float maxCargoWeight, int maxSpeed)
        {
            this.Name = name;
            this.MaxCargoWeight = maxCargoWeight;
            this.MaxSpeed = maxSpeed;
        }
        public string Name { get; set; }
        public float MaxCargoWeight { get; set; }
        public int MaxSpeed { get; set; }

        public bool juste = true;



        public void Start(){ }
        public bool LoadContainer(IContainer container) 
        {

            return juste;
        }
        public bool UnloadContainer(IContainer container) 
        {
            return juste;
        }
    }

}