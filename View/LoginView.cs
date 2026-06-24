using seasonPlusHouse.CODE.DTO;
using seasonPlusHouse.CODE.BLL;
namespace seasonPlusHouse
{
    public partial class LoginView : Form
    {
        
        public LoginView()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            usuarioDTO dto = new usuarioDTO();

            dto.nomeUsuario1 = txtUser.Text;
            dto.senhaUsuario1 = txtSenha.Text;

            //Loginca de serviço de login do BCrypt

            AluguelTemporada servico = new AluguelTemporada();
            bool loginValido = servico.ValidarLogin(dto);

            // 3. Responde na tela
            if (loginValido)
            {
                MessageBox.Show("Bem-vindo ao Season + House!");
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos.");
            }


        }
    }
}
