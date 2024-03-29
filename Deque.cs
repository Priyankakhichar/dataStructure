﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
        public class Deque<E>
        {
            public E data;
            public Deque<E> next;
            public Deque<E> pre;

            public Deque()
            {
                this.next = null;
                this.pre = null;
            }

            public Deque(E val)
            {
                this.data = val;
                this.next = null;
                this.pre = null;
            }
        }
}
