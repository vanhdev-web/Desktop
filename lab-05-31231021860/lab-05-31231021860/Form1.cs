using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lab_05_31231021860.Modules;

namespace lab_05_31231021860
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Load_Tree(params Department[] departments)
        {
            foreach (var department in departments)
            {
                TreeNode treeNode = new TreeNode(department.Name);
                treeNode.Tag = department;
                treeView1.Nodes.Add(treeNode);
                treeNode.Nodes.Add(new TreeNode("sdfsad"));
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Student s1 = new Student(1, "sinhvien1", "email1");
            Student s2 = new Student(2, "sinhvien2", "email2");
            Student s3 = new Student(3, "sinhvien3", "email3");
            Student s4 = new Student(4, "sinhvien4", "email4");
            Student s5 = new Student(5, "sinhvien5", "email5");
            Student s6 = new Student(6, "sinhvien6", "email6");
            Student s7 = new Student(7, "sinhvien7", "email7");
            Student s8 = new Student(8, "sinhvien8", "email8");
            Student s9 = new Student(9, "sinhvien9", "email9");
            Student s10 = new Student(10, "sinhvien10", "email10");


            Classs cl1 = new Classs("class1", new Student[] {s1,s2,s3});
            Classs cl2 = new Classs("class2", new Student[] { s4, s5, s3 });
            Classs cl3 = new Classs("class3", new Student[] { s6, s7, s8 });
            Classs cl4 = new Classs("class4", new Student[] { s8, s9, s10 });


            Department dp1 = new Department("Khoa 1", new Classs[] {cl1, cl2});
            Department dp2 = new Department("Khoa 2", new Classs[] {cl3,cl4});

            Load_Tree(dp1, dp2);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            TreeNode treeNode = e.Node as TreeNode;
            treeNode.Nodes.Clear();
            var type = treeNode.Tag;
          

            if (type is Department deparment)
            {
                Classs[] classes = deparment.classes;
                foreach ( Classs c in classes )
                {
                    TreeNode nodeChild = new TreeNode(c.Name);
                    treeNode.Nodes.Add(nodeChild);
                    nodeChild.Tag = c;
                    nodeChild.Nodes.Add(new TreeNode("sagasdf"));

            }
            }
            else if (type is Classs classs)
            {
                Student[] students = classs.students;
                foreach (Student c in students)
                {
                    TreeNode nodeChild = new TreeNode(c.Name);
                    treeNode.Nodes.Add(nodeChild);
                    nodeChild.Tag = c;


                }
            }


        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode treeNode = e.Node as TreeNode;
            var a = treeNode.Tag;

            if (a is Department deparment)
            {
                listView1.View = View.List;
                Classs[] classess = deparment.classes;
                listView1.Columns.Clear(); // Xóa các cột cũ (nếu có)
                listView1.Items.Clear();   // Xóa các item cũ (nếu có)
                for (int i = 0; i < classess.Length; i++)
                {
                    ListViewItem listViewItem = new ListViewItem(classess[i].Name);
                    listView1.Items.Add(listViewItem);
                }
            }
            else if (a is Classs classs)
            {
                listView1.View = View.Details;
                listView1.Columns.Clear(); // Xóa các cột cũ (nếu có)
                listView1.Items.Clear();   // Xóa các item cũ (nếu có)
                Student[] students = classs.students;
                ColumnHeader cl1 = new ColumnHeader();
                cl1.Text = "ID";
                ColumnHeader cl2 = new ColumnHeader();
                cl2.Text = "Name";
                ColumnHeader cl3 = new ColumnHeader();
                cl3.Text = "Email";

                listView1.Columns.AddRange(new ColumnHeader[] { cl1, cl2, cl3 });
                foreach (var student in students)
                {
                    ListViewItem listViewItem = new ListViewItem(student.Id.ToString());
                    listViewItem.SubItems.Add(student.Name);
                    listViewItem.SubItems.Add(student.Email);
                    listView1.Items.Add(listViewItem);
                    listView1.FullRowSelect = true;
                }
            }

            
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                ListViewItem item = e.Item;
                label1.Text = item.SubItems[0].Text;
                label2.Text = item.SubItems[1].Text;
            }
        }
    }
}
