﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Konyvek_03_08
{
    class Konyv
    {
        private int id;
        private string szerzo;
        private string cim;
        private int ar;
        private string isbn;

        private static int ID = 0;

        /// <summary>
        /// Az osztály alapinformációi
        /// </summary>
        /// <param name="szerzo">A könyv szerzője</param>
        /// <param name="cim">A könyv címe</param>
        /// <param name="ar">A könyv ára</param>
        /// <param name="isbn">A könyv ISBN száma</param>

        public Konyv(string szerzo,string cim, int ar, string isbn)  //  <-- KONTSTRUKTOR
        {
            this.Id = ID;
            ID++;
            this.Szerzo = szerzo;
            this.Cim = cim;
            this.Ar = ar;
            this.Isbn = isbn;
        }

        //csak a szerzőt és a címet kérjük be
        public Konyv(string szerzo, string cim):this(szerzo,cim,3000,"I-898765432-1")
        {

        }
            

        //sZERZŐ,CÍM,ÁR
        public Konyv(string szerzo, string cim, int ar):this(szerzo,cim,ar,"I-47183271-1")
        {

        }


        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                if (value<0)
                {
                    throw new Exception("Az ID értéke nem lehet negatív");
                }
                id = value;
            }
        }

        public string Szerzo
        {
            get
            {
                return szerzo;
            }
            private set
            {
                if (string.IsNullOrEmpty(value) || value.Length<3)
                {
                    throw new Exception("A szerző nem lehet üres, vagy 3 karakternél kisebb");
                }
                szerzo = value;
            }
        }

        private bool cimMegadva = false;
        public string Cim
        {
            get
            {
                return cim;
            }
            set
            {
                if (value.Length<3)
                {
                    throw new Exception("A címnek legalább 3 karakternek kell lennie");
                }

                if (cimMegadva)
                {
                    throw new Exception("A cím már egyszer meg lett adva!");
                }

                cim = value;
                cimMegadva = true;
            }
        }

        public int Ar
        {
            get
            {
                return ar;
            }
            set
            {
                if (value < 250 || value > 50000)
                {
                    throw new Exception("Az ár értékénel a [250;50000] tartományban kell lennie!");
                }
                ar = value;
            }
        }

        public string Isbn
        {
            get
            {
                return isbn;
            }
            set
            {
                isbn = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sr = new StringBuilder();

            sr.AppendFormat("ID: {0}\n", this.Id);
            sr.AppendFormat("Szerző: {0}\n", this.Szerzo);
            sr.AppendFormat("Cím: {0}\n", this.Cim);
            sr.AppendFormat("Ár: {0}\n", this.Ar);
            sr.AppendFormat("ISBN: {0}\n", this.Isbn);

            return sr.ToString();
        }

        public override bool Equals(object obj)
        {
            if (obj is Konyv)
            {
                Konyv masik = obj as Konyv;

                return this.Szerzo == masik.Szerzo 
                    && this.Cim==masik.Cim;
            }

            return false;
        }
    }
}
