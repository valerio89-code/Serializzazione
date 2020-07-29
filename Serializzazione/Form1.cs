using Newtonsoft.Json;
using Serializzazione.Code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

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
            p.Auto = new Automobile { Cilindrata = 1500, Marca = "Fiat" };
            //Studente s = new Studente() { Matricola = 256 };
            //SerializzaInXML(p);
            SerializzaInXMLConDataContract(p);
            //SerializzaInBinario(p);
            SerializzaInJSON(p);
            SerializzaInJsonConNewtonsoft(p);

        }
            
        private void btn_deserialize_Click(object sender, EventArgs e)
        {
            DeserializzaDaJsonConNewtonsoft();
        }

        public void DeserializzaDaJsonConNewtonsoft()
        {
            using (var streamReader = new StreamReader("C:\\Corso c#\\serializzatoJsonConNewtonsoft.json"))
            {
                var persona = JsonConvert.DeserializeObject<Persona>(streamReader.ReadLine());
                ShowPersona(persona);
            }
        }
        public void DeserializzaDaBinario()
        {
            FileStream fs = new FileStream("C:\\Corso c#\\Serializzazione.txt", FileMode.Open);
            var bf = new BinaryFormatter();
            object obj = bf.Deserialize(fs);
            Persona p = (Persona)obj;
            ShowPersona(p);
            fs.Close();
        }
        private void SerializzaInBinario(Persona pippo)
        {
            FileStream fs = new FileStream("C:\\Corso c#\\Serializzazione.txt", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, pippo);
            fs.Close();
        }
        private void SerializzaInXMLConDataContract(Persona p)
        {
            var dcs = new DataContractSerializer(typeof(Persona));
            FileStream fs = File.OpenWrite("C:\\Corso c#\\serializzatoXmlConDataContract.xml");
            dcs.WriteObject(fs, p);
            fs.Close();
        }
        private void SerializzaInXML(Persona p)
        {
            XmlSerializer dcs = new XmlSerializer(typeof(Persona));
            FileStream fs = File.OpenWrite("C:\\Corso c#\\serializzato2.xml");
            dcs.Serialize(fs, p);
            fs.Close();
        }
        private void SerializzaInJSON(Persona p)
        {
            var dcs = new DataContractJsonSerializer(typeof(Persona));
            FileStream fs = File.OpenWrite("C:\\Corso c#\\serializzato.json");
            dcs.WriteObject(fs, p);
            fs.Flush();
            fs.Close();

            
        }

        private void SerializzaInJsonConNewtonsoft(Persona p)
        {
            var sw = new StreamWriter("C:\\Corso c#\\serializzatoJsonConNewtonsoft.json");
            var personaSerialized = JsonConvert.SerializeObject(p);
            sw.WriteLine(personaSerialized);
            sw.Close();
        }
        private void ShowPersona(Persona p)
        {
            tbx_cognome.Text = p.Cognome;
            tbx_età.Text = p.Età.ToString();
            tbx_nome.Text = p.Nome;
        }

        private Persona GetPersona()
        {
            return new Persona(tbx_nome.Text)
            {
                Cognome = tbx_cognome.Text,
                Età = int.Parse(tbx_età.Text)
            };
        }
    }
}
