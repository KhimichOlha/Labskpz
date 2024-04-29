using System.Text;

namespace BuilderPerson
{
    public class Character
    {
        public double Height { get; set; }
        public string Build { get; set; }
        public string HairColor { get; set; }
        public string EyeColor { get; set; }
        public string Clothing { get; set; }
        public List<string> Inventory { get; set; } = new List<string>();
        public string GetInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Height: {Height}, Build: {Build}, Hair Color: {HairColor}, Eye Color: {EyeColor}, Clothing: {Clothing}");
            foreach (var item in Inventory)
            {
                sb.AppendLine(item);
            }
            return sb.ToString();
        }
    }
}
