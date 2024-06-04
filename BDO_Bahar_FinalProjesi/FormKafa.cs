using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDO_Bahar_FinalProjesi
{
    public partial class FormKafa : Form
    {
        public FormKafa()
        {
            InitializeComponent();
        }

        private void FormKafa_Load(object sender, EventArgs e)
        {
            // Etiketlere kafatası bölümlerinin isimlerini atayalım
            label1.Text = "Parietal Bone";
            label2.Text = "Frontal Bone";
            label3.Text = "Occipital Bone";
            label4.Text = "Temporal Bone";
            
            // Diğer etiketler için de benzer şekilde isimler atayabilirsiniz
        }

        private void Label_Click(object sender, EventArgs e)
        {
            Label selectedLabel = sender as Label;

            if (selectedLabel != null)
            {
                // Tıklanan bölümün adını al ve detaylarını göster
                string skullPart = selectedLabel.Text;
                ShowSkullPartDetails(skullPart);
            }
        }

        private void ShowSkullPartDetails(string skullPart)
        {
            string details;

            if (skullPart == "Parietal Bone")
            {
                details = "Parietal Bone:\n\n- Located on the sides and roof of the skull.\n- Forms the central side and upper back part of each side of the skull.";
            }
            else if (skullPart == "Frontal Bone")
            {
                details = "Frontal Bone:\n\n- Located at the front of the skull.\n- Forms the forehead and the upper part of the eye sockets.";
            }
            else if (skullPart == "Occipital Bone")
            {
                details = "Occipital Bone:\n\n- Located at the back and base of the skull.\n- Contains the foramen magnum, through which the spinal cord connects with the brain.";
            }
            else if (skullPart == "Temporal Bone")
            {
                details = "Temporal Bone:\n\n- Located at the sides and base of the skull.\n- Houses structures of the ears.";
            }
            else if (skullPart == "Sphenoid Bone")
            {
                details = "Sphenoid Bone:\n\n- Located at the sides and base of the skull.\n- Houses structures of the ears.";
            }
            else
            {
                details = "Details for this skull part are not available.";
            }

            // Detayları bir mesaj kutusunda göster
            MessageBox.Show(details, "Skull Part Details");
        }

        
    }
}
