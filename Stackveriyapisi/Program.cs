using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stackveriyapisi
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Stack
    {
        public int[] dizi;
        private int kapasite;
        private int indeks;
        public Stack(int kapasite)
        {
            if (kapasite <= 0)
            {
                throw new Exception("Dizinin kapasitesi o veya 0'dan az olamaz.");
            }
            else
            {
                this.kapasite = kapasite;
                dizi= new int[kapasite];    
            }
        }
        public void Push(int deger)
        {
            if(isFull()==true)
            {
                throw new Exception("Diziye eleman eklemek için yer yoktur.");
}
            dizi[indeks++] = deger;
        }
        public int Pop()
        {
            if(isEmpty()==true)
            {
                throw new Exception("Diziden eleman çıkarmak için eleman yoktur.");
            }
            return dizi[--indeks];
        }
        public int Peek()
        {
            if(isEmpty()==true)
            {
                throw new Exception("Dizinin son giren bir elemanı yok.");
            }
            return dizi[--indeks];
        }
            public int Size()
        {
            return indeks;
        }
        public bool isFull()
        {
            return indeks == kapasite;
        }
        public bool isEmpty()
        {
            return indeks == 0;
        }
    }
}
