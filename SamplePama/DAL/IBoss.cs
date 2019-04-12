using SamplePama.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SamplePama.DAL
{
    public interface IBoss : ICrud<Boss>
    {
        string GetBoss();
    }
}
