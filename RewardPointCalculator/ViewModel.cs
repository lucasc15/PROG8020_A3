using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RewardPointCalculator
{
    class ViewModel: ObservaleObject
    {
        private int _books;
        public int books
        {
            get { return _books; }
            set { _books = value; }
        }

        private int _points;
        public int points
        {
            get { return _points;  }
            set { _points = value; OnPropertyChanged(); }
        }
        
        public void calculatePoints ()
        {
            if (books <= 0)
            {
                points = 0;
            } else {
                switch (books)
                {
                    case 1:
                        points = 5;
                        break;
                    case 2:
                        points = 15;
                        break;
                    case 3:
                        points = 30;
                        break;
                    default:
                        points = 60;
                        break;
               }
            }
        }
    }
}
