using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BussinessChatter
{
    public partial class ListItem : UserControl
    {
        public ListItem()
        {
            InitializeComponent();
        }

        #region Properties
        private int _id;
        [Category("Custom props")]
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _title;
        [Category("Custom props")]
        public string Title
        {
            get { return _title; }
            set { _title = value; title.Text = value; }
        }

        private string _assignees;
        
        [Category("Custom props")]
        public string Assignees
        {
            get { return _assignees; }
            set { _assignees = value; assignees.Text = value; }
        }

        private int _progress;

        [Category("Custom props")]
        public int Progress
        {
            get { return _progress; }
            set { _progress = value; progress.Width = (progressBg.Width * value) / 100; progressText.Width = (progressBg.Width * value) / 100; progressText.Text = value + "%"; }
        }
        private int _userid;

        [Category("Custom props")]
        public int UserId
        {
            get { return _userid; }
            set { _userid = value; }
        }

        private string _icon;
        
        public string Icon
        {
            get { return _icon; }
            set { _icon = value; itemPic.ImageLocation = value; }
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            mainWindow f1 = new mainWindow(_userid);
            f1.AddUserToTask(_id, _userid);
            f1.refreshItems();
        }
    }
}
