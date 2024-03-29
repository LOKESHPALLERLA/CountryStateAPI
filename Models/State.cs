using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.NewFolder
{
    [Table("State")]
    public class State
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Cid { get; set; }
        public Country Country { get; set; }
    }
}
