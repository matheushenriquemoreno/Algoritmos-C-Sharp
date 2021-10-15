using System;
using System.Globalization;

namespace inter_face_icomparable.Entities
{
    class Eployww : IComparable 
    {
        public string Name { get; set; }
        public double Salary { get; set; }
        
        public Eployww(string cvsEmploee)
        {
            string[] vetor = cvsEmploee.Split(',');
            Name = vetor[0];
            Salary = double.Parse(vetor[1], CultureInfo.InvariantCulture);

        }
        public int CompareTo(object obj)
        {
           if (!(obj is Eployww))
            {
                throw new ArgumentException("Comparing Error!");
            }
            Eployww hoter = obj as Eployww; // down casting.
            return Salary.CompareTo(hoter.Salary);
            // ou return Name.CompareTo(hoter.Name);
        }
        public override string ToString()
        {
            return Name + " , " + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
