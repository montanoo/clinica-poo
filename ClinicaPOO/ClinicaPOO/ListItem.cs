using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaPOO
{
    public partial class ListItem : UserControl 
    {
        public ListItem()
        {
            InitializeComponent();
        }

        #region Properties
        private string _procedure;
        private string _doctor;
        private DateTime _dateTime;
        private double _price;


        [Category("CustomProps")]
        public string Procedure
        {
            get { return _procedure; }
            set { _procedure = value; lblprocedure.Text = value; }
        }

        [Category("CustomProps")]
        public string Doctor
        {
            get { return _doctor; }
            set { _doctor = value; lbldoctor.Text = value; }
        }

        [Category("CustomProps")]
        public DateTime AssignedDate
        {
            get { return _dateTime; }
            set { _dateTime = value; lbldatetime.Text = value.ToString(); }
        }

        [Category("CustomProps")]
        public double Price
        {
            get { return _price; }
            set { _price = value; lblprice.Text = value.ToString(); }
        }


        #endregion

        private void ListItem_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Lavender;
        }

        private void ListItem_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }
    }
}
