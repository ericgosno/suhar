using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockModel
{
    public static class CurrencyController
    {
        public static IQueryable<currency> getCurrency()
        {
            var list = from f in StockEntity.Entity.currencies
                       select f;
            return list;
        }

        public static IQueryable<currency> getCurrency(int CurrencyID)
        {
            return getCurrency().Where(a => a.Currency_ID == CurrencyID);
        }

        private static string decryptSatuan(int value)
        {
            int satuan = value % 10;
            if (value == 0) return "";
            if (value == 1) return " Satu";
            if (value == 2) return " Dua";
            if (value == 3) return " Tiga";
            if (value == 4) return " Empat";
            if (value == 5) return " Lima";
            if (value == 6) return " Enam";
            if (value == 7) return " Tujuh";
            if (value == 8) return " Delapan";
            if (value == 9) return " Sembilan";
            return "";
        }

        private static string decryptPuluhan(int value)
        {
            string ans = "";
            int puluhansatuan = (value % 100);
            int satuan = puluhansatuan % 10;
            int puluhan = puluhansatuan / 10;
            if (puluhan == 0)
            {
                ans += "";
                ans = ans + decryptSatuan(satuan);
            }
            else if (puluhan == 1)
            {
                if (satuan == 0) ans += " Sepuluh";
                if (satuan == 1) ans += " Sebelas";
                if (satuan == 2) ans += " Dua Belas";
                if (satuan == 3) ans += " Tiga Belas";
                if (satuan == 4) ans += " Empat Belas";
                if (satuan == 5) ans += " Lima Belas";
                if (satuan == 6) ans += " Enam Belas";
                if (satuan == 7) ans += " Tujuh Belas";
                if (satuan == 8) ans += " Delapan Belas";
                if (satuan == 9) ans += " Sembilan Belas";
            }
            else
            {
                ans = ans + decryptSatuan(puluhan) + " Puluh";
                ans = ans + decryptSatuan(satuan);
            }
            return ans;
        }

        private static string decryptRatusan(int value)
        {
            string ans = "";
            int ratusanpuluhan = (value % 1000);
            int puluhan = ratusanpuluhan % 100;
            int ratusan = ratusanpuluhan / 100;
            if (ratusan == 0) ans += "";
            else if (ratusan == 1) ans += " Seratus";
            else ans = ans + decryptSatuan(ratusan) + " Ratus";

            ans = ans + decryptPuluhan(puluhan);
            return ans; 
        }

        private static string decryptRibuan(int value)
        {
            string ans = "";
            int ribuanratusan = (value % 10000);
            int ratusan = ribuanratusan % 1000;
            int ribuan = ribuanratusan / 1000;
            if (ribuan == 0) ans += "";
            else if (ribuan == 1) ans += " Seribu";
            else ans = ans + decryptSatuan(ribuan) + " Ribu";

            ans = ans + decryptRatusan(ratusan);
            return ans; 
        }

        public static string decryptMoney(decimal money, int currencyID)
        {
            int decimalParts = Convert.ToInt32(Convert.ToInt64((money * 100M)) % Convert.ToInt64(100));
            int nominalParts = Convert.ToInt32(Math.Floor(money));
            string ans = "";

            int valnow = nominalParts;
            int milyarparts = valnow / 1000000000;
            if(milyarparts > 0)ans = ans + decryptRatusan(milyarparts) + " Milyar";

            valnow = valnow % 1000000000;
            int jutaparts = valnow / 1000000;
            if (jutaparts > 0) ans = ans + decryptRatusan(jutaparts) + " Juta";

            valnow = valnow % 1000000;
            int ribuparts = valnow / 1000;
            if (ribuparts == 1) ans = ans + " Seribu";
            else if(ribuparts > 0) ans = ans + decryptRatusan(ribuparts) + " Ribu";

            valnow = valnow % 1000;
            ans = ans + decryptRatusan(valnow);

            if (currencyID == 1) ans = ans + " Dollar";
            else ans = ans + " Rupiah";

            if (decimalParts > 0)
            {
                ans = ans + " Points" + decryptPuluhan(decimalParts) + " Sen";
            }
            if (currencyID == 1) ans = ans + " Amerika";
            return ans;
        }
    }
}
