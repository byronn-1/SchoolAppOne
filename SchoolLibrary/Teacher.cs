﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
    public class Teacher : Person
    {
        public string Subject { get; set; }

        public override float ComputeGradeAverage()
        {
            // todo: fix the implementation later
            return 0.0f;
        }
    }
}
