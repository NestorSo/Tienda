namespace TareaDeCurso
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            Usuarios();
        }
       Dictionary<string, string> usuarios = new Dictionary<string, string>();
        frmRegistro Tienda = new frmRegistro(); 
        public void Usuarios()
        {
            usuarios.Add("Nsoto26007","N2601");
            usuarios.Add("Cpalaios26007","C2601");
            usuarios.Add("Dchavarria26007","D2601");
        }
        private void btnInicio_Click(object sender, EventArgs e)
        {
            string user = txtUsuario.Text;
            string pass= txtContrase�a.Text;
            int i = 5;
            if (usuarios.ContainsKey(user) && usuarios.ContainsValue(pass))
            {
                Tienda.ShowDialog();
                txtContrase�a.Clear();
                txtUsuario.Clear();
            }
            else
            {
                
                    txtContrase�a.Clear();
                    txtUsuario.Clear();
                    MessageBox.Show("El usuario ingresado o la contrase�a son incorretos vuelva a ingresarlos",
                        "Intente ingresarlos nuevamente ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                
            }
        }

       
    }
}