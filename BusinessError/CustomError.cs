using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessError
{
    public class CustomError:Exception
    {
        private int _ID;
        private string _Message;

        public int ID
        {
            get { return _ID; }

        }
        public override string Message
        {
            get { return _Message; }
        }

      
        public CustomError(int pID)
        {
            string MyMessage;

            switch (pID)
            {
                case 1:
                    MyMessage = "Le user n'est pas reconnu...";
                    break;
              
                case 4:
                    MyMessage = "pour rechercher il faut au moins 3 caractères";
                    break;
                case 5:
                    MyMessage = "ce livre n'est pas disponible dans notre bibliotheque";
                    break;
                case 6:
                    MyMessage = "tous les exemplaires ont  déjà été empruntés";
                    break;
               case 13:
                    MyMessage = "ce livre est en emprunt";
                    break;
                default:
                    MyMessage = "Erreur non connue...";
                    _ID = 999;
                    break;
            }

            _Message = MyMessage;
        }

    }
}
