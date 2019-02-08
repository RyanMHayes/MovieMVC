using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieMVC.Models
{
    public class MovieFilter
    {
        public int ID { get; set; }
        private static int nextId = 1;

        public string Value { get; set; }

        public MovieFilter()
        {
            ID = nextId;
            nextId++;
        }

        public MovieFilter(string value) : this()
        {
            Value = value;
        }

        public bool Contains(string testValue)
        {
            return Value.ToLower().Contains(testValue.ToLower());
        }

        public override string ToString()
        {
            return Value;
        }

        // override object.Equals
        public override bool Equals(object obj)
        {

            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            return (obj as MovieFilter).ID == ID;
        }

        // override object.GetHashCode
        public override int GetHashCode()
        {
            return ID;
        }

    }
}
