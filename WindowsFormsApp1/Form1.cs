using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BiblioMascota;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // AGREGAR 5 MASCOTAS COMO DATOS DE PRUEBA
            ColeccionMascotas.Agregar(new Mascota {
                Id = 1001, Nombre = "RAMBO", Raza = "CHIHUAHUA",
                Edad = 4, FechaNacim = new DateTime(2018,1,15),
                Sexo = "MACHO", Vacunado = true
            });

            ColeccionMascotas.Agregar(new Mascota {
                Id = 1002, Nombre = "FELIX", Raza = "SIBERIANO",
                Edad = 4,
                FechaNacim = new DateTime(2020, 12, 25),
                Sexo = "MACHO",
                Vacunado = true
            });
            ColeccionMascotas.Agregar(new Mascota
            {
                Id = 1003,
                Nombre = "BILS",
                Raza = "GATITO",
                Edad = 500,
                FechaNacim = new DateTime(1950, 12, 25),
                Sexo = "MACHO",
                Vacunado = false
            });
            ColeccionMascotas.Agregar(new Mascota
            {
                Id = 1004,
                Nombre = "LOLY",
                Raza = "MALTES",
                Edad = 2,
                FechaNacim = new DateTime(2020, 8, 5),
                Sexo = "HEMBRA",
                Vacunado = true
            });
            ColeccionMascotas.Agregar(new Mascota
            {
                Id = 1005,
                Nombre = "PETUNIA",
                Raza = "GRAN DANES",
                Edad = 8,
                FechaNacim = new DateTime(2014, 7, 26),
                Sexo = "HEMBRA",
                Vacunado = true
            });

            // agregamos las mascotas al dataGrid y actualizamos
            dataGridView1.DataSource = ColeccionMascotas.ListarTodas();
            dataGridView1.Refresh();

        }

        private void bt_crear_Click(object sender, EventArgs e)
        {
            string errores = "";
            if (tx_id.Text == "") errores += "falta id\n";
            if (tx_nombre.Text == "") errores += "falta nombre\n";
            if (tx_raza.Text == "") errores += "falta raza\n";
            if (tx_edad.Text.Length == 0) errores += "falta edad";
            if(errores != "")
            {
                MessageBox.Show(errores);
                return; // quiebra la ejecución
            }

            Mascota mascota = new Mascota();
            mascota.Id = int.Parse(tx_id.Text);
            mascota.Nombre = tx_nombre.Text;
            mascota.Raza = tx_raza.Text;
            mascota.Edad = int.Parse(tx_edad.Text);
            mascota.Vacunado = ch_vacunas.Checked;
            mascota.FechaNacim = dt_fecha.Value;
            mascota.Sexo = tx_sexo.Text;

            if(ColeccionMascotas.Agregar(mascota) == true)
            {
                dataGridView1.DataSource = ColeccionMascotas.ListarTodas();
                dataGridView1.Refresh();
                MessageBox.Show("Mascota Agregada con exito!");
            } else
            {
                MessageBox.Show("Id Mascota Ya existe, revisa");
            }
            

            //richTextBox1.Text += mascota.Datos();

            

        }

        private void bt_buscar_Click(object sender, EventArgs e)
        {
            // validar que el id no esté vacio
            if (tx_id.Text == "")
            {
                MessageBox.Show("Id no puede estar vacio");
                return;
            }
            Mascota buscada = ColeccionMascotas.BuscarId(int.Parse(tx_id.Text));
            if(buscada == null)
            {
                MessageBox.Show("Id no existe en coleccion");
            } else
            {
                // mascota existe, rellenamos el form con los datos de buscada
                tx_nombre.Text = buscada.Nombre;
                tx_raza.Text = buscada.Raza;
                tx_edad.Text = buscada.Edad + "";
                tx_sexo.Text = buscada.Sexo;
                ch_vacunas.Checked = buscada.Vacunado;   
                dt_fecha.Value = buscada.FechaNacim;
            }
        }

        private void bt_eliminar_Click(object sender, EventArgs e)
        {
            int idEliminar = int.Parse(tx_id.Text);
            DialogResult dialogResult = 
                MessageBox.Show("Seguro de eliminar", 
                "eliminar", 
                MessageBoxButtons.YesNo);

            if(dialogResult == DialogResult.No)
            {
                return;
            }

            if(ColeccionMascotas.Eliminar(idEliminar) == true)
            {
                // si duevuelve true, se eliminó la mascota
                dataGridView1.DataSource = ColeccionMascotas.ListarTodas();
                dataGridView1.Refresh();
                MessageBox.Show("Mascota removida con exito!");
            }  else
            {
                MessageBox.Show("Id no encontrado en coleccion");
            }
        }

        private void bt_editar_Click(object sender, EventArgs e)
        {
            Mascota mascota = new Mascota();
            mascota.Id = int.Parse(tx_id.Text);
            mascota.Nombre = tx_nombre.Text;
            mascota.Raza = tx_raza.Text;
            mascota.Edad = int.Parse(tx_edad.Text);
            mascota.Vacunado = ch_vacunas.Checked;
            mascota.FechaNacim = dt_fecha.Value;
            mascota.Sexo = tx_sexo.Text;
            if (ColeccionMascotas.Modificar(mascota) == true)
            {
                dataGridView1.DataSource = ColeccionMascotas.ListarTodas();
                dataGridView1.Refresh();
                MessageBox.Show("Mascota Modificada con exito!");
            }
            else
            {
                MessageBox.Show("Id Mascota Ya existe, revisa");
            }

        }

        private void bt_reset_Click(object sender, EventArgs e)
        {
            tx_id.Text = "";
            tx_nombre.Text = "";
            tx_raza.Text = "";
            tx_edad.Text = "";
            tx_sexo.Text = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
