using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Act4_u4
{
    public partial class Form1 : Form
    {
        private ComboBox cmbTypeProduct;
        private Panel panelDetails;
        private Panel panelTelevision;
        private Panel panelLaptop;
        private Panel panelSmartphone;
        private TextBox txtNameTelevision;
        private TextBox txtPriceTelevision;
        private TextBox txtInchesTelevision;
        private TextBox txtNameLaptop;
        private TextBox txtPriceLaptop;
        private TextBox txtSystemOpLaptop;
        private TextBox txtRAMLaptop;
        private TextBox txtNameSmartphone;
        private TextBox txtPriceSmartphone;
        private TextBox txtSystemOpSmartphone;
        private TextBox txtCameraSmartphone;
        private ListBox lstCarrito;
        private Label lblTotal;
        private List<IElectronic> carrito;
        public Form1()
        {
            InitializeComponent();
            carrito = new List<IElectronic>();

            cmbTypeProduct = new ComboBox();
            {
                Name = "cmbTypeProduct";
                Dock = DockStyle.Top;
                cmbTypeProduct.DropDownStyle = ComboBoxStyle.DropDownList;
            }

            cmbTypeProduct.Items.AddRange(new string[] { "Television", "Laptop", "Smartphone" });
            cmbTypeProduct.SelectedIndexChanged += CmbTypeProduct_SelectedIndexChanged;
            this.Controls.Add(cmbTypeProduct);

            panelDetails = new Panel { Dock = DockStyle.Top};
            this.Controls.Add(panelDetails);

            panelTelevision = new Panel { Dock = DockStyle.Top, Visible = false };
            panelDetails.Controls.Add(panelTelevision);
            AddLabelAndTextBox(panelTelevision, "Name:", out txtNameTelevision);
            AddLabelAndTextBox(panelTelevision, "Price:", out txtPriceTelevision);
            AddLabelAndTextBox(panelTelevision, "Inches:", out txtInchesTelevision);


            panelLaptop = new Panel { Dock = DockStyle.Top, Visible = false };
            panelDetails.Controls.Add(panelLaptop);
            AddLabelAndTextBox(panelLaptop, "Name:", out txtNameLaptop);
            AddLabelAndTextBox(panelLaptop, "Price:", out txtPriceLaptop);
            AddLabelAndTextBox(panelLaptop, "System Operating:", out txtSystemOpLaptop);
            AddLabelAndTextBox(panelLaptop, "RAM:", out txtRAMLaptop);


            panelSmartphone = new Panel { Dock = DockStyle.Top, Visible = false };
            panelDetails.Controls.Add(panelSmartphone);
            AddLabelAndTextBox(panelSmartphone, "Name:", out txtNameSmartphone);
            AddLabelAndTextBox(panelSmartphone, "Price:", out txtPriceSmartphone);
            AddLabelAndTextBox(panelSmartphone, "System Operating:", out txtSystemOpSmartphone);
            AddLabelAndTextBox(panelSmartphone, "Camera:", out txtCameraSmartphone);


            Button BtnAddProduct = new Button { Text = "Add Product", Dock = DockStyle.Top };
            BtnAddProduct.Click += BtnAddProduct_Click;
            this.Controls.Add(BtnAddProduct);

            lstCarrito = new ListBox { Dock = DockStyle.Top };
            this.Controls.Add(lstCarrito);

            Button BtnCalculateTotal = new Button { Text = "Calculate Total", Dock = DockStyle.Top };
            BtnCalculateTotal.Click += BtnCalculateTotal_Click;
            this.Controls.Add(BtnCalculateTotal);

            lblTotal = new Label { Text = "Total: $0.00", Dock = DockStyle.Top };

            this.Controls.Add(lblTotal);

        }

        private void CmbTypeProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelTelevision.Visible = (cmbTypeProduct.SelectedIndex == 0);
            panelLaptop.Visible = (cmbTypeProduct.SelectedIndex == 1);
            panelSmartphone.Visible = (cmbTypeProduct.SelectedIndex == 2);
        }

        private void BtnAddProduct_Click(object sender, EventArgs e)
        {
            IElectronic product = null;
            switch (cmbTypeProduct.SelectedIndex)
            {
                case 0: //Television
                    product = new Television(
                        txtNameTelevision.Text,
                        double.Parse(txtPriceTelevision.Text),
                        int.Parse(txtInchesTelevision.Text));
                    break;

                case 1: //laptop

                    product = new Laptop(
                        txtNameLaptop.Text,
                        double.Parse(txtPriceLaptop.Text),
                        txtSystemOpLaptop.Text,
                        int.Parse(txtRAMLaptop.Text));
                    break;

                case 2: //Smartphone
                    product = new Smartphone(
                        txtNameSmartphone.Text,
                        double.Parse(txtPriceSmartphone.Text),
                        txtSystemOpSmartphone.Text,
                        int.Parse(txtCameraSmartphone.Text));
                    break;

            }

            if (product != null)
            {
                carrito.Add(product);
                lstCarrito.Items.Add(product.Name);
            }
        }

        private void BtnCalculateTotal_Click(object sender, EventArgs e)
        {
            double total = 0;

            foreach (var item in carrito)
            {
                total += item.Price;
            }

            lblTotal.Text = "Total: $" + total.ToString("F2");
        }

        private void AddLabelAndTextBox(Panel panel, string labelText, out TextBox textBox)
        {
            Label label = new Label { Text = labelText, Dock = DockStyle.Top };
            textBox = new TextBox { Dock = DockStyle.Top };
            panel.Controls.Add(textBox);
            panel.Controls.Add(label);
        }
    }
}