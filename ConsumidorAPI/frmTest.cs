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
            //Creamos el listado de Posts a llenar
            List<Post> listado = new List<Post>();
            //Instanciamos un objeto Reply
            Reply oReply = new Reply();
            //poblamos el objeto con el método generic Execute
            oReply = await Consumer.Execute<List<Post>>(this.txtUri.Text, ApiHelper.methodHttp.GET, listado);
            //Poblamos el datagridview
            this.dgvGet.DataSource = oReply.Data;
            //Mostramos el statuscode devuelto, podemos añadirle lógica de validación
            MessageBox.Show(oReply.StatusCode);
        }

        private async void btnPost_Click(object sender, EventArgs e)
        {
            Post post = new Post()
            {
                userId = 1,
                title = "titulo del post",
                body = "Cuerpo del post"

            };

            Reply oReply = new Reply();
            
            oReply = await Consumer.Execute<Post>(this.txtUriPost.Text, ApiHelper.methodHttp.POST, post);

            MessageBox.Show(oReply.StatusCode);
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            Reply oReply = new Reply();

            oReply = await Consumer.Execute<Post>($"{this.txtUriPost.Text}/{this.txtId.Value}", ApiHelper.methodHttp.DELETE, null);

            MessageBox.Show(oReply.StatusCode);
        }
    }
}
