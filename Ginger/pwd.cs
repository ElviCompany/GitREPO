using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ginger
{
    public static partial class PwdChecking
    {
        public static bool IsPasswordCorrect(string Password)
        {
            bool result = false;
            switch (Password)
            {
                case "1":
                    result = true;
                    break;
                case "vt[jbk":
                    result = true;
                    break;
                case "Vt[jbk":
                    result = true;
                    break;
                case "VT{JBK":
                    result = true;
                    break;
                case "Мехоил":
                    result = true;
                    break;
                case "мехоил":
                    result = true;
                    break;
                case "МЕХОИЛ":
                    result = true;
                    break;
                case "мЕХОИЛ":
                    result = true;
                    break;
                case "vT[JBK":
                    result = true;
                    break;
                case "+79147982636":
                    result = true;
                    break;
                case "79147982636":
                    result = true;
                    break;
                case "9147982636":
                    result = true;
                    break;
                case "Oks76ana":
                    result = true;
                    break;
                case "oKS76ANA":
                    result = true;
                    break;
                case "Щлы76фтф":
                    result = true;
                    break;
                case "щЛЫ76ФТФ":
                    result = true;
                    break;
                default:
                    result = false;
                    break;
            }
            return result;
        }
    }
}
