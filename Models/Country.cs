using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.NewFolder
{
    [Table("Country")]
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<State>? States { get; set; }
    }
}
