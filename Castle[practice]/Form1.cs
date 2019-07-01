using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Castle_practice_
{
    public partial class Form1 : Form
    {
        string FilePath;
        private bool SelectCell = false;
        private bool BuildWall = false;
        private bool DestroyWall = false;
        Tuple<int, int> cell1 = null;
        Tuple<int, int> cell2 = null;

        private bool AreaCell = false;

        private static int n, m;
        private static int size_mode;
        private int[,] init_matrix = new int[20, 20];                                                                                                                                          //delegate void Del(); private Thread Timer = new Thread(button1_Click);    private static void button1_Click(object sender) { Thread.Sleep(2000); Form1 form = (Form1)sender; while (form.Opacity > 0) { Thread.Sleep(100); form.Invoke(new Del(() => form.Opacity -= 0.01)); } PictureBox pic = new PictureBox();pic.SetBounds(0, 0, 639, 700);pic.Image = Image.FromFile(@"Resources\maxresdefault.jpg");pic.SizeMode = PictureBoxSizeMode.StretchImage; form.Invoke(new Del(() => form.Opacity = 1));form.Invoke(new Del(() => form.Controls.Add(pic)));System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"Resources\female_scream.wav");form.Invoke(new Del(() => player.Play()));}

        private static int[,] amatrix = new int[60, 60];

        private PictureBox background;
        private static PictureBox[,] cells = new PictureBox[20, 20]; private PictureBox pic = new PictureBox();
        public static List<PictureBox> selectCells = new List<PictureBox>();
        public static List<ROOM> rooms = new List<ROOM>();


        public Form1()
        {
            InitializeComponent();

            функцииToolStripMenuItem.Enabled = false;
            сохранитьToolStripMenuItem.Enabled = false;
            сохранитьКакToolStripMenuItem.Enabled = false;


            // Timer.Start(this);
            /*this.Size = new System.Drawing.Size(700, 700);
            GraphicsPath path = new GraphicsPath();
            path.AddRectangle(new Rectangle(0, 0, 700, 700));
            path.AddEllipse(new RectangleF(250, 0, 200, 700));
            path.AddEllipse(new RectangleF(100, 500, 200, 200));
            path.AddEllipse(new RectangleF(400, 500, 200, 200));
            

            Region region = new Region(path);
            this.Region = region*/



            /*Random ran = new Random();
            for (int i = 0; i < 20; i++)
                for (int j = 0; j < 20; j++)
                {
                    
                    string s = ran.Next(16).ToString();
                    cells[i, j] = new PictureBox();
                    cells[i, j].SetBounds(j*30 + 10, i*30 + 50, 30, 30);
                    cells[i, j].Image = Image.FromFile(@"Resources\" + s + ".png");
                    this.Controls.Add(this.cells[i,j]);
                    cells[i, j].Visible = true;
                }*/
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }



        public void ReadFile(string path) // считывание матрицы из файла
        {
            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                string line = sr.ReadLine();
                string[] size = line.Split(' ');
                n = Convert.ToInt32(size[0]);
                m = Convert.ToInt32(size[1]);

                for (int i = 0; i < n; i++)
                {
                    line = sr.ReadLine();
                    string[] nums = line.Split(' ');
                    for (int j = 0; j < m; j++)
                    {
                        init_matrix[i, j] = Convert.ToInt32(nums[j]);
                    }
                }
            }
        }

        private void BuildCastle() // вывод замка на экран, построение массива picture box'ов
        {
            if (n > m)
                size_mode = 600 / n;
            else
                size_mode = 600 / m;

            if (background != null)
                this.Controls.Remove(background);

            background = new PictureBox();
            background.SetBounds(10, 50, size_mode * m, size_mode * n);
            background.BackColor = Color.FromArgb(72, 164, 255);
            this.Controls.Add(background);

            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                {
                    cells[i, j] = new PictureBox();
                    cells[i, j].Name = "name" + i.ToString() + "|" + j.ToString();
                    cells[i, j].SetBounds(j * size_mode + 10, i * size_mode + 50, size_mode, size_mode);
                    cells[i, j].SizeMode = PictureBoxSizeMode.StretchImage;
                    cells[i, j].Image = Image.FromFile(@"Resources\" + (init_matrix[i, j]).ToString() + ".png");
                    cells[i, j].Click += new System.EventHandler(pictureBox_Click);
                    cells[i, j].MouseMove += new System.Windows.Forms.MouseEventHandler(pictureBox_MouseEnter);
                    cells[i, j].MouseLeave += new EventHandler(pictureBox_MouseLeave);
                    this.Controls.Add(cells[i, j]);
                    cells[i, j].BringToFront();
                }
        }

        private void BuildMatrix() // матрица для работы с алгоритмами
        {
            for (int i = 0, ii = 1; i < n * 2 + 1; i++, ii += 2)
                for (int j = 0, jj = 1; j < m * 2 + 1; j++, jj += 2)
                {
                    BuildCell(i, j, ii, jj);
                }

            for (int i = 0, ii = 1; i < n * 2 + 1; i++, ii += 2)
                for (int j = 0, jj = 1; j < m * 2 + 1; j++, jj += 2)
                {
                    if (amatrix[ii, jj - 1] == 1)
                    {
                        amatrix[ii - 1, jj - 1] = 1;
                        amatrix[ii + 1, jj - 1] = 1;
                    }

                    if (amatrix[ii - 1, jj] == 1)
                    {
                        amatrix[ii - 1, jj + 1] = 1;
                        amatrix[ii - 1, jj - 1] = 1;
                    }

                    if (amatrix[ii, jj + 1] == 1)
                    {
                        amatrix[ii - 1, jj + 1] = 1;
                        amatrix[ii + 1, jj + 1] = 1;
                    }

                    if (amatrix[ii + 1, jj] == 1)
                    {
                        amatrix[ii + 1, jj - 1] = 1;
                        amatrix[ii + 1, jj + 1] = 1;
                    }
                }

            for (int i = 0; i < n * 2 + 1; i++)
                amatrix[i, m * 2] = 1;

            for (int i = 0; i < n * 2 + 1; i++)
                amatrix[i, 0] = 1;

            for (int i = 0; i < m * 2 + 1; i++)
                amatrix[0, i] = 1;

            for (int i = 0; i < m * 2 + 1; i++)
                amatrix[n * 2, i] = 1;


            for (int i = 0; i < n * 2 + 1; i++)
            {
                string text = "";
                for (int j = 0; j < m * 2 + 1; j++)
                {
                    if (j != m * 2)
                        text += amatrix[i, j] + " ";
                    else text += amatrix[i, j];

                }
                textBox1.AppendText(text + "\n");
            }
        }

        private void BuildCell(int i, int j, int ii, int jj)
        {
            char[] code = Program.BinaryConvert(init_matrix[i, j]).ToCharArray();
            int left, top, right, bottom;
            left = Convert.ToInt32(code[0].ToString());
            top = Convert.ToInt32(code[1].ToString());
            right = Convert.ToInt32(code[2].ToString());
            bottom = Convert.ToInt32(code[3].ToString());

            amatrix[ii, jj] = 0;
            amatrix[ii, jj - 1] = left;
            amatrix[ii - 1, jj] = top;
            amatrix[ii, jj + 1] = right;
            amatrix[ii + 1, jj] = bottom;

            amatrix[ii - 1, jj - 1] = 0;
            amatrix[ii + 1, jj - 1] = 0;
            amatrix[ii - 1, jj + 1] = 0;
            amatrix[ii - 1, jj - 1] = 0;
        }



        private Tuple<int, int> GetCell(object sender)
        {
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    if (sender.Equals(cells[i, j]))
                    {
                        Tuple<int, int> tuple = new Tuple<int, int>(i, j);
                        return tuple;
                    }
            return null;

        }

        private bool CheckCells()
        {
            if (Math.Abs(cell1.Item1 - cell2.Item1) + Math.Abs(cell1.Item2 - cell2.Item2) != 1)
                return false;
            return true;
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            if (SelectCell)
            {
                if (cell1 == null)
                {
                    selectCells = new List<PictureBox>();
                    cell1 = GetCell(sender);
                    PictureBox selectedCellPointer = new PictureBox();
                    selectedCellPointer.BackColor = Color.FromArgb(185, 122, 87);
                    int pic_x = cells[cell1.Item1, cell1.Item2].Location.X + size_mode / 2 - size_mode / 8;
                    int pic_y = cells[cell1.Item1, cell1.Item2].Location.Y + size_mode / 2 - size_mode / 8; ;
                    selectedCellPointer.SetBounds(pic_x, pic_y, size_mode / 4, size_mode / 4);
                    selectCells.Add(selectedCellPointer);
                    this.Controls.Add(selectCells[selectCells.Count - 1]);
                    selectedCellPointer.BringToFront();
                    //int pic_x = cells[cell1.Item1, cell1.Item2].Location.X + 11;
                    //int pic_y = cells[cell1.Item1, cell1.Item2].Location.Y + 11;
                    //cells[cell1.Item1, cell1.Item2].SetBounds(pic_x, pic_y, size_mode - 22, size_mode - 22);

                    textBox1.AppendText(cell1.Item1.ToString() + " " + cell1.Item2.ToString() + "\n");
                }
                else
                {

                    cell2 = GetCell(sender);
                    if (CheckCells())
                    {
                        textBox1.AppendText(cell2.Item1.ToString() + " " + cell2.Item2.ToString() + "\n");
                        if (BuildWall) EditWall('1');
                        else if (DestroyWall) EditWall('0');

                        DisposeRooms();
                    }
                }
            }

            if (AreaCell)
            {

                for (int i = 0; i < n; i++)
                    for (int j = 0; j < m; j++)
                        if (sender.Equals(cells[i, j]))
                        {
                            RoomArea(i, j);
                        }
                AreaCell = false;
            }
        }

        private void EditWall(char c)
        {
            int i1 = cell1.Item1, j1 = cell1.Item2, i2 = cell2.Item1, j2 = cell2.Item2;
            Controls.Remove(selectCells[0]);
            selectCells = null;
            SelectCell = false;
            функцииToolStripMenuItem.Enabled = true;
            openToolStripMenuItem.Enabled = true;
            // синхронизация матриц
            int c1 = 0, c2 = 0;
            string s1 = "", s2 = "";
            s1 = Program.BinaryConvert(init_matrix[i1, j1]);
            s2 = Program.BinaryConvert(init_matrix[i2, j2]);
            char[] ss1 = s1.ToCharArray();
            char[] ss2 = s2.ToCharArray();

            if (i1 == i2 && j1 < j2)
            {
                ss1[2] = c; s1 = new string(ss1);
                //textBox1.AppendText(s1 + "\n");

                ss2[0] = c; s2 = new string(ss2);
                //textBox1.AppendText(s2 + "\n");
            }

            if (i1 == i2 && j1 > j2)
            {
                ss1[0] = c; s1 = new string(ss1);
                ss2[2] = c; s2 = new string(ss2);
            }

            if (i1 < i2 && j1 == j2)
            {
                ss1[3] = c; s1 = new string(ss1);
                ss2[1] = c; s2 = new string(ss2);
            }

            if (i1 > i2 && j1 == j2)
            {
                ss1[1] = c; s1 = new string(ss1);
                ss2[3] = c; s2 = new string(ss2);
            }
            c1 = Convert.ToInt32(s1, 2);
            c2 = Convert.ToInt32(s2, 2);

            /// init matrix
            init_matrix[i1, j1] = c1;
            init_matrix[i2, j2] = c2;

            /// pictureBox
            cells[i1, j1].Image = Image.FromFile(@"Resources\" + (init_matrix[i1, j1]).ToString() + ".png");
            cells[i2, j2].Image = Image.FromFile(@"Resources\" + (init_matrix[i2, j2]).ToString() + ".png");

            ///amatrix
            BuildMatrix();


        }


        private void pictureBox_MouseEnter(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            if (SelectCell || AreaCell)
            {

                pic.Cursor = System.Windows.Forms.Cursors.Hand;
            }
            else
            {
                pic.Cursor = System.Windows.Forms.Cursors.Arrow;
            }
        }

        private void pictureBox_MouseLeave(object sender, EventArgs e)
        {
            //textBox1.AppendText("V\n");
        }


        private void построитьСтенуToolStripMenuItem_Click(object sender = null, EventArgs e = null)
        {
            функцииToolStripMenuItem.Enabled = false;
            openToolStripMenuItem.Enabled = false;
            cell1 = null;
            cell2 = null;
            SelectCell = true;
            BuildWall = true;
            DestroyWall = false;
        }

        private void разрушитьСтенуToolStripMenuItem_Click(object sender = null, EventArgs e = null)
        {
            функцииToolStripMenuItem.Enabled = false;
            openToolStripMenuItem.Enabled = false;
            cell1 = null;
            cell2 = null;
            SelectCell = true;
            BuildWall = false;
            DestroyWall = true;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {

        }


        private void конверторToolStripMenuItem_Click(object sender = null, EventArgs e = null)
        {
            BinaryConvertor form = new BinaryConvertor();
            form.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {                                                                                                                                                                  //if (Timer.IsAlive)Timer.Suspend();
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void бинарныйФорматToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string writePath = @"Resources\CodBinar.txt";
            string text = "";
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = @"C:\Users\jion9\source\repos\Castle[practice]\Castle[practice]\bin\Debug\Resources\";
            saveFileDialog1.Title = "Save text Files";
            saveFileDialog1.CheckFileExists = false;
            saveFileDialog1.CheckPathExists = true;
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                writePath = saveFileDialog1.FileName;
                try
                {
                    using (StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default))
                    {
                        for (int i = 0; i < n; i++)
                        {
                            text = "";
                            for (int j = 0; j < m; j++)
                            {
                                text += Program.BinaryConvert(init_matrix[i, j]);
                                if (j != m - 1)
                                    text += " ";
                            }
                            sw.WriteLine(text);
                        }

                    }
                    MessageBox.Show("Файл успешно сохранен!", "Сохранение");
                }
                catch
                {
                    MessageBox.Show("Ошибка сохранения файла", "Сохранение");
                }
            }
        }

        private void количествоСтенToolStripMenuItem_Click(object sender = null, EventArgs e = null)
        {
            //horizon
            int h = 0;
            bool b = true;
            for (int i = 0; i < n * 2 + 1; i += 2)
            {
                b = true;
                for (int j = 0; j < m * 2; j++)
                {
                    if ((amatrix[i, j] == 1) && (amatrix[i, j + 1] == 1) && b)
                    { h++; b = false; }
                    if (amatrix[i, j] == 0) b = true;

                }
            }
            //vertical
            int v = 0;
            b = true;
            for (int i = 0; i < m * 2 + 1; i += 2)
            {
                b = true;
                for (int j = 0; j < n * 2; j++)
                {
                    if ((amatrix[j, i] == 1) && (amatrix[j + 1, i] == 1) && b)
                    { v++; b = false; }
                    if (amatrix[j, i] == 0) b = true;

                }
            }

            MessageBox.Show("Горизонтальные стены: " + h.ToString() + "\nВертикальные стены " + v.ToString(), "Результат");
        }


        private void FindRoom(int i, int j)
        {

        }

        private void DisposeRooms()
        {
            for (int i = 0; i < rooms.Count; i++)
                rooms[i].label.Dispose();
            rooms = new List<ROOM>();
        }

        private void числоКомнатToolStripMenuItem_Click(object sender = null, EventArgs e = null)
        {
            DisposeRooms();
            int count = 0;
            for (int i = 1; i < m * 2; i++)
                for (int j = 1; j < n * 2; j++)
                    if (amatrix[j, i] == 0)
                    {
                        /*if ((j == 1 || amatrix[j - 1, i] == 1) &&
                            (j == 1 || amatrix[j + 1, i] == 1) &&
                            (i == 1 || amatrix[j, i - 1] == 1)) */
                        /// check if right
                        {
                            FillRoom(j, i);
                            count++;
                            ROOM r = new ROOM
                            {
                                label = new Label(),
                                di = (j - 1) / 2,
                                dj = (i - 1) / 2

                            };


                            textBox1.AppendText(r.di.ToString() + "|" + r.dj.ToString() + "\n");

                            r.label.Text = count.ToString();
                            r.label.Location = new System.Drawing.Point(r.dj * size_mode + 10 + 11, r.di * size_mode + 50 + 11);
                            r.label.AutoSize = true;

                            r.label.Parent = cells[r.di, r.dj];
                            r.label.BackColor = System.Drawing.Color.Transparent;


                            r.label.BringToFront();
                            rooms.Add(r);
                            this.Controls.Add(rooms[rooms.Count - 1].label);
                            rooms[rooms.Count - 1].label.BringToFront();
                        }
                    }
            MessageBox.Show(count.ToString());
            clear_am();
        }

        private void FillRoom(int j, int i)
        {
            amatrix[j, i] = 2;

            if (amatrix[j + 1, i] == 0)
                FillRoom(j + 1, i);

            if (amatrix[j - 1, i] == 0)
                FillRoom(j - 1, i);

            if (amatrix[j, i + 1] == 0)
                FillRoom(j, i + 1);

            if (amatrix[j, i - 1] == 0)
                FillRoom(j, i - 1);

            return;

        }


        private void площадьКомнатыToolStripMenuItem_Click(object sender = null, EventArgs e = null)
        {
            /*Form2 form = new Form2();
            form.ShowDialog();*/
            AreaCell = true;
        }

        public void RoomArea(int di, int dj)
        {
            selectCells = new List<PictureBox>();
            //int di = rooms[index].di*2 + 1;
            //int dj = rooms[index].dj*2 + 1;

            int area = AreaRec(di * 2 + 1, dj * 2 + 1);

            foreach (PictureBox p in selectCells)
            {
                this.Controls.Add(p);
                p.BringToFront();
            }

            MessageBox.Show(area.ToString() + " кв.", "Площадь комнаты ");

            foreach (PictureBox p in selectCells)
            {
                this.Controls.Remove(p);
                p.BringToFront();
            }
            selectCells = null;

            clear_am();
        }

        private static void clear_am()
        {
            for (int i = 0; i < n * 2 + 1; i++)
                for (int j = 0; j < m * 2 + 1; j++)
                    if (amatrix[i, j] == 2) amatrix[i, j] = 0;
        }

        public static int AreaRec(int i, int j)
        {
            PictureBox selectedCellPointer = new PictureBox();
            selectedCellPointer.BackColor = Color.IndianRed;
            int pic_x = cells[(i - 1) / 2, (j - 1) / 2].Location.X + size_mode / 2 - size_mode / 8;
            int pic_y = cells[(i - 1) / 2, (j - 1) / 2].Location.Y + size_mode / 2 - size_mode / 8;
            selectedCellPointer.SetBounds(pic_x, pic_y, size_mode / 4, size_mode / 4);
            //selectedCellPointer.BringToFront();
            selectCells.Add(selectedCellPointer);

            amatrix[i, j] = 2;
            int a = 1;

            if (amatrix[i + 1, j] != 1)
                if (amatrix[i + 2, j] != 2)
                    a += AreaRec(i + 2, j);

            if (amatrix[i - 1, j] != 1)
                if (amatrix[i - 2, j] != 2)
                    a += AreaRec(i - 2, j);

            if (amatrix[i, j + 1] != 1)
                if (amatrix[i, j + 2] != 2)
                    a += AreaRec(i, j + 2);

            if (amatrix[i, j - 1] != 1)
                if (amatrix[i, j - 2] != 2)
                    a += AreaRec(i, j - 2);

            return a;

        }

        private void сохранитьToolStripMenuItem_Click(object sender = null, EventArgs e = null)
        {
            string text;
            string writePath = FilePath;

            if (sender.Equals(обычныйФорматToolStripMenuItem))
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.InitialDirectory = @"C:\Users\jion9\source\repos\Castle[practice]\Castle[practice]\bin\Debug\Resources\";
                saveFileDialog1.Title = "Save text Files";
                saveFileDialog1.CheckFileExists = false;
                saveFileDialog1.CheckPathExists = true;
                saveFileDialog1.DefaultExt = "in";
                saveFileDialog1.Filter = "IN files (*.in)|*.in|All files (*.*)|*.*";
                saveFileDialog1.FilterIndex = 2;
                saveFileDialog1.RestoreDirectory = true;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    writePath = saveFileDialog1.FileName;
            }

            using (StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default))
            {
                sw.WriteLine(n.ToString() + " " + m.ToString());

                for (int i = 0; i < n; i++)
                {
                    text = "";
                    for (int j = 0; j < m; j++)
                    {
                        text += init_matrix[i, j];
                        if (j != m - 1)
                            text += " ";
                    }
                    sw.WriteLine(text);
                }

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

        }
        private void openToolStripMenuItem1_Click(object sender = null, EventArgs e = null)
        {
            try
            {
                var FD = new System.Windows.Forms.OpenFileDialog();

                FD.Filter = "in files(*.in)|*.in";
                if (FD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    FilePath = FD.FileName;

                    if (cells.Length != 0)
                    {
                        for (int i = 0; i < n; i++)
                            for (int j = 0; j < m; j++)
                                this.Controls.Remove(cells[i, j]);
                    }
                    ReadFile(FilePath);
                    BuildCastle();
                    BuildMatrix();
                    функцииToolStripMenuItem.Enabled = true;
                    сохранитьToolStripMenuItem.Enabled = true;
                    сохранитьКакToolStripMenuItem.Enabled = true;
                    DisposeRooms();
                }
            }
            catch
            {

            }
        }
    }

    public class ROOM
    {
        public Label label;
        public int di;
        public int dj;
    }
}
