using System;
using System.Drawing;
using System.Windows.Forms;

namespace PT4
{
    public partial class AnimalsPopUpModify : Form
    {
        public client client { get; set; }
        public animal animal { get; set; }

        public AnimalsPopUpModify(client c, animal a)
        {
            this.client = c;
            this.animal = a;
            InitializeComponent();
            InitPanel();
            InitText();
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
        }

        #region Init Methods

        private void InitText()
        {
            textBox_Name.Text = animal.nomAnimal;
            textBox_Espece.Text = animal.nomEspece;
            textBox_Race.Text = animal.nomRace;
            numericUpDown_Weight.Value = animal.poids;
            numericUpDown_Heigth.Value = animal.taille;
            dateTimePicker_birthdate.Value = animal.dateNaissance.Value;
        }

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
                    idAnimal = animal.idAnimal,
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
                label_error.Text = "Impossible de modifier : Des informations sont incorrectes";
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            string message = "Voulez-vous vraiment supprimer cette animal ?";
            string caption = "Suppression animal";
            var response = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
            if (response == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Retry;
                this.Close();
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
