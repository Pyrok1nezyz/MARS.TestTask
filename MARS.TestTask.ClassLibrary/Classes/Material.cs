
namespace MARS.TestTask.ClassLibrary
{
    public class Material : IDBEntity<Material>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public long Price { get; set; }
        public DateTime Date_Byed { get; set; }
        public string Nomenclature { get; set; }
        public List<Component> Components { get; set; }
    }
}
