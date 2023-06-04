using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace tp1{
    class Employe{
            private int matricule;
            private float tarifH;
            private int nbHeures;
            private static int compteurInstance = 0;
            public double SalaireTotal{get; private set;}
            public double SalaireDeBase {get; private set;}
            public string Nom {get; private set;}
            public Employe(string nom="", float tarif=100){
                Nom = nom;
                tarifH = tarif;
                compteurInstance++;
                matricule = compteurInstance;
            }
            public int HeuresDeTravail {
                get => nbHeures;
                set{
                    if(value>0){
                        nbHeures=value;
                    }
                    else{
                        nbHeures=0;
                    }
                }
            }
            virtual public void CalculerSalaire(){
                SalaireDeBase = tarifH*HeuresDeTravail;
                SalaireTotal = SalaireDeBase;
            }
            public override string ToString(){
                return $"Nom :{Nom} - Matricule : {matricule}";
            }
        
    }
    ////ici la methode main
    public static void Main(){
        Employe e1 = new Employe("lilich", 200);
        Employe e2 = new Employe("mimich", 300);
        e1.HeuresDeTravail = 20;
        e1.CalculerSalaire();
        Console.WriteLine(e1);
    }
}
