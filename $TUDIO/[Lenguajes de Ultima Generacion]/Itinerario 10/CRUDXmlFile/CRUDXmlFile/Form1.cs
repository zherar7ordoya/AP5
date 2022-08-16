using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CRUDXmlFile
{
    public partial class Form1 : Form
    {
        private XDocument xmldoc;
        private string URL_XML_FILE = "data_employees.xml";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDataEmployees();
        }

        public void LoadDataEmployees()
        {
            xmldoc = XDocument.Load(URL_XML_FILE);
            var data = xmldoc.Descendants("Employee").Select(p => new
            {
                Id = p.Element("id").Value,
                FullName = p.Element("fullname").Value,
                Salary = p.Element("salary").Value,
                Email = p.Element("email").Value,
                Address = p.Element("address").Value
            }).OrderBy(p => p.Id).ToList();
           

            txt_id.DataBindings.Clear();
            txt_fullname.DataBindings.Clear();
            txt_salary.DataBindings.Clear();
            txt_email.DataBindings.Clear();
            txt_address.DataBindings.Clear();

            txt_id.DataBindings.Add("text", data, "id");
            txt_fullname.DataBindings.Add("text", data, "fullname");
            txt_salary.DataBindings.Add("text", data, "salary");
            txt_email.DataBindings.Add("text", data, "email");
            txt_address.DataBindings.Add("text", data, "address");
            dataGridView1.DataSource = data;

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            foreach (var item in group_info.Controls)
            {
                if(item is TextBox)
                {
                    (item as TextBox).Clear();
                }
            }
            txt_id.Focus();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            XElement emp = new XElement("Employee",
                new XElement("id", txt_id.Text),
                new XElement("fullname", txt_fullname.Text),
                new XElement("salary", txt_salary.Text),
                new XElement("email", txt_email.Text),
                new XElement("address", txt_address.Text));
            xmldoc.Root.Add(emp);
            xmldoc.Save(URL_XML_FILE);
            LoadDataEmployees();
            btn_add_Click(null, null);
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            XElement emp = xmldoc.Descendants("Employee").FirstOrDefault(p => p.Element("id").Value == txt_id.Text);
            if (emp != null)
            {
                emp.Element("fullname").Value = txt_fullname.Text;
                emp.Element("salary").Value = txt_salary.Text;
                emp.Element("email").Value = txt_email.Text;
                emp.Element("address").Value = txt_address.Text;          
                xmldoc.Save(URL_XML_FILE);
                LoadDataEmployees();
                btn_add_Click(null, null);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            XElement emp = xmldoc.Descendants("Employee").FirstOrDefault(p => p.Element("id").Value == txt_id.Text);
            if (emp != null)
            {
                emp.Remove();
                xmldoc.Save(URL_XML_FILE);
                LoadDataEmployees();
                btn_add_Click(null, null);
            }
        }
    }
}
