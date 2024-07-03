namespace pokemon
{
    public class Pokemon {
        /// <summary>
        /// Name of the Pokemon
        /// </summary>
        public string Name {get; set;}
        
        /// <summary>
        /// Individual values of the Pokemon
        /// </summary>
        public List<uint> Ivs {get; set;}

        /// <summary>
        /// Constructor
        /// </summary>
        public Pokemon() {
            Name = "";
            Ivs = new List<uint>([0,0,0,0,0,0]);
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public Pokemon(string name) {
            Name = name;
            Ivs = new List<uint>([0,0,0,0,0,0]);
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public Pokemon(string name, IEnumerable<uint> ivs) {
            Name = name;
            Ivs = new List<uint>(ivs);
        }

        public void print() {
            string output = Ivs[0].ToString() + "hp/" + Ivs[1].ToString() + "atk/" + Ivs[2].ToString() + "def/" + Ivs[3].ToString() + "SpA/" + Ivs[4].ToString() + "SpD/" + Ivs[5].ToString() + "Spe";
            Console.WriteLine(output);
        }
    }
}
