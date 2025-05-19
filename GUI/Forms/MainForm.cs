using System.Windows.Forms;

namespace AcademicTaskManager.GUI.Forms
{
    public class MainForm : Form
    {
        private Button btnTeste;

        public MainForm()
        {
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            // Configuração básica do formulário
            this.Text = "Academic Task Manager";
            this.Width = 800;
            this.Height = 600;

            // Adiciona um botão de teste
            btnTeste = new Button
            {
                Text = "Clique Aqui",
                Width = 100,
                Height = 50,
                Top = 20,
                Left = 20
            };
            
            btnTeste.Click += (sender, e) => 
            {
                MessageBox.Show("Funcionando!");
            };

            this.Controls.Add(btnTeste);
        }
    }
}