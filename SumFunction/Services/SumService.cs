using SumFunction.Models;

namespace SumFunction.Services
{
    public class SumService
    {
        public decimal Sum(SumItem sumItem)
        {
            return sumItem.A + sumItem.B;
        }
    }
}
