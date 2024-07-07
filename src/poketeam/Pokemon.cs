using parameters;

namespace poketeam
{
    public class Pokemon {
        ///<summary>
        /// Id of the pokémon in the national dex
        ///</summary>
        public uint Id {get; set;}

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
        public Pokemon(DrawParameters param) {
            Random rng = new Random();
            Name = "";
            Ivs = new List<uint>([0,0,0,0,0,0]);
        }

        /// <summary>
        /// Print the ivs of the pokémon
        /// </summary>
        public void print() {
            string output = Ivs[0].ToString() + "HP/" + Ivs[1].ToString() + "Atk/" + Ivs[2].ToString() + "Def/" + Ivs[3].ToString() + "SpA/" + Ivs[4].ToString() + "SpD/" + Ivs[5].ToString() + "Spe";
            Console.WriteLine(output);
        }
    }
}
