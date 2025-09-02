using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace SHIPINGCABINETRY
{
    public partial class Form1 : Form
    {
        private IWebDriver driver;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnabrir_Click(object sender, EventArgs e)
        {
            try
            {
                ChromeOptions options = new ChromeOptions();
                options.AddArgument("--start-maximized");

                // Crear servicio ocultando la consola
                var service = ChromeDriverService.CreateDefaultService();
                service.HideCommandPromptWindow = true;

                // 👇 Aquí usamos la variable global, no una local
                driver = new ChromeDriver(service, options);
                driver.Navigate().GoToUrl("https://cabinetrystock.com/");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir ChromeDriver: " + ex.Message);
            }
        }

        private void btnltlfrieght_Click(object sender, EventArgs e)
        {
            try
            {
                // Buscar todos los select que tengan name empezando con "variable_shipping_class"
                var selects = driver.FindElements(By.CssSelector("select[name^='variable_shipping_class']"));

                foreach (var select in selects)
                {
                    var selectElement = new SelectElement(select);
                    // Seleccionar la opción con value=1312
                    selectElement.SelectByValue("1312");
                }

                MessageBox.Show("Se seleccionó 'LTL Freight' en todos los selects.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar opciones: " + ex.Message);
            }
        }
    }
}
