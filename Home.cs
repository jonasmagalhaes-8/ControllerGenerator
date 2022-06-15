using System;
using System.IO;
using System.Windows.Forms;

namespace ControllerGenerator
{
    public partial class Home : Form
    {
        public Home()
        { InitializeComponent(); }

        private string substidor(string controllerName, string metodo)
        {
            metodo = metodo.Replace("Name", controllerName);
            metodo = metodo.Replace("Lower", controllerName.ToLower());
            metodo = metodo.Replace("FirstLow", char.ToLower(controllerName[0]) + controllerName.Substring(1));

            if(txtApi.Visible == false)
            metodo = metodo.Replace("SelectedApi", cb_api.SelectedItem.ToString());
            else
            metodo = metodo.Replace("SelectedApi", txtApi.Text);

            return metodo;
        }

        private void cb_api_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cb_api.SelectedIndex==4)
            txtApi.Visible = true;
            else
            {
                if(txtApi.Visible==true)
                {
                    txtApi.Visible = false;
                    txtApi.Text = "";
                }
            }
        }

        private void btController_Click(object sender, EventArgs e)
        {
            if (cb_api.SelectedIndex != -1)
            {
                string controllerName = txtNameController.Text;
                string resultado = "";

                resultado += substidor(controllerName, File.ReadAllText(@"controllerCabecario.txt"));

                if (cbxGet.Checked)
                resultado += "\n\n" + substidor(controllerName, File.ReadAllText(@"controllerGetbyid.txt"));

                if (cbxInsert.Checked)
                resultado += "\n\n" + substidor(controllerName, File.ReadAllText(@"controllerInsert.txt"));

                if (cbxUpdate.Checked)
                resultado += "\n\n" + substidor(controllerName, File.ReadAllText(@"controllerUpdate.txt"));

                if (cbxDelete.Checked)
                resultado += "\n\n" + substidor(controllerName, File.ReadAllText(@"controllerDelete.txt"));

                if (cbxFind.Checked)
                resultado += "\n\n" + substidor(controllerName, File.ReadAllText(@"controllerFind.txt"));

                txtGenerated.Text = resultado;
            }
            else
            MessageBox.Show("Informe uma API!");
        }

        private void btService_Click(object sender, EventArgs e)
        {
                string controllerName = txtNameController.Text;
                string resultado = "";

                resultado += substidor(controllerName, File.ReadAllText(@"serviceCabecario.txt"));

                if (cbxGet.Checked)
                resultado += "\n\n" + substidor(controllerName, File.ReadAllText(@"serviceGetbyid.txt"));

                if (cbxInsert.Checked)
                resultado += "\n\n" + substidor(controllerName, File.ReadAllText(@"serviceInsert.txt"));

                if (cbxUpdate.Checked)
                resultado += "\n\n" + substidor(controllerName, File.ReadAllText(@"serviceUpdate.txt"));

                if (cbxDelete.Checked)
                resultado += "\n\n" + substidor(controllerName, File.ReadAllText(@"serviceDelete.txt"));

                txtGenerated.Text = resultado;
        }

        private void btRepository_Click(object sender, EventArgs e)
        {
            string controllerName = txtNameController.Text;
            string resultado = "";

            resultado += substidor(controllerName, File.ReadAllText(@"repositoryCabecario.txt"));

            txtGenerated.Text = resultado;
        }
    }
}
