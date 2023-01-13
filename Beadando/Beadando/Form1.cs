using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beadando
{
    public partial class Form1 : Form
    {
        Tuple<string, string, string> combo;

        //amit sikeresen átkonvertáltunk, az lesz az input szalag, pl.: i+i*(i+i)#
        string inputSzalag;

        //hol áll a szalag éppen
        int index;
        string szabaly;

        //kell egy stack, azért hogy tudjuk mi a következő alkalmazandó szabály
        Stack<string> verem;

        public Form1()
        {

            InitializeComponent();
            warningLbl.Text = "";
            verem = new Stack<string>();
        }

        //kell az input button-re egy metódus
        //ami azért kell, hogy beolvassuk az inputot, és átalakítsa
        private void inputOKBtn_Click(object sender, EventArgs e)
        {
            if (inputTxtBx.Text == "")
            {
                warningLbl.Text = "Nincs input!";
                return;
            }
            //ha nem üres a textbox, akkor
            //elkezdődik az átalakítás a nulladik indextől - mivel az input szalagot a nulladik helyről akarjuk olvasni
            index = 0;
            //még ezen a ponton nem tudjuk mi a szabály
            szabaly = "";

            inputSzalag = inputTxtBx.Text;
            //az inputba kapott számokat i betűkkel helyettesítjük
            inputSzalag = Regex.Replace(inputSzalag, "[0-9]+", "i");

            //ha az input szalag nem #-re végződik, akkor hozzárakunk egyet
            if (!inputSzalag.EndsWith("#"))
            {
                inputSzalag += "#";
            }
            //beleteszem a konvertált input textboxjába az átalakított inputomat
            convertedInputTxtBx.Text = inputSzalag;
            //majd megjelenítem, hogy sikeres az input átadás
            warningLbl.Text = "Az input sikeresen átadva!";
        }

        private void solveBtn_Click(object sender, EventArgs e)
        {
            //ha az input szalag nem üres, és adtunk meg útvonalat, akkor:
            if (inputSzalag != "" && pathTxtBx.Text != "")
            {
                //a veremnek tartalmaznia kell a célfetételt, melyet elsőnek teszünk bele
                verem.Push("#");

                //a verembe beletesszük a szabályokat, amiket a dgv 0.sor 0.cellájából kiolvassuk a kezdő szabályt
                verem.Push(szabalyokDataGridView.Rows[0].Cells[0].Value.ToString());

                //elmentjük az inputszalag tartalmát, a még alkalmazandó szabályokat és a már elvégzett szabályokat
                combo = new Tuple<string, string, string>(inputSzalag, veremTartalom(), szabaly);
                //kiíratjuk egy textboxba az alábbiakat
                stepsTxtBx.AppendText("\n" + combo + "\n");

                //a rowindex segítségével kiválasztom hogy melyik sort kell alkalmazni a táblázatból
                int rowIndex = -1;
                //addig fut, amíg az index kisebb mint az inputszalag hossza
                while (index < inputSzalag.Length)
                {
                    //az átalakított input szalag alapján megnézzük, hogy az adott indexen lévő karakter a táblázat
                    //melyik oszlopában van 
                    int columnIndex = szabalyokDataGridView.Columns[inputSzalag[index].ToString()].Index;
                    //kiválaszt egy sort, azalapján hogy mi van a veremben
                    foreach (DataGridViewRow row in szabalyokDataGridView.Rows)
                    {
                        //megnézi hogy mi van a verem tetején 
                        if (row.Cells[0].Value.ToString().Equals(verem.Peek()))
                        {
                            //kijelöli, hogy melyik sort kell kiválasztani
                            rowIndex = row.Index;
                            break;
                        }
                    }
                    //a verem tetejéről kivesszük a szabályt
                    verem.Pop();
                    //
                    if (szabalyokDataGridView.Rows[rowIndex].Cells[columnIndex].Value == "")
                    {
                        stepsTxtBx.AppendText("A szabályrendszer alapján nem helyes a kifejezés!");
                        break;

                    }
                    //ha pop, akkor az input szalagon lépünk egyet
                    else if (szabalyokDataGridView.Rows[rowIndex].Cells[columnIndex].Value.ToString() == "pop")
                    {
                        index++;
                    }
                    //ha elfogadó állapot, akkor elértük a célfeltételt, és kiíratjuk
                    else if (szabalyokDataGridView.Rows[rowIndex].Cells[columnIndex].Value.ToString() == "accept")
                    {
                        stepsTxtBx.AppendText("A Turing-gép elfogadó állapotba került!");
                        break;
                    }
                    //ha nem üres, ha nem pop, és nem elfogadó, akkor belerakjuk a következő szabályt
                    else
                    {
                        //a result-ba beleolvassuk azt, amit a táblázat celláiban találunk
                        string result = szabalyokDataGridView.Rows[rowIndex].Cells[columnIndex].Value.ToString();

                        //a szabályokban lévő nyitó és zárójeleket nem vesszük figyelembe
                        result = result.Substring(1, result.Length - 2);

                        //lesz két rész, az első rész a szabály, a második a szabály sorszáma
                        string[] parts = result.Split(',');

                        //ha a szabály epszilon, akkor nem történik semmi
                        if (parts[0].ToString().Equals("eps"))
                        {
                            szabaly += parts[1].ToString();
                        }
                        //ha nem epszilon, akkor
                        else
                        {
                            //van egy for ciklus ami visszafelé megy, mivel verem alapon működik 
                            //a táblázatos elemző, ezért visszafelé kell haladnunk
                            for (int k = parts[0].Length - 1; k > -1; k--)
                            {
                                //ha a szabály részben a k-adik helyen találok egy '-t akkor
                                if (parts[0][k].ToString().Equals("'"))
                                {
                                    //a verembe pusholjuk az összekonkatenált E' -t vagy T'-t
                                    //az E-t összekonkatenálja a '-vel 
                                    verem.Push(String.Concat(parts[0][k - 1], parts[0][k]));
                                    k--;
                                }
                                //ha nem találok vesszőt, akkor az adott szabály egy karakter, és azt pusholjuk
                                else
                                {
                                    verem.Push(parts[0][k].ToString());
                                }
                            }
                            //a szabályba hozzáfűzzük hogy hanyadik szabályt alkalmaztuk
                            szabaly += parts[1].ToString();
                        }
                    }
                    //újra eltárolom az inputszalag tartalmát, a még alkalmazandó szabályokat és a már elvégzett szabályokat
                    combo = new Tuple<string, string, string>(inputSzalag.Substring(index), veremTartalom(), szabaly);
                    //kiíratjuk a textboxba sortörésekkel
                    stepsTxtBx.AppendText(combo + "\n");
                }
            }
            else
            {
                warningLbl.Text = "Nincsen fájl/A szalag üres!";
            }

        }

        //fájlt töltünk be, melyben a szabályrendszer található
        private void browseBtn_Click(object sender, EventArgs e)
        {
            //az elején az útvonal még üres, illetve a szabályok datagridview-ja nincs betöltve
            pathTxtBx.Text = "";
            szabalyokDataGridView.DataSource = null;

            //ha új szabályt töltünk be, akkor előtte ki kell törölnünk az előzőt
            szabalyokDataGridView.Rows.Clear();

            //létrehozunk az ablakot, amivel tudunk tallózni egy fájlt
            OpenFileDialog openFileDialog = new OpenFileDialog();
            //Beállítjuk a kiterjesztést
            openFileDialog.Filter = "csv files (*.csv) |*.csv| All files(*.*)|*.*";
            //megnyitjuk az ablakot
            openFileDialog.ShowDialog();

            //ha a kiválasztott fájl csv kiterjesztésű, akkor:
            if (openFileDialog.FileName.EndsWith(".csv"))
            {
                //az útvonalat betöltjük a textboxba
                pathTxtBx.Text = openFileDialog.FileName;
                //egy try-catch segítségével beolvassuk a fájlt
                try
                {
                    //fájlbeolvasás
                    StreamReader sr = new StreamReader(pathTxtBx.Text);

                    //az adatok pontosvesszővel vannak elválasztva a csv-ben, ezért ezeket kivesszük
                    string firstRow = sr.ReadLine().Replace(";", "");

                    //beállítjuk hogy hány oszlopa legyen a datagridviewban, hogy hány oszlopa legyen
                    szabalyokDataGridView.ColumnCount = firstRow.Length + 1;

                    //a csv első sorát betöltjük a fejlécbe
                    szabalyokDataGridView.Columns[0].Name = " ";

                    //for ciklussal feltöltöm a datagridviewt az adatokkal
                    for (int i = 1; i < szabalyokDataGridView.ColumnCount; i++)
                    {
                        szabalyokDataGridView.Columns[i].Name = firstRow[i - 1].ToString();
                    }

                    //addig fut, amíg nem érünk a fájlunk végére
                    while (!sr.EndOfStream)
                    {
                        //ez olvassa ki a fájlból a következő sort
                        string line = sr.ReadLine();

                        //;-k mentén szétválasszuk az adatokat hogy a megfelelő cellába kerüljenek
                        string[] cell = line.Split(';');

                        //berakjuk a dgv-be
                        szabalyokDataGridView.Rows.Add(cell);
                    }
                }
                //catch ágon kezeljük, ha nincs ilyen fájl
                catch (FileNotFoundException ex)
                {
                    throw new FileNotFoundException("Ilyen fájl nem létezik!");
                }
            }
            //ha nem csv akkor nem megfelelő a fájl formátuma
            else
            {
                warningLbl.Text = "A fájl formátuma nem megfelelő.";
            }
        }

        //kiolvassuk a veremből az összes szabályt, és egy stringgé fűzzük össze
        private string veremTartalom()
        {
            //kezdetben üres
            string tartalom = "";
            //foreach-el a veremben lévő szabályokat beleteszem
            foreach (string c in verem)
            {
                tartalom += c;
            }
            return tartalom;
        }

        private void standardBtn_Click(object sender, EventArgs e)
        {
            if (convertedInputTxtBx.Text != "")
            {
                inputSzalag = convertedInputTxtBx.Text;
                if (!inputSzalag.EndsWith("#"))
                {
                    inputSzalag += "#";
                }
            }
            else
            {
                warningLbl.Text = "Adjon meg adatot";
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            szabalyokDataGridView.Width = Convert.ToInt32(this.Width * 0.70);
            szabalyokDataGridView.Height = Convert.ToInt32(this.Height * 0.8);
            stepsTxtBx.Left = Convert.ToInt32(this.Width * 0.73);
            stepsTxtBx.Width = Convert.ToInt32(this.Width * 0.25);
            stepsTxtBx.Height = Convert.ToInt32(this.Height * 0.8);

        }
    }
}
