﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXE5_143_KLMPOK2
{

    class node
    {
        int AHMAD, REAR, max = 5;
        int[] queue_array = new int[5];

        public node()
        {
            AHMAD = -1;
            REAR = -1;
        }
        public void insert(int element)
        {

            if ((AHMAD == 0 && REAR == max - 1) || (AHMAD == REAR + 1))
            {
                Console.WriteLine("\nQueue overvlow\n");
                return;
            }
            if (AHMAD == -1)
            {
                AHMAD = 0;
                REAR = 0;
            }
            else
            {

                if (REAR == max - 1)
                    REAR = 0;
                else;

                REAR = REAR + 1;
            }
            queue_array[REAR] = element;
        }
        public void remove()
        {
            if (AHMAD == -1)
            {
                Console.WriteLine("Queue underflow\n");
                return;
            }
            Console.WriteLine("\nThe Elements deleted from queue is: " + queue_array[AHMAD]
                + "\n");
            if (AHMAD == REAR)
            {
                AHMAD = -1;
                REAR = -1;
            }
            else
            {
                if (AHMAD == max - 1)
                    AHMAD = 0;
                else
                    AHMAD = AHMAD + 1;
            }
        }

        public void display()
        {
            int FRONT_position = AHMAD;
            int REAR_position = REAR;
         
            if (AHMAD == -1)
            {
                Console.WriteLine("Queue is empty\n");
                return;
            }
            Console.WriteLine("\nElements in the queue are ...............................\n");
            if (FRONT_position <= REAR_position)
            {
      
                while (FRONT_position <= REAR_position)
                {
                    Console.Write(queue_array[FRONT_position] + "  ");
                    FRONT_position++;
                }
                Console.WriteLine();
            }
            else
            {
               
                while (FRONT_position <= max - 1)
                {
                    Console.Write(queue_array[FRONT_position] + "  ");
                    FRONT_position++;
                }
               
                FRONT_position = 0;
         
                while (FRONT_position <= REAR_position)
                {
                    Console.Write(queue_array[FRONT_position] + "  ");
                    FRONT_position++;
                }




            }
        }
    }
}
