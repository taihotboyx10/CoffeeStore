using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CofffeeStoreManagement.Util
{
    public class Constant
    {
        public static readonly string USERNAME_MESSAGE = "ユーザー名は入力されていません。";
        public static readonly string PWD_MESSAGE = "パスワードは入力されていません。";

        public static readonly Dictionary<int, string> TABLE_STATUS = new Dictionary<int, string>
        {
            { 0, "空"},
            { 1, "満"},
            { 2, "予約済み"},
        };

    }
}
