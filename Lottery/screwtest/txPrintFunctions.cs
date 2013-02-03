using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using txGeometry;
// using 

namespace screwtest
{
    public class txPrintFunctions
    {
        txScrwUtility screwutility;
        string file0;
        string file1;
        string file2;
        string file3;

        string fileneggative;

        List<txVector2> positivey = new List<txVector2>();
        List<txVector2> neggativey = new List<txVector2>();


        public txPrintFunctions()
        {
            screwutility = new txScrwUtility();
            string directory = "D:\\data";
            file0 = directory+"\\d0.txt";
            file1 = directory+"\\d1.txt";
            file2 = directory+"\\d2.txt";
            file3 = directory+"\\d3.txt";
            fileneggative = directory + "\\neggative.txt";
        }

        // {0, beta}
        public void PrintDomain0()
        {
            FileStream fs = new FileStream(file0, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            
            
            int n = 1000;
            double t = 0.0;
            double tend = screwutility.Alphact;
            double step = (tend - t) / n;
            txVector2 currentv;
            txMatrix2 m;
            m = txMatrix2.Identity();
            for (int i = 0; i < n; i++)
            {
                currentv = txScrwUtility.Domain0(screwutility.ScrewRadius, t, m);
                //sw.Write(currentv.x + "\t\t\t\t\t\t" + currentv.y);
                sw.WriteLine(currentv.x + "\t\t\t" + currentv.y);
                positivey.Add(currentv);
                t += step;
            }

            sw.Flush();
            sw.Close();
            sw.Dispose();
        }

        public void PrintDomain1()
        {
            FileStream fs = new FileStream(file1, FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(fs);


            int n = 1000;
            double t = screwutility.Beta;
            double tend = screwutility.Alpha * 2.0 - screwutility.Beta;
            double step = (tend - t) / n;
            txVector2 currentv;
            txMatrix2 m;
            m = txMatrix2.Identity();
            for (int i = 0; i < n; i++)
            {
                currentv = txScrwUtility.Domain1(screwutility.ScrewRadiusE, t);
                //sw.Write(currentv.x + "\t\t\t\t\t\t" + currentv.y);
                sw.WriteLine(currentv.x + "\t\t\t" + currentv.y);
                positivey.Add(currentv);
                t += step;
            }

            sw.Flush();
            sw.Close();
            sw.Dispose();
        }


        public void PrintDomain2()
        {
            FileStream fs = new FileStream(file2, FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(fs);


            int n = 1000;
            double t = -screwutility.Alphact;
            double tend = 0;
            double step = (tend - t) / n;
            txVector2 currentv;
            txMatrix2 m = new txMatrix2(2.0 * screwutility.Alpha);
            for (int i = 0; i < n; i++)
            {
                currentv = txScrwUtility.Domain0(screwutility.ScrewRadius, t, m);
                //sw.Write(currentv.x + "\t\t\t\t\t\t" + currentv.y);
                sw.WriteLine(currentv.x + "\t\t\t" + currentv.y);
                positivey.Add(currentv);
                t += step;
            }

            sw.Flush();
            sw.Close();
            sw.Dispose();
        }


        public void PrintDomain3()
        {
            FileStream fs = new FileStream(file3, FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(fs);


            int n = 1000;
            double t = screwutility.Alpha * 2.0;
            double tend = Math.PI;
            double step = (tend - t) / n;
            txVector2 currentv;
            txMatrix2 m;
            m = txMatrix2.Identity();
            for (int i = 0; i < n; i++)
            {
                currentv = txScrwUtility.Domain1(screwutility.ScrewRadius, t);
                //sw.Write(currentv.x + "\t\t\t\t\t\t" + currentv.y);
                sw.WriteLine(currentv.x + "\t\t\t" + currentv.y);
                positivey.Add(currentv);
                t += step;
            }

            sw.Flush();
            sw.Close();
            sw.Dispose();
        }


        public void NeggativeY()
        {
            txMatrix2 m = new txMatrix2(Math.PI);
            foreach (txVector2 item in positivey)
            {
                neggativey.Add(m * item);
            }

            FileStream fs = new FileStream(fileneggative, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);

            foreach (txVector2 item in neggativey)
            {
                sw.WriteLine(item.x+"\t\t\t"+item.y);
            }

            sw.Flush();
            sw.Close();
            sw.Dispose();
        }


        public void PrintAll()
        {
            PrintDomain0();
            PrintDomain1();
            PrintDomain2();
            PrintDomain3();

            NeggativeY();
        }
    }
}
