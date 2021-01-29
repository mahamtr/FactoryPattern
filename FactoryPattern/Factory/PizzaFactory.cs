using FactoryPattern.Pizza;

namespace FactoryPattern.Factory
{
    public class PizzaFactory : IPizzaFactory
    {
        public IPizza createPizza(PizzaType type)
        {
            if(type == PizzaType.Vegan) return new VeganPizza();
            return new TraditionalPizza();
        }
    }
}