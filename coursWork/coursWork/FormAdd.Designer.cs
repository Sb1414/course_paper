namespace coursWork
{
    partial class FormAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdd));
            this.panelBack = new System.Windows.Forms.Panel();
            this.showAlRoutes = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.buttonDel = new System.Windows.Forms.Button();
            this.textBoxCountry2 = new System.Windows.Forms.TextBox();
            this.textBoxCountry1 = new System.Windows.Forms.TextBox();
            this.textBoxDistance = new System.Windows.Forms.TextBox();
            this.textBoxShort2 = new System.Windows.Forms.TextBox();
            this.textBoxShort1 = new System.Windows.Forms.TextBox();
            this.buttonGo = new System.Windows.Forms.Button();
            this.textBoxName2 = new System.Windows.Forms.TextBox();
            this.textBoxName1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelUp = new System.Windows.Forms.Panel();
            this.buttonClose = new System.Windows.Forms.Button();
            this.panelBack.SuspendLayout();
            this.panelUp.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBack
            // 
            this.panelBack.BackColor = System.Drawing.Color.PowderBlue;
            this.panelBack.BackgroundImage = global::coursWork.Properties.Resources.formAdd1;
            this.panelBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelBack.Controls.Add(this.showAlRoutes);
            this.panelBack.Controls.Add(this.labelInfo);
            this.panelBack.Controls.Add(this.buttonDel);
            this.panelBack.Controls.Add(this.textBoxCountry2);
            this.panelBack.Controls.Add(this.textBoxCountry1);
            this.panelBack.Controls.Add(this.textBoxDistance);
            this.panelBack.Controls.Add(this.textBoxShort2);
            this.panelBack.Controls.Add(this.textBoxShort1);
            this.panelBack.Controls.Add(this.buttonGo);
            this.panelBack.Controls.Add(this.textBoxName2);
            this.panelBack.Controls.Add(this.textBoxName1);
            this.panelBack.Controls.Add(this.panelUp);
            this.panelBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBack.Location = new System.Drawing.Point(0, 0);
            this.panelBack.Name = "panelBack";
            this.panelBack.Size = new System.Drawing.Size(873, 526);
            this.panelBack.TabIndex = 1;
            // 
            // showAlRoutes
            // 
            this.showAlRoutes.BackColor = System.Drawing.Color.Transparent;
            this.showAlRoutes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showAlRoutes.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showAlRoutes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(115)))), ((int)(((byte)(114)))));
            this.showAlRoutes.Location = new System.Drawing.Point(615, 467);
            this.showAlRoutes.Name = "showAlRoutes";
            this.showAlRoutes.Size = new System.Drawing.Size(246, 33);
            this.showAlRoutes.TabIndex = 1;
            this.showAlRoutes.Text = "Output of all routes";
            this.showAlRoutes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.showAlRoutes.Click += new System.EventHandler(this.showAlRoutes_Click);
            this.showAlRoutes.MouseLeave += new System.EventHandler(this.showAlRoutes_MouseLeave);
            this.showAlRoutes.MouseHover += new System.EventHandler(this.showAlRoutes_MouseHover);
            // 
            // labelInfo
            // 
            this.labelInfo.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfo.Location = new System.Drawing.Point(36, 370);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(798, 130);
            this.labelInfo.TabIndex = 7;
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.Color.DarkCyan;
            this.buttonDel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDel.FlatAppearance.BorderSize = 0;
            this.buttonDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDel.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDel.Location = new System.Drawing.Point(705, 306);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(134, 36);
            this.buttonDel.TabIndex = 10;
            this.buttonDel.Text = "Delete all";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // textBoxCountry2
            // 
            this.textBoxCountry2.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCountry2.Location = new System.Drawing.Point(320, 210);
            this.textBoxCountry2.Name = "textBoxCountry2";
            this.textBoxCountry2.Size = new System.Drawing.Size(240, 31);
            this.textBoxCountry2.TabIndex = 9;
            this.textBoxCountry2.Enter += new System.EventHandler(this.textBoxCountry2_Enter);
            this.textBoxCountry2.Leave += new System.EventHandler(this.textBoxCountry2_Leave);
            // 
            // textBoxCountry1
            // 
            this.textBoxCountry1.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCountry1.Location = new System.Drawing.Point(41, 210);
            this.textBoxCountry1.Name = "textBoxCountry1";
            this.textBoxCountry1.Size = new System.Drawing.Size(240, 31);
            this.textBoxCountry1.TabIndex = 8;
            this.textBoxCountry1.Enter += new System.EventHandler(this.textBoxCountry1_Enter);
            this.textBoxCountry1.Leave += new System.EventHandler(this.textBoxCountry1_Leave);
            // 
            // textBoxDistance
            // 
            this.textBoxDistance.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDistance.Location = new System.Drawing.Point(599, 210);
            this.textBoxDistance.Name = "textBoxDistance";
            this.textBoxDistance.Size = new System.Drawing.Size(240, 31);
            this.textBoxDistance.TabIndex = 6;
            this.textBoxDistance.Enter += new System.EventHandler(this.textBoxDistance_Enter);
            this.textBoxDistance.Leave += new System.EventHandler(this.textBoxDistance_Leave);
            // 
            // textBoxShort2
            // 
            this.textBoxShort2.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxShort2.Location = new System.Drawing.Point(320, 159);
            this.textBoxShort2.Name = "textBoxShort2";
            this.textBoxShort2.Size = new System.Drawing.Size(240, 31);
            this.textBoxShort2.TabIndex = 6;
            this.textBoxShort2.Enter += new System.EventHandler(this.textBoxShort2_Enter);
            this.textBoxShort2.Leave += new System.EventHandler(this.textBoxShort2_Leave);
            // 
            // textBoxShort1
            // 
            this.textBoxShort1.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxShort1.Location = new System.Drawing.Point(41, 159);
            this.textBoxShort1.Name = "textBoxShort1";
            this.textBoxShort1.Size = new System.Drawing.Size(240, 31);
            this.textBoxShort1.TabIndex = 5;
            this.textBoxShort1.Enter += new System.EventHandler(this.textBoxShort1_Enter);
            this.textBoxShort1.Leave += new System.EventHandler(this.textBoxShort1_Leave);
            // 
            // buttonGo
            // 
            this.buttonGo.BackColor = System.Drawing.Color.DarkCyan;
            this.buttonGo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonGo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGo.FlatAppearance.BorderSize = 0;
            this.buttonGo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGo.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGo.Location = new System.Drawing.Point(705, 264);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(134, 36);
            this.buttonGo.TabIndex = 4;
            this.buttonGo.Text = "Add";
            this.buttonGo.UseVisualStyleBackColor = false;
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
            // 
            // textBoxName2
            // 
            this.textBoxName2.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxName2.Location = new System.Drawing.Point(320, 111);
            this.textBoxName2.Name = "textBoxName2";
            this.textBoxName2.Size = new System.Drawing.Size(240, 31);
            this.textBoxName2.TabIndex = 3;
            this.textBoxName2.Enter += new System.EventHandler(this.textBoxName2_Enter);
            this.textBoxName2.Leave += new System.EventHandler(this.textBoxName2_Leave);
            // 
            // textBoxName1
            // 
            this.textBoxName1.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxName1.Location = new System.Drawing.Point(41, 111);
            this.textBoxName1.Name = "textBoxName1";
            this.textBoxName1.Size = new System.Drawing.Size(240, 31);
            this.textBoxName1.TabIndex = 2;
            this.textBoxName1.Enter += new System.EventHandler(this.textBoxName1_Enter);
            this.textBoxName1.Leave += new System.EventHandler(this.textBoxName1_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(231, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "This is a page for adding information";
            // 
            // panelUp
            // 
            this.panelUp.BackColor = System.Drawing.Color.Transparent;
            this.panelUp.Controls.Add(this.buttonClose);
            this.panelUp.Controls.Add(this.label1);
            this.panelUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUp.Location = new System.Drawing.Point(0, 0);
            this.panelUp.Name = "panelUp";
            this.panelUp.Size = new System.Drawing.Size(873, 30);
            this.panelUp.TabIndex = 0;
            this.panelUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelUp_MouseDown);
            this.panelUp.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelUp_MouseMove);
            // 
            // buttonClose
            // 
            this.buttonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClose.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClose.Location = new System.Drawing.Point(0, 0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(30, 30);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.Text = "x";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // FormAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 526);
            this.Controls.Add(this.panelBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAddcs";
            this.panelBack.ResumeLayout(false);
            this.panelBack.PerformLayout();
            this.panelUp.ResumeLayout(false);
            this.panelUp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelUp;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.TextBox textBoxDistance;
        private System.Windows.Forms.TextBox textBoxShort2;
        private System.Windows.Forms.TextBox textBoxShort1;
        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.TextBox textBoxName2;
        private System.Windows.Forms.TextBox textBoxName1;
        private System.Windows.Forms.TextBox textBoxCountry2;
        private System.Windows.Forms.TextBox textBoxCountry1;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Label showAlRoutes;
    }
}