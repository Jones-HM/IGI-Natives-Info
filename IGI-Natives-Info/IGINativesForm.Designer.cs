
namespace MethodSignatureFinder
{
    partial class IGINativesForm
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
            this.txtMethodName = new System.Windows.Forms.TextBox();
            this.methodLabel = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMethodName
            // 
            this.txtMethodName.Location = new System.Drawing.Point(279, 77);
            this.txtMethodName.Name = "txtMethodName";
            this.txtMethodName.Size = new System.Drawing.Size(307, 31);
            this.txtMethodName.TabIndex = 0;
            // 
            // methodLabel
            // 
            this.methodLabel.AutoSize = true;
            this.methodLabel.Location = new System.Drawing.Point(66, 80);
            this.methodLabel.Name = "methodLabel";
            this.methodLabel.Size = new System.Drawing.Size(146, 25);
            this.methodLabel.TabIndex = 1;
            this.methodLabel.Text = "Method Name";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(12, 589);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(228, 56);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "Generate Native";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(269, 589);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(228, 56);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save Native";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(66, 167);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(76, 25);
            this.lblOutput.TabIndex = 1;
            this.lblOutput.Text = "Output";
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(547, 589);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(228, 56);
            this.btnConvert.TabIndex = 2;
            this.btnConvert.Text = "Convert Natives";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // IGINativesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 657);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.methodLabel);
            this.Controls.Add(this.txtMethodName);
            this.Name = "IGINativesForm";
            this.Text = "Project IGI - Natives Info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMethodName;
        private System.Windows.Forms.Label methodLabel;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button btnConvert;
    }
}

