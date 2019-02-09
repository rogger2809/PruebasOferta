using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ModeloNegocios;
using AccesoDatos;

namespace Asignación_de_Demanda
{
    public partial class Principal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            this.PoblarLista();
        }

        public void PoblarLista()
        {
            List<Resultado> ListResultado = null;

            this.GridDemandaOferta.DataSource = null;
            this.GridDemandaOferta.DataBind();

            //Obtener l valos del campo
            int IdProducto = string.IsNullOrEmpty(this.txtIdProducto.Text) ? IdProducto = 0 : Convert.ToInt32(this.txtIdProducto.Text);

            if(IdProducto != 0)
            {
                //obtenemos la informacion de la DB
                try
                {
                    ListResultado = Consulta.ObtenerResultado(IdProducto);
                }
                catch (Exception ex)
                {

                }
            }

            if(ListResultado != null)
            {
                if(ListResultado.Count > 0)
                {
                    this.GridDemandaOferta.DataSource = ListResultado;
                    this.GridDemandaOferta.DataBind();

                }
            }
            

        }
    }
}