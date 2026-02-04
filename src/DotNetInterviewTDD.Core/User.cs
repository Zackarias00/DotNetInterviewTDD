using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetInterviewTDD.Core
{
    public class User(string name)
    {
        public string Name { get;set; } = name;

        public User WithName(string v)
        {
            throw new NotImplementedException();
        }
    }
}
