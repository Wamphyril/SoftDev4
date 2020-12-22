using System;

namespace LAB4TRPO
{
    class Program
    {
        static void Main(string[] args)
        {
            //1) ----------------------------------------------------------------------------------------------
            private void ChangeMode(bool mode)
            {
                label1.Enabled = mode;
                button1.Enabled = mode;
                button2.Enabled = mode;
                button3.Enabled = !mode;
                button4.Enabled = !mode;
            }
            //2) ----------------------------------------------------------------------------------------------
            {
                return m_driverStatusNames[driver.Status];
            }
            //3) ----------------------------------------------------------------------------------------------
            uint i;
             …
            if (i < 10)
            {
            …
            }
            //4) ----------------------------------------------------------------------------------------------
            string destination = String.Join('', source);
            //5) ----------------------------------------------------------------------------------------------
            bool IsNumber(string str)
            {
                try
                {
                    int number = Convert.ToInt32(str);
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            6) ----------------------------------------------------------------------------------------------
    foreach (DirectoryInfo dir in dirs.GetDirectories())
            {
                //create folder{16}
                stream.Write(new byte[] { (byte)NetworkMessage.MakeDir }, 0, 1);
                stream.Read(new byte[1], 0, 1);
                stream.Write(BitConverter.GetBytes(Encoding.UTF8.GetBytes(SubFolder.Replace('\\', '/') + dir.Name.Replace('\\', '/')).Length), 0, 4);
                stream.Write(Encoding.UTF8.GetBytes(SubFolder.Replace('\\', '/') + dir.Name.Replace('\\', '/')), 0, Encoding.UTF8.GetBytes(SubFolder.Replace('\\', '/') + dir.Name.Replace('\\', '/')).Length);
                //send folder name
                stream.Read(new byte[1], 0, 1);//Ok
            }
            //7) ----------------------------------------------------------------------------------------------
            String[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            //8) ----------------------------------------------------------------------------------------------
                Console.WriteLine($"--{DateTime.Now.ToLongTimeString()}--");
            //9) ----------------------------------------------------------------------------------------------
            return (Counter % 10 != 0 && Counter != 0);
            //10) ----------------------------------------------------------------------------------------------
            if (Connected == 0))
            {
                rez = setup();
                fl_end = true; // выход
            }
            else
            fl_end = true;
            //11) ----------------------------------------------------------------------------------------------
            List<int> arr = new List<int>();
            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i] > 100)
                    arr.Remove(arr[i]);
            }
            //12) ----------------------------------------------------------------------------------------------
            if (form.Keys.Length >= 0) throw Exception;
            //13) ----------------------------------------------------------------------------------------------
            //Use the Name field
            string[] nameParts = customer.Name.Split(' ');
            string firstName = nameParts[0];
            string lastName = nameParts[1];
            //14) ----------------------------------------------------------------------------------------------
            foreach (string id in sourceIDs.Split(new char[] { ',' },
            StringSplitOptions.RemoveEmptyEntries))
            {
                sourceId = Convert.ToInt32(id);
                break;
            }
            //15) ----------------------------------------------------------------------------------------------
            public string generateEMail()
            {
                string res = PersonName.Replace(' ', '.');
                res += "@domain.ua";
             return res;
                //16) ----------------------------------------------------------------------------------------------
                foreach (string id in sourceIDs.Split(new char[] { ',' },
                StringSplitOptions.RemoveEmptyEntries))
                {
                sourceId = Convert.ToInt32(id);
                break;
                }
            //17) ----------------------------------------------------------------------------------------------
            string GetTextDiv2(string text)
            {
                int mid = text.Length / 2;
                int r = text.IndexOf(" ", mid); if (r < 0) r = 5000;
                int l = text.IndexOf(" ", 0, mid); if (l < 0) l = 5000;
                if (r - mid > mid - l) // to left is closer
                    mid = l;
                else mid = r;
                if (mid == 5000) return "&nbsp" + text;
                return "&nbsp" + text.Substring(0, mid) + " <br/>&nbsp" +
               text.Substring(mid, text.Length - mid);
            }
            //18) ----------------------------------------------------------------------------------------------
        private static readonly char SPECIFIER = "$"[0];
        private static readonly char DELIMITER = ":"[0];
        private static readonly char[] DELIMITER_ARRAY = new char[1] { DELIMITER };
//19) ----------------------------------------------------------------------------------------------
string mailTo = ((Config.GetSetting("AdminNotifications_EmailAddress") == null) ||
(Config.GetSetting("AdminNotifications_EmailAddress").Length <= 0)) ?
Globals.GetHostPortalSettings().HostSettings["SMTPPassword"].ToString() :
Config.GetSetting("AdminNotifications_EmailAddress");
//20) ----------------------------------------------------------------------------------------------
public bool CheckPath(string path)
        {
            int n;
            n = 0;
            //Проверяем наличие нужных папок;
            if (Directory.Exists(path + "SCLAD"))
            {
                n += 1;
            }
            if (Directory.Exists(path + "REAL"))
            {
                n += 1;
            }
            if (Directory.Exists(path + "DOSTAVKA"))
            {
                n += 1;
            }
            //Проверяем наличие нужных файлов
            if (File.Exists(path + "analit.dbf"))
            {
                n += 1;
            }
            if (File.Exists(path + "partner.dbf"))
            {
                n += 1;
            }
            if (File.Exists(path + "SCLAD\\mdoc.dbf"))
            {
                n += 1;
            }
            if (File.Exists(path + "SCLAD\\mdoc.fpt"))
            {
                n += 1;
            }
            if (File.Exists(path + "SCLAD\\mdocm.dbf"))
            {
                n += 1;
            }
            if (File.Exists(path + "SCLAD\\mgrup.dbf"))
            {
                n += 1;
            }
            if (File.Exists(path + "SCLAD\\mlabel.dbf"))
            {
                n += 1;
            }
            if (File.Exists(path + "SCLAD\\mlabel.fpt"))
            {
                n += 1;
            }
            if (File.Exists(path + "REAL\\rbookm.dbf"))
            {
                n += 1;
            }
            if (File.Exists(path + "REAL\\rbook.dbf"))
            {
                n += 1;
            }
            if (File.Exists(path + "REAL\\rbook.fpt"))
            {
                n += 1;
            }
            if (File.Exists(path + "DOSTAVKA\\avt.dbf"))
            {
                n += 1;
            }
            if (File.Exists(path + "DOSTAVKA\\avtm.dbf"))
            {
                n += 1;
            }
            if (File.Exists(path + "DOSTAVKA\\avtm.fpt"))
            {
                n += 1;
            }
            if (File.Exists(path + "DOSTAVKA\\cargo.dbf"))
            {
                n += 1;
            }
            if (File.Exists(path + "DOSTAVKA\\cargom.dbf"))
            {
                n += 1;
            }
            if (File.Exists(path + "DOSTAVKA\\zamena.dbf"))
            {
                n += 1;
            }
            //Если указанная папка содержит все, что нужно
            if (n == 20)
            {
                return true;
            }
            return false;
        }
//21) ----------------------------------------------------------------------------------------------
txtContacts.Text = "";
bool first = true;
foreach (string contact in contacts)
{
if (first != true)
txtContacts.Text += ";";
first = false;
txtContacts.Text += contact;
}
//22) ----------------------------------------------------------------------------------------------
if (Game1.clou == true)
 {Game1.clou = false;}
 else
 { Game1.clou = true; }
        }
    }
}
