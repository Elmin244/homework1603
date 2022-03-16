using System;
using System.Collections.Generic;
using System.Text;

namespace _16032022
{
     internal class User
     {
       private string _Username;
       private string _Password;
        public string Username
        {
            get=>this._Username;
            set
            {
                if (value.Length > 6 || value.Length < 25)
                    this._Username = value;
            }
        }
        public string Password
        {
            get => this._Password;
            set
            {
                if (value.Length > 8 || value.Length < 25)
                    this._Password = value;
            }
        }
        static bool CheckString(string text)
        {
            bool HasDigit = false;
            bool HasUpper = false;
            bool HasLower = false;
            for (int i = 0; i < text.Length; i++)
            {
                if (Char.IsDigit(text[i]))
                {
                    HasDigit = true;
                }
                if (Char.IsUpper(text[i]))
                {
                    HasUpper = true;
                }
                if (Char.IsLower(texy[i]))
                {
                    HasLower = true;
                }
                return HasDigit && HasUpper && HasLower ? true : false;
            }
        }
     }
}

