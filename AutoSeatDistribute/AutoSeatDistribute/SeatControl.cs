using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoSeatDistribute
{
    public partial class SeatControl : UserControl
    {
        List<int> EachRowsCount = new List<int>();
        int peopleCount,Rows;
        string className;
        List<int> PeopleNumberList = new List<int>();
        List<int> Result = new List<int>();
        int widget,high;
        bool Animate;
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
                        string lbn = "LB" + Result[count];
                        seat.Text = Result[count].ToString();
                        seat.Name = lbn;
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
