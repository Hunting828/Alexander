using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Xml.Serialization;
using System.Data.SqlClient;

namespace ISIS_Labs
{
    public partial class Child : Form
    {
        public Child()
        {
            InitializeComponent();
        }

        string MyFName = "";
        string[] textArray;
        int longestWord = 0;
        int words = 0;
        int j = 0;
        public string[] words_getText(string[] textArray)
        {
            string text = textBox1.Text;
            text = Regex.Replace(text, "[-.?!)(,:;*]", " "); //Замена всех знаков препинания пробелами
            textArray = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries); //разбиваем текст на слова (в массив строк)
            return textArray;
        }
        public void words_wordsCount(string[] textArray)
        {
            string[] tempArray = new string[1];
            longestWord = this.wordCount.Value;
            for (int i = 0; i < textArray.Length; i++) //перебираем
            {
                if (textArray[i].Length == longestWord)
                {
                    words++;
                    tempArray[j] = textArray[i];
                    Array.Resize(ref tempArray, tempArray.Length + 1);
                    j++;
                }
            }
            tempArray = tempArray.Where(n => !string.IsNullOrEmpty(n)).ToArray();
            var result = tempArray.GroupBy(x => x)
                .Where(x => x.Count() > 0)
                .Select(x => new { Word = x.Key, Frequency = x.Count() });
            foreach (var item in result)
            {
                int rowNumber = dataGridView1.Rows.Add();
                dataGridView1.Rows[rowNumber].Cells[0].Value = item.Word;
                dataGridView1.Rows[rowNumber].Cells[1].Value = item.Frequency;
            }
            this.dataGridView1.Sort(this.dataGridView1.Columns["Frequency"], ListSortDirection.Descending);
            textBox2.Text = string.Format("Найдено слов указанной длины: {0}", words);

        }
        private void textLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = openFileDialog1.FileName;
            // читаем файл в строку
            string fileText = System.IO.File.ReadAllText(filename);
            textBox1.Text = fileText;
            string text = textBox1.Text;
            text = Regex.Replace(text, "[-.?!)(,:;*]", " ");
            string[] textArray = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int maxlen = 0, index = 0;
            for (int i = 0; i < textArray.Length; i++)
            {
                if (textArray[i].Length > maxlen)
                {
                    maxlen = textArray[i].Length;
                    index = i;
                }
            }
            wordCount.Maximum = textArray[index].Length;
        }

        private void textSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = saveFileDialog1.FileName;
            // сохраняем текст в файл
            System.IO.File.WriteAllText(filename, textBox1.Text);
        }

        private void iniSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveINI = new SaveFileDialog();
            saveINI.Filter = "INI File |*.ini";
            if (saveINI.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                IniFiles ini = new IniFiles(saveINI.FileName);
                ini.Write("App", "Value", wordCount.Value.ToString());
                ini.Write("App", "FileRoute", MyFName);
                ini.Write("App", "FormWidth", Convert.ToString(this.Size.Width));
                ini.Write("App", "FormHeight", Convert.ToString(this.Size.Height));
            }
        }

        private void iniLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog iniLoad = new OpenFileDialog();
            iniLoad.Filter = "INI File |*.ini";
            if (iniLoad.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                IniFiles ini = new IniFiles(iniLoad.FileName);
                string reini = ini.ReadINI("App", "Value");
                string fini = ini.ReadINI("App", "FileRoute");
                int i = int.Parse(reini);
                wordCount.Value = i;
                //richTextBox1.LoadFile(fini);
                using (StreamReader sr = new StreamReader(fini))
                {
                    textBox1.Text = (sr.ReadToEnd());
                }
                Width = Convert.ToInt32(ini.ReadINI("App", "FormWidth"));
                Height = Convert.ToInt32(ini.ReadINI("App", "FormHeight"));
            }
        }
        private void saveXML_Click(object sender, EventArgs e)
        {
            //string fileName = @"D:\\data.xml";
            List<Profile> Stat = new List<Profile>();
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                DataGridViewRow _row = dataGridView1.Rows[i];

                Profile p = new Profile();
                if (_row.Cells[0].Value != null)
                    p.LongOfWord = (int)_row.Cells[0].Value;

                if (_row.Cells[1].Value != null)
                    p.Count = (int)_row.Cells[1].Value;

                if (_row.Cells[2].Value != null)
                    p.Percent = ((double)_row.Cells[2].Value);
                Stat.Add(p);
            }
            Serializer.Save<List<Profile>>(Stat, "Statistic.xml");
            saveXML.Enabled = false;
        }

        private void statsCount_Click(object sender, EventArgs e)
        {
            statsCount.Enabled = false;
            statsClear.Enabled = true;
            words_getText(textArray);
            words_wordsCount(textArray);
        }
        private void statsClear_Click(object sender, EventArgs e)
        {
            statsCount.Enabled = true;
            statsClear.Enabled = false;
            longestWord = 0;
            words = 0;
            j = 0;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("Word", "Слово");
            dataGridView1.Columns.Add("Frequency", "Частота появления");
        }

        [Serializable]
        public class Profile
        {
            public int LongOfWord;
            public int Count;
            public double Percent;
        }

        class Serializer
        {

            public static T Load<T>(string _fileName)
            {
                /* Восстанавливаем из файла в файл. */

                TextReader _writer = null;

                try
                {
                    XmlSerializer _Serializer = new XmlSerializer(typeof(T));
                    _writer = new StreamReader(_fileName);

                    return (T)_Serializer.Deserialize(_writer);
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return default(T);
                }
                finally
                {
                    if (_writer != null)
                        _writer.Close();
                }
            }

            public static bool Save<T>(T obj, string _file)
            {
                TextWriter _writer = null;
                try
                {
                    XmlSerializer _Serializer = new XmlSerializer(typeof(T));
                    _writer = new StreamWriter(_file);
                    _Serializer.Serialize(_writer, obj);
                    return true;
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return false;
                }
                finally
                {
                    if (_writer != null)
                        _writer.Close();
                }

            }
        }

        static string openedFile = " ";
        private void openTextFromDB_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(domainUpDown1.Text) && !string.IsNullOrWhiteSpace(domainUpDown1.Text))
            {
                try
                {
                    DBClass class1 = new DBClass();
                    openedFile = domainUpDown1.Text;
                    string content = class1.OpenText(openedFile);
                    textBox1.Text = content;
                }
                catch
                {
                    MessageBox.Show("Ошибка!", "WARNING, CRITICAL ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox1.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Выбирите текст!", "WARNING, CRITICAL ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void saveIniToDB_Click(object sender, EventArgs e)
        {
            int wSize = this.Size.Width;
            int hSize = this.Size.Height;
            int tVal = wordCount.Value;
            string lText = openedFile;
            DBClass class1 = new DBClass();
            class1.IniAdd(wSize, hSize, tVal, lText);
        }

        private void loadIniToDB_Click(object sender, EventArgs e)
        {
            DBClass class1 = new DBClass();
            int wSizeL = class1.ReadWidth();
            int hSizeL = class1.ReadHeight();
            int tValL = class1.ReadLen();
            string lTextL = class1.ReadText();
            Width = wSizeL;
            Height = hSizeL;
            wordCount.Value = tValL;
            string content = class1.OpenText(lTextL);
            textBox1.Text = content;
        }
    }
}
