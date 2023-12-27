using toutorial.usedClasses;

namespace Adaper_Pattern.Adapter
{
    public class paymentItemAdapter
    {
        private PayItems _paymentItems;
        public paymentItemAdapter(PayItems paymentItems)
        {
            _paymentItems = paymentItems;
        }
        public string NamePayment => _paymentItems.NamePayment;
        public double Value => _paymentItems.isDeduction?_paymentItems.Value* -1: _paymentItems.Value;
    }
}
