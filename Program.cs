using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ANDREW_S_ASSIGNMENT_2
{
    public delegate int StudentDetails(string A, int B);
    class Program
    {

        private string getStudentName;
        private int getStudentId;
        private string address;
        public string StudentAddress
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }

        }

        static void Main(string[] args)
        {
            Program K = new Program();
            K.getStudentName = "ANDREW";
            Console.WriteLine("The student's name is: " + K.getStudentName);
            K.getStudentId = 143;
            Console.WriteLine("The student's ID is: " + K.getStudentId);
            K.StudentAddress = "LIRA";
            Console.WriteLine("The student's Address is: " + K.StudentAddress);
            Dictionary<string, string> T = new Dictionary<string, string>();
            T.Add("id", "143");
            T.Add("name", "ANDREW");
            T.Add("address", "LIRA");
            ICollection G = T.Keys;
            Console.WriteLine("Keys \t Values");
            Console.WriteLine("----------------------");
            IDictionaryEnumerator objDictionayEnumerator =
T.GetEnumerator();
            while (objDictionayEnumerator.MoveNext())
            {
                Console.WriteLine(objDictionayEnumerator.Key.ToString()
                + "\t\t" + objDictionayEnumerator.Value);
            }
        }
    }
}
