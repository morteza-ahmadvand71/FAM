using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baran.Ferroalloy.Automation.SqlDataBase
{
    public class ExceptionConnection:Exception
    {
        public ExceptionConnection(String Message) : base(Message)
        {

        }
    }
}
