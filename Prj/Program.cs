namespace ValidaTag
{
    public class Program
    {
        //===============================================================================+
        //-- Beschreibung: Entwickler Test
        //-- Unternehmen: ORBIT Gesellschaft für Applikations und Informationssysteme GmbH
        //-- Projekt: Testprojekt  - Entwickler Test
        //-- ============================================================================+
        //-- Gesprächspartner : Bruno Casari, Jochen Kock und Christian Lamp. 
        //-- Entwickler: Julio Tavares
        //-- Datum: 25/03/2024
        //-- Grund: Entwickler Test
        //-- ============================================================================+
        public static void Main(string[] args)
        {
            Console.WriteLine(" **** OrbIT **** ");

            //string ret = HasSpecialChar("##Header");
            //string ret = VerficaNullOrEmpty("### Header");
            //string ret = VerificaHasches("###### Header");
            string ret = MarkdownParser("*/*/-+ ");
            Console.WriteLine(ret);
            //string retRemoveVazio = LeerzeichenVorHashesNachHeader("    ###### Kopfzeile     ");

        }

        //public static string HasSpecialChar(string str)
        //{
        //    //string specialChar = @"\|!#$%&/()=?»«@£§€{}.-;'<>_,";
        //    string specialChar = @"#";
        //    foreach (var item in specialChar)
        //    {
        //        if (str.Contains(item)) return "Achou!";
        //    }

        //    return "Keine Hashes";
        //}

        //public static string VerficaNullOrEmpty(string str)
        //{

        //    int count = 0;
        //    string ret = string.Empty;
        //    foreach (char c in str)
        //    {
        //        if (char.IsWhiteSpace(c))
        //        {
        //            count++;
        //        }
        //    }

        //    if (count >= 2)
        //    {
        //        ret = "Zu viele Leerzeichen dazwischen";
        //    }
        //    else
        //    {
        //        ret = string.Empty;
        //    }
        //    return ret;

        //}

        //public static string VerificaHasches(string str)
        //{
        //    int count = str.ToString().Count(x => x == '#');
        //    string ret = string.Empty;

        //    if (count > 6)
        //       {
        //            ret = "Zu viele Hasches";
        //       }
        //    else
        //        {
        //            ret = string.Empty;
        //        }
        //    return ret;
        //   }


        //public static string LeerzeichenVorHashesNachHeader(string str)
        //{ 
        //    int indexHeader = str.IndexOf('r');
        //    int indexLeerzeichen = str.IndexOf(' ');
        //    int lenStrHeader = str.Length;

        //    int indexKopfzeile = str.IndexOf('e');
        //    int lenStrKopfzeile = str.Length;

        //    string specialCharEmpty = @" ";
        //    string specialCharKopfzeile = @"#";



        //    //if (str.Contains(specialCharEmpty) && indexLeerzeichen == 0 && indexHeader + 1 == lenStrHeader && indexHeader + 1.specialCharEmpty)
        //    //{
        //    //    return true; 
        //    //}

        //    //if (str.Contains(specialCharKopfzeile) && indexKopfzeile == 0 && indexHeader + 1 == lenStrKopfzeile)
        //    //{
        //    //    return true;
        //    //}

        //    //string[] listEingabe = str.Split(' ');
        //    //string[0] lst = new []string();

        //    //foreach (var lstString in listEingabe)
        //    //{

        //    //    lst.add
        //    //}

        //    //int ret = str.LastIndexOf(" ");
        //    //if (ret > 0)
        //    //{
        //    //    str.TrimStart().TrimEnd().Trim();
        //    //}
        //    //return str;

        //    string MyString = str;
        //    char[] MyChar = {' '};
        //    string NewString = MyString.TrimEnd(MyChar).TrimStart();
        //    //Console.WriteLine(NewString);
        //    return NewString;



        //}

        public static void EingabeMarkdownParser(string strEingabe)
        {

        }
        public static void PrintMarkdownParser(int i, string strAusgabe)
        { 
            Console.WriteLine($"<h{i}>Header</h{i}>");   
        }
        public static string MarkdownParser(string str)
        {
            string strEingabe = str;
            char[] leerZeichenChar = { ' ' };
            string retEingabe = str.TrimEnd(leerZeichenChar).TrimStart();

            int countHasches = retEingabe.ToString().Count(x => x == '#');
            int countLeerzeichen = retEingabe.ToString().Count(x => x == ' ');
            string ret = string.Empty;
            string retAusgabe = string.Empty; 

            for (int i = 0; i <= countHasches; i++)
            {
                if (countHasches == 6 && countLeerzeichen == 1 && retEingabe.Contains("Header".TrimStart().TrimEnd()))
                {
                    if(i == countHasches)
                        //PrintMarkdownParser(i, retAusgabe);
                    Console.WriteLine($"<h{i}>Header</h{i}>");
                }

                if (countHasches == 5 && countLeerzeichen < 2 && retEingabe.Contains("Header".TrimStart().TrimEnd()))
                {
                    //ret = "<h5>Header</h5>";

                    if (i == countHasches)
                        Console.WriteLine($"<h{i}>Header</h{i}>");
                    //PrintMarkdownParser(i, retAusgabe);
                    //Console.WriteLine($"<h{i}>Header</h{i}>");
                }

                if (countHasches == 4 && countLeerzeichen < 2 && retEingabe.Contains("Header".TrimStart().TrimEnd()))
                {
                    //ret = "<h4>Header</h4>";

                    if (i == countHasches)
                        Console.WriteLine($"<h{i}>Header</h{i}>");
                    //PrintMarkdownParser(i, retAusgabe);
                    //Console.WriteLine($"<h{i}>Header</h{i}>");
                }

                if (countHasches == 3 && countLeerzeichen < 2 && retEingabe.Contains("Header".TrimStart().TrimEnd()))
                {
                    //retAusgabe = "<h3>Header</h3>";
                    if (i == countHasches)
                        Console.WriteLine($"<h{i}>Header</h{i}>");
                    //PrintMarkdownParser(i, retAusgabe);
                }

                if (countHasches == 3 && countLeerzeichen < 2 && retEingabe.Contains("Header".TrimStart().TrimEnd()))
                {
                    //retAusgabe = "<h3>Header</h3>";
                    if (i == countHasches)
                        Console.WriteLine($"<h{i}>Header</h{i}>");
                    //Console.WriteLine("<h3>Header</h3>");
                    //PrintMarkdownParser(i, retAusgabe);
                }

                if (countHasches == 2 && countLeerzeichen == 1 && retEingabe.Contains("Kopfzeile".TrimStart().TrimEnd()))
                {
                    //retAusgabe = "<h2>Header</h2>";
                    if (i == countHasches)
                        Console.WriteLine($"<h{i}>Kopfzeile</h{i}>");
                        //Console.WriteLine("<h2>Header</h2>");
                            //PrintMarkdownParser(i, retAusgabe);
                }

                if (countHasches == 2 && countLeerzeichen == 0 && retEingabe.Contains("Kopfzeile".TrimStart().TrimEnd()))
                {
                    //retAusgabe = "<h1>Header</h1>";
                    if (i == countHasches)
                        Console.WriteLine($"<h{i-1}>Kopfzeile</h{i-1}>");
                    //Console.WriteLine("<h1>Header</h1>");
                    //PrintMarkdownParser(i, retAusgabe);

                }

                if (countHasches == 1 && countLeerzeichen == 0 && retEingabe.Contains("Kopfzeile".TrimStart().TrimEnd()))
                {
                    retAusgabe = "<h1>Header</h1>";
                    if (i == countHasches)
                        Console.WriteLine($"<h{i}>Header</h{i}>");
                    //PrintMarkdownParser(i, retAusgabe);
                }

                if (countHasches > 6 && countLeerzeichen == 1 && retEingabe.Contains("Header".TrimStart().TrimEnd()))
                {
                    //retAusgabe = "(zu viele Hashes)";
                    if (i == countHasches)
                        //PrintMarkdownParser(i, retAusgabe);
                        Console.WriteLine(" '####### Header' (zu viele Hashes)");
                }

                if (countHasches > 0 && countLeerzeichen > 1 && retEingabe.Contains("Header".TrimStart().TrimEnd()))
                {
                    //retAusgabe = "(zu viele Leerzeichen dazwischen)";
                    if (i == countHasches)
                        Console.WriteLine(" '###  Header' zu viele Leerzeichen dazwischen");
                            //PrintMarkdownParser(i, retAusgabe);

                }   

                if (countHasches == 0 && countLeerzeichen == 0 && retEingabe.Contains("Header"))
                {
                    //retAusgabe = "(keine Hashes)";
                    if (i == countHasches)
                        Console.WriteLine("(keine Hashes)");
                            //PrintMarkdownParser(i,retAusgabe);
                }

                if (countHasches >= 0 && countLeerzeichen >= 0 && !retEingabe.Contains("Header".TrimStart().TrimEnd()) && !retEingabe.Contains("Kopfzeile".TrimStart().TrimEnd()))
                {
                    //retAusgabe = "Ungültige Kopfzeilen und Ungültige Header";
                    if (i == countHasches)
                        //PrintMarkdownParser(i,retAusgabe);
                        Console.WriteLine("Ungültige Kopfzeilen und Ungültige Header");
                }
                //retAusgabe = string.Empty;
            }

            return ret;
        }
    }
}