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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace AutoSeatDistribute
{
    public partial class SeatControl : UserControl
    {
        List<int> EachRowsCount = new List<int>();
        int peopleCount,Rows;
        string className;
        List<int> PeopleNumberList = new List<int>();
        List<int> Result = new List<int>();
        List<string> SeatsResultID = new List<string>();
        int widget,high;
        bool Animate;

        private void SwitchButton_Click(object sender, EventArgs e)
        {
            int nc = 0;
            bool sus = int.TryParse(FirstTB.Text, out nc);
            bool sus2 = int.TryParse(SecondTB.Text, out nc);
            if (sus && sus2)
            {
                bool findsus1 = false;
                bool findsus2 = false;
                foreach (Control c in SeatsPanel.Controls)
                {
                    //MessageBox.Show(c.Name);
                    if (c is Label && c.Name == "lbn" + FirstTB.Text)
                    {
                        findsus1 = true;

                    }else if (c is Label && c.Name == "lbn" + SecondTB.Text)
                    {
                        findsus2 = true;
                    }
                }
                if (findsus1 && findsus2)
                {
                    string tmpText,tmpName;
                    Control c = ((Label)SeatsPanel.Controls.Find("lbn" + FirstTB.Text, true)[0]);
                    tmpText = c.Text;
                    tmpName = c.Name;
                    Control v = ((Label)SeatsPanel.Controls.Find("lbn" + SecondTB.Text, true)[0]);
                    c.Text = v.Text;
                    c.Name = v.Name;
                    v.Text = tmpText;
                    v.Name = tmpName;
                    MessageBox.Show("Change Successful!");
                }
                else
                {
                    MessageBox.Show("No such as Number in result");
                }
            }
            else if(sus == false && sus2 == true)
            {
                MessageBox.Show("First empty should be number! ");
            }else if (sus2 == false && sus == true)
            {
                MessageBox.Show("Second empty should be number!");
            }
            else
            {
                MessageBox.Show("Please enter again!");
            }
        }

        public SeatControl(List<int> tbc, int ppl, string clsn,int rw, bool animate)
        {
            InitializeComponent();
            EachRowsCount = tbc;
            peopleCount = ppl;
            className = clsn;
            Rows = rw;
            Animate = animate;
        }

        private void SeatControl_Load(object sender, EventArgs e)
        {
            try
            {
                int count = 0;
                label1.Text = className;
                widget = 565 / Rows;
                high = 39;
                for (int i = 1; i <= peopleCount; i++)
                {
                    PeopleNumberList.Add(i);
                }
                for (int i = 0; i < peopleCount; i++)
                {
                    Random random = new Random(Guid.NewGuid().GetHashCode());
                    int index = random.Next(0, peopleCount - i);
                    Result.Add(PeopleNumberList[index]);
                    PeopleNumberList.RemoveAt(index);
                }
                for (int i = 0; i < Rows; i++)
                {
                    for (int j = 0; j < EachRowsCount[i]; j++)
                    {
                        if (Animate == true)
                        {
                            MessageBox.Show($"第{count+1}個是: " + Result[count].ToString());
                        }
                        Label seat = new Label();
                        seat.Text = Result[count].ToString();
                        string SeatsID = "lbn" + Result[count].ToString();
                        seat.Name = SeatsID;
                        SeatsResultID.Add(SeatsID);
                        seat.AutoSize = false;
                        var Fontsize = seat.Font.Size;
                        Fontsize = 14;
                        seat.Font = new Font("Arial", Fontsize, FontStyle.Bold);
                        seat.Size = new Size(34, 30);
                        seat.Location = new Point(0 + i * widget, 0 + j * high);
                        seat.TextAlign = ContentAlignment.MiddleCenter;
                        seat.BackColor = label1.BackColor;
                        SeatsPanel.Controls.Add(seat);
                        count++;
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
