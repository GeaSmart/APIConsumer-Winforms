
namespace ConsumidorAPI
{
    partial class frmTest
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
            this.btnGet = new System.Windows.Forms.Button();
            this.txtUri = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvGet = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(673, 30);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(75, 41);
            this.btnGet.TabIndex = 0;
            this.btnGet.Text = "GET";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // txtUri
            // 
            this.txtUri.Location = new System.Drawing.Point(108, 39);
            this.txtUri.Name = "txtUri";
            this.txtUri.Size = new System.Drawing.Size(528, 22);
            this.txtUri.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "URI";
            // 
            // dgvGet
            // 
            this.dgvGet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGet.Location = new System.Drawing.Point(30, 77);
            this.dgvGet.Name = "dgvGet";
            this.dgvGet.RowHeadersWidth = 51;
            this.dgvGet.RowTemplate.Height = 24;
            this.dgvGet.Size = new System.Drawing.Size(718, 434);
            this.dgvGet.TabIndex = 3;
            // 
            // frmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 535);
            this.Controls.Add(this.dgvGet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUri);
            this.Controls.Add(this.btnGet);
            this.Name = "frmTest";
            this.Text = "API Tests";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.TextBox txtUri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvGet;
    }
}