using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_53_Sorting_MyLinkedList__I_hate_my_life_
{
    public enum Gender { Male, Female };
    public class ClubMember : IComparable
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public int Age { get; set; }

        public int CompareTo(object obj)
        {
            ClubMember clubMember = obj as ClubMember;
            return FirstName.CompareTo(clubMember.FirstName);
        }
        public override string ToString()
        {
            return $"{Id}: {FirstName} {LastName} ({Gender}, {Age} years)";
        }
    }

}
