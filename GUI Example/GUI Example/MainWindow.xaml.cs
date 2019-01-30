using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Media;

namespace GUI_Example
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        SoundPlayer evoTurbo = new SoundPlayer(Properties.Resources.evosound);
        private void login_Click(object sender, RoutedEventArgs e)
        {
            if (textbox1.Text == "MisterTams" && textbox2.Password == "evo9gsr")
            {
                Window1 window1 = new Window1();
                evoTurbo.Load();
                this.Hide();
                window1.Show();
                evoTurbo.Play();

            }
            else
            {
                SystemSounds.Beep.Play();
                MessageBox.Show("Invalid Login");
                textbox2.Password = "";
            }
        }

        private void Diamond_Star_Racing_Log_In_Closed(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill(); //kills any background process if the .exe gets closed 
            //but keeps running in the background
        }
    }
}
