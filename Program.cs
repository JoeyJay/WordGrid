using System;
using System.Collections.Generic;

namespace Lab
{
    class Program
    {
        static void Main(string[] args)
        {
             //ceate array of  words to test
             Console.WriteLine("Enter size of matrix"); //change to something more meaningful
             int table_size = Convert.ToInt32(Console.ReadLine());
             if(table_size <= 8 && table_size >= 3){ // TODO add try catch for invalid entries
                char[,] arr = create_arr(table_size);
                print_arr(arr, table_size);
             }
             else{
                 Console.WriteLine("Invalid entry");
                 Environment.Exit(1);
             }
             
             Console.WriteLine(table_size);
             //List<int> lts = new List<int>();
             //var x = lts.add(arr[3]);
             // Console.WriteLine(x);
            //move_right(node);
        }
        public static void move_right(char[,] r_arr, int table_size)
        {     
            var temp = 0;
            for(int r = 0; r < table_size; r++){
               for (int c = 0; c < table_size; c++){
                   temp = r_arr[r,c+1];
            }      
            Console.WriteLine(temp);
            }
        }


        public static char[,] create_arr(int table_size)
        {
           char[,] arr = new char[table_size,table_size];
           Random rnd = new Random ();
           for (int r = 0; r  < table_size; r++){
               for (int c = 0; c < table_size; c++){
                   arr[r,c] = (char)rnd.Next('a','z');
               }
           }
           return arr;
        }

        public static void print_arr(char[,] arr, int table_size)//refactor to get table size from arr
        {
        for (int row = 0; row < table_size; row++)
            {
                for (int col = 0; col < table_size; col++)
                Console.Write(String.Format("{0}\t", arr[row,col]));
                Console.WriteLine();
            }  
        }

        public static void search(char[,] arr[row,col])//get length of arr instead of specifying rc values
        {   
            StringBuilder sb = new StringBuilder();
        }
    }
}
