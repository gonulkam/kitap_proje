﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; // Sql kullanmak için

namespace kitap_proje
{
    internal class sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=ASUS\\SQLEXPRESS;Initial Catalog=kutuphane_proje;Integrated Security=True");
            baglan.Open();
            return baglan;


        }
    }
}
