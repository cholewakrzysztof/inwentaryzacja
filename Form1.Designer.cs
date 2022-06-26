
namespace CRUD
{
    partial class Form1
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
            this.groupBox_sale = new System.Windows.Forms.GroupBox();
            this.button_sale_edit = new System.Windows.Forms.Button();
            this.button_sale_del = new System.Windows.Forms.Button();
            this.button_sale_add = new System.Windows.Forms.Button();
            this.groupBox_sprzet = new System.Windows.Forms.GroupBox();
            this.button_sprzet_del = new System.Windows.Forms.Button();
            this.button_sprzet_add = new System.Windows.Forms.Button();
            this.groupBox_stan = new System.Windows.Forms.GroupBox();
            this.button_stan_add = new System.Windows.Forms.Button();
            this.button_stan_del = new System.Windows.Forms.Button();
            this.listBox_stan = new System.Windows.Forms.ListBox();
            this.listBox_sprzet = new System.Windows.Forms.ListBox();
            this.listBox_sale = new System.Windows.Forms.ListBox();
            this.button_sale_show = new System.Windows.Forms.Button();
            this.button_sprzet_show = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.groupBox_sale.SuspendLayout();
            this.groupBox_sprzet.SuspendLayout();
            this.groupBox_stan.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_sale
            // 
            this.groupBox_sale.Controls.Add(this.button_sale_edit);
            this.groupBox_sale.Controls.Add(this.button_sale_del);
            this.groupBox_sale.Controls.Add(this.button_sale_add);
            this.groupBox_sale.Controls.Add(this.listBox_sale);
            this.groupBox_sale.Location = new System.Drawing.Point(12, 12);
            this.groupBox_sale.Name = "groupBox_sale";
            this.groupBox_sale.Size = new System.Drawing.Size(200, 267);
            this.groupBox_sale.TabIndex = 0;
            this.groupBox_sale.TabStop = false;
            this.groupBox_sale.Text = "groupBox sale";
            // 
            // button_sale_edit
            // 
            this.button_sale_edit.Enabled = false;
            this.button_sale_edit.Location = new System.Drawing.Point(6, 154);
            this.button_sale_edit.Name = "button_sale_edit";
            this.button_sale_edit.Size = new System.Drawing.Size(75, 23);
            this.button_sale_edit.TabIndex = 3;
            this.button_sale_edit.Text = "EDIT";
            this.button_sale_edit.UseVisualStyleBackColor = true;
            this.button_sale_edit.Click += new System.EventHandler(this.button_sale_edit_Click);
            // 
            // button_sale_del
            // 
            this.button_sale_del.Location = new System.Drawing.Point(119, 125);
            this.button_sale_del.Name = "button_sale_del";
            this.button_sale_del.Size = new System.Drawing.Size(75, 23);
            this.button_sale_del.TabIndex = 2;
            this.button_sale_del.Text = "DELETE";
            this.button_sale_del.UseVisualStyleBackColor = true;
            this.button_sale_del.Click += new System.EventHandler(this.button_sale_del_Click);
            // 
            // button_sale_add
            // 
            this.button_sale_add.Location = new System.Drawing.Point(7, 124);
            this.button_sale_add.Name = "button_sale_add";
            this.button_sale_add.Size = new System.Drawing.Size(75, 23);
            this.button_sale_add.TabIndex = 1;
            this.button_sale_add.Text = "ADD";
            this.button_sale_add.UseVisualStyleBackColor = true;
            this.button_sale_add.Click += new System.EventHandler(this.button_sale_add_Click);
            // 
            // groupBox_sprzet
            // 
            this.groupBox_sprzet.Controls.Add(this.button_sprzet_del);
            this.groupBox_sprzet.Controls.Add(this.button_sprzet_add);
            this.groupBox_sprzet.Controls.Add(this.listBox_sprzet);
            this.groupBox_sprzet.Location = new System.Drawing.Point(458, 35);
            this.groupBox_sprzet.Name = "groupBox_sprzet";
            this.groupBox_sprzet.Size = new System.Drawing.Size(200, 266);
            this.groupBox_sprzet.TabIndex = 1;
            this.groupBox_sprzet.TabStop = false;
            this.groupBox_sprzet.Text = "groupBox sprzet";
            this.groupBox_sprzet.Visible = false;
            // 
            // button_sprzet_del
            // 
            this.button_sprzet_del.Location = new System.Drawing.Point(119, 124);
            this.button_sprzet_del.Name = "button_sprzet_del";
            this.button_sprzet_del.Size = new System.Drawing.Size(75, 23);
            this.button_sprzet_del.TabIndex = 2;
            this.button_sprzet_del.Text = "DELETE";
            this.button_sprzet_del.UseVisualStyleBackColor = true;
            this.button_sprzet_del.Click += new System.EventHandler(this.button_sprzet_del_Click);
            // 
            // button_sprzet_add
            // 
            this.button_sprzet_add.Location = new System.Drawing.Point(7, 124);
            this.button_sprzet_add.Name = "button_sprzet_add";
            this.button_sprzet_add.Size = new System.Drawing.Size(75, 23);
            this.button_sprzet_add.TabIndex = 1;
            this.button_sprzet_add.Text = "ADD";
            this.button_sprzet_add.UseVisualStyleBackColor = true;
            this.button_sprzet_add.Click += new System.EventHandler(this.button_sprzet_add_Click);
            // 
            // groupBox_stan
            // 
            this.groupBox_stan.Controls.Add(this.button_stan_add);
            this.groupBox_stan.Controls.Add(this.button_stan_del);
            this.groupBox_stan.Controls.Add(this.listBox_stan);
            this.groupBox_stan.Location = new System.Drawing.Point(218, 24);
            this.groupBox_stan.Name = "groupBox_stan";
            this.groupBox_stan.Size = new System.Drawing.Size(200, 266);
            this.groupBox_stan.TabIndex = 2;
            this.groupBox_stan.TabStop = false;
            this.groupBox_stan.Text = "groupBox stan sali";
            this.groupBox_stan.Visible = false;
            // 
            // button_stan_add
            // 
            this.button_stan_add.Location = new System.Drawing.Point(7, 124);
            this.button_stan_add.Name = "button_stan_add";
            this.button_stan_add.Size = new System.Drawing.Size(89, 23);
            this.button_stan_add.TabIndex = 2;
            this.button_stan_add.Text = "ADD SPRZET";
            this.button_stan_add.UseVisualStyleBackColor = true;
            this.button_stan_add.Click += new System.EventHandler(this.button_stan_add_Click);
            // 
            // button_stan_del
            // 
            this.button_stan_del.Location = new System.Drawing.Point(119, 124);
            this.button_stan_del.Name = "button_stan_del";
            this.button_stan_del.Size = new System.Drawing.Size(75, 23);
            this.button_stan_del.TabIndex = 1;
            this.button_stan_del.Text = "DELETE";
            this.button_stan_del.UseVisualStyleBackColor = true;
            this.button_stan_del.Click += new System.EventHandler(this.button_stan_del_Click);
            // 
            // listBox_stan
            // 
            this.listBox_stan.FormattingEnabled = true;
            this.listBox_stan.ItemHeight = 15;
            this.listBox_stan.Location = new System.Drawing.Point(7, 23);
            this.listBox_stan.Name = "listBox_stan";
            this.listBox_stan.Size = new System.Drawing.Size(120, 94);
            this.listBox_stan.TabIndex = 0;
            // 
            // listBox_sprzet
            // 
            this.listBox_sprzet.FormattingEnabled = true;
            this.listBox_sprzet.ItemHeight = 15;
            this.listBox_sprzet.Location = new System.Drawing.Point(7, 23);
            this.listBox_sprzet.Name = "listBox_sprzet";
            this.listBox_sprzet.Size = new System.Drawing.Size(120, 94);
            this.listBox_sprzet.TabIndex = 0;
            // 
            // listBox_sale
            // 
            this.listBox_sale.FormattingEnabled = true;
            this.listBox_sale.ItemHeight = 15;
            this.listBox_sale.Location = new System.Drawing.Point(7, 23);
            this.listBox_sale.Name = "listBox_sale";
            this.listBox_sale.Size = new System.Drawing.Size(120, 94);
            this.listBox_sale.TabIndex = 0;
            this.listBox_sale.SelectedIndexChanged += new System.EventHandler(this.listBox_sale_SelectedIndexChanged);
            // 
            // button_sale_show
            // 
            this.button_sale_show.Location = new System.Drawing.Point(12, 299);
            this.button_sale_show.Name = "button_sale_show";
            this.button_sale_show.Size = new System.Drawing.Size(75, 23);
            this.button_sale_show.TabIndex = 3;
            this.button_sale_show.Text = "SALE";
            this.button_sale_show.UseVisualStyleBackColor = true;
            this.button_sale_show.Click += new System.EventHandler(this.button_sale_show_Click);
            // 
            // button_sprzet_show
            // 
            this.button_sprzet_show.Location = new System.Drawing.Point(137, 299);
            this.button_sprzet_show.Name = "button_sprzet_show";
            this.button_sprzet_show.Size = new System.Drawing.Size(75, 23);
            this.button_sprzet_show.TabIndex = 4;
            this.button_sprzet_show.Text = "SPRZET";
            this.button_sprzet_show.UseVisualStyleBackColor = true;
            this.button_sprzet_show.Click += new System.EventHandler(this.button_sprzet_show_Click);
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(12, 328);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(200, 23);
            this.button_save.TabIndex = 5;
            this.button_save.Text = "SAVE AND QIUT";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 360);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.button_sprzet_show);
            this.Controls.Add(this.groupBox_stan);
            this.Controls.Add(this.groupBox_sprzet);
            this.Controls.Add(this.button_sale_show);
            this.Controls.Add(this.groupBox_sale);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox_sale.ResumeLayout(false);
            this.groupBox_sprzet.ResumeLayout(false);
            this.groupBox_stan.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_sale;
        private System.Windows.Forms.Button button_sale_edit;
        private System.Windows.Forms.Button button_sale_del;
        private System.Windows.Forms.Button button_sale_add;
        private System.Windows.Forms.ListBox listBox_sale;
        private System.Windows.Forms.GroupBox groupBox_sprzet;
        private System.Windows.Forms.Button button_sprzet_del;
        private System.Windows.Forms.Button button_sprzet_add;
        private System.Windows.Forms.GroupBox groupBox_stan;
        private System.Windows.Forms.Button button_stan_add;
        private System.Windows.Forms.Button button_stan_del;
        private System.Windows.Forms.ListBox listBox_stan;
        private System.Windows.Forms.Button button_sale_show;
        private System.Windows.Forms.Button button_sprzet_show;
        public System.Windows.Forms.ListBox listBox_sprzet;
        private System.Windows.Forms.Button button_save;
    }
}

