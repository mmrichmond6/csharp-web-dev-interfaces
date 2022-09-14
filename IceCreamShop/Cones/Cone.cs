using System;
using System.Collections.Generic;

namespace IceCreamShop.Cones
{
    public class Cone : Ingredient
    {
        public Cone(string name, double cost, List<string> allergens) : base(name, cost, allergens)
        {
        }
    }
}
