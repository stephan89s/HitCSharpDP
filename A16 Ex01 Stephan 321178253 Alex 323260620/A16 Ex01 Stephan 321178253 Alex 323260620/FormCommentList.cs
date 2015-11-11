using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace A16_Ex01_Stephan_321178253_Alex_323260620
{
    public partial class FormCommentList : Form
    {
        public FormCommentList(List<ApplicationComment> i_m_selectedPostCommentsList)
        {

            InitializeComponent();
            dataGridViewComments.DataSource = i_m_selectedPostCommentsList;
        }

        private void buttonCloseComment_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
