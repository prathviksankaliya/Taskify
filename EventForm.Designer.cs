namespace Taskify
{
    partial class EventForm
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
            this.txdate = new System.Windows.Forms.TextBox();
            this.txevent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txdate
            // 
            this.txdate.Enabled = false;
            this.txdate.Font = new System.Drawing.Font("Shruti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txdate.Location = new System.Drawing.Point(93, 63);
            this.txdate.Name = "txdate";
            this.txdate.Size = new System.Drawing.Size(244, 44);
            this.txdate.TabIndex = 0;
            // 
            // txevent
            // 
            this.txevent.Font = new System.Drawing.Font("Shruti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txevent.Location = new System.Drawing.Point(93, 149);
            this.txevent.Name = "txevent";
            this.txevent.Size = new System.Drawing.Size(244, 44);
            this.txevent.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Shruti", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Shruti", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(90, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Event";
            // 
            // btnsave
            // 
            this.btnsave.Font = new System.Drawing.Font("Shruti", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(244, 219);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(93, 35);
            this.btnsave.TabIndex = 4;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btndelete
            // 
            this.btndelete.Font = new System.Drawing.Font("Shruti", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(135, 219);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(93, 35);
            this.btndelete.TabIndex = 6;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Visible = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // EventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 281);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txevent);
            this.Controls.Add(this.txdate);
            this.Name = "EventForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EventForm";
            this.Load += new System.EventHandler(this.EventForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txdate;
        private System.Windows.Forms.TextBox txevent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btndelete;
    }
}