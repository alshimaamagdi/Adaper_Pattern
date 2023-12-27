using toutorial.usedClasses;

namespace Adaper_Pattern.usedClasses
{
    public class loadedData
    {
        public List<Employee> LoadedData()
        {
            var result= new List<Employee>()
            {
                new Employee()
                {
                    Name="Mahmed Hassan Magdi",
                    PayItems =
                    {
                        new PayItems()
                        {
                            NamePayment="salary",
                            Value=2000
                        },
                         new PayItems()
                        {
                            NamePayment="Transaction",
                            Value=300
                        },   new PayItems()
                        {
                            NamePayment="Payment",
                            Value=500
                        },
                    }
                },
                  new Employee()
                {
                    Name="Hassan Hassan Magdi",
                    PayItems =
                    {
                        new PayItems()
                        {
                            NamePayment="salary",
                            Value=2000
                        },
                         new PayItems()
                        {
                            NamePayment="Transaction",
                            Value=300
                        },   new PayItems()
                        {
                            NamePayment="Payment",
                            Value=-500
                        },
                    }
                },

            };
            return result;
        }
    }
}
