using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseMethodShareDtNt
{
    public class Exercise_Attribute
    {
        private string _action;
        private Given_Rule _Vals;

        public string Action { get => _action; set => _action = value; }
        public Given_Rule Vals { get => _Vals; set => _Vals = value; }
    }
}
