namespace Example.Models
{
    public class Candy
    {
       
        public string Name { get; set; }    
        public double Weight { get; set; }
        public double Price { get; set; }
        public bool IsCheck { get; set; }
    }

   public class CandyList
    {
        public List<Candy> can { get; set; }
    }
}
