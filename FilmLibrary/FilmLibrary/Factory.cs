using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmLibrary
{
   
    // Product
    abstract class Ingredient
    {

    }

    //Concrete Product
    class Bread: Ingredient
    {

    }

    class Turkey: Ingredient
    {

    }

    class Lettuce: Ingredient
    {

    }

    // the Creator
    abstract class Sandwich
    {
        private List<Ingredient> _ingredients = new List<Ingredient>();
        public Sandwich()
        {
            CreateIngredients();
        }

        //Factory method
        public abstract void CreateIngredients();

        public List<Ingredient> Ingredients
        {
            get
            {
                return _ingredients;
            }
        }
    }

    //Concrete Creator
    class TurkeySandwich: Sandwich
    {
        public override void CreateIngredients()
        {
            Ingredients.Add(new Bread());
            Ingredients.Add(new Lettuce());
            Ingredients.Add(new Turkey());
        }
    }
}
