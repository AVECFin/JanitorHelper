using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MKApplication.Person
{
  public abstract class PersonBase
  {
    public PersonBase() { }

    public string FirstName
    {
      get { return this.firstName; }
      set { this.firstName = value; }
    }

    public string LastName
    {
      get { return this.lastName; }
      set { this.lastName = value; }
    }

    public string Id
    {
      get { return this.id; }
      set { this.id = value; }
    }

    public DateTime BirthDay
    {
      get { return this.birthDay; }
      set { this.birthDay = value; }
    }


    public abstract override string ToString();

    private string firstName;
    private string lastName;
    private DateTime birthDay;
    private string id;
  }

} // MKApplication.Person