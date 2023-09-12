using System.ComponentModel.DataAnnotations.Schema;

namespace MARS.TestTask.ClassLibrary
{
    [Table("dbo.list_products")]
    public class Product : IDBEntity<Product>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Nomenclature { get; set; }
        public List<Component> Components { get; set; }
    }
}