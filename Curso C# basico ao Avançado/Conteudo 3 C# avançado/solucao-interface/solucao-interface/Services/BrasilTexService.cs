
namespace solucao_interface.Services
{
    class BrasilTexService : ITaxService // subtipo da interface
    {

        public double Tax(double amount)
        {
            if (amount <= 100) 
            {
                return amount * 0.2;
            }
            else
            {
                return amount * 0.15;
            }
        }
    }
}
