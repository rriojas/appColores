using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace appColores
{
  public class Metodos
  {
    public static void LimpiarTextos(Form f)
    {
      foreach (Control elControl in f.Controls)
      {
        if (elControl is TextBox)
        {
          ((TextBox)elControl).Clear();
        }

      }
    }
  }
}
