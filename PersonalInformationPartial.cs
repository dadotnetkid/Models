using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public partial class PersonalInformations
    {
        public string FullName => this.FirstName + " " + this.LastName + " " + this.Ext;
        public List<string> GroupIds { get; set; }
    }
}
