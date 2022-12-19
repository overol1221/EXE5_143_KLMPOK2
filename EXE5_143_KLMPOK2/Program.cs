using System;
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

    }
    }
