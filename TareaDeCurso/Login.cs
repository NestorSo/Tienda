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
        frmTiendaDeRopa Tienda = new frmTiendaDeRopa(); 
        public void Usuarios()
        {
            usuarios.Add("Nsoto26007","N2601");
            usuarios.Add("Cpalaios26007","C2601");
            usuarios.Add("Dchavarria26007","D2601");
        }
        private void btnInicio_Click(object sender, EventArgs e)
        {
            string user = txtUsuario.Text;
            string pass= txtContraseña.Text;
            int i = 5;
            if (usuarios.ContainsKey(user) && usuarios.ContainsValue(pass))
            {
                Tienda.ShowDialog();
            }
            else
            {
                
                    txtContraseña.Clear();
                    txtUsuario.Clear();
                    MessageBox.Show("El usuario ingresado o la contraseña son incorretos vuelva a ingresarlos",
                        "le quedan " + i-- + " intentos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                
            }
        }
    }
}