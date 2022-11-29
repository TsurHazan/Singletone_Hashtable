using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace exc_hashtable
{
    public class Manager
    {
        private readonly Random rnd = new Random();
        public Hashtable tbl = new Hashtable();
        private Manager() { }

        private static Manager _Instance;
        public static Manager Instance
        {
            get { 
            if (_Instance == null)
            {
                _Instance = new Manager();
                    
            }
                return _Instance; 
            }
        }

        public void loadTable()
        {
            for (int i = 0; i < 1000; i++)
            {
                int num = rnd.Next(100, 10000);
                if (num % 2 == 0)
                {
                    falafel newF=new falafel();
                    newF.id=num;
                    num = rnd.Next(1, 6);
                    newF.ballAmount = num;
                    addToTbl(newF);
                }
                else
                {
                    IceCream newIC = new IceCream();
                    newIC.id=num;
                    num = rnd.Next(1, 6);
                    newIC.ballAmount=num;
                    addToTbl(newIC);
                }
            }
        }

        private void addToTbl(object obj)
        {
            if (obj is falafel)
            {
                falafel item=(falafel)obj;
                try
                {
                    tbl.Add(item.id, item);
                }
                catch (Exception)
                {
                     Console.WriteLine("Key "+item.id+" is used" );
                }
                
            }
            else
            {
                IceCream item=(IceCream)obj;
                try
                {
                    tbl.Add(item.id, item);
                }
                catch (Exception)
                {
                    Console.WriteLine("Key " + item.id + " us used");
                }

            }
        }
        
    }
}
