﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseMethodShareDtNt
{
    public class Given_Rule
    {
        private string _match_Category;
        private int _rank;
        private string _exercise;
        private int _exercise_ID;

        public string Match_Case { get => _match_Category; set => _match_Category = value; }
        public int Rank { get => _rank; set => _rank = value; }
        public string Exercise { get => _exercise; set => _exercise = value; }
        public int Exercise_ID { get => _exercise_ID; set => _exercise_ID = value; }
    }
}
