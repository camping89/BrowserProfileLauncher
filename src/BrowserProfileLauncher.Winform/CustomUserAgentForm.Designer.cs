
namespace BrowserProfileLauncher.Winform
{
    partial class CustomUserAgentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomUserAgentForm));
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUseDefaultAgent = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbUserAgent = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSave.Location = new System.Drawing.Point(595, 41);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(106, 39);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Ok";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.Location = new System.Drawing.Point(848, 41);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(106, 39);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnUseDefaultAgent
            // 
            this.btnUseDefaultAgent.DialogResult = System.Windows.Forms.DialogResult.Ignore;
            this.btnUseDefaultAgent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUseDefaultAgent.Location = new System.Drawing.Point(721, 41);
            this.btnUseDefaultAgent.Name = "btnUseDefaultAgent";
            this.btnUseDefaultAgent.Padding = new System.Windows.Forms.Padding(3);
            this.btnUseDefaultAgent.Size = new System.Drawing.Size(106, 39);
            this.btnUseDefaultAgent.TabIndex = 7;
            this.btnUseDefaultAgent.Text = "Use Default";
            this.btnUseDefaultAgent.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(14, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Choose User Agent";
            // 
            // cbUserAgent
            // 
            this.cbUserAgent.FormattingEnabled = true;
            this.cbUserAgent.Location = new System.Drawing.Point(176, 12);
            this.cbUserAgent.Name = "cbUserAgent";
            this.cbUserAgent.Size = new System.Drawing.Size(778, 23);
            this.cbUserAgent.TabIndex = 9;
            // 
            // CustomUserAgentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 88);
            this.Controls.Add(this.cbUserAgent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUseDefaultAgent);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CustomUserAgentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NevaD - Custom User Agent";
            this.Load += new System.EventHandler(this.CustomUserAgentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUseDefaultAgent;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cbUserAgent;
    }
}
