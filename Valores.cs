using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransformarDateTime
{
    public class Valores
    {
        public int TransformData(DateTime data)
        {
            return int.Parse(data.ToString("yyyyMM"));
        }
    }
}
