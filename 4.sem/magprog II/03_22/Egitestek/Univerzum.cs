﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egitestek
{
    class Univerzum
    {
        private List<Egitest> egitestek = new List<Egitest>();

        public void AddEgitest(string nev,int eletkor)
        {
            Egitest ujEgitest = new Egitest(nev, eletkor);


            if (egitestek.Contains(ujEgitest))
            {
                throw new Exception("A lista mar tartalmazza ezt az egutestet");

            }
            egitestek.Add(ujEgitest);

        }

        public void AddCsillag(string nev, int eletkor,CsillagOsztaly osztaly ,double atmero)
        {
            Csillag ujCsillag = new Csillag(nev, eletkor, osztaly, atmero);


            if (egitestek.Contains(ujCsillag))
            {
                throw new Exception("A lista mar tartalmazza ezt az egutestet");

            }
            egitestek.Add(ujCsillag);

        }
        public void AddBolygo(string nev, int eletkor, BolygoOsztaly osztaly, double keringesiTavolsag)
        {
            Bolygo ujBolygo = new Bolygo(nev, eletkor, osztaly, keringesiTavolsag);


            if (egitestek.Contains(ujBolygo))
            {
                throw new Exception("A lista mar tartalmazza ezt az egutestet");

            }
            egitestek.Add(ujBolygo);

        }

        public List<Egitest> OsszesEgitest
        {
            get
            {
                List<Egitest> masolat = new List<Egitest>();

                foreach (Egitest egitest in egitestek)
                {
                    if (egitest is Bolygo)
                    {
                        Bolygo temp = egitest as Bolygo;

                        Bolygo bolygoMasolat = new Bolygo(temp.Nev, temp.Eletkor, temp.BolygoOsztaly, temp.KeringesiTavolsag);

                        masolat.Add(bolygoMasolat);
                    }
                    else if(egitest is Csillag)
                    {
                        Csillag temp = egitest as Csillag;

                        Csillag csillagMasolat = new Csillag(temp.Nev, temp.Eletkor, temp.CsillagOsztaly, temp.Atmero);

                        masolat.Add(csillagMasolat);
                    }
                    else
                    {
                        Egitest egitestMasolat = new Egitest(egitest.Nev, egitest.Eletkor);

                        masolat.Add(egitestMasolat);
                    }
                }
                return masolat;
            }
        }

        public List<Csillag> Csillagok
        {
            get
            {
                List<Csillag> masolat = new List<Csillag>();

                foreach (Egitest egitest in egitestek)
                {
                    if (egitest is Csillag)
                    {
                        Csillag temp = egitest as Csillag;

                        Csillag csillagMasolat = new Csillag(temp.Nev, temp.Eletkor, temp.CsillagOsztaly, temp.Atmero);

                        masolat.Add(csillagMasolat);
                    }
                }

                return masolat;
            }
        }

        public List<Csillag> NeutronCsillagok
        {
            get
            {
                List<Csillag> masolat = new List<Csillag>();

                foreach (Egitest egitest in egitestek)
                {
                    if (egitest is Csillag && (egitest as Csillag).CsillagOsztaly == CsillagOsztaly.Neutron)
                    {
                        Csillag temp = egitest as Csillag;

                        Csillag csillagMasolat = new Csillag(temp.Nev, temp. Eletkor, temp.CsillagOsztaly, temp.Atmero);

                        masolat.Add(csillagMasolat);
                    }
                }
                return masolat;
            }
        }


        public List<Csillag> Bolygok
        {
            get
            {
                List<Bolygo> masolat = new List<Bolygo>();

                foreach (Egitest egitest in egitestek)
                {
                    if (egitest is Bolygo)
                    {
                        Bolygo temp = egitest as Bolygo;

                        Bolygo bolygoMasolat = new Csillag(temp.Nev, temp.Eletkor, temp.BolygoOsztaly, temp.KeringesiTavolsag);

                        masolat.Add(bolygoMasolat);
                    }
                }

                return masolat;
            }
        }

        public Bolygo LegTavolabbiBolygo
        {
            get
            {
                if (egitestek.Count==0)
                {
                    throw new Exception("Az egitestek lista ures")
                }

                Bolygo max = null;
                foreach (Egitest egitest in egitestek)
                {
                    if (egitest is Bolygo)
                    {
                        max = egitest as Bolygo;
                        break;
                    }
                }

                if (max == null)
                {
                    throw new Exception("A lista nem tartalmaz bolygot");
                }

                foreach (Egitest egitest in egitestek)
                {
                    if (egitest is Bolygo && (egitest as Bolygo).KeringesiTavolsag > max.KeringesiTavolsag)
                    {
                        max = egitest as Bolygo;
                    }
                }

                return new Bolygo(max.Nev, max.Eletkor, max.BolygoOsztaly, max.KeringesiTavolsag);
            }
        }



        //bolygokat lekerdezo property
        //legtavolabbi bolygo, bolygo a visszateresi erteke, mi van akkor ha ures a lista
    }
}
