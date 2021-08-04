using ConsumidorAPI.ApiHelper;
using ConsumidorAPI.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsumidorAPI
{
    public partial class frmTest : Form
    {
        public frmTest()
        {
            InitializeComponent();
        }

        private async void btnGet_Click(object sender, EventArgs e)
        {
            List<Post> listado = new List<Post>();
            Reply oReply = new Reply();
            Consumer consumer = new Consumer();
            oReply = await consumer.Execute<List<Post>>(this.txtUri.Text, ApiHelper.methodHttp.GET, listado);

            this.dgvGet.DataSource = oReply.Data;
            MessageBox.Show(oReply.StatusCode);
        }
    }
}
