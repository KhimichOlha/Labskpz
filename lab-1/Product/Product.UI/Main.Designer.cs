namespace Product.UI
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tcProduct = new TabControl();
            tabPage1 = new TabPage();
            btAddProduct = new Button();
            dtDate = new DateTimePicker();
            lbDate = new Label();
            tbunitOfMeasurement = new TextBox();
            lbunitOfMeasurement = new Label();
            tbPriceProduct = new TextBox();
            lbPriceProduct = new Label();
            tbNameProduct = new TextBox();
            lbNameProduct = new Label();
            tabPage2 = new TabPage();
            btBuy = new Button();
            lvProducts = new ListView();
            tabPage3 = new TabPage();
            lbSumReport = new Label();
            tabPage4 = new TabPage();
            lbRegisterIncoming = new Label();
            tabPage5 = new TabPage();
            lbOutReport = new Label();
            tcProduct.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            tabPage5.SuspendLayout();
            SuspendLayout();
            // 
            // tcProduct
            // 
            tcProduct.Controls.Add(tabPage1);
            tcProduct.Controls.Add(tabPage2);
            tcProduct.Controls.Add(tabPage3);
            tcProduct.Controls.Add(tabPage4);
            tcProduct.Controls.Add(tabPage5);
            tcProduct.Dock = DockStyle.Fill;
            tcProduct.Location = new Point(0, 0);
            tcProduct.Name = "tcProduct";
            tcProduct.SelectedIndex = 0;
            tcProduct.Size = new Size(840, 511);
            tcProduct.TabIndex = 0;
            tcProduct.Click += tcProduct_Click;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btAddProduct);
            tabPage1.Controls.Add(dtDate);
            tabPage1.Controls.Add(lbDate);
            tabPage1.Controls.Add(tbunitOfMeasurement);
            tabPage1.Controls.Add(lbunitOfMeasurement);
            tabPage1.Controls.Add(tbPriceProduct);
            tabPage1.Controls.Add(lbPriceProduct);
            tabPage1.Controls.Add(tbNameProduct);
            tabPage1.Controls.Add(lbNameProduct);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(832, 478);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Add product";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btAddProduct
            // 
            btAddProduct.Location = new Point(31, 392);
            btAddProduct.Margin = new Padding(3, 4, 3, 4);
            btAddProduct.Name = "btAddProduct";
            btAddProduct.Size = new Size(86, 31);
            btAddProduct.TabIndex = 10;
            btAddProduct.Text = "Додати";
            btAddProduct.UseVisualStyleBackColor = true;
            btAddProduct.Click += btAddProduct_Click;
            // 
            // dtDate
            // 
            dtDate.Location = new Point(26, 311);
            dtDate.Name = "dtDate";
            dtDate.Size = new Size(250, 27);
            dtDate.TabIndex = 9;
            // 
            // lbDate
            // 
            lbDate.AutoSize = true;
            lbDate.Location = new Point(26, 269);
            lbDate.Name = "lbDate";
            lbDate.Size = new Size(108, 20);
            lbDate.TabIndex = 8;
            lbDate.Text = "Дата поставки";
            // 
            // tbunitOfMeasurement
            // 
            tbunitOfMeasurement.Location = new Point(26, 213);
            tbunitOfMeasurement.Name = "tbunitOfMeasurement";
            tbunitOfMeasurement.Size = new Size(125, 27);
            tbunitOfMeasurement.TabIndex = 5;
            // 
            // lbunitOfMeasurement
            // 
            lbunitOfMeasurement.AutoSize = true;
            lbunitOfMeasurement.Location = new Point(26, 191);
            lbunitOfMeasurement.Name = "lbunitOfMeasurement";
            lbunitOfMeasurement.Size = new Size(124, 20);
            lbunitOfMeasurement.TabIndex = 4;
            lbunitOfMeasurement.Text = "Одиниця виміру";
            // 
            // tbPriceProduct
            // 
            tbPriceProduct.Location = new Point(26, 141);
            tbPriceProduct.Name = "tbPriceProduct";
            tbPriceProduct.Size = new Size(125, 27);
            tbPriceProduct.TabIndex = 3;
            // 
            // lbPriceProduct
            // 
            lbPriceProduct.AutoSize = true;
            lbPriceProduct.Location = new Point(26, 103);
            lbPriceProduct.Name = "lbPriceProduct";
            lbPriceProduct.Size = new Size(41, 20);
            lbPriceProduct.TabIndex = 2;
            lbPriceProduct.Text = "Ціна";
            // 
            // tbNameProduct
            // 
            tbNameProduct.Location = new Point(26, 53);
            tbNameProduct.Name = "tbNameProduct";
            tbNameProduct.Size = new Size(125, 27);
            tbNameProduct.TabIndex = 1;
            // 
            // lbNameProduct
            // 
            lbNameProduct.AutoSize = true;
            lbNameProduct.Location = new Point(26, 21);
            lbNameProduct.Name = "lbNameProduct";
            lbNameProduct.Size = new Size(106, 20);
            lbNameProduct.TabIndex = 0;
            lbNameProduct.Text = "Назва товару ";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btBuy);
            tabPage2.Controls.Add(lvProducts);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(832, 478);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Basket";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btBuy
            // 
            btBuy.Location = new Point(726, 416);
            btBuy.Margin = new Padding(3, 4, 3, 4);
            btBuy.Name = "btBuy";
            btBuy.Size = new Size(86, 31);
            btBuy.TabIndex = 1;
            btBuy.Text = "Купити";
            btBuy.UseVisualStyleBackColor = true;
            btBuy.Click += btBuy_Click;
            // 
            // lvProducts
            // 
            lvProducts.Location = new Point(5, 4);
            lvProducts.Margin = new Padding(3, 4, 3, 4);
            lvProducts.Name = "lvProducts";
            lvProducts.Size = new Size(822, 345);
            lvProducts.TabIndex = 0;
            lvProducts.UseCompatibleStateImageBehavior = false;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(lbSumReport);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(832, 478);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Залишки на складі";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // lbSumReport
            // 
            lbSumReport.AutoSize = true;
            lbSumReport.Location = new Point(3, 1);
            lbSumReport.Name = "lbSumReport";
            lbSumReport.Size = new Size(0, 20);
            lbSumReport.TabIndex = 0;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(lbRegisterIncoming);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(832, 478);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Пробуткова накладна";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // lbRegisterIncoming
            // 
            lbRegisterIncoming.AutoSize = true;
            lbRegisterIncoming.Location = new Point(2, 1);
            lbRegisterIncoming.Name = "lbRegisterIncoming";
            lbRegisterIncoming.Size = new Size(0, 20);
            lbRegisterIncoming.TabIndex = 0;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(lbOutReport);
            tabPage5.Location = new Point(4, 29);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(832, 478);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Видаткова накладна";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // lbOutReport
            // 
            lbOutReport.AutoSize = true;
            lbOutReport.Location = new Point(1, 8);
            lbOutReport.Name = "lbOutReport";
            lbOutReport.Size = new Size(50, 20);
            lbOutReport.TabIndex = 0;
            lbOutReport.Text = "label1";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(840, 511);
            Controls.Add(tcProduct);
            Name = "MainForm";
            Text = "Main";
            tcProduct.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tcProduct;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox tbunitOfMeasurement;
        private Label lbunitOfMeasurement;
        private TextBox tbPriceProduct;
        private Label lbPriceProduct;
        private TextBox tbNameProduct;
        private Label lbNameProduct;
        private Label lbDate;
        private DateTimePicker dtDate;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private Label lbRegisterIncoming;
        private Label lbSumReport;
        private Label lbOutReport;
        private Button btAddProduct;
        private Button btBuy;
        private ListView lvProducts;
    }
}
