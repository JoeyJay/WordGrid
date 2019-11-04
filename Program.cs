using System;
using System.Collections.Generic;

namespace Lab
{
    class Program
    {
        static int ROW = 0;
        static int COL = 0;

        static string textfile = System.IO.File.ReadAllText("csv.txt");

        static string[] dictionary = textfile.Split(',');

        static int n = dictionary.Length;

        static void Main(string[] args)
        {

             Console.WriteLine("Enter size of matrix"); //change to something more meaningful
             int table_size = Convert.ToInt32(Console.ReadLine());
             ROW = table_size;
             COL = table_size;
             if(table_size <= 10 && table_size >= 2){ 
                char[,] arr = create_arr(table_size);
                print_arr(arr, table_size);
                  Console.WriteLine("Following words of " +
                "dictionary are present");
                search(arr);
             }
             else{
                 Console.WriteLine("Invalid entry");
                 Environment.Exit(1);
             }
             
             //List<int> lts = new List<int>();
             //var x = lts.add(arr[3]);
             // Console.WriteLine(x);
            //move_right(node);
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

        public static void print_arr(char[,] arr, int table_size)
        {
        for (int row = 0; row < table_size; row++)
            {
                for (int col = 0; col < table_size; col++)
                Console.Write(String.Format("{0}\t", arr[row,col]));
                Console.WriteLine();
            }  
        }

        public static void search(char[,] arr)
        {   
            //StringBuilder sb = new StringBuilder();
            bool[,] visited = new bool[ROW, COL];
            String str = " ";
            int j = 0, i = 0;
            for( i = 0; i < ROW; i++){
                for( j = 0; j < COL; j++){
                    searchGrid(arr, visited, i, j, str);          
            str = "" + str[str.Length - 1]; 
            visited[i, j] = false;
                }
            }          
        }

        public static void searchGrid(char [,] arr, bool [,]visited, int r, int c, String str)
        {
            visited[r, c] = true;
            str = str + arr[r,c];
            if(isWord(str))
                Console.WriteLine(str);

           for (int row = r - 1; row <= r + 1 && row < ROW; row++)
            for (int col = c - 1; col <= c + 1 && col < COL; col++) 
                if (row >= 0 && col >= 0 && !visited[row, col]) 
                    searchGrid(arr, visited, row, col, str);  
        }

        static bool isWord(String str) 
        { 
            for (int i = 0; i < n; i++) 
                if (str.Equals(dictionary[i])) 
                    return true; 
            return false; 
        } 


    }
}
