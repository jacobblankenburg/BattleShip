using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    public class FileWritter
    {

        public void WriteToFile(string path, string message)
        {
            FileStream fs = new FileStream(path, FileMode.Append, FileAccess.Write);
            StreamWriter sr = new StreamWriter(fs);

            sr.Write(message);
            sr.Close();
            fs.Close();


        }
    }
}