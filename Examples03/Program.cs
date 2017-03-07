using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples03
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string sql =
                @"select * from table
                where id > 100";
            string xml =
                @"<Pokemon>
                <NationalNo>#001</NationalNo>
                <Name>Bulbsaur</Name>
                </Pokemon>";
            string jason =
                @"Pokemon ={
                 NationalNo: '#001',Name:Bulbsaur}";
            Console.WriteLine(sql);
            Console.WriteLine(xml);
            Console.WriteLine(jason);
        }
    }
}