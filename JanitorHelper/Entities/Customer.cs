using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MKApplication.Person;

namespace MKApplication.Entities
{
  public class Customer
    : PersonBase
  {

    public Customer() { }

    #region      OVERRIDES

    public override string ToString()
    {
      return this.FirstName + " " + this.LastName + " " + this.BirthDay.Date + this.Id;
    }

    #endregion    OVERRIDES
  }
}
