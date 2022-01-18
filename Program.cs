using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Day2_CS
{
    class Program
    {
        static List<Member> members = new List<Member>{
             new Member
            {
                FirstName = "Phuong",
                LastName = "Nguyen Nam",
                Gender = "Male",
                DateOfBirth = new DateTime(2001, 1, 22),
                PhoneNumber = "",
                BirthPlace = "Phu Tho",
                IsGraduated = false
            },
            new Member
            {
                FirstName = "Nam",
                LastName = "Nguyen Thanh",
                Gender = "Male",
                DateOfBirth = new DateTime(2001, 1, 20),
                PhoneNumber = "",
                BirthPlace = "Ha Noi",
                IsGraduated = false
            },
            new Member
            {
                FirstName = "Son",
                LastName = "Do Hong",
                Gender = "Male",
                DateOfBirth = new DateTime(2000, 11, 6),
                PhoneNumber = "",
                BirthPlace = "Ha Noi",
                IsGraduated = false
            },
            new Member
            {
                FirstName = "Huy",
                LastName = "Nguyen Duc",
                Gender = "Male",
                DateOfBirth = new DateTime(1996, 1, 26),
                PhoneNumber = "",
                BirthPlace = "Ha Noi",
                IsGraduated = false
            },
            new Member
            {
                FirstName = "Hoang",
                LastName = "Phuong Viet",
                Gender = "Male",
                DateOfBirth = new DateTime(1999, 2, 5),
                PhoneNumber = "",
                BirthPlace = "Ha Noi",
                IsGraduated = false
            },
            new Member
            {
                FirstName = "Long",
                LastName = "Lai Quoc",
                Gender = "Male",
                DateOfBirth = new DateTime(1997, 5, 30),
                PhoneNumber = "",
                BirthPlace = "Bac Giang",
                IsGraduated = false
            },
            new Member
            {
                FirstName = "Thanh",
                LastName = "Tran Chi",
                Gender = "Male",
                DateOfBirth = new DateTime(2000, 9, 18),
                PhoneNumber = "",
                BirthPlace = "Ha Noi",
                IsGraduated = false
            },
        };
        static void Main(string[] args)
        {
            //1. Return all Male Members
            // var maleMembers = GetMaleMembers();
            // PrintData(maleMembers);
        

            //2. Find oldest member
            // var oldestMembers = GetOldestMember();
            // if(oldestMembers != null)
            //     PrintData(new List<Member> {oldestMembers});

            //3. Full Name Members
            // var fullnames = GetFullNames();
            // foreach (var fullname in fullnames)
            // {
            //     Console.WriteLine(fullname);
            // }

            // 4. List members by birth year
            // var results = SplitMembersByBirthYear(2000);
            // Console.WriteLine("-----------Year is 2000-----------");
            // PrintData(results.Item1);
            // Console.WriteLine("-------Year Greater than 2000------");
            // PrintData(results.Item2);
            // Console.WriteLine("-------Year Less than 2000--------");
            // PrintData(results.Item3);

            // 5. Get members who was born in Ha Noi
            var result = GetMembersByBirthPlace("Ha noi");
            if(result != null)
                PrintData(new List<Member> {result});
            else
                Console.WriteLine("No data..");
        }
        static void PrintData(List<Member> data)
        {
            var index = 0;
            foreach (var item in data)
            {
                ++index;
                Console.WriteLine($"{index}. {item.LastName} {item.FirstName} - {item.DateOfBirth.ToString("dd/MM/yyyy")} - [{item.Age}]");
            }
        }
        static List<Member> GetMaleMembers()
        {
           var results = members.Where(g => g.Gender == "Male").ToList();
           return results;
        }
        static Member GetOldestMember()
        {
            var maxAge = members.Max(m => m.Age);
            return members.First(m => m.Age == maxAge);
        }
        static List<string> GetFullNames()
        {
            var fullNames = members.Select(m => m.FullName);
            return fullNames.ToList();
        }
        static Tuple<List<Member>, List<Member>, List<Member>> SplitMembersByBirthYear(int year)
        {
            var listBirthYear = members.Where(m => m.DateOfBirth.Year == year).ToList();
            var listBirthYearGreater = members.Where(m => m.DateOfBirth.Year > year).ToList();
            var listBirthYearLess = members.Where(m => m.DateOfBirth.Year < year).ToList();
            return Tuple.Create(listBirthYear, listBirthYearGreater, listBirthYearLess);
        }
        static Member GetMembersByBirthPlace(string place)
        {
            return members.FirstOrDefault(m => m.BirthPlace.Equals(place, StringComparison.CurrentCultureIgnoreCase));
        }
    }
}
