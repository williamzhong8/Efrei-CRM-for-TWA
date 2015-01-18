
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TwaCRM.mission{
	/**
	 * La classe Facture mod�lise une facture associ�e � une mission d'une entreprise attribu� � un int�rimaire.
	 */
	public class Facture {
        
        /**
         * Constructeur par d�faut
         */
        public Facture()
        {
            _uniqueId = _counter;
            _counter++;
        }

		/**
		 * Constructeur
		 */
		public Facture(Mission mission)
        {
            _uniqueId = _counter;
            _counter++;

		    Mission = mission;
		}

        private static int _counter = 0;

        /**
         * Contient l'id unique
         */
        private int _uniqueId;
        public int UniqueId
        {
            get { return _uniqueId; }
            set { _uniqueId = value; }
        }

		/**
		 * Contient la mission concern�e par la facture
		 */
		private Mission _mission;
	    public Mission Mission
	    {
            get { return _mission; }
            set { _mission = value; }
	    }

        /**
         * Surcharge de l'op�rateur ToString
         */
        public override string ToString()
        {
            return Mission.ToString() +
                " | Tarif journalier fixe : " + Mission.EmployeInterim.TarifJournalierFixe +
                " | Tarif journalier variable : " + Mission.EmployeInterim.TarifJournalierVariable;
        }
	}
}