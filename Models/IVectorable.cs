using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorLabWinForms.Models
{
    public interface IVectorable
    {
        int Length { get; }
        int this[int i] { get; set; }
        double GetNorm();
    }
}
