namespace Ginger
{
    partial class ApptCardPhone
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApptCardPhone));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ButtonPhonesSave = new System.Windows.Forms.Button();
            this.ButtonPhonesCancel = new System.Windows.Forms.Button();
            this.boxPhones = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.boxPhones, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(312, 216);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.ButtonPhonesSave);
            this.flowLayoutPanel1.Controls.Add(this.ButtonPhonesCancel);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(46, 184);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(219, 29);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // ButtonPhonesSave
            // 
            this.ButtonPhonesSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ButtonPhonesSave.Location = new System.Drawing.Point(3, 3);
            this.ButtonPhonesSave.Name = "ButtonPhonesSave";
            this.ButtonPhonesSave.Size = new System.Drawing.Size(132, 23);
            this.ButtonPhonesSave.TabIndex = 0;
            this.ButtonPhonesSave.Text = "Сохранить и закрыть";
            this.ButtonPhonesSave.UseVisualStyleBackColor = true;
            this.ButtonPhonesSave.Click += new System.EventHandler(this.ButtonPhonesSave_Click);
            // 
            // ButtonPhonesCancel
            // 
            this.ButtonPhonesCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonPhonesCancel.Location = new System.Drawing.Point(141, 3);
            this.ButtonPhonesCancel.Name = "ButtonPhonesCancel";
            this.ButtonPhonesCancel.Size = new System.Drawing.Size(75, 23);
            this.ButtonPhonesCancel.TabIndex = 1;
            this.ButtonPhonesCancel.Text = "Отмена";
            this.ButtonPhonesCancel.UseVisualStyleBackColor = true;
            // 
            // boxPhones
            // 
            this.boxPhones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.boxPhones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.boxPhones.Location = new System.Drawing.Point(3, 3);
            this.boxPhones.Multiline = true;
            this.boxPhones.Name = "boxPhones";
            this.boxPhones.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.boxPhones.Size = new System.Drawing.Size(306, 175);
            this.boxPhones.TabIndex = 1;
            // 
            // ApptCardPhone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ButtonPhonesCancel;
            this.ClientSize = new System.Drawing.Size(312, 216);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ApptCardPhone";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Телефоны";
            this.Shown += new System.EventHandler(this.ApptCardPhone_Shown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button ButtonPhonesSave;
        private System.Windows.Forms.Button ButtonPhonesCancel;
        private System.Windows.Forms.TextBox boxPhones;
    }
}