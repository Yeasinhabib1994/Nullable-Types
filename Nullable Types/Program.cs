using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullable_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime? date = null; // ? is used to define nullable types. 
                                   //with nullable types null value can be assignes to value types.

            Console.WriteLine("GetValueOrDefault: " + date.GetValueOrDefault());
            Console.WriteLine("HasValue: " + date.HasValue);
            //Console.WriteLine("value: " + date.Value); // this causes an exception cause date has no value.

            DateTime date2 = date.GetValueOrDefault(); // to assign nullable type value to value type have to use GetValueOrDefault operator.
            Console.WriteLine("after converting nullable type to value type: "+date2);

            DateTime? date3 = date2; // value types can be easily converted to nullable type.
            Console.WriteLine("after converting value type to nullable type: "+date3);

            if (date != null)
                date2 = date.GetValueOrDefault(); // DateTime date2 = date ?? DateTime.Today; // this code is equivalent to the if else.
            else date2 = DateTime.Today;
            Console.WriteLine(date2);
        }
    }
}
