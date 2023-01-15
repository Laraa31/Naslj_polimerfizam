using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace naslj_polimerfizam
{
    internal class UniMastersChef
    {
		private CompetitionEntry[] entries;

		private int idx = 0;

		public UniMastersChef(int noOfEntries)
		{
			this.entries = new CompetitionEntry[noOfEntries];
		}
		public bool addEntry(CompetitionEntry entry)
		{
			if (idx == this.entries.Length) return false;

			foreach (CompetitionEntry e in entries)
			{
				if (e != null && e.Equals(entry))
					return false;
			}
			entries[idx++] = entry;
			return true;
		}
		public Dessert getBestDessert()
		{
			if (idx == 0) return null;

			double max = entries[0].getRating();
			int maxIdx = 0;

			for (int i = 0; i < idx; i++)
			{
				if (entries[i].getRating() > max)
				{
					max = entries[i].getRating();
					maxIdx = i;
				}
			}

			return entries[maxIdx].Dessert;
		}
		public static Person[] getInvolvedPeople(CompetitionEntry entry)
		{

			Person[] retVal = new Person[4];

			int idx = 0;

			retVal[idx++] = entry.Teacher;

			foreach (Student s in entry.Students)
			{
				retVal[idx++] = s;
			}

			return retVal;
		}
	}
}
