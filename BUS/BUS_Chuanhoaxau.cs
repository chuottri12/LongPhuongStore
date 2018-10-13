using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_Chuanhoaxau
    {
        public string Ten(string ten)
        {
            int i;
            ten = ten.Trim(); //xóa bỏ hết dấu cách đầu và cuối tên
            while (ten.IndexOf("  ") >= 0) //xóa đi dấu cách thừa
            {
                ten = ten.Replace("  ", " ");
            }
            ten = ten.Substring(0, 1).ToUpper()+ten.Substring(1); //Ký tự đầu viết HOA
            
            for (i = 1; i < ten.Length; i++)
            {
                string s = " ";
                if (String.Compare(ten.Substring(i,1), s, false) == 0)
                {
                    ten = ten.Substring(0,i+1) + ten.Substring(i+1, 1).ToUpper() + ten.Substring(i + 2);
                }
                
            }
           //kết thúc
            return ten;
        }
        public string DoanVan(string s)
        {
            s = s.Trim();
            while (s.IndexOf("  ") >= 0) //xóa đi dấu cách thừa
            {
                s = s.Replace("  ", " ");
            }
            s = s.Substring(0, 1).ToUpper() + s.Substring(1); //Ký tự đầu viết HOA

            return s;
        }

        public bool SoNguyen(string pValue)
        {
            foreach (Char c in pValue)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }
        public bool SoLe(string pText)
        {
            Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
            return regex.IsMatch(pText);
        }
    }
}
