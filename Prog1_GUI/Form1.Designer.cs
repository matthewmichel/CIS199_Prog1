namespace Prog1_GUI
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
            this.lngthWlsLbl = new System.Windows.Forms.Label();
            this.hghtWllsLbl = new System.Windows.Forms.Label();
            this.titleLbl = new System.Windows.Forms.Label();
            this.numDoorsLbl = new System.Windows.Forms.Label();
            this.numWndwsLbl = new System.Windows.Forms.Label();
            this.coatsLbl = new System.Windows.Forms.Label();
            this.wllsLngthTxt = new System.Windows.Forms.TextBox();
            this.hghtWllsTxt = new System.Windows.Forms.TextBox();
            this.doorTxt = new System.Windows.Forms.TextBox();
            this.wndwsTxt = new System.Windows.Forms.TextBox();
            this.coatsTxt = new System.Windows.Forms.TextBox();
            this.clcBtn = new System.Windows.Forms.Button();
            this.actualGlnsLbl = new System.Windows.Forms.Label();
            this.roundedGlnsLbl = new System.Windows.Forms.Label();
            this.clearBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lngthWlsLbl
            // 
            this.lngthWlsLbl.AutoSize = true;
            this.lngthWlsLbl.Location = new System.Drawing.Point(108, 86);
            this.lngthWlsLbl.Name = "lngthWlsLbl";
            this.lngthWlsLbl.Size = new System.Drawing.Size(164, 13);
            this.lngthWlsLbl.TabIndex = 1;
            this.lngthWlsLbl.Text = "Total length of ALL walls (in feet):";
            // 
            // hghtWllsLbl
            // 
            this.hghtWllsLbl.AutoSize = true;
            this.hghtWllsLbl.Location = new System.Drawing.Point(137, 110);
            this.hghtWllsLbl.Name = "hghtWllsLbl";
            this.hghtWllsLbl.Size = new System.Drawing.Size(135, 13);
            this.hghtWllsLbl.TabIndex = 3;
            this.hghtWllsLbl.Text = "Height of the walls (in feet):";
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.titleLbl.Location = new System.Drawing.Point(64, 9);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(372, 31);
            this.titleLbl.TabIndex = 0;
            this.titleLbl.Text = "Handy-Dandy Paint Estimator";
            // 
            // numDoorsLbl
            // 
            this.numDoorsLbl.AutoSize = true;
            this.numDoorsLbl.Location = new System.Drawing.Point(123, 134);
            this.numDoorsLbl.Name = "numDoorsLbl";
            this.numDoorsLbl.Size = new System.Drawing.Size(150, 13);
            this.numDoorsLbl.TabIndex = 5;
            this.numDoorsLbl.Text = "Number of doors (non-neg int):";
            // 
            // numWndwsLbl
            // 
            this.numWndwsLbl.AutoSize = true;
            this.numWndwsLbl.Location = new System.Drawing.Point(108, 158);
            this.numWndwsLbl.Name = "numWndwsLbl";
            this.numWndwsLbl.Size = new System.Drawing.Size(165, 13);
            this.numWndwsLbl.TabIndex = 7;
            this.numWndwsLbl.Text = "Number of windows (non-neg int):";
            // 
            // coatsLbl
            // 
            this.coatsLbl.AutoSize = true;
            this.coatsLbl.Location = new System.Drawing.Point(85, 182);
            this.coatsLbl.Name = "coatsLbl";
            this.coatsLbl.Size = new System.Drawing.Size(188, 13);
            this.coatsLbl.TabIndex = 9;
            this.coatsLbl.Text = "Number of coats of paint (non-neg int):";
            // 
            // wllsLngthTxt
            // 
            this.wllsLngthTxt.Location = new System.Drawing.Point(278, 83);
            this.wllsLngthTxt.Name = "wllsLngthTxt";
            this.wllsLngthTxt.Size = new System.Drawing.Size(100, 20);
            this.wllsLngthTxt.TabIndex = 2;
            // 
            // hghtWllsTxt
            // 
            this.hghtWllsTxt.Location = new System.Drawing.Point(278, 107);
            this.hghtWllsTxt.Name = "hghtWllsTxt";
            this.hghtWllsTxt.Size = new System.Drawing.Size(100, 20);
            this.hghtWllsTxt.TabIndex = 4;
            // 
            // doorTxt
            // 
            this.doorTxt.Location = new System.Drawing.Point(278, 131);
            this.doorTxt.Name = "doorTxt";
            this.doorTxt.Size = new System.Drawing.Size(100, 20);
            this.doorTxt.TabIndex = 6;
            // 
            // wndwsTxt
            // 
            this.wndwsTxt.Location = new System.Drawing.Point(278, 155);
            this.wndwsTxt.Name = "wndwsTxt";
            this.wndwsTxt.Size = new System.Drawing.Size(100, 20);
            this.wndwsTxt.TabIndex = 8;
            // 
            // coatsTxt
            // 
            this.coatsTxt.Location = new System.Drawing.Point(278, 179);
            this.coatsTxt.Name = "coatsTxt";
            this.coatsTxt.Size = new System.Drawing.Size(100, 20);
            this.coatsTxt.TabIndex = 10;
            // 
            // clcBtn
            // 
            this.clcBtn.Location = new System.Drawing.Point(119, 221);
            this.clcBtn.Name = "clcBtn";
            this.clcBtn.Size = new System.Drawing.Size(110, 23);
            this.clcBtn.TabIndex = 11;
            this.clcBtn.Text = "Calculate Gallons";
            this.clcBtn.UseVisualStyleBackColor = true;
            this.clcBtn.Click += new System.EventHandler(this.clcBtn_Click);
            // 
            // actualGlnsLbl
            // 
            this.actualGlnsLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.actualGlnsLbl.Location = new System.Drawing.Point(88, 261);
            this.actualGlnsLbl.Name = "actualGlnsLbl";
            this.actualGlnsLbl.Size = new System.Drawing.Size(290, 21);
            this.actualGlnsLbl.TabIndex = 12;
            this.actualGlnsLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // roundedGlnsLbl
            // 
            this.roundedGlnsLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.roundedGlnsLbl.Location = new System.Drawing.Point(88, 291);
            this.roundedGlnsLbl.Name = "roundedGlnsLbl";
            this.roundedGlnsLbl.Size = new System.Drawing.Size(290, 22);
            this.roundedGlnsLbl.TabIndex = 13;
            this.roundedGlnsLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(254, 221);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(102, 23);
            this.clearBtn.TabIndex = 14;
            this.clearBtn.Text = "Clear Data";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.clcBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 348);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.roundedGlnsLbl);
            this.Controls.Add(this.actualGlnsLbl);
            this.Controls.Add(this.clcBtn);
            this.Controls.Add(this.coatsTxt);
            this.Controls.Add(this.wndwsTxt);
            this.Controls.Add(this.doorTxt);
            this.Controls.Add(this.hghtWllsTxt);
            this.Controls.Add(this.wllsLngthTxt);
            this.Controls.Add(this.coatsLbl);
            this.Controls.Add(this.numWndwsLbl);
            this.Controls.Add(this.numDoorsLbl);
            this.Controls.Add(this.titleLbl);
            this.Controls.Add(this.hghtWllsLbl);
            this.Controls.Add(this.lngthWlsLbl);
            this.Name = "Form1";
            this.Text = "Prog 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lngthWlsLbl;
        private System.Windows.Forms.Label hghtWllsLbl;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Label numDoorsLbl;
        private System.Windows.Forms.Label numWndwsLbl;
        private System.Windows.Forms.Label coatsLbl;
        private System.Windows.Forms.TextBox wllsLngthTxt;
        private System.Windows.Forms.TextBox hghtWllsTxt;
        private System.Windows.Forms.TextBox doorTxt;
        private System.Windows.Forms.TextBox wndwsTxt;
        private System.Windows.Forms.TextBox coatsTxt;
        private System.Windows.Forms.Button clcBtn;
        private System.Windows.Forms.Label actualGlnsLbl;
        private System.Windows.Forms.Label roundedGlnsLbl;
        private System.Windows.Forms.Button clearBtn;
    }
}

