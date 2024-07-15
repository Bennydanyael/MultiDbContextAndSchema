using Microsoft.EntityFrameworkCore;

namespace multischema_test.domainB.entities
{

    [PrimaryKey(nameof(Id))]
    public class PersonB
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
