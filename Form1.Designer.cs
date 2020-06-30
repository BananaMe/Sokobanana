namespace Sokobanana
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Play_button = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Title = new System.Windows.Forms.TextBox();
            this.Description_text = new System.Windows.Forms.RichTextBox();
            this.Restart_text = new System.Windows.Forms.TextBox();
            this.Arrow_key_box = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Play_button
            // 
            this.Play_button.BackColor = System.Drawing.Color.Chocolate;
            resources.ApplyResources(this.Play_button, "Play_button");
            this.Play_button.Name = "Play_button";
            this.Play_button.UseVisualStyleBackColor = false;
            this.Play_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Title
            // 
            this.Title.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.Title.BackColor = System.Drawing.Color.Moccasin;
            this.Title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Title.CausesValidation = false;
            resources.ApplyResources(this.Title, "Title");
            this.Title.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Description_text
            // 
            this.Description_text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(225)))), ((int)(((byte)(203)))));
            this.Description_text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.Description_text, "Description_text");
            this.Description_text.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Description_text.Name = "Description_text";
            this.Description_text.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Restart_text
            // 
            this.Restart_text.BackColor = System.Drawing.Color.Moccasin;
            resources.ApplyResources(this.Restart_text, "Restart_text");
            this.Restart_text.Name = "Restart_text";
            this.Restart_text.ReadOnly = true;
            this.Restart_text.ShortcutsEnabled = false;
            this.Restart_text.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // Arrow_key_box
            // 
            this.Arrow_key_box.BackColor = System.Drawing.Color.Moccasin;
            resources.ApplyResources(this.Arrow_key_box, "Arrow_key_box");
            this.Arrow_key_box.Name = "Arrow_key_box";
            this.Arrow_key_box.ReadOnly = true;
            this.Arrow_key_box.ShortcutsEnabled = false;
            this.Arrow_key_box.TextChanged += new System.EventHandler(this.textBox1_TextChanged_3);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(181)))), ((int)(((byte)(155)))));
            this.Controls.Add(this.Arrow_key_box);
            this.Controls.Add(this.Restart_text);
            this.Controls.Add(this.Description_text);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Play_button);
            this.ForeColor = System.Drawing.Color.Black;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button Play_button;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.RichTextBox Description_text;
        private System.Windows.Forms.TextBox Restart_text;
        private System.Windows.Forms.TextBox Arrow_key_box;
    }
}

