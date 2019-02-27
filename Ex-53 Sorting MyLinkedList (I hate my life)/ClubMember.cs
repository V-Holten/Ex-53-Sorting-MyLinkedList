using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_53_Sorting_MyLinkedList__I_hate_my_life_
{
    public enum Gender { Male, Female };
    public class ClubMember : IComparable<ClubMember>
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public int Age { get; set; }

        public int CompareTo(ClubMember clubmember)
        {
            return FirstName.CompareTo(clubmember.FirstName);
        }

        public override string ToString()
        {
            return $"{Id}: {FirstName} {LastName} ({Gender}, {Age} years)";
        }

        public class SortClubMembersAfterLastName : IComparer<ClubMember>
        {
            public int Compare(ClubMember first, ClubMember second)
            {
                return first.LastName.CompareTo(second.LastName);
            }
        }

        public class SortClubMembersAfterGenderAndLastName : IComparer<ClubMember>
        {
            public int Compare(ClubMember first, ClubMember second)
            {
                if (first.Gender == second.Gender)
                {
                    return first.LastName.CompareTo(second.LastName);
                }
                else
                {
                    return first.Gender.CompareTo(second.Gender);
                }
            }
        }
    }

}
