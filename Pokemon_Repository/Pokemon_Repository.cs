using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Repository
{
    public class PokemonRepository
    {
        private List<Pokemon> _pokemonTeam = new List<Pokemon>();

        //add to list (limit pokemon to 6)
        public void AddPokemonToTeam(Pokemon pokemon)
        {
            _pokemonTeam.Add(pokemon);
        }

        //get list
        public List<Pokemon> GetPokemonTeam()
        {
            return _pokemonTeam;
        }

        //get one pokemon
        public Pokemon GetPokemonByTeamPosition(int teamPosition)
        {
            
            Pokemon pokemon = _pokemonTeam[teamPosition - 1];
            return pokemon;
        }

        //update pokemon
        public bool UpdatePokemonByTeamPosition(int teamPosition, Pokemon updates)
        {
            Pokemon oldPokemon = GetPokemonByTeamPosition(teamPosition);

            if(oldPokemon != null)
            {
                oldPokemon.PokemonSpeciesName = updates.PokemonSpeciesName;
                oldPokemon.PokemonNickName = updates.PokemonNickName;
                oldPokemon.Level = updates.Level;
                oldPokemon.PokemonType = updates.PokemonType;
                oldPokemon.SecondaryType = updates.SecondaryType;
                oldPokemon.MoveOne = updates.MoveOne;
                oldPokemon.MoveTwo = updates.MoveTwo;
                oldPokemon.MoveThree = updates.MoveThree;
                oldPokemon.MoveFour = updates.MoveFour;

                return true;
            }
            else
            {
                return false;
            }

        }

        public bool UpdatePokemonByNickName(string nickName, Pokemon newPokemon)
        {
            Pokemon olderPokemon = GetPokemonByNickName(nickName);

            if (olderPokemon != null)
            {
                olderPokemon.PokemonSpeciesName = newPokemon.PokemonSpeciesName;
                olderPokemon.PokemonNickName = newPokemon.PokemonNickName;
                olderPokemon.Level = newPokemon.Level;
                olderPokemon.PokemonType = newPokemon.PokemonType;
                olderPokemon.SecondaryType = newPokemon.SecondaryType;
                olderPokemon.MoveOne = newPokemon.MoveOne;
                olderPokemon.MoveTwo = newPokemon.MoveTwo;
                olderPokemon.MoveThree = newPokemon.MoveThree;
                olderPokemon.MoveFour = newPokemon.MoveFour;

                return true;
            }
            else
            {
                return false;
            }
        }

        //remove pokemon
        public void RemovePokemonFromTeam(int teamPosition)
        {
            Pokemon pokemon = _pokemonTeam[teamPosition - 1];
            _pokemonTeam.Remove(pokemon);
        }

        //get pokemon by nickname
        public Pokemon GetPokemonByNickName(string nickName)
        {
            foreach (Pokemon pokemon in _pokemonTeam)
            {
                if(pokemon.PokemonNickName.ToLower() == nickName.ToLower())
                {
                    return pokemon;
                }
            }

            return null;
        }
    }
}
