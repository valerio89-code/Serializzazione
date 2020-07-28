using Serializzazione.Code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serializzazione
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_serialize_Click(object sender, EventArgs e)
        {
            Persona p = GetPersona();
            FileStream fs = new FileStream("C:\\Corso c#\\Serializzazione.txt", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, p);
            fs.Close();
        }

        private void btn_deserialize_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("C:\\Corso c#\\Serializzazione.txt", FileMode.Open);
            var bf = new BinaryFormatter();
            object obj = bf.Deserialize(fs);
            Persona p = (Persona)obj;
            ShowPersona(p);
            fs.Close();
        }

        private void ShowPersona(Persona p)
        {
            tbx_cognome.Text = p.Cognome;
            tbx_età.Text = p.Età.ToString();
            tbx_nome.Text = p.Nome;
        }

        private Persona GetPersona()
        {
            return new Persona
            {
                Cognome = tbx_nome.Text,
                Nome = tbx_cognome.Text,
                Età = int.Parse(tbx_età.Text)
            };
        }
    }
}
