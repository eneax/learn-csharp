namespace Testability
{
    public interface IShippingCalculator
    {
        float CalculateShipping(Order order);
    }

    // make ShippingCalculator class to implement IShippingCalculator interface
    public class ShippingCalculator : IShippingCalculator
    {
        public float CalculateShipping(Order order)
        {
            if (order.TotalPrice < 30f)
            {
                return order.TotalPrice * 0.1f;
            }

            return 0;
        }
    }
}