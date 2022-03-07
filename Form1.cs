using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFcruzlara
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label2.Text = @"Seleccione la parte de la computadora
de la cual desea obtener información
";
        }

        private void firmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("WFcruzlara_signature.exe");
        }

        private void procesador_Click(object sender, EventArgs e)
        {
            label2.Text = "El procesador o CPU (Computer Processing Unit) \nes la unidad que se encarga de procesar la información que vemos en la pantalla.\nEste microprocesador se encarga de la mayoría de los cálculos que realiza el equipo\npara que nosotros podamos utilizarlo como lo hacemos.";
            webBrowser1.Navigate("https://www.youtube.com/v/ziMuHUTdDYE");
        }

        private void mother_Click(object sender, EventArgs e)
        {
            label2.Text = "También conocida como motherboard, se encarga de administrar las conexiones\nentre los distintos componentes del equipo y de transmitir la corriente eléctrica,\nque recibe de la fuente de alimentación, a los demás componentes.\nTambién incluen todos los puertos necesarios para conectar los periféricos al equipo.\nDesde puertos USB hasta conexiones de sonido, red y salida de vídeo.";
            webBrowser1.Navigate("https://www.youtube.com/v/gPgUu87xYaU");
        }

        private void ram_Click(object sender, EventArgs e)
        {
            label2.Text = "Random Access Memory, o ‘Memoria de Acceso Aleatorio’.\nEse es el nombre de las memorias RAM, uno de los componentes que se encarga \nde manejar la información de la computadora.\nEstas memorias son las que reciben y transmiten toda la información \ndel software (sistema operativo y programas). \nEn ellas se cargan todas las instrucciones que ejecuta la CPU y otros componentes del equipo, \nasí como también contiene los datos de los programas que se están ejecutando.";
            webBrowser1.Navigate("https://www.youtube.com/v/5nznFIrN_4U");
        }

        private void storage_Click(object sender, EventArgs e)
        {
            label2.Text = "Estos discos tienen la tarea de almacenar la información.\nA través del sistema operativo de la computadora se puede escribir\no leer dicha información que hay en el disco duro.";
            webBrowser1.Navigate("https://www.youtube.com/v/fTRxLMJn_Jg");
        }

        private void power_Click(object sender, EventArgs e)
        {
            label2.Text = "La fuente de alimentación se encarga de nutrir al equipo con corriente eléctrica.\nSin fuente de alimentación no funcionará nada.";
            webBrowser1.Navigate("https://www.youtube.com/v/kKcsP4665TE");
        }

        private void gpu_Click(object sender, EventArgs e)
        {
            label2.Text = @"Una tarjeta gráfica es una ‘placa’ que se puede añadir al ordenador 
para mejorar su rendimiento. Esta cuenta con un procesador de gráficos 
llamado GPU que se encarga de procesar únicamente la información 
que se va a utilizar para mostrar gráficos en el monitor de la computadora. 
En ocasiones esta tarjeta no es estrictamente necesaria 
ya que muchas placas madre incluyen una unidad de procesamiento gráfico.";
            webBrowser1.Navigate("https://www.youtube.com/v/lSTKcpz6Ioo");
        }

        private void lector_Click(object sender, EventArgs e)
        {
            label2.Text = @"Básicamente, un ‘lector’ es un componente del equipo 
que se encarga de leer algún tipo de unidad 
(en el caso del lector de CD/DVD leen esta clase de discos) 
para poder acceder a su información o grabar en ellos 
en el caso de que cuente con dicha característica.";
            webBrowser1.Navigate("https://www.youtube.com/v/5cW2FqPCSuo");
        }

        private void externHardware_Click(object sender, EventArgs e)
        {
            label2.Text = @"Además del hardware interno de las computadoras también nos encontramos 
con otros componentes que podemos reconocer fácilmente. Se trata de los periféricos.
Un periférico es todo componente que se conecta a la computadora de forma externa. 
Es decir, se trata del monitor en el que ves la imagen de tu PC, 
el ratón que utilizas para controlar el puntero y el teclado que te permite escribir. 
La impresora es también un periférico, y así sucesivamente.";
            webBrowser1.Navigate("https://www.youtube.com/v/dap5lEuS5uM");
        }
    }
}
