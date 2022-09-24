using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoSeatDistribute
{
    public partial class Action : Form
    {
        string classname;
        int rowscount;
        List<string> RowsLableName = new List<string>();
        List<string> RowsTBName = new List<string>();
        List<int> EachRowsSeatCount = new List<int>();
        bool Animate = false;
        public Action(string nm, int rc)
        {
            InitializeComponent();
            classname = nm;
            rowscount = rc;
        }

        private void Action_Load(object sender, EventArgs e)
        {
            ClassNameLable.Text = "班級:" + classname;
            for(int i = 0; i < rowscount; i++)
            {
                Label label = new Label();
                TextBox TB = new TextBox();
                string EachTBName = "RowsTextBox" + i.ToString();
                string EachLableName = "RowsLable" + i.ToString();
                TB.Name = EachTBName;
                label.Name = EachLableName;
                RowsTBName.Add(EachTBName);
                RowsLableName.Add(EachLableName);
                label.Text = (i+1).ToString();
                var Fontsize = label.Font.Size;
                Fontsize = 12;
                label.Font = new Font("Arial", Fontsize,FontStyle.Regular);
                label.AutoSize = false;
                label.Size = new Size(18, 20);
                label.TextAlign = ContentAlignment.MiddleCenter;
                TB.Size = new Size(70, 25);
                TB.Location = new Point(35, 20 + 27 * (i + 1));
                label.Location = new Point(10, 20 + 27* (i + 1));
                label.BackColor = ControlPanel.BackColor;
                RowsSeatsPanel.Controls.Add(label);
                RowsSeatsPanel.Controls.Add(TB);
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Lastbutton_Click(object sender, EventArgs e)
        {
            Start st = new Start();
            st.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int aa = 0;
            bool allsus = true;
            bool peoplesus = int.TryParse(PPLNText.Text, out aa);
            int nc = 0;
            int allpeople;
            int total = 0;
            bool rowerror = false;
            for (int i = 0; i < rowscount; i++)
            {
                bool sus = int.TryParse(((TextBox)RowsSeatsPanel.Controls.Find(RowsTBName[i], true)[0]).Text,out nc);
                if (sus)
                {   
                    if(Convert.ToInt32(((TextBox)RowsSeatsPanel.Controls.Find(RowsTBName[i], true)[0]).Text) > 8)
                    {
                        MessageBox.Show("第" + (i + 1).ToString() + "排沒那麼多人吧");
                        rowerror = true;
                        break;
                    }
                    int person = Convert.ToInt32(((TextBox)RowsSeatsPanel.Controls.Find(RowsTBName[i], true)[0]).Text);
                    total = total + person;
                    EachRowsSeatCount.Add(person);
                }
                else
                {
                    MessageBox.Show("Your " + (i+1).ToString() + " rows are not number");
                    allsus = false;
                }
            }
            if (rowerror)
            {
                allsus = false;
            }
            if (allsus)
            {
                int tpr = int.Parse(PPLNText.Text);
                if (peoplesus && total == tpr)
                {   
                    allpeople = Convert.ToInt32(PPLNText.Text);
                    if(allpeople>45 || allpeople < 15)
                    {
                        MessageBox.Show("你們班沒那麼多或那麼少人吧= =");
                        ControlPanel.Controls.Clear();
                        EachRowsSeatCount.Clear();
                    }
                    else
                    {
                        if(total == allpeople)
                        {   
                            ControlPanel.Controls.Clear();
                            SeatControl sc = new SeatControl(EachRowsSeatCount, allpeople, classname, rowscount,Animate);
                            ControlPanel.Controls.Add(sc);
                            EachRowsSeatCount.Clear();
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Number of People should be int, please enter your number again");
                    EachRowsSeatCount.Clear();
                    ControlPanel.Controls.Clear();
                }
            }
            else
            {
                MessageBox.Show("Please enter your rows again");
                EachRowsSeatCount.Clear();
                ControlPanel.Controls.Clear();
            }
        }

        private void Animation_CheckStateChanged(object sender, EventArgs e)
        {
            if (Animation.Checked)
            {
                Animate = true;
            }
            else
            {
                Animate = false;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {   
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string tper = folderBrowserDialog1.SelectedPath;
                int width = ControlPanel.Size.Width;
                int height = ControlPanel.Size.Height;
                Bitmap bm = new Bitmap(width, height);
                ControlPanel.DrawToBitmap(bm, new Rectangle(0, 0, width, height));
                bm.Save($"{tper}\\{classname}座位表.Jpeg",ImageFormat.Jpeg);
                MessageBox.Show("Picture downloaded successful!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
