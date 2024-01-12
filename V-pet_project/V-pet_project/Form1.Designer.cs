namespace V_pet_project
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
            this._rendorBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _rendorBTN
            // 
            this._rendorBTN.Location = new System.Drawing.Point(12, 12);
            this._rendorBTN.Name = "_rendorBTN";
            this._rendorBTN.Size = new System.Drawing.Size(112, 23);
            this._rendorBTN.TabIndex = 0;
            this._rendorBTN.Text = "Rendor_digimon";
            this._rendorBTN.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._rendorBTN);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _rendorBTN;
    }
}

