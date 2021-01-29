using FactoryPattern.Pizza;

namespace FactoryPattern.Factory
{
    public interface IPizzaFactory
    {
        IPizza createPizza(PizzaType type);
    }
}