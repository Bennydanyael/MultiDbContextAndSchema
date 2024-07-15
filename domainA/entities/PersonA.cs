using Microsoft.EntityFrameworkCore;

namespace multischema_test.domainA.entities
{

    [PrimaryKey(nameof(Id))]
    public class PersonA
    {
        public int Id { get; set; }
        public string FName { set; get; }
        public string FName2 { set; get;}
    }
}
