//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Day6Concepts.MethodOverLoading
//{
//    public class MethodOverLoading
//    {
//        #region Method Over Loading with different Number of Parameters
//        public static void Add(int FN, int SN)
//        {
//            Console.WriteLine("Sum={0}", FN, SN);
//        }

//        public static void Add(int FN, int SN, int TN)
//        {
//            Console.WriteLine("Sum={0}", FN, SN);
//        }
//        #endregion

//        #region Method Over Loading with different Type of Parameters
//        public static void Add(int FN, int SN)
//        {
//            Console.WriteLine("Sum={0}", FN, SN);
//        }

//        public static void Add(float FN, float SN)
//        {
//            Console.WriteLine("Sum={0}", FN, SN);
//        }
//        #endregion

//        #region Method Over Loading with different Kind of Parameters
//        public static void Add(int FN, int SN, int TN)
//        {
//            Console.WriteLine("Sum={0}", FN, SN);
//        }

//        public static void Add(int FN, int SN, out TN)
//        {
//            Console.WriteLine("Sum={0}", FN, SN);
//            TN = FN + SN;
//        }
//        #endregion 
//        }
//    }
