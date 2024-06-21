using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT.Data.IspitIB210156
{
    public class PrisustvoIB210156
    {
        public int Id { get; set; }
        public int NastavaId { get; set; }
        public NastavaIB210156 Nastava { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
    }
}
