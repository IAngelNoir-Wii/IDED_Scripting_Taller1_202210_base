using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace TestProject1
{
    internal class TestMethods
    {
        private static List<Ticket> requestType;

        internal enum EValueType
        {
            Two,
            Three,
            Five,
            Seven,
            Prime
        }
        class orde { 
            public Ticket.ERequestType requestType { get; set; }
            public int turno { get; set; }
                }
        

        internal static Stack<int> GetNextGreaterValue(Stack<int> sourceStack)
        {
            Stack<int> result = sourceStack;
            int[,] respuesta;
            int NoMayor = -1;

            for (int j = 0; j < 3; j++) 
            {
                int Elementos = result.Pop();
                int Comparador = Elementos;
                if (j < 3)
                {
                    for(int i = 3; i == 0; i--)
                    {
                        int Comparadorn=result.Pop();
                        
                        if (Comparador < Comparadorn)
                        {
                           respuesta=new int[Comparador,Comparadorn];
                        }
                    }
                    respuesta = new int[Comparador, NoMayor];

                }
                if (j == 3)
                {
                    respuesta = new int[Comparador, NoMayor];
                }
            }
            return result;
        }

        internal static Dictionary<int, EValueType> FillDictionaryFromSource(int[] sourceArr)
        {
            Dictionary<int, EValueType> result = null;

            for (int i = 0; i < sourceArr.Length; i++)
            {
                
                if (sourceArr[i] % 2 == 0)
                {
                    int dos=sourceArr[i];
                    result= new Dictionary<int, EValueType>()
                    {
                        {dos,EValueType.Two },
                    };
                }
                else if (sourceArr[i] % 3 == 0)
                {
                    int tres = sourceArr[i];
                    result = new Dictionary<int, EValueType>()
                    {
                        {tres,EValueType.Three },
                    };
                }
                else if (sourceArr[i] % 5 == 0)
                {
                    int cnco = sourceArr[i];
                    result = new Dictionary<int, EValueType>()
                    {
                        {cnco,EValueType.Five },
                    };
                }
                else if (sourceArr[i] % 7 == 0)
                {
                    int siete = sourceArr[i];
                    result = new Dictionary<int, EValueType>()
                    {
                        {siete,EValueType.Seven },
                    };
                }
                else
                {
                    int primo = sourceArr[i];
                    result = new Dictionary<int, EValueType>()
                    {
                        {primo,EValueType.Prime },
                    };
                }
            }

            return result;
        }

        internal static int CountDictionaryRegistriesWithValueType(Dictionary<int, EValueType> sourceDict, EValueType type)
        {
            int count2 = 0,count3 = 0,count5 = 0,count7 = 0,count0 = 0 ;
            for (int i = 0; i < sourceDict.Count; i++)
            {
                if (sourceDict[i] == EValueType.Two) 
            {
                 count2++;
            }
            else if (sourceDict[i] == EValueType.Three)
            {
                count3++;
                
            }
            else if (sourceDict[i] == EValueType.Five)
            {
                count5++;
                
            }
            else if (sourceDict[i] == EValueType.Seven)
            {
                count7++;
                
            }
            else
            {
                count0++;
                
            }
                Console.WriteLine("Hay "+count2+" llaves pares");
                Console.WriteLine("Hay " + count3 + " llaves multiplo de 3");
                Console.WriteLine("Hay " + count5 + " llaves multiplo de 5");
                Console.WriteLine("Hay " + count7 + " llaves multiplo de 7");
                Console.WriteLine("Hay " + count0 + " llaves primos");

            }
            return 0;

        }

        internal static Dictionary<int, EValueType> SortDictionaryRegistries(Dictionary<int, EValueType> sourceDict)
        {
            Dictionary<int, EValueType> result = null;

            var myList = sourceDict.ToList();

            myList.Sort((pair1, pair2) => pair1.Value.CompareTo(pair2.Value));
            foreach (var value in myList)
            {
                Console.WriteLine(value);
            }

            return result;
        }

        internal static Queue<Ticket>[] ClassifyTickets(List<Ticket> sourceList)
        {
            Queue<Ticket>[] result = null;

            Queue PaymentQ=new Queue();
            Queue CancelletionQ = new Queue();
            Queue SubscriptionQ = new Queue();

            for (int i = 0; i < sourceList.Count; i++)
            {
                if(sourceList[i].RequestType==Ticket.ERequestType.Payment)
                {
                    PaymentQ.Enqueue(sourceList[i]);
                }
                else if (sourceList[i].RequestType == Ticket.ERequestType.Cancellation)
                {
                    CancelletionQ.Enqueue(sourceList[i]);
                }
                else
                {
                    SubscriptionQ.Enqueue(sourceList[i]);
                }
            }
            
            return result;
        }

        internal static bool AddNewTicket(Queue<Ticket> targetQueue, Ticket ticket)
        {
            bool result = false;
          
            return result;
        }        
    }
}