using System.ComponentModel.DataAnnotations.Schema;

namespace MARS.TestTask.ClassLibrary
{
    [Table("dbo.list_components")]
    public class Component : IDBEntity<Component>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public long Price { get; set; }
        public DateTime Date_Byed { get; set; }
        public string Nomenclature { get; set; }
        public List<Product> Products { get; set; }
        public List<Material> Materials { get; set; }
    }
}
