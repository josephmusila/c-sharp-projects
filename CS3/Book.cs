using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CS3
{
    public class Book
    {
       public string title;
       private string director;
      private string rating;

        public Book(string aTitle, string aDirector, string aRating)
        {
            title=aTitle;
            Director=aDirector;
            Rating=aRating;
        }
        public string Rating  
        {
            get { return rating; }
            set { 
                if(value=="G" || value=="PG" || value=="PG_13" || value=="R" || value=="NR")
                {
                    rating=value;
                }else{
                    rating="NR";
                }
            }
        }
        public string Director
        {
            get{
                return director;
            }
            set{
                if(value=="A" || value=="B" || value=="C" || value=="D")
                {
                    director=value;
                }else{
                    director="No Director";
                }
            }
        }
    }
}