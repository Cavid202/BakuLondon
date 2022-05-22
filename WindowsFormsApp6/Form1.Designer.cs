namespace WindowsFormsApp6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.baku = new System.Windows.Forms.Button();
            this.london = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // baku
            // 
            resources.ApplyResources(this.baku, "baku");
            this.baku.Name = "baku";
            this.baku.UseVisualStyleBackColor = true;
            this.baku.Click += new System.EventHandler(this.button1_Click);
            // 
            // london
            // 
            resources.ApplyResources(this.london, "london");
            this.london.Name = "london";
            this.london.UseVisualStyleBackColor = true;
            this.london.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
  
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp6.Properties.Resources.baku;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.london);
            this.Controls.Add(this.baku);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button baku;
        private System.Windows.Forms.Button london;
        private System.Windows.Forms.Label label1;
    }
}

