using System.IO;
using System.Text;

namespace WpfAddressBook
{
    class IniFile
    {

        private readonly string LOGIN_COMMAND = "loginComand";

        /// <summary>
        /// DBにログインするためのコマンド
        /// </summary>
        public string LoginComand { get; private set; }

        public IniFile(string filePath)
        {
            // ファイルの存在チェック
            // 存在しない場合はエラー終了
            if (!System.IO.File.Exists(filePath))
                throw new FileNotFoundException("IniFileが存在しません");

            // 存在すれば内容の読み込み
            using (var reader = new StreamReader(filePath, Encoding.UTF8))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();

                    if (line.StartsWith(this.LOGIN_COMMAND))
                    {
                        this.LoginComand = line.Replace($"{this.LOGIN_COMMAND}=", "");
                    }
                }
            }
        }
    }
}
