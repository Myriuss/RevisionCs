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
            public double SalaireTotal{get; private set;}
            public double SalaireDeBase {get; private set;}
            public string Nom {get; private set;}
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
        
    }
}
