using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace App_reto1
{
    public partial class frm_registro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_registrar_Click(object sender, EventArgs e)
        {
            cls_registro objUsuarios = new cls_registro();
            objUsuarios.fnt_agregar(txt_id.Text, txt_nombre.Text, txt_apellido.Text, txt_contacto.Text, txt_correo.Text,
                txt_direccion.Text, txt_empresa.Text, txt_salario.Text, txt_monto.Text, cbx_meses.SelectedValue);
            lbl_mensaje.Text = objUsuarios.getMensaje();
        }

        protected void btn_cancelar_Click(object sender, EventArgs e)
        {
            txt_id.Text = "";
            txt_nombre.Text = "";
            txt_apellido.Text = "";
            txt_contacto.Text = "";
            txt_correo.Text = "";
            txt_direccion.Text = "";
            txt_empresa.Text = "";
            txt_salario.Text = "";
            txt_monto.Text = "";
            cbx_meses.SelectedIndex = 0;
            this.txt_id.Focus();
        }
    }
}