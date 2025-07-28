using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Padaria
{
    public partial class FrmCaixa : Form
    {
        //Variaveis globais 
        Model.Usuario usuario;
        public FrmCaixa(Model.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }
    }
}
