
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
            this.lblUserAgent = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtUserAgent = new System.Windows.Forms.TextBox();
            this.btnUseDefaultAgent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUserAgent
            // 
            this.lblUserAgent.AutoSize = true;
            this.lblUserAgent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUserAgent.Location = new System.Drawing.Point(12, 25);
            this.lblUserAgent.Name = "lblUserAgent";
            this.lblUserAgent.Size = new System.Drawing.Size(145, 21);
            this.lblUserAgent.TabIndex = 2;
            this.lblUserAgent.Text = "Custom User Agent";
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSave.Location = new System.Drawing.Point(562, 75);
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
            this.btnCancel.Location = new System.Drawing.Point(815, 75);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(106, 39);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtUserAgent
            // 
            this.txtUserAgent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUserAgent.Location = new System.Drawing.Point(174, 22);
            this.txtUserAgent.Name = "txtUserAgent";
            this.txtUserAgent.Size = new System.Drawing.Size(778, 29);
            this.txtUserAgent.TabIndex = 6;
            // 
            // btnUseDefaultAgent
            // 
            this.btnUseDefaultAgent.DialogResult = System.Windows.Forms.DialogResult.Ignore;
            this.btnUseDefaultAgent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUseDefaultAgent.Location = new System.Drawing.Point(688, 75);
            this.btnUseDefaultAgent.Name = "btnUseDefaultAgent";
            this.btnUseDefaultAgent.Padding = new System.Windows.Forms.Padding(3);
            this.btnUseDefaultAgent.Size = new System.Drawing.Size(106, 39);
            this.btnUseDefaultAgent.TabIndex = 7;
            this.btnUseDefaultAgent.Text = "Use Default";
            this.btnUseDefaultAgent.UseVisualStyleBackColor = true;
            // 
            // CustomUserAgentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 136);
            this.Controls.Add(this.btnUseDefaultAgent);
            this.Controls.Add(this.txtUserAgent);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblUserAgent);
            this.Name = "CustomUserAgentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Custom User Agent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblUserAgent;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.TextBox txtUserAgent;
        private System.Windows.Forms.Button btnUseDefaultAgent;
    }
}
