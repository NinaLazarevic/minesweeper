using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOProjektovanje_Lab3
{
    public partial class Minesweeper : Form
    {
        public Minesweeper()
        {
            InitializeComponent();
        }

        private int timer;
        public int mines;
        public int size;
        private bool newGameStarted;

        private bool GameNowStarted; /*pomocna promenjiva,pokazuje da li je korisnik kliknuo neko dugme u prvih 5 sekundi
                                     ako nije,generisu se random brojevi na dugmicima,dok korisnik ne
                                     zapocne igru klikom na neko dugme*/

        public bool NewGameStarted
        {
            get
            {
                return newGameStarted;
            }

            set
            {
                newGameStarted = value;
            }
        }

        public int Timer
        {
            get
            {
                return timer;
            }

            set
            {
                timer = value;
            }
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewGame newGame = new NewGame();
            newGame.setParent(this);
            newGame.ShowDialog();
            if (NewGameStarted == true)
            {
                
                tmrTime.Start();
                Timer = 0;
                lblMines.Text = mines.ToString();
                clearPreviousGame();
                CreateGrid();
                GameNowStarted = false; //jos uvek korisnik nije kliknuo na dugme
            }

        }

        private void tmrTime_Tick(object sender, EventArgs e)
        {
            Timer++;
            lblTime.Text = Timer.ToString();

        }

        private Button createButton(int x, int y, int gridX, int gridY)
        {
            Button btn = new Button();

            btn.Text = "";
            btn.Name = gridX.ToString() + " " + gridY.ToString();
            btn.Size = new System.Drawing.Size(25, 25);
            btn.Location = new System.Drawing.Point(x, y);
            Controls.AddRange(new System.Windows.Forms.Control[] { btn, });
            btn.Click += new System.EventHandler(btnOnclick);
            btn.MouseMove += new System.Windows.Forms.MouseEventHandler(btnMouseMove);


            return btn;
        }

        private Label createLables(int x, int y, int gridX, int gridY)
        {
            Label lbl = new Label();
            lbl.Name = gridX.ToString() + " " + gridY.ToString();
            lbl.Text = "0";
            lbl.Size = new System.Drawing.Size(25, 25);
            lbl.Font = new Font("Microsoft Sans Serif", 15.75f, lbl.Font.Style, lbl.Font.Unit);
            lbl.Location = new System.Drawing.Point(x, y);
            Controls.AddRange(new System.Windows.Forms.Control[] { lbl, });
            return lbl;
        }

        private int[,] grid; //mreza brojeva
        private Button[,] btn_grid; //mreza dugmadi
        private Label[,] lbl_grid; //mreza labela

        int startx = 22;
        int starty = 100; //x i y koordinate odakle se iscrtava mreza

        private bool CreateGrid() //pravimo mrezu
        {
            previousSize = size; //za brisanje polja

            this.Width = startx*2 + (size + 1) * 25;
            this.Height = starty*2 + (size + 1) * 25-5; //velicina forme

            grid = new int[size, size];
            btn_grid = new Button[size,size];
            lbl_grid = new Label[size,size];

            Random rnd1 = new Random();

            for (int i=0;i<size;i++)
                for(int j=0;j<size;j++)
                {
                    grid[i, j] = 0; //nema mina

                    btn_grid[i, j] = createButton(startx + 25 * i, starty + 25 * j, i, j);
                    //btn_grid[i, j].Visible = true;
                    lbl_grid[i, j] = createLables(startx + 25 * i, starty + 25 * j, i, j);
                }

            int currMineCount = mines;
            //Add Mines
            while (currMineCount > 0)
            {
                int mineX = rnd1.Next(size);
                int mineY = rnd1.Next(size);

                if (grid[mineX, mineY] == 0)
                {
                    lbl_grid[mineX, mineY].Text = "*";
                    lbl_grid[mineX, mineY].Font = new Font("Microsoft Sans Serif", 30.75f, lbl_grid[mineX, mineY].Font.Style, lbl_grid[mineX, mineY].Font.Unit);
                    lbl_grid[mineX, mineY].Location = new System.Drawing.Point(lbl_grid[mineX, mineY].Location.X , lbl_grid[mineX, mineY].Location.Y);
                    grid[mineX, mineY] = -1; //Add a mine
                    currMineCount--;
                }
            }

            //racunanje mina u matrici
            for(int i=0;i< size;i++)
            {
                for(int j=0;j< size;j++)
                {
                    if(grid[i,j]!=-1)
                    {
                        int numOfMines = 0;
                        if ((i-1) != -1 && (j-1) != -1 && grid[i - 1, j - 1] == -1)
                            numOfMines++;
                        if ((i - 1) != -1 && grid[i - 1, j] == -1)
                            numOfMines++;
                        if ((i - 1) != -1 && (j+1) != size && grid[i - 1, j + 1] == -1)
                            numOfMines++;
                        if ((j - 1) != -1 && grid[i , j - 1] == -1)
                            numOfMines++;
                        if ((j + 1) != size && grid[i , j + 1] == -1)
                            numOfMines++;
                        if ((i + 1) != size && (j - 1) != -1 && grid[i + 1, j - 1] == -1)
                            numOfMines++;
                        if ((i + 1) != size && grid[i + 1, j] == -1)
                            numOfMines++;
                        if ((i + 1) != size && (j + 1) != size && grid[i + 1, j + 1] == -1)
                            numOfMines++;

                        grid[i, j] = numOfMines;


                        if (numOfMines == 0)
                        {
                            lbl_grid[i, j].Text = " ";
                        }
                        else
                        {
                            lbl_grid[i, j].Text = numOfMines.ToString();
                        }
                    }
                    

                }
            }

            return true;

        }

        void btnMouseMove(object sender,System.EventArgs e)
        {
            if (GameNowStarted)
                return;
            if (Timer >= 5 && GameNowStarted==false)
            {
                    Random rnd = new Random();
                    for (int i = 0; i < size; i++)
                        for (int j = 0; j < size; j++)
                        {

                            Int32 x = rnd.Next(100);
                            btn_grid[i, j].Text = x.ToString();

                        }
                
                
            }
           
                
            


        }

        void btnOnclick(object sender, System.EventArgs e)
        {
            GameNowStarted = true;
            if (!tmrTime.Enabled)
            {
                return;
            }
            Button bttnClick = sender as Button;

            if (bttnClick == null)
            {
                return; //not a button.
            }
            for (int i = 0; i < size; i++) //za ciscenje dugmica od random brojeva
            {
                for (int j = 0; j < size; j++)
                {

                    btn_grid[i, j].Text = " ";
                }
            }
            string[] split = bttnClick.Name.Split(new Char[] { ' ' });

            int x = System.Convert.ToInt32(split[0]);
            int y = System.Convert.ToInt32(split[1]);

            if (grid[x, y] == -1)
            {
                //Game Over! Otkrivaju se sve mine
                tmrTime.Enabled = false;

                for (int xx = 0; xx < size; xx++)
                {
                    for (int yy = 0; yy < size; yy++)
                    {
                        if (grid[xx, yy] == -1)
                        {
                            btn_grid[xx, yy].Visible = false;
                        }

                    }
                }


            }

            RemoveBlank(x, y);
            bttnClick.Visible = false;


        }

        void RemoveBlank(int x, int y)
        {
            if (!btn_grid[x, y].Visible)
            {
                return;
            }
            btn_grid[x, y].Visible = false;
            for (int xx = -1; xx < 2; xx++)
            {
                for (int yy = -1; yy < 2; yy++)
                {
                    if (x + xx >= 0 && y + yy >= 0 && x + xx < size && y + yy < size)
                    {
                        {
                            btn_grid[x, y].Visible = false;
                            if (grid[x, y] == 0)
                            {
                                RemoveBlank(x + xx, y + yy);
                            }
                        }

                    }
                }


            }
        }

        int previousSize;
      
        private void clearPreviousGame()
        {
            if (btn_grid != null)
            {
                for (int x = 0; x < previousSize; x++)
                {
                    for (int y = 0; y < previousSize; y++)
                    {
                        //grid[x, y] = 0;



                        if (Controls.Contains(btn_grid[x, y]))
                        {
                            Controls.Remove(btn_grid[x, y]);
                        }

                        if (Controls.Contains(lbl_grid[x, y]))
                        {
                            Controls.Remove(lbl_grid[x, y]);
                        }

                       
                    }
                }
            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearPreviousGame();
            if (ZatvoriFormu() == System.Windows.Forms.DialogResult.Yes)
            {
                _formaZatvorena = true;
                this.Close();
            }
        }
        DialogResult ZatvoriFormu()
        {
            return MessageBox.Show("Da li ste sigurni da zelite da zatvorite igru?",
                                                "Obavestenje",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Question);
        }
        private bool _formaZatvorena;

        private void Minesweeper_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_formaZatvorena)
                return;
            clearPreviousGame();
            if (ZatvoriFormu() == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;
        }
    }
}
