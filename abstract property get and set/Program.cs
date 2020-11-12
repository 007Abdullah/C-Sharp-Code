using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_property_get_and_set
{
    class Program
    {
        static void Main(string[] args)
        {
            ABdullah obj = new ABdullah();
            obj.DiamensionOne = 20;
            obj.DiamensionTwo = 4.233F;
            Console.WriteLine("Area OF  Rectangle :" + obj.Area());
        }
    }
    public abstract class Fingure
    {

        public abstract float DiamensionOne
        {
            set;
        }
        public abstract float DiamensionTwo
        {
            set;
        }
    }
    public class ABdullah : Fingure
    {
        float dimensionOne;
        float dimensionTwo;


        public override float DiamensionOne
        {

            set
            {
                if (value < 0)
                {
                    dimensionOne = 0;

                }
                else
                {
                    dimensionOne = value;
                }
            }
        }
        public override float DiamensionTwo
        {
            set
            {
                if (value <= 0)
                {
                    dimensionTwo = 0;
                }
                else
                {
                    dimensionTwo = value;
                }

            }
        }
      public  float Area()
        {
            return dimensionOne * dimensionTwo;
        } 
    }
    
}
