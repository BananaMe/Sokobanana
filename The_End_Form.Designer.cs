namespace Sokobanana
{
    partial class The_End_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(The_End_Form));
            this.OK_Button = new System.Windows.Forms.Button();
            this.The_End_Text = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // OK_Button
            // 
            this.OK_Button.BackColor = System.Drawing.Color.Chocolate;
            this.OK_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OK_Button.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OK_Button.Location = new System.Drawing.Point(90, 79);
            this.OK_Button.Name = "OK_Button";
            this.OK_Button.Size = new System.Drawing.Size(80, 48);
            this.OK_Button.TabIndex = 0;
            this.OK_Button.Text = "OK";
            this.OK_Button.UseVisualStyleBackColor = false;
            this.OK_Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // The_End_Text
            // 
            this.The_End_Text.BackColor = System.Drawing.Color.Moccasin;
            this.The_End_Text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.The_End_Text.Dock = System.Windows.Forms.DockStyle.Top;
            this.The_End_Text.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.The_End_Text.Location = new System.Drawing.Point(0, 0);
            this.The_End_Text.Name = "The_End_Text";
            this.The_End_Text.ReadOnly = true;
            this.The_End_Text.Size = new System.Drawing.Size(287, 44);
            this.The_End_Text.TabIndex = 1;
            this.The_End_Text.Text = "The End!";
            this.The_End_Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.The_End_Text.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // The_End_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(181)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(287, 203);
            this.Controls.Add(this.The_End_Text);
            this.Controls.Add(this.OK_Button);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::Sokobanana.Properties.Settings.Default, "test2", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = global::Sokobanana.Properties.Settings.Default.test2;
            this.Name = "The_End_Form";
            this.Text = "Sokobanana";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OK_Button;
        private System.Windows.Forms.TextBox The_End_Text;
    }
}