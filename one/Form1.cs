using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.WinForms;
using MetroFramework.Forms;
using MetroFramework;
using MetroFramework.Interfaces;
using MetroFramework.Components;
using MetroFramework.Controls;
using MetroFramework.Drawing;
using MetroFramework.Fonts;
using MetroFramework.Native;
using MetroFramework.Properties;

//hola bienvenido lograste entrar a mi codigo como premio te guiare por aqui
//este codigo fue realizado por JD

namespace one
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        //nombramos a los registros del usuario como item 
        ListViewItem Item;

        //aqui estan las acciones del boton Agregar
        private void metroButton1_Click(object sender, EventArgs e)
        {
                                    //evaluamos cual es la mayor nota 
                    int notaA, notaB, notaC, notaMin = 0;

                    notaA = int.Parse(txtNota1.Text);
                    notaB = int.Parse(txtNota2.Text);
                    notaC = int.Parse(txtNota3.Text);
                    if (notaA <= notaB)
                    {
                        if (notaA <= notaC)
                        {
                            notaMin = notaA;
                        }
                        else
                        {
                            notaMin = notaC;
                        }
                    }
                    else
                    {
                        if (notaB <= notaC)
                        {
                            notaMin = notaA;
                        }
                        else
                        {  
                                notaMin = notaC;   
                        }
                    }

                    //obtenemos el promedio de las notas divido en 3
                    int promedio;
                    promedio = (notaA + notaB + notaC) / 3;

                    string Condicion;
                    if (promedio >= 51)
                    {
                        Condicion = "Aprobado";
                    }
                    else
                    {
                        if (promedio >= 35)
                        {
                            Condicion = "Segundo Turno";
                        }
                        else
                        {
                            Condicion = "Reprobado";
                        }
                    }

                    //mostramos el curso en un label oculto ;)
                    string curso = this.txtCurso.Text;//recolecta
                    this.lblCurso.Text = "Curso: " + " " + curso.ToString();//muestra

            //copiamos los datos que el usuario ingresa hacia el listView 
                    ListViewItem Registrar = new ListViewItem(txtNombre.Text);
                    Registrar.SubItems.Add(txtNota1.Text);
                    Registrar.SubItems.Add(txtNota2.Text);
                    Registrar.SubItems.Add(txtNota3.Text);
            //mostramos la informacion del procedimiento de mas arriba
                    Registrar.SubItems.Add(notaMin.ToString());
                    Registrar.SubItems.Add(promedio.ToString());
                    Registrar.SubItems.Add(Condicion.ToString());
            //importante! para registrar todo
                    lvEstudiantes.Items.Add(Registrar);
            //limpiamos los texbox para que el usuario pueda ingresar mas registros
                    txtNombre.Clear();
                    txtNota1.Clear();
                    txtNota2.Clear();
                    txtNota3.Clear();       
        }

        //este boton limpia todo el lisView
        private void btnLImpiar_Click(object sender, EventArgs e)
        {
        
            lvEstudiantes.Items.Clear();
        }
        //obtenemos el registro marcado por el usuario para eliminarlo
        private void lvEstudiantes_MouseClick(object sender, MouseEventArgs e)
        { 
            Item = lvEstudiantes.GetItemAt(e.X, e.Y);

        }
        //eliminamos el registro marcado 
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Item != null)
            {
                lvEstudiantes.Items.Remove(Item);
               
            }
            else
            {
                MessageBox.Show("Debe Seleccionar un Registro");
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            //boton Acerca de
            Form2 Form2 = new Form2();
            //muestra el formulario 4
            Form2.Show();
        }
    }

}
//espero haberte ayudado si tienes dudas contactame a mi correo con gusto te respondere
//aquila6555@gmail.com
//repite: Quiero, Puedo y Lo voy a lograr.
//Que tengas un lindo dia :)
