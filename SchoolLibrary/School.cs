﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
    public class School
    {
        
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string PhoneNumber { get; set; }

        private string _twitterAddress;
        public string TwitterAddress
        {
             get
            {
                return _twitterAddress;
            }
            set
            {
                if(value.StartsWith("@"))
                {
                    _twitterAddress = value;
                } else
                {
                    throw new Exception("The twitter address must begin wtih @");
                }
            }
        }
        // or type ctor and hit tab key twice
        public School()
        {
            Name = "Untitled School";
            PhoneNumber = "555-1234";
        }
        public School(string SchoolName, string SchoolPhoneNumber)
        {
            Name = SchoolName;
            PhoneNumber = SchoolPhoneNumber;
        }

        public float AverageThreeScores(float a, float b, float c)
        {
            var result = (a + b + c) / 3;
            return result;
        }
        public static int AverageThreeScores(int a, int b, int c)
        { 
            var result = (a + b + c) / 3;
            return result;
        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(Name);
            sb.AppendLine(this.Address);
            sb.Append(City);
            sb.AppendLine(", ");
            sb.AppendLine(State);
            sb.AppendLine("  ");
            sb.Append(Zip);

            return sb.ToString();
        }
    }
}
;