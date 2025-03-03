﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriorityQueueWithArray
{
    public class PriorityQueue
    {
        public Model[] queue;
        public int size;
        public int front;
        public int rear;

        public PriorityQueue(int sizeOfQueue)
        {
            size = sizeOfQueue;
            queue = new Model[sizeOfQueue];
            front = -1;
            rear = -1;
        }

        public void Enqueue(int value, int priority)
        {
            if (IsFull())
            {
                Console.WriteLine("The queue is full!");
            }
            else
            {
                rear++;
                queue[rear] = new Model(value, priority);
            }
        }

        public void Dequeue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("The queue is empty!");
            }
            else
            {
                int maxIndex = 0;
                int max = queue[0].priority;
                for (int i = front + 1; i <= rear; i++)
                {
                    if (max < queue[i].priority)
                    {
                        max = queue[i].priority;
                        maxIndex = i;
                    }
                }

                Console.WriteLine("Value : " + queue[maxIndex].value + " || Priority : " + queue[maxIndex].priority);
                queue[maxIndex] = queue[rear];
                rear--;
            }
        }

        public void Print()
        {
            if (IsEmpty())
            {
                Console.WriteLine("The queue is empty");
            }

            for (int i = front + 1; i <= rear; i++)
            {
                Console.WriteLine("Value : " + queue[i].value + " || Priority : " + queue[i].priority);
            }
        }

        public bool IsEmpty()
        {
            if (rear == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsFull()
        {
            if ((rear + 1) == size)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
