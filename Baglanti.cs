using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SınemaSeansTakip
{
    public static class Baglanti
    {
        public static readonly string ConnectionString = $"Data Source={Application.StartupPath}\\sinemaDb.db;Version=3;";
    }
}
