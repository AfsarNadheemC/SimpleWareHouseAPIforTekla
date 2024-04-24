using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TSM = Tekla.Structures.Model;
using TSG = Tekla.Structures.Geometry3d;
using Tekla.Structures.Model;

namespace WareHouse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TSM.Model model = new TSM.Model();
            if (model.GetConnectionStatus())
            {
                int length = Convert.ToInt32(textBox3.Text);
                int width = Convert.ToInt32(textBox4.Text);
                int height = Convert.ToInt32(textBox1.Text);

                int lengthPart = length / 3000;
                
                double lengthBalance = (length % 3000)/lengthPart;

                double lengthGap = 3000+lengthBalance;

                for (double i = 0; i <= lengthPart; i ++ )
                {
                    TSG.Point point = new TSG.Point(0,i*lengthGap,0);
                    TSG.Point point1 = new TSG.Point(0,i*lengthGap,height);

                    TSM.Beam beam = new TSM.Beam(point,point1);

                    beam.Material.MaterialString = "IS2062";
                    beam.Profile.ProfileString = "ISMB400";
                    beam.Class = "7";
                  

                    beam.Insert();
                    model.CommitChanges();

                    TSG.Point point2 = new TSG.Point(width, i * lengthGap, 0);
                    TSG.Point point3 = new TSG.Point(width, i * lengthGap, height);

                    TSM.Beam beam1 = new TSM.Beam(point2, point3);

                    beam1.Material.MaterialString = "IS2062";
                    beam1.Profile.ProfileString = "ISMB400";
                    beam1.Class = "7";
                    

                    beam1.Insert();
                    model.CommitChanges();

                    TSG.Point point4 = new TSG.Point(0, i * lengthGap, height);
                    TSG.Point point5 = new TSG.Point(width/2, i * lengthGap, height+(height/4));

                    TSM.Beam beam2 = new TSM.Beam(point4, point5);

                    beam2.Material.MaterialString = "IS2062";
                    beam2.Profile.ProfileString = "ISMB400";
                    beam2.Class = "6";

                    beam2.Insert();
                    model.CommitChanges();

                    TSG.Point point6 = new TSG.Point(width/2, i * lengthGap, height + (height / 4));
                    TSG.Point point7 = new TSG.Point(width, i * lengthGap, height);

                    TSM.Beam beam3 = new TSM.Beam(point6, point7);

                    beam3.Material.MaterialString = "IS2062";
                    beam3.Profile.ProfileString = "ISMB400";
                    beam3.Class = "6";

                    beam3.Insert();
                    model.CommitChanges();
                    
                }

                TSG.Point point8 = new TSG.Point(width/2,0, height + (height / 4));
                TSG.Point point9 = new TSG.Point(width / 2, length, height + (height / 4));

                TSM.Beam beam4 = new TSM.Beam(point8,point9);

                beam4.Material.MaterialString = "IS2062";
                beam4.Profile.ProfileString = "ISMB400";
                beam4.Class = "5";

                beam4.Insert();
                model.CommitChanges();

                TSG.Point point10 = new TSG.Point(0, 0, height );
                TSG.Point point11 = new TSG.Point(0, length, height );

                TSM.Beam beam5 = new TSM.Beam(point10, point11);

                beam5.Material.MaterialString = "IS2062";
                beam5.Profile.ProfileString = "ISMB400";
                beam5.Class = "5";

                beam5.Insert();
                model.CommitChanges();

                TSG.Point point12 = new TSG.Point(width , 0, height);
                TSG.Point point13 = new TSG.Point(width , length, height);

                TSM.Beam beam6 = new TSM.Beam(point12, point13);

                beam6.Material.MaterialString = "IS2062";
                beam6.Profile.ProfileString = "ISMB400";
                beam6.Class = "5";

                beam6.Insert();
                model.CommitChanges();

                TSG.Point point14 = new TSG.Point(0, 0, height);
                TSG.Point point15 = new TSG.Point(width, 0, height);

                TSM.Beam beam7 = new TSM.Beam(point14, point15);

                beam7.Material.MaterialString = "IS2062";
                beam7.Profile.ProfileString = "ISMB400";
                beam7.Class = "6";

                beam7.Insert();
                model.CommitChanges();

                TSG.Point point16 = new TSG.Point(0, length, height);
                TSG.Point point17 = new TSG.Point(width, length, height);

                TSM.Beam beam8 = new TSM.Beam(point12, point13);

                beam8.Material.MaterialString = "IS2062";
                beam8.Profile.ProfileString = "ISMB400";
                beam8.Class = "6";

                beam8.Insert();
                model.CommitChanges();


            }
        }
    }
}
