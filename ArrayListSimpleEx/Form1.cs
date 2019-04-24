using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace ArrayListSimpleEx
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private ArrayList sentence = new ArrayList();

        bool reverseOrder;

        private void Form1_Load(object sender, EventArgs e)
        {
            //Add the 5 items using a string array
            sentence.AddRange(new string[] { "I ", "Love", "Progamming", "So", "Much" });
        }

        private void WriteSentence()
        {
            foreach (string word in sentence)
            {
                lblMessage.Text += word + " ";
            }
        }

        private void btnShowMsg_Click(object sender, EventArgs e)
        {
            reverseOrder = false;

            lblMessage.ResetText();

            WriteSentence();

        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            try
            {
                reverseOrder = true;

                lblMessage.ResetText();

                //Reverses the order of the elements in the ArrayList
                sentence.Reverse();

                WriteSentence();

                //Put the elements back to the initial order by reversing again
                sentence.Reverse();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtSecondPos.Text != string.Empty)
                {
                    sentence.Insert(1, txtSecondPos.Text);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (sentence.Count > 5)
                {
                    if (reverseOrder)
                    {
                        MessageBox.Show("The elements must be in order.");
                    }

                    else
                    {
                        bool valdation = MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes;

                        if (valdation)
                        {
                            sentence.RemoveAt(1);
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }
    }
}
