using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreAcademyA.Week3.Esercizi.FigureGeometriche
{
    interface IFileManager
    {
        public void ScriviSuFile(string fileName);
        public void LeggiDaFile(string fileName);
    }
}
