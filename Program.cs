using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    public class Program
    {
        static int size, sizeco, sizero, sizejaggedro;
        static bool success = false;
        static int menu()
        {
            int choice = 0;
            Console.WriteLine("1 - Working With one-dimensional array");
            Console.WriteLine("2 - Working With Two-dimensional array");
            Console.WriteLine("3 - Working With jagged array");
            Console.WriteLine("4 - Exist");
            Console.Write("Please enter your choose : ");
            do{
                success = int.TryParse(Console.ReadLine(), out choice);
                if (!success) Console.WriteLine(" Please Try Again");
            } while (!success);
            switch (choice)
            {
                case 1:
                    onedimansional();
                    break;
                case 2:
                    TwoDimansional();
                    break;
                case 3:
                    jaggedarr();
                    break;
                case 4:
                    break;
                default:
                    Console.WriteLine("Your choose not correct, please enter a correct choose");
                    menu();
                    break;
            }
            return 0;
        }
        static void onedimansional()
        {
            int cho1 = MenuOneDimansional();
            int[] arr = new int[size];
            if (cho1 == 1)
            {
                int subcho1;
                subcho1 = MenuCreateArrOne();
                if (subcho1 == 1)
                {
                    size = ReciveSizeOneDimansionalFromUser();
                    arr = createarronedimansionalbyrandom(ref size);
                    cho1 = MenuOneDimansional();
                }
                else if (subcho1 == 2)
                {
                    size = ReciveSizeOneDimansionalFromUser();
                    arr = createonedimensionalbyuser(ref size);
                    cho1 = MenuOneDimansional();
                }
            }
            if (cho1 == 2)
            {
                RemoveEven(arr, arr.Length);
                cho1 = MenuOneDimansional();
            }
            if (cho1 == 3) menu();
        }
        static int MenuOneDimansional()
        {
            int choiceone;
            Console.WriteLine("1 - Create array");
            Console.WriteLine("2 - Remove first even element");
            Console.WriteLine("3 - Back");
            Console.Write("Please enter your choose");
            do
            {
                success = int.TryParse(Console.ReadLine(), out choiceone);
                if (!success) Console.WriteLine(" Please Try Again");
            } while (!success);
            return choiceone;
        }
        static int MenuCreateArrOne()
        {
            int choicecreate;
            Console.WriteLine("1 - Create an array by Random ");
            Console.WriteLine("2 - Create an array by user ");
            Console.Write("Please enter your choose : ");
            do
            {
                success = int.TryParse(Console.ReadLine(), out choicecreate);
                if (!success) Console.WriteLine(" Please Try Again");
            } while (!success);
            return choicecreate;
        }
        static int ReciveSizeOneDimansionalFromUser()
        {
            int size;
            Console.Write("Please enter size of array : ");
            do
            {
                success = int.TryParse(Console.ReadLine(), out size);
                if (!success) Console.WriteLine(" Please Try Again");
            } while (!success);
            return size;
        }
        static int[] createarronedimansionalbyrandom(ref int size)
        {
            Random rndele = new Random();
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                arr[i] = rndele.Next(0, 1000);
            }
            foreach (int j in arr)
            {
                Console.Write(" " + j + " ");
            }
            Console.WriteLine();
            return arr;
        }
        static int[] createonedimensionalbyuser(ref int size)
        {
            int[] arronebyuser = new int[size];
            for (int i = 1; i <= size; i++)
            {
                Console.Write("Enter an element number  " + i);
                do
                {
                    success = int.TryParse(Console.ReadLine(), out arronebyuser[i]);
                    if (!success) Console.WriteLine(" Please Try Again");
                } while (!success);
            }
            return arronebyuser;
        }
        static int[] RemoveEven(int[] rarr, int size)
        {

            if (rarr.Length == 0)
            {
                Console.WriteLine("This array Empty Please Create arrry ");
                MenuCreateArrOne();
            }
            else
            {
                for (int i = 0; i < rarr.Length; i++)
                {
                    if (rarr[i] % 2 == 0)
                    {
                        for (int j = i; j < size - 1; j++)              
                            rarr[j] = rarr[j + 1];                        
                        break;
                    }
                    else continue;
                }
                for (int i = 0; i < size - 1; i++)
                    Console.Write(" " + rarr[i] + " ");
                Console.WriteLine();
            }
            return rarr;
        }
        //==============================================================================================================================================
        static int[,] CreateTwoDimansionalByRandom()
        {
            Console.Write("Enter size Rows : ");
            do
            {
                success = int.TryParse(Console.ReadLine(), out sizero);
                if (!success) Console.WriteLine(" Please Try Again");
            } while (!success);
            
            Console.Write("Enter size Columns : ");
            do
            {
                success = int.TryParse(Console.ReadLine(), out sizeco);
                if (!success) Console.WriteLine(" Please Try Again");
            } while (!success);
            Random rndele = new Random();
            int[,] arr = new int[sizero, sizeco];
            for (int i = 0; i < sizero; i++)
            {
                for (int j = 0; j < sizeco; j++)
                {
                    arr[i, j] = rndele.Next(0, 1000);
                }
            }
            for (int i = 0; i < sizero; i++)
            {
                for (int j = 0; j < sizeco; j++)
                {
                    Console.Write(" " + arr[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            return arr;

        }
        static int[,] CreateTwoDimansionalByUser()
        {
            Console.Write("Enter size Rows : ");
            do
            {
                success = int.TryParse(Console.ReadLine(), out sizero);
                if (!success) Console.WriteLine(" Please Try Again");
            } while (!success);
          
            Console.Write("Enter size Columns : ");
            do
            {
                success = int.TryParse(Console.ReadLine(), out sizeco);
                if (!success) Console.WriteLine(" Please Try Again");
            } while (!success);
            int[,] arr = new int[sizero, sizeco];
            int eletwodiman;
            for (int i = 0; i < sizero; i++)
            {
                for (int j = 0; j < sizeco; j++)
                {
                    Console.Write("Enter Element Number  ({0},{1})  :  ", i, j);
                    do
                    {
                        success = int.TryParse(Console.ReadLine(), out eletwodiman);
                        if (!success) Console.WriteLine(" Please Try Again");
                    } while (!success);
                    arr[i, j] = eletwodiman;
                }
            }
            for (int i = 0; i < sizero; i++)
                for (int j = 0; j < sizeco; j++)
                    Console.Write(" " + arr[i, j] + " ");
                Console.WriteLine();
            Console.WriteLine();
            return arr;
        }
        static int menuTwoDimansional()
        {
            int choicetwo;
            Console.WriteLine("1 - Create array");
            Console.WriteLine("2 - Remove  Line of elements");
            Console.WriteLine("3 - Back");
            Console.Write("Please enter your choose");
            do
            {
                success = int.TryParse(Console.ReadLine(), out choicetwo);
                if (!success) Console.WriteLine(" Please Try Again");
            }while (!success);
            return choicetwo;
        }
        static int MenuCreateArrTwo()
        {
            int choicecreate;
            Console.WriteLine("1 - Create an array by Random ");
            Console.WriteLine("2 - Create an array by user ");
            Console.Write("Please enter your choose : ");
            do
            {
                success = int.TryParse(Console.ReadLine(), out choicecreate);
                if (!success) Console.WriteLine(" Please Try Again");
            } while (!success);
            return choicecreate;
        }
        static void TwoDimansional()
        {
            int choicetwo = menuTwoDimansional(), subchoicetwo;
            int[,] arr = new int[sizero, sizeco];
            if (choicetwo == 1)
            {
                subchoicetwo = MenuCreateArrTwo();
                if (subchoicetwo == 1)
                {
                    arr = CreateTwoDimansionalByRandom();

                }
                else if (subchoicetwo == 2)
                {
                    arr = CreateTwoDimansionalByUser();

                }
                choicetwo = menuTwoDimansional();
            }
            if (choicetwo == 2)
            {
                RemoveRowFrom2D(arr);
                choicetwo = menuTwoDimansional();

            }
            if (choicetwo == 3) menu();
        }
        static void RemoveRowFrom2D(int[,] originalarr)
        {
            if (originalarr.GetLength(0) == 0 && originalarr.GetLength(1) == 0)
            {
                Console.WriteLine("This array Empty Please Create arrry ");
                menuTwoDimansional();
            }
            else
            {
                int[,] R = new int[originalarr.GetLength(0) - 1, originalarr.GetLength(1)];
                int numrowremove;

                Console.Write("Enter Number of Row you need delete it : ");
                do
                {
                    success = int.TryParse(Console.ReadLine(), out numrowremove);
                    if (!success) Console.WriteLine(" Please Try Again");
                } while (!success);
                for (int i = 0, j = 0; i < originalarr.GetLength(0); i++)
                {
                    if (i == numrowremove) continue;
                    for (int k = 0, u = 0; k < originalarr.GetLength(1); k++)
                    {
                        R[j, u] = originalarr[i, k];
                        u++;
                    }
                    j++;
                }
                for (int i = 0; i < R.GetLength(0); i++)
                {
                    for (int j = 0; j < R.GetLength(1); j++)
                    {
                        Console.Write(" " + R[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
        //===============================================================================================================================================
        static int MenuJagged()
        {
            int choicejagged;
            Console.WriteLine("1 - Create array");
            Console.WriteLine("2 - Add Row to array");
            Console.WriteLine("3 - Back");
            Console.Write("Please enter your choose ");
            success = false;
            do
            {
                success = int.TryParse(Console.ReadLine(), out choicejagged);
                if (!success) Console.WriteLine(" Please Try Again");
            } while (!success);
            return choicejagged;
        }
        static int menuCreateJagged()
        {
            int choicecreate;
            Console.WriteLine("1 - Create an array by Random ");
            Console.WriteLine("2 - Create an array by user ");
            Console.Write("Please enter your choose : ");
            do
            {
                success = int.TryParse(Console.ReadLine(), out choicecreate);
                if (!success) Console.WriteLine(" Please Try Again");
            } while (!success);
            return choicecreate;
        }
        static int[][] CreateJaggedByRandom()
        {
            Random eleRadjagged = new Random();
            Console.Write("Enter number of rows for Jagged array : ");
            do
            {
                success = int.TryParse(Console.ReadLine(), out sizejaggedro);
                if (!success) Console.WriteLine(" Please Try Again");
            } while (!success);
            int[][] arr = new int[sizejaggedro][];
            int numOfEle;
            for (int i = 0; i < sizejaggedro; i++)
            {
                Console.Write("Enter number of element you need add in row number  {0} : ", i);
                do
                {
                    success = int.TryParse(Console.ReadLine(), out numOfEle);
                    if (!success) Console.WriteLine(" Please Try Again");
                } while (!success);
                arr[i] = new int[numOfEle];
                for (int j = 0; j < numOfEle; j++)
                {
                    arr[i][j] = eleRadjagged.Next(0, 1000);
                }
            }
            for (int i = 0; i < sizejaggedro; i++)
            {
                Console.Write("{0} ==>", i);
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(" " + arr[i][j] + " ");
                }
                Console.WriteLine();
            }

            return arr;
        }
        static int[][] CreateJaggedByUser()
        {
            Console.Write("Enter number of rows for Jagged array");
            sizejaggedro = int.Parse(Console.ReadLine());
            int[][] arr = new int[sizejaggedro][];
            int numOfEle, elejagged;
            for (int i = 0; i < sizejaggedro; i++)
            {
                Console.Write("Enter number of element you need add in row number  {0}", i);
                numOfEle = int.Parse(Console.ReadLine());
                arr[i] = new int[numOfEle];
                for (int j = 0; j < numOfEle; j++)
                {
                    Console.Write("Enter element number {0} in row number {1}", j, i);
                    elejagged = int.Parse(Console.ReadLine());
                    arr[i][j] = elejagged;
                }
            }
            for (int i = 0; i < sizejaggedro; i++)
            {
                Console.Write("{0} ==>", i);
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(" " + arr[i][j] + " ");
                }
                Console.WriteLine();
            }

            return arr;
        }
        static int[][] AddrowTojagged(int[][] originalarr)
        {
            int[][] R = new int[originalarr.Length + 1][];
            int numofRowAdd, numofele, ele; bool ch = false;
            Console.Write("Enter a number of row you need ADD it ");
            do
            {
                success = int.TryParse(Console.ReadLine(), out numofRowAdd);
                if (!success) Console.WriteLine(" Please Try Again");
            } while (!success);
            Console.Write("Enter number of elements you need add in new row ");
            do
            {
                success = int.TryParse(Console.ReadLine(), out numofele);
                if (!success) Console.WriteLine(" Please Try Again");
            } while (!success);
            for (int i = 0; i < originalarr.Length + 1; i++)
            {
                if (i == numofRowAdd)
                {
                    R[i] = new int[numofele];
                    for (int x = 0; x < numofele; x++)
                    {
                        Console.Write("Enter element ");
                        do
                        {
                            success = int.TryParse(Console.ReadLine(), out ele);
                            if (!success) Console.WriteLine(" Please Try Again");
                        } while (!success);
                        R[i][x] = ele;
                    }
                    ch = true;
                }
                else
                {
                    if (ch == true)
                    {
                        R[i] = new int[originalarr[i - 1].Length];
                        int j;
                        for (j = 0; j < originalarr[i - 1].Length; j++)
                            R[i][j] = originalarr[i - 1][j]; j = 0;
                    }
                    else
                    {
                        R[i] = new int[originalarr[i].Length];
                        for (int k = 0; k < originalarr[i].Length; k++)
                            R[i][k] = originalarr[i][k];
                    }
                }
            }
            for (int i = 0; i < sizejaggedro + 1; i++)
            {
                for (int j = 0; j < R[i].Length; j++)
                    Console.Write(" " + R[i][j] + " ");
                Console.WriteLine();
            }
            return R;
        }
        static void jaggedarr()
        {
            int chojagged;
            int[][] arr = new int[sizejaggedro][];
            chojagged = MenuJagged();
            if (chojagged == 1)
            {
                int chojaggedcreate = menuCreateJagged();
                if (chojaggedcreate == 1)
                {
                    arr = CreateJaggedByRandom();
                    chojagged = MenuJagged();
                }
                else
                {
                    arr = CreateJaggedByUser();
                    chojagged = MenuJagged();
                }
            }
            if (chojagged == 2)
            {
                AddrowTojagged(arr);
                chojagged = MenuJagged();
            }
            if (chojagged == 3) menu();


        }

        static void Main(string[] args)
        {
            Console.WriteLine("\t\tLab 5");
            menu();
        }
    }
}


  
