namespace parameters
{
    /// <summary>
    /// Number of current number of pokémons
    /// </summary>
    public const uint NB_POKEDEX_ENTRY = 1008;


    class DrawParameters {
        /// <summary>
        /// Generation to use for the randomizer.
        /// 0 is for NationalDex
        /// </summary>
        public uint generation {get; set;}

        /// <summary>
        /// Number of pokémons disponible in the generation.
        /// </summary>
        public uint nb_poke_disp {get; set;}

        public DrawParameters() {
            generation = 0;
            nb_poke_disp = NB_POKEDEX_ENTRY;
        }

        public DrawParameters(uint generation) {
            generation = generation;
        }
    }
}