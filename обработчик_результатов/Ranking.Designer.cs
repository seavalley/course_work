namespace обработчик_результатов
{
    partial class Ranking
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
            this.types = new System.Windows.Forms.ComboBox();
            this.subject = new System.Windows.Forms.ComboBox();
            this.name = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.show = new System.Windows.Forms.Button();
            this.Count = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // types
            // 
            this.types.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.types.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.types.FormattingEnabled = true;
            this.types.Items.AddRange(new object[] {
            "Полная сводка",
            "Сводка по предмету",
            "Сводка по учащемуся"});
            this.types.Location = new System.Drawing.Point(36, 67);
            this.types.Name = "types";
            this.types.Size = new System.Drawing.Size(159, 33);
            this.types.TabIndex = 12;
            this.types.SelectionChangeCommitted += new System.EventHandler(this.types_SelectionChangeCommitted);
            // 
            // subject
            // 
            this.subject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.subject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.subject.FormattingEnabled = true;
            this.subject.Items.AddRange(new object[] {
            "трпо",
            "экономика",
            "зки"});
            this.subject.Location = new System.Drawing.Point(223, 67);
            this.subject.Name = "subject";
            this.subject.Size = new System.Drawing.Size(159, 33);
            this.subject.TabIndex = 13;
            this.subject.Visible = false;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(223, 65);
            this.name.Multiline = true;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(159, 35);
            this.name.TabIndex = 14;
            this.name.Visible = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(412, 47);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(664, 450);
            this.dataGridView2.TabIndex = 15;
            // 
            // show
            // 
            this.show.BackColor = System.Drawing.Color.Tan;
            this.show.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.show.Font = new System.Drawing.Font("Segoe UI", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.show.ForeColor = System.Drawing.Color.White;
            this.show.Location = new System.Drawing.Point(104, 132);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(210, 46);
            this.show.TabIndex = 16;
            this.show.Text = "Фильтр";
            this.show.UseVisualStyleBackColor = false;
            this.show.Click += new System.EventHandler(this.show_Click);
            // 
            // Count
            // 
            this.Count.BackColor = System.Drawing.Color.Tan;
            this.Count.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Count.Font = new System.Drawing.Font("Segoe UI", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Count.ForeColor = System.Drawing.Color.White;
            this.Count.Location = new System.Drawing.Point(104, 470);
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(210, 46);
            this.Count.TabIndex = 17;
            this.Count.Text = "Сохранить";
            this.Count.UseVisualStyleBackColor = false;
            this.Count.Click += new System.EventHandler(this.Count_Click);
            // 
            // Ranking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(1088, 567);
            this.Controls.Add(this.Count);
            this.Controls.Add(this.show);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.name);
            this.Controls.Add(this.subject);
            this.Controls.Add(this.types);
            this.Name = "Ranking";
            this.Text = "Ranking";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox types;
        private System.Windows.Forms.ComboBox subject;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button show;
        private System.Windows.Forms.Button Count;
    }
}