using FontAwesome.Sharp;
using LibFunctions;
using System.Runtime.InteropServices;

namespace EasyGabinete_v10
{
    public partial class F_Principal : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currectChildForm;
        public F_Principal()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 45);
            panel1Menu.Controls.Add(leftBorderBtn);
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        #region Botoões Menu
        private void iconButton1_Click(object sender, EventArgs e)
        {
            ActiveButtons(sender, RGBColor.color1);
            OpenForm(new F_Geral());
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            ActiveButtons(sender, RGBColor.color1);
            OpenForm(new F_Apoiador());
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            ActiveButtons(sender, RGBColor.color1);
            OpenForm(new F_Instituicoes());
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            ActiveButtons(sender, RGBColor.color1);
            OpenForm(new F_Demandas());
        }

        private void Btn_Map_Click(object sender, EventArgs e)
        {
            ActiveButtons(sender, RGBColor.color1);
        }

        private void Btn_Propositura_Click(object sender, EventArgs e)
        {
            ActiveButtons(sender, RGBColor.color1);
        }

        private void Btn_Aniversariante_Click(object sender, EventArgs e)
        {
            ActiveButtons(sender, RGBColor.color1);
        }

        private void Btn_Agenda_Click(object sender, EventArgs e)
        {
            ActiveButtons(sender, RGBColor.color1);
        }

        private void Btn_Suporte_Click(object sender, EventArgs e)
        {
            ActiveButtons(sender, RGBColor.color1);
        }

        private void Btn_Usuario_Click(object sender, EventArgs e)
        {
            ActiveButtons(sender, RGBColor.color1);
        }

        private void Btn_TelefonesUteis_Click(object sender, EventArgs e)
        {
            ActiveButtons(sender, RGBColor.color1);
        }

        private void Btn_Sair_Click(object sender, EventArgs e)
        {
            ActiveButtons(sender, RGBColor.color1);
            F_Sair fsair = new F_Sair();
            fsair.ShowDialog();
            if(fsair.DialogResult == DialogResult.OK)
            {
                Application.Exit();
            }
            else
            {
                DisableButtons();
                panel1Menu.Controls.Remove(leftBorderBtn);
            }
        }
        #endregion


        private struct RGBColor
        {
            public static Color color1 = Color.FromArgb(241, 33, 9);
        }

        private void OpenForm(Form newForm)
        {
            if(currectChildForm != null)
            {
                currectChildForm.Close();
            }
            currectChildForm = newForm;
            newForm.TopLevel = false;
            newForm.FormBorderStyle = FormBorderStyle.None;
            newForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(newForm);
            panelDesktop.Tag = newForm;
            newForm.BringToFront();
            newForm.Show();
        }

        private void ActiveButtons(object senderBtn, Color color)
        {
            
            if (senderBtn != null)
            {
                DisableButtons();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.White;
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor= color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                panel1Menu.Controls.Add(leftBorderBtn);
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }

        private void DisableButtons()
        {
            if (currentBtn != null) 
            {
                currentBtn.BackColor = Color.FromArgb(49, 225 ,243);
                currentBtn.ForeColor = Color.Black;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor= Color.Black;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void Btn_Icon_Click(object sender, EventArgs e)
        {
            F_Sair fsair = new F_Sair();
            fsair.ShowDialog();
            if (fsair.DialogResult == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Reset();
            OpenForm(new F_PainelPrincipal());

        }

        private void Reset()
        {
            DisableButtons();
            leftBorderBtn.Visible = false;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void iconButton14_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal)
                WindowState= FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void iconButton15_Click(object sender, EventArgs e)
        {
            WindowState= FormWindowState.Minimized;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}