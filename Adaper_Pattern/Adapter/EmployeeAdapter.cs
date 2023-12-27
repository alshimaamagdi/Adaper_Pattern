using System.Linq;
using toutorial.usedClasses;

namespace Adaper_Pattern.Adapter
{
    public class EmployeeAdapter
    {
        private Employee _emp;
        public EmployeeAdapter(Employee emp)
        {
            _emp = emp;
        }
        public string Name => _emp.Name;
        //Convert Our Class To Class That server can understand
        public List<paymentItemAdapter> PayItems => _emp.PayItems.Select(PayItems => new paymentItemAdapter(PayItems)).ToList();

    }
}
