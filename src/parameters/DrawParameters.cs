namespace parameters
{
    const uint NB_POKEDEX_ENTRY = 1008;

    class DrawParameters {
        public uint generation {get; set;}
        public uint nb_poke_disp {get; set;}

        public DrawParameters() {
            generation = 0;
        }

        public DrawParameters(uint generation) {
            generation = generation;
        }
    }
}