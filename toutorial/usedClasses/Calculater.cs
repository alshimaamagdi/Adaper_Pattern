namespace toutorial.usedClasses
{
    public class Calculater
    {
        public object calculateValues(Employee emp)
        {
            var add = emp.PayItems.Select(a => a.Value).Sum();
            var result = new 
            {
                name= emp.Name,
                Salary= add
            };
            return result;
        }
    }
}
