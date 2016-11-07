using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyLibrary;

namespace MyTestListProject
{
    public partial class TestListProject : Form
    {
        int temp = 0;
        string strTemp = "";
        MyLinkedList<int> myList;

        public TestListProject()
        {
            InitializeComponent();
            myList = new MyLinkedList<int>();

        }
        

        private void InTextBox_Click(object sender, EventArgs e)
        {
            
        }

        private void WriteListButton_Click(object sender, EventArgs e)
        {
            this.WriteList();
        }

        private void WriteList()
        {
            OutTextBox.Clear();
            InTextBox.Clear();

            var node = myList.First;
            while (node != null)
            {
                OutTextBox.Text += node.Value.ToString() + " ";

                node = node.Next;
            }

            //foreach (int value in myList)
            //{
            //    OutTextBox.Text += value.ToString() + " ";
            //}
        }

        private void AddStartButton_Click(object sender, EventArgs e)
        {
            strTemp = InTextBox.Text;
            InTextBox.Clear();
            temp = int.Parse(strTemp);
            myList.AddFirst(temp);

            this.WriteList();
        }

        private void AddEndButton_Click(object sender, EventArgs e)
        {

            strTemp = InTextBox.Text;
            temp = int.Parse(strTemp);
            myList.AddLast(temp);
            OutTextBox.Text += strTemp + " ";
            InTextBox.Clear();
        }
        
        private void AddAfterIndexButton_Click(object sender, EventArgs e)
        {
              
            if (myList.Count == 0)
                throw new IndexOutOfRangeException();
            strTemp = InTextBox.Text;
            InTextBox.Clear();
            temp = int.Parse(strTemp);
            myList.AddAfter(myList.First,temp);
            this.WriteList();
        }

        private void DeleteValueButton_Click(object sender, EventArgs e)
        {
            strTemp = InTextBox.Text;
            InTextBox.Clear();
            temp = int.Parse(strTemp);
            myList.Remove(temp);
            this.WriteList();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
           
            myList.Clear();
            this.WriteList();
        }
    }
}
