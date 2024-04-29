using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPerson
{
    public class CharacterDirector
    {
        private readonly ICharacterBuilder _characterBuilder;
        public CharacterDirector(ICharacterBuilder character)
        {
            _characterBuilder = character;

        }
        public Character Constrat()
        {
            return _characterBuilder.SetHeight(170).SetBuild("Злодій").SetClothing("Плащ").SetHairColor("чорний").SetInventory(new List<string> { "Палочка чарівна", "маска" }).Build();
        }
    }
}
