using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sortering_Selection
{
    public class Metoder
    {
        public static void Swap(ref int a,ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }  
        public static void SelectionSort(List<int> lista)
        {
            for(int k=0;k<lista.Count-1;k++)
            {
                int minsta = k;
                for(int j=k+1;j<lista.Count;j++)
                {
                    if (lista[j]<lista[minsta])
                    {
                        minsta=j;
                    }
                }
                int temp = lista[minsta];
                lista[minsta] = lista[k];
                lista[k]=temp;
            }
        }
        public static void BubbleSort(List<int> lista)
        {
            for(int k=0;k<lista.Count-1;k++)
            {
                for(int j=0;j<lista.Count-1;j++)
                {
                    if(lista[j]>lista[j+1])
                    {
                        int temp = lista[j];
                         lista[j]=lista[j+1];
                        lista[j+1]=temp;
                    }
                 } 

            }           
        }
        public static void InsertionSort(List<int> lista)
        {
            for (int i = 1; i < lista.Count; i++)
            {
		        for (int j = i; j > 0; j--)
		        {
			        if (lista[j] < lista[j - 1])
			        {
				        int temp = lista[j - 1];
				        lista[j - 1] = lista[j];
				        lista[j] = temp;
			        }
                }
            }

        }
        public static List<int> MergeSort(List<int> lista,int vänster,int höger)
        {
            if(vänster<höger)
            {
                int mitten = vänster+(höger-vänster)/2;
                MergeSort(lista, vänster, mitten);
                MergeSort(lista, mitten+1 , höger);
                MergeLista(lista, vänster, mitten, höger);
            }
            return lista;
        }
        public static void MergeLista(List<int> lista, int vänster, int mitten, int höger)
        {
            var vänsterlistalängd = mitten -vänster+1;
            var högerlistalängd = höger - mitten;
            var tempvänsterlista = new List<int>(vänsterlistalängd);
            var temphögerlista = new List<int>(högerlistalängd);
            int i,j;


            for(i=0;i<vänsterlistalängd;i++)
            {
                tempvänsterlista.Add( lista[vänster+i]);
            }

            for(j=0;j<högerlistalängd;j++)
            {
                temphögerlista.Add(lista[mitten+1+j]);
            }

            i=0;
            j=0;
            int k = vänster;

            while (i < vänsterlistalängd && j < högerlistalängd)
            {
                 if (tempvänsterlista[i] <= temphögerlista[j])
                {
                      lista[k++] = tempvänsterlista[i++];
                }
                else
                {
                     lista[k++] = temphögerlista[j++];
                }
            }
            while (i < vänsterlistalängd)
            {
                lista[k++] = tempvänsterlista[i++];
            }
            while (j < högerlistalängd)
            {
                lista[k++] = temphögerlista[j++];
            }

        }
        public static List<int> QuickSort(List<int> lista,int vänster,int höger)
        {
            var i = vänster;
            var j = höger;
            var sväng = lista[vänster];
            
            while(i<=j)
            {
                while(lista[i]<sväng)
                {
                    i++;
                }
                while(lista[j]>sväng)
                {
                    j--;
                }
                if(i<=j)
                {
                    int temp = lista[i];
                    lista[i]=lista[j];
                    lista[j]=temp;
                    i++;
                    j--;
                }
            }
            if(vänster<j)
            {
                QuickSort(lista,vänster,j);
            }
            if(i<höger)
            {
                QuickSort(lista,i,höger);
            }
            return lista;
        }
    }
}
    
