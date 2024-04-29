using System.Text;

namespace VirusPrototype
{
    public class Virus : ICloneable
    {
        public double Weight { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public List<Virus> Children { get; set; } = new List<Virus>();

        public Virus(double weight, int age, string name, string type)
        {
            Weight = weight;
            Age = age;
            Name = name;
            Type = type;
        }
        public void AddChild(Virus child)
        {
            Children.Add(child);
        }
        public object Clone()
        {
            Virus clone = new Virus(Weight, Age, Name, Type);
            foreach (var child in Children)
            {
                clone.AddChild((Virus)child.Clone());
            }
            return clone;
        }
        public string DisplayInfo(string prefix = "")
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{prefix}Name: {Name}, Type: {Type}, Weight: {Weight}, Age: {Age}");
            foreach (var child in Children)
            {
                sb.Append(child.DisplayInfo(prefix + " "));
            }
            return sb.ToString();
        }

    }
}
