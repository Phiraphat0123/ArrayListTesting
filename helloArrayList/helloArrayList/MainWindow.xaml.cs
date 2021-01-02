using System;
using System.Collections;
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

namespace helloArrayList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ArrayList al;
        public MainWindow()
        {
            InitializeComponent();
            al = new ArrayList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (input.Text == "")
            {
                MessageBox.Show("คุณแน่ใจใช่ไหมที่จะใส่ข้อมูลเปล่า");
            }
            else
            {
                al.Add(int.Parse(input.Text));
                MessageBox.Show("รับข้อเรัยบร้อย ");
                count.Text = "Count : " + al.Count;
                input.Text = "";
            }
        }

        private void remove_Click(object sender, RoutedEventArgs e)
        {
            if (al.Count == 0)
            {
                MessageBox.Show("ไม่สามารถลบได้เนื่องจาก Array List มีค่าเป็น 0");
            }
            else { al.Remove(int.Parse(input.Text));
            count.Text = "Count : " + al.Count;
             input.Text = "";
            }
            
        }

        private void show_Click(object sender, RoutedEventArgs e)
        {   al.Sort();
            if (al.Count == 0)
            {
                MessageBox.Show("ไม่มีข้อมูล");
            }
            else
            {
                foreach (int data in al)
                {
                    MessageBox.Show(data.ToString());
                }
            }

            
            
            
        }

        
    }
}
