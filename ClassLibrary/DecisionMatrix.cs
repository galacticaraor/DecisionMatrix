using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class DecisionMatrix
    {
        public string UUID { get; internal set; }
        public string Name { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public List<Factor> Pros { get; set; }
        public List<Factor> Cons { get; set; }
        public int ProWeight { get; internal set; }
        public int ConWeight { get; internal set; }

        public DecisionMatrix()
        {
            UUID = Guid.NewGuid().ToString();
            Name = "";
            DateCreated = DateTime.Now;
            DateUpdated = DateTime.Now;
            Pros = new List<Factor>();
            Cons = new List<Factor>();
            ProWeight = 0;
            ConWeight = 0;
        }

        public void AddPro(Factor factor)
        {
            //Add to the list of pros
            Pros.Add(factor);
            RecalculateProsCons();
        }

        public void EditPro(Factor factor)
        {
            //Find the pro being edited in the list of pros
            Factor f = Pros.Find(x => x.UUID == factor.UUID);
            f.Name = factor.Name;
            f.Weight = factor.Weight;
            RecalculateProsCons();
        }

        public void DeletePro(string uuid)
        {
            //Delete the pro from the list of pros
            Factor f = Pros.Find(x => x.UUID == uuid);
            Pros.Remove(f);
            RecalculateProsCons();
        }

        public void AddCon(Factor factor)
        {
            //Add to the list of cons
            Cons.Add(factor);
            RecalculateProsCons();
        }

        public void EditCon(Factor factor)
        {
            //Find the con being edited in the list of cons
            Factor f = Cons.Find(x => x.UUID == factor.UUID);
            f.Name = factor.Name;
            f.Weight = factor.Weight;
            RecalculateProsCons();
        }

        public void DeleteCon(string uuid)
        {
            //Delete the con from the list of cons
            Factor f = Cons.Find(x => x.UUID == uuid);
            Cons.Remove(f);
            RecalculateProsCons();
        }

        private void RecalculateProsCons()
        {
            ProWeight = 0;
            ConWeight = 0;
            //Loop through the pros
            foreach (Factor f in Pros)
            {
                ProWeight += f.Weight;
            }
            //Loop through the cons
            foreach (Factor f in Cons)
            {
                ConWeight += f.Weight;
            }
        }

    }
}
