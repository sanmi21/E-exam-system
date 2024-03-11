namespace Eexamscholarship
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.questcounter = new System.Windows.Forms.Label();
            this.Timelabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.NextQuestionbutton = new System.Windows.Forms.Button();
            this.EndExambutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(241, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(824, 128);
            this.label1.TabIndex = 0;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(241, 347);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(170, 33);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(241, 408);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(170, 33);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.Location = new System.Drawing.Point(241, 471);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(170, 33);
            this.radioButton3.TabIndex = 3;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Navy;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(5, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1212, 63);
            this.label2.TabIndex = 4;
            this.label2.Text = "IELTS";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // questcounter
            // 
            this.questcounter.AutoSize = true;
            this.questcounter.Location = new System.Drawing.Point(155, 145);
            this.questcounter.Name = "questcounter";
            this.questcounter.Size = new System.Drawing.Size(0, 16);
            this.questcounter.TabIndex = 5;
            
            // 
            // Timelabel
            // 
            this.Timelabel.Location = new System.Drawing.Point(1046, 539);
            this.Timelabel.Name = "Timelabel";
            this.Timelabel.Size = new System.Drawing.Size(100, 23);
            this.Timelabel.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(990, 512);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // NextQuestionbutton
            // 
            this.NextQuestionbutton.BackColor = System.Drawing.Color.Navy;
            this.NextQuestionbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NextQuestionbutton.Location = new System.Drawing.Point(484, 559);
            this.NextQuestionbutton.Name = "NextQuestionbutton";
            this.NextQuestionbutton.Size = new System.Drawing.Size(98, 55);
            this.NextQuestionbutton.TabIndex = 8;
            this.NextQuestionbutton.Text = "Next question";
            this.NextQuestionbutton.UseVisualStyleBackColor = false;
            this.NextQuestionbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // EndExambutton
            // 
            this.EndExambutton.BackColor = System.Drawing.Color.Navy;
            this.EndExambutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EndExambutton.Location = new System.Drawing.Point(807, 559);
            this.EndExambutton.Name = "EndExambutton";
            this.EndExambutton.Size = new System.Drawing.Size(75, 55);
            this.EndExambutton.TabIndex = 9;
            this.EndExambutton.Text = "End exam";
            this.EndExambutton.UseVisualStyleBackColor = false;
            this.EndExambutton.Visible = false;
            this.EndExambutton.Click += new System.EventHandler(this.EndExambutton_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 666);
            this.Controls.Add(this.EndExambutton);
            this.Controls.Add(this.NextQuestionbutton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Timelabel);
            this.Controls.Add(this.questcounter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label questcounter;
        private System.Windows.Forms.Label Timelabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button NextQuestionbutton;
        private System.Windows.Forms.Button EndExambutton;
        public System.Windows.Forms.Timer timer1;
    }
}