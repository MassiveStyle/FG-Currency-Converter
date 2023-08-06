using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Resources.ResXFileRef;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Fantasy_Grounds_Currency_Converter
{
    public partial class Form1 : Form
    {
        bool firstClickPp = true;
        bool firstClickGp = true;
        bool firstClickSp = true;
        bool firstClickCp = true;

        public Form1()
        {
            InitializeComponent();


        }

        private void button1_Click(object sender, EventArgs e)
        {

            Conversion();
            CleanUp();
        }

        void Conversion()
        {
            if (!cpInput.Text.All(char.IsNumber) ||
                !spInput.Text.All(char.IsNumber) ||
                !gpInput.Text.All(char.IsNumber) ||
                !ppInput.Text.All(char.IsNumber))
            {
                MessageBox.Show("Please input only Numbers");
                cpInput.Text = "0";
                spInput.Text = "0";
                gpInput.Text = "0";
                ppInput.Text = "0";
            }

            if (string.IsNullOrEmpty(cpInput.Text))
            {
                cpInput.Text = "0";
            }
            if (string.IsNullOrEmpty(spInput.Text))
            {
                spInput.Text = "0";
            }
            if (string.IsNullOrEmpty(gpInput.Text))
            {
                gpInput.Text = "0";
            }
            if (string.IsNullOrEmpty(ppInput.Text))
            {
                ppInput.Text = "0";
            }


            int platinInput = Convert.ToInt32(ppInput.Text);
            int goldInput = Convert.ToInt32(gpInput.Text);
            int silverInput = Convert.ToInt32(spInput.Text);
            int copperInput = Convert.ToInt32(cpInput.Text);
            int platinOutput = Convert.ToInt32(ppOutput.Text);
            int goldOutput = Convert.ToInt32(gpOutput.Text);
            int silverOutput = Convert.ToInt32(spOutput.Text);
            int copperOutput = Convert.ToInt32(cpOutput.Text);
            int converter = 100;


            switch (copperInput >= 100)
            {
                case true:
                    {
                        cpOutput.Text = Convert.ToString(copperInput % converter);
                        spOutput.Text = Convert.ToString(copperInput / converter);
                        break;
                    }
                case false:
                    {
                        cpOutput.Text = Convert.ToString(copperInput);
                    }
                    break;
            }

            switch (silverInput >= 100)
            {
                case true:
                    {
                        spOutput.Text = Convert.ToString((silverInput % converter) + (copperInput / converter));
                        gpOutput.Text = Convert.ToString(silverInput / converter);
                    }
                    break;
                case false:
                    {
                        spOutput.Text = Convert.ToString(silverInput + copperInput / converter);
                    }
                    break;

            }

            switch (goldInput >= 100)
            {
                case true:
                    {
                        gpOutput.Text = Convert.ToString((goldInput % converter) + (silverInput / converter));
                        ppOutput.Text = Convert.ToString(goldInput / converter);
                    }
                    break;
                case false:
                    {
                        gpOutput.Text = Convert.ToString(goldInput + silverInput / converter);
                    }
                    break;
            }

            switch (platinInput > 0)
            {
                case true:
                    {
                        ppOutput.Text = Convert.ToString(platinInput + goldInput / converter);
                    }
                    break;
                    case false:
                    {
                        ppOutput.Text = Convert.ToString(platinInput + goldInput / converter);
                    }
                    break;
            }
            FinalConversion();
        }



        void FinalConversion()
        {
            int platinInput = Convert.ToInt32(ppInput.Text);
            int goldInput = Convert.ToInt32(gpInput.Text);
            int silverInput = Convert.ToInt32(spInput.Text);
            int copperInput = Convert.ToInt32(cpInput.Text);

            int platinOutput = Convert.ToInt32(ppOutput.Text);
            int goldOutput = Convert.ToInt32(gpOutput.Text);
            int silverOutput = Convert.ToInt32(spOutput.Text);
            int copperOutput = Convert.ToInt32(cpOutput.Text);

            int converter = 100;

            switch (silverOutput >= 100)
            {
                case true:
                    {
                        spOutput.Text = Convert.ToString(silverOutput % converter);
                        gpOutput.Text = Convert.ToString(silverOutput / converter);
                    }
                    break;
                case false:
                    {
                        spOutput.Text = Convert.ToString(silverOutput);
                    }
                    break;
            }

            switch (goldOutput >= 100)
            {
                case true:
                    {
                        gpOutput.Text = Convert.ToString(goldOutput % converter);
                        ppOutput.Text = Convert.ToString(goldOutput / converter);
                    }
                    break;
                case false:
                    {
                        gpOutput.Text = Convert.ToString(goldOutput);
                    }
                    break;
            }
        }

        private void CleanUp()
        {
            ppInput.Text = "0";
            gpInput.Text = "0";
            spInput.Text = "0";
            cpInput.Text = "0";
            firstClickCp = true;
            firstClickSp = true;
            firstClickGp = true;
            firstClickPp = true;
        }

        private void ppInput_Click(object sender, EventArgs e)
        {
            if (firstClickPp)
            {
                ppInput.Text = string.Empty;
                firstClickPp = false;
            }

        }
        private void gpInput_Click(object sender, EventArgs e)
        {
            if (firstClickGp)
            {
                gpInput.Text = string.Empty;
                firstClickGp = false;
            }

        }
        private void spInput_Click(object sender, EventArgs e)
        {
            if (firstClickSp)
            {
                spInput.Text = string.Empty;
                firstClickSp = false;
            }

        }
        private void cpInput_Click(object sender, EventArgs e)
        {
            if (firstClickCp)
            {
                cpInput.Text = string.Empty;
                firstClickCp = false;
            }

        }

    }
}

