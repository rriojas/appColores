using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appColores
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }
    /*private void txtR_TextChanged(object sender, EventArgs e)
    {
      CambiaColorFondo();
    }
    private void txtG_TextChanged(object sender, EventArgs e)
    {
      CambiaColorFondo();
    }
    private void txtB_TextChanged(object sender, EventArgs e)
    {
      CambiaColorFondo();
    }
    */
    void CambiaColorFondo(object sender, EventArgs e)
    {
      int R = 0;
      if (txtR.Text != "")
      {
        R = int.Parse(txtR.Text);
      }
      int G = 0;
      if (txtG.Text != "")
      {
        G = int.Parse(txtG.Text);
      }
      int B = 0;
      if (txtB.Text != "")
      {
        B = int.Parse(txtB.Text);
      }
      this.BackColor = Color.FromArgb(R, G, B);
    }

    private void btnLimpiar_Click(object sender, EventArgs e)
    {
      Metodos.LimpiarTextos(this);
      
    }
    
  }
}
