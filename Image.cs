using System.Linq;

namespace konstruktorTets
{
    public class Image
    {
        public int Cisla { get; set; }
        
        public Image(NahodneCisla nahodneCisla)
        {
            Cisla = nahodneCisla.ListCisel.FirstOrDefault();
        }
    }
}