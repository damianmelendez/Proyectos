using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Traductor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        Dictionary<char, string> diccionariosecreto = new Dictionary<char, string>()
        {
            ['A'] = "░",
            ['B'] = "▓",
            ['C'] = "▤",
            ['D'] = "▙",
            ['E'] = "▞",
            ['F'] = "▰",
            ['G'] = "▫",
            ['H'] = "◰",
            ['I'] = "▯",
            ['J'] = "∷",
            ['K'] = "▪",
            ['L'] = "◼",
            ['M'] = "⬒",
            ['N'] = "▛",
            ['O'] = "⬤",
            ['P'] = "◍",
            ['Q'] = "◉",
            ['R'] = "◒",
            ['S'] = "⧫",
            ['T'] = "▦",
            ['U'] = "▨",
            ['V'] = "◪",
            ['W'] = "◹",
            ['X'] = "◿",
            ['Y'] = "◖",
            ['Z'] = "◢",
            ['0'] = "⬓",
            ['1'] = "◈",
            ['2'] = "⬖",
            ['3'] = "◲",
            ['4'] = "◳",
            ['5'] = "⬘",
            ['6'] = "◔",
            ['7'] = "◭",
            ['8'] = "⬟",
            ['9'] = "⬠"
        };
        string traducirtexto(string input) 
        {
            StringBuilder resultado = new StringBuilder();
            foreach (char c in input.ToUpper()) 
            {
                if (diccionariosecreto.ContainsKey(c))
                    resultado.Append(diccionariosecreto[c]);
                else
                    resultado.Append(c);
            }
            return resultado.ToString ();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string textotemporal = textBox1.Text;
            textBox2.Text = traducirtexto(textotemporal);
        }
    }
}
