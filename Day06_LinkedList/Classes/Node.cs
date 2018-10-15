﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Day06_LinkedList.Classes
{
    class Node
    {
        public int Value { get; set; } //can change to "int" to "object" to ensure that we're not bound to a certain type
        public Node Next { get; set; }

        public Node(int value)
        {
            Value = value;
        }
    }
}
