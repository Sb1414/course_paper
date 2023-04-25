namespace coursWork
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelBack = new System.Windows.Forms.Panel();
            this.buttonShowAllAir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelFindInfo = new System.Windows.Forms.Label();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.buttonInverse = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelUp = new System.Windows.Forms.Panel();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonShowAllRouts = new System.Windows.Forms.Button();
            this.panelBack.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelSearch.SuspendLayout();
            this.panelUp.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBack
            // 
            this.panelBack.BackColor = System.Drawing.Color.PowderBlue;
            this.panelBack.BackgroundImage = global::coursWork.Properties.Resources.form1back;
            this.panelBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelBack.Controls.Add(this.panel1);
            this.panelBack.Controls.Add(this.panelSearch);
            this.panelBack.Controls.Add(this.label1);
            this.panelBack.Controls.Add(this.panelUp);
            this.panelBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBack.Location = new System.Drawing.Point(0, 0);
            this.panelBack.Name = "panelBack";
            this.panelBack.Size = new System.Drawing.Size(1056, 638);
            this.panelBack.TabIndex = 0;
            // 
            // buttonShowAllAir
            // 
            this.buttonShowAllAir.BackColor = System.Drawing.Color.DarkCyan;
            this.buttonShowAllAir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonShowAllAir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonShowAllAir.FlatAppearance.BorderSize = 0;
            this.buttonShowAllAir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShowAllAir.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonShowAllAir.Location = new System.Drawing.Point(736, 0);
            this.buttonShowAllAir.Name = "buttonShowAllAir";
            this.buttonShowAllAir.Size = new System.Drawing.Size(217, 30);
            this.buttonShowAllAir.TabIndex = 3;
            this.buttonShowAllAir.Text = "show all airports";
            this.buttonShowAllAir.UseVisualStyleBackColor = false;
            this.buttonShowAllAir.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.labelFindInfo);
            this.panel1.Location = new System.Drawing.Point(96, 197);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(863, 370);
            this.panel1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.PowderBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(863, 334);
            this.dataGridView1.TabIndex = 5;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Airport №1";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Airport №2";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Distance";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // labelFindInfo
            // 
            this.labelFindInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelFindInfo.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFindInfo.Location = new System.Drawing.Point(0, 0);
            this.labelFindInfo.Name = "labelFindInfo";
            this.labelFindInfo.Size = new System.Drawing.Size(863, 42);
            this.labelFindInfo.TabIndex = 4;
            // 
            // panelSearch
            // 
            this.panelSearch.BackColor = System.Drawing.Color.Transparent;
            this.panelSearch.Controls.Add(this.label3);
            this.panelSearch.Controls.Add(this.label2);
            this.panelSearch.Controls.Add(this.comboBox2);
            this.panelSearch.Controls.Add(this.buttonInverse);
            this.panelSearch.Controls.Add(this.comboBox1);
            this.panelSearch.Controls.Add(this.buttonSearch);
            this.panelSearch.Location = new System.Drawing.Point(96, 101);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(864, 78);
            this.panelSearch.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(378, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "City of arrival";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(52, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "City of departure";
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(378, 24);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(242, 29);
            this.comboBox2.TabIndex = 5;
            // 
            // buttonInverse
            // 
            this.buttonInverse.BackColor = System.Drawing.Color.Transparent;
            this.buttonInverse.BackgroundImage = global::coursWork.Properties.Resources.icons8_resize_horizontal_25;
            this.buttonInverse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonInverse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonInverse.FlatAppearance.BorderSize = 0;
            this.buttonInverse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInverse.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonInverse.Location = new System.Drawing.Point(304, 24);
            this.buttonInverse.Name = "buttonInverse";
            this.buttonInverse.Size = new System.Drawing.Size(68, 31);
            this.buttonInverse.TabIndex = 2;
            this.buttonInverse.UseVisualStyleBackColor = false;
            this.buttonInverse.Click += new System.EventHandler(this.buttonInverse_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(56, 24);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(242, 29);
            this.comboBox1.TabIndex = 4;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.DarkCyan;
            this.buttonSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSearch.FlatAppearance.BorderSize = 0;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSearch.Location = new System.Drawing.Point(683, 24);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(134, 31);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(351, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome to the Airports app!";
            // 
            // panelUp
            // 
            this.panelUp.BackColor = System.Drawing.Color.Transparent;
            this.panelUp.Controls.Add(this.buttonShowAllRouts);
            this.panelUp.Controls.Add(this.buttonAdd);
            this.panelUp.Controls.Add(this.buttonShowAllAir);
            this.panelUp.Controls.Add(this.buttonClose);
            this.panelUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUp.Location = new System.Drawing.Point(0, 0);
            this.panelUp.Name = "panelUp";
            this.panelUp.Size = new System.Drawing.Size(1056, 30);
            this.panelUp.TabIndex = 0;
            this.panelUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelUp_MouseDown);
            this.panelUp.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelUp_MouseMove);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.DarkCyan;
            this.buttonAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(959, 0);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(97, 30);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
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
            // buttonShowAllRouts
            // 
            this.buttonShowAllRouts.BackColor = System.Drawing.Color.DarkCyan;
            this.buttonShowAllRouts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonShowAllRouts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonShowAllRouts.FlatAppearance.BorderSize = 0;
            this.buttonShowAllRouts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShowAllRouts.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonShowAllRouts.Location = new System.Drawing.Point(513, 0);
            this.buttonShowAllRouts.Name = "buttonShowAllRouts";
            this.buttonShowAllRouts.Size = new System.Drawing.Size(217, 30);
            this.buttonShowAllRouts.TabIndex = 4;
            this.buttonShowAllRouts.Text = "show all routs";
            this.buttonShowAllRouts.UseVisualStyleBackColor = false;
            this.buttonShowAllRouts.Click += new System.EventHandler(this.buttonShowAllRouts_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 638);
            this.Controls.Add(this.panelBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelBack.ResumeLayout(false);
            this.panelBack.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.panelUp.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBack;
        private System.Windows.Forms.Panel panelUp;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelFindInfo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonInverse;
        private System.Windows.Forms.Button buttonShowAllAir;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonShowAllRouts;
    }
}

