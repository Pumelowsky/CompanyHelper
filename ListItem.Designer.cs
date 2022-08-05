
namespace BussinessChatter
{
    partial class ListItem
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.title = new System.Windows.Forms.Label();
            this.descriptionText = new System.Windows.Forms.Label();
            this.assignees = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.itemPic = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.progressBg = new System.Windows.Forms.Panel();
            this.progress = new System.Windows.Forms.Panel();
            this.progressText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.itemPic)).BeginInit();
            this.progressBg.SuspendLayout();
            this.progress.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(112, 6);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(42, 22);
            this.title.TabIndex = 1;
            this.title.Text = "Title";
            // 
            // descriptionText
            // 
            this.descriptionText.Font = new System.Drawing.Font("Open Sans", 10F);
            this.descriptionText.Location = new System.Drawing.Point(112, 28);
            this.descriptionText.Name = "descriptionText";
            this.descriptionText.Size = new System.Drawing.Size(81, 21);
            this.descriptionText.TabIndex = 2;
            this.descriptionText.Text = "Assignees: ";
            // 
            // assignees
            // 
            this.assignees.Font = new System.Drawing.Font("Open Sans", 10F);
            this.assignees.Location = new System.Drawing.Point(112, 49);
            this.assignees.Name = "assignees";
            this.assignees.Size = new System.Drawing.Size(376, 21);
            this.assignees.TabIndex = 3;
            this.assignees.Text = "John";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Open Sans", 10F);
            this.label1.Location = new System.Drawing.Point(112, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Progress:";
            // 
            // itemPic
            // 
            this.itemPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.itemPic.Location = new System.Drawing.Point(14, 14);
            this.itemPic.Name = "itemPic";
            this.itemPic.Size = new System.Drawing.Size(85, 85);
            this.itemPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.itemPic.TabIndex = 0;
            this.itemPic.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Open Sans", 9.75F);
            this.button1.Location = new System.Drawing.Point(521, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 30);
            this.button1.TabIndex = 6;
            this.button1.Text = "Claim Task";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(521, 52);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 30);
            this.button2.TabIndex = 7;
            this.button2.Text = "More Info";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // progressBg
            // 
            this.progressBg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.progressBg.Controls.Add(this.progress);
            this.progressBg.Location = new System.Drawing.Point(199, 80);
            this.progressBg.Name = "progressBg";
            this.progressBg.Size = new System.Drawing.Size(290, 20);
            this.progressBg.TabIndex = 8;
            // 
            // progress
            // 
            this.progress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.progress.Controls.Add(this.progressText);
            this.progress.Location = new System.Drawing.Point(0, 0);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(200, 20);
            this.progress.TabIndex = 0;
            // 
            // progressText
            // 
            this.progressText.Font = new System.Drawing.Font("Open Sans SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.progressText.Location = new System.Drawing.Point(0, 0);
            this.progressText.Name = "progressText";
            this.progressText.Size = new System.Drawing.Size(200, 20);
            this.progressText.TabIndex = 1;
            this.progressText.Text = "0%";
            this.progressText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(58)))), ((int)(((byte)(73)))));
            this.Controls.Add(this.progressBg);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.assignees);
            this.Controls.Add(this.descriptionText);
            this.Controls.Add(this.title);
            this.Controls.Add(this.itemPic);
            this.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ListItem";
            this.Size = new System.Drawing.Size(671, 113);
            ((System.ComponentModel.ISupportInitialize)(this.itemPic)).EndInit();
            this.progressBg.ResumeLayout(false);
            this.progress.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox itemPic;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label descriptionText;
        private System.Windows.Forms.Label assignees;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel progressBg;
        private System.Windows.Forms.Panel progress;
        private System.Windows.Forms.Label progressText;
    }
}
