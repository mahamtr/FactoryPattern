using System;
using FactoryPattern.Factory;
using FactoryPattern.Pizza;
using Xunit;

namespace FactoryPattern.specs
{
    public class ItalianPizza
    {
        [Fact]
        public void ShouldSuccedWithTraidtionalPizza()
        {
            var pizzaFactory = new PizzaFactory();
            var pizzaType = PizzaType.Traditional;


            var pizza = pizzaFactory.createPizza(pizzaType);

            
            Assert.True(pizza is TraditionalPizza);
        }
        
        [Fact]
        public void ShouldSuccedWithVeganPizza()
        {
            var pizzaFactory = new PizzaFactory();
            var pizzaType = PizzaType.Vegan;


            var pizza = pizzaFactory.createPizza(pizzaType);

            
            Assert.True(pizza is VeganPizza);
        }
    }
}