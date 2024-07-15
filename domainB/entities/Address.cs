using Microsoft.EntityFrameworkCore;

namespace multischema_test.domainB.entities
{
    [PrimaryKey(nameof(AddressId))]
    public class Address
    {
        public Guid AddressId { set; get; }
        public string AddressLine1 { set; get; }
        public string AddressLine2 { set; get; }
    }
}
