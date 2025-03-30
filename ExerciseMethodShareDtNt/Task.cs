using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseMethodShareDtNt
{
    public class Task
    {
        private int _id;
        private DateTime _date;
        private bool _done;

        public int Id { get => _id; set => _id = value; }
        public DateTime Date { get => _date; set => _date = value; }
        public bool Done { get => _done; set => _done = value; }
    }
}
