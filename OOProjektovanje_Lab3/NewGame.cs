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
    public partial class NewGame : Form
    {
        public NewGame()
        {
            InitializeComponent();
            
        }

        private Minesweeper _parent;

        public void setParent(Minesweeper Parent)
        {
            _parent = Parent;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (rbnDefault.Checked == true)
            {
                _parent.size = 9;
                _parent.mines = 10;
            }
            else
            {
                if (rbnOther.Checked == true)
                {
                    _parent.size = (Int32)this.numSize.Value;
                    _parent.mines = (Int32)this.numMines.Value;

                }
            }
            _parent.NewGameStarted = true;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _parent.NewGameStarted = false;
            this.Close();
        }

        private void rbnDefault_CheckedChanged(object sender, EventArgs e)
        {
            if(rbnDefault.Checked==true)
            {
                _parent.size = 9;
                _parent.mines = 10;
            }
            else
            {
                if(rbnOther.Checked==true)
                {
                    _parent.size = (Int32)this.numSize.Value;
                    _parent.mines = (Int32)this.numMines.Value;

                }
            }
                
        }
    }
}
