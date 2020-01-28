﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exempel_2._5
{
    public class Samling<T>
    {
        protected int buffert;  //storleken på buffert.
        protected T[] lista;    //Samling av element av vilken typ som helst
        protected int längd;    //Antal tillgängliga platser.
        protected int antal;    //Antal använda platser.

        public Samling()
        {
            buffert = 30;
            antal = 0;
            längd = 30;
            lista = new T[längd];
        }

        protected void Expandera(int storlek)
        {
            if (storlek < 1) return;

            //Gör ett nytt större fält.
            T[] temp = new T[längd + storlek];

            //Kopiera över värden från det gamla fältet.
            for (int i = 0; i < antal; i++) temp[i] = lista[i];

            lista = temp;
            längd += storlek;
        }

        protected void Reducera()
        {
            //Gör en ny mindre lista.
            T[] temp = new T[antal];

            //Kopiera över värden från det gamla fältet.
            for (int i = 0; i < antal; i++) temp[i] = lista[i];

            lista = temp;
            längd = antal;
        }

        public void LäggTill(T e)
        {
            //Skafa fler platser om det behövs.
            if (antal + 1 > längd) Expandera(1 + buffert);

            lista[antal++] = e;
        }

        public T Tabort(int index)
        {
            T temp = lista[index];

            //Flytta alla element efter index ett steg åt vänster.
            for (int i = index; i < antal - 1; i++)
            {
                lista[i] = lista[i + 1];
            }

            antal--;

            //Krymp fältet om det finss för många tomma platser.
            if (längd - antal > buffert) Reducera();

            return temp;
        }

        public T ElementFrån(int index)
        {
            return lista[index];
        }
    }

}
