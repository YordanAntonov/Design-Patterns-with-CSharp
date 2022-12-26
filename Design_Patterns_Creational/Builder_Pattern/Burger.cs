using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder_Pattern
{
    public class Burger
    {
        private List<string> burgerIngridients;

        public int mSize;
        public bool Cheese;
        public bool Pepperoni;
        public bool Lettuce;
        public bool Tomato;

        public Burger(BurgerBuilder builder)
        {
            burgerIngridients = new List<string>();

            this.mSize = builder.Size;
            this.Cheese = builder.Cheese;
            this.Pepperoni = builder.Pepperoni;
            this.Lettuce = builder.Lettuce;
            this.Tomato = builder.Tomato;
        }

        private void GetBurgerIngridients()
        {
            if (Cheese)
            {
                burgerIngridients.Add(nameof(Cheese));
            }
            if (Pepperoni)
            {
                burgerIngridients.Add(nameof(Pepperoni));
            }
            if (Lettuce)
            {
                burgerIngridients.Add(nameof(Lettuce));
            }
            if (Tomato)
            {
                burgerIngridients.Add(nameof(Tomato));
            }

        }

        public string GetDescription()
        {
            StringBuilder sb = new StringBuilder();
            this.GetBurgerIngridients();
            sb.AppendLine($"This is {this.mSize} inch Burger. ");
            sb.AppendLine($"Your burger contains: {(this.burgerIngridients.Any()? string.Join(", ", burgerIngridients) : "none additional ingridients.")}");

            return sb.ToString().TrimEnd();
        }
    }
}