using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoLib.Tovars;


namespace DemoLib.Repository
{
    public interface TovarRepository
    {
        List<Tovar> GetAllTovars();
    }
}
