using System;
using System.Drawing;
using System.Windows.Forms;

namespace PT4
{
    public partial class AnimalsPopUp : Form
    {
        public client client { get; set; }
        public animal animal { get; set; }

        public AnimalsPopUp(client c)
        {
            this.client = c;
            InitializeComponent();
            InitPanel();
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
        }
        #region Init Methods
        private void InitPanel()
        {
            panel_main.Location = new Point(this.ClientSize.Width / 2 - panel_main.Size.Width / 2, this.ClientSize.Height / 2 - panel_main.Size.Height / 2);
            panel_main.Anchor = AnchorStyles.None;
        }
        #endregion

        #region Buttons Events
        private void button_OK_Click(object sender, EventArgs e)
        {
            if (Valid())
            {
                animal = new animal
                {
                    client = client,
                    nomAnimal = textBox_Name.Text,
                    nomEspece = textBox_Espece.Text,
                    nomRace = textBox_Race.Text,
                    poids = Int32.Parse(numericUpDown_Weight.Value.ToString()),
                    taille = Int32.Parse(numericUpDown_Heigth.Value.ToString()),
                    dateNaissance = dateTimePicker_birthdate.Value
                };
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                label_error.Text = "Des informations sont incorrectes";
            }
        }
        #endregion

        private bool Valid()
        {
            return !String.IsNullOrWhiteSpace(textBox_Name.Text)
                && !String.IsNullOrWhiteSpace(textBox_Espece.Text)
                && !String.IsNullOrWhiteSpace(textBox_Race.Text)
                && numericUpDown_Heigth.Value > 0
                && numericUpDown_Weight.Value > 0;
        }
    }
}
