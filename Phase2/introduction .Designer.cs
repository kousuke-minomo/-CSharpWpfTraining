namespace WindowsFormsApp1
{
    partial class introduction
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonRigtt = new System.Windows.Forms.Button();
            this.buttonDownn = new System.Windows.Forms.Button();
            this.buttonCenter = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblBlue = new System.Windows.Forms.Label();
            this.lblGreen = new System.Windows.Forms.Label();
            this.lblRed = new System.Windows.Forms.Label();
            this.rBar = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gBar = new System.Windows.Forms.TrackBar();
            this.bBar = new System.Windows.Forms.TrackBar();
            this.VisibleWindow = new System.Windows.Forms.CheckBox();
            this.movebar = new System.Windows.Forms.TrackBar();
            this.LengthBar = new System.Windows.Forms.TrackBar();
            this.heightBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbllheight = new System.Windows.Forms.Label();
            this.lblLength = new System.Windows.Forms.Label();
            this.lblmoveValue = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movebar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LengthBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightBar)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonRigtt);
            this.groupBox1.Controls.Add(this.buttonDownn);
            this.groupBox1.Controls.Add(this.buttonCenter);
            this.groupBox1.Controls.Add(this.buttonLeft);
            this.groupBox1.Controls.Add(this.buttonUp);
            this.groupBox1.Location = new System.Drawing.Point(20, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 204);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "子ウインドウの位置制御";
            // 
            // buttonRigtt
            // 
            this.buttonRigtt.Location = new System.Drawing.Point(101, 85);
            this.buttonRigtt.Name = "buttonRigtt";
            this.buttonRigtt.Size = new System.Drawing.Size(30, 30);
            this.buttonRigtt.TabIndex = 0;
            this.buttonRigtt.Text = "→";
            this.buttonRigtt.UseVisualStyleBackColor = true;
            this.buttonRigtt.Click += new System.EventHandler(this.buttonRigtt_Click);
            // 
            // buttonDownn
            // 
            this.buttonDownn.Location = new System.Drawing.Point(65, 121);
            this.buttonDownn.Name = "buttonDownn";
            this.buttonDownn.Size = new System.Drawing.Size(30, 30);
            this.buttonDownn.TabIndex = 0;
            this.buttonDownn.Text = "↓";
            this.buttonDownn.UseVisualStyleBackColor = true;
            this.buttonDownn.Click += new System.EventHandler(this.buttonDownn_Click);
            // 
            // buttonCenter
            // 
            this.buttonCenter.Location = new System.Drawing.Point(65, 85);
            this.buttonCenter.Name = "buttonCenter";
            this.buttonCenter.Size = new System.Drawing.Size(30, 30);
            this.buttonCenter.TabIndex = 0;
            this.buttonCenter.UseVisualStyleBackColor = true;
            this.buttonCenter.Click += new System.EventHandler(this.buttonCenter_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.Location = new System.Drawing.Point(28, 85);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(30, 30);
            this.buttonLeft.TabIndex = 0;
            this.buttonLeft.Text = "←";
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonLeft_Click);
            // 
            // buttonUp
            // 
            this.buttonUp.Location = new System.Drawing.Point(65, 48);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(30, 30);
            this.buttonUp.TabIndex = 0;
            this.buttonUp.Text = "↑";
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonUp_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblBlue);
            this.groupBox3.Controls.Add(this.lblGreen);
            this.groupBox3.Controls.Add(this.lblRed);
            this.groupBox3.Controls.Add(this.rBar);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.gBar);
            this.groupBox3.Controls.Add(this.bBar);
            this.groupBox3.Location = new System.Drawing.Point(261, 258);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(328, 175);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "子ウインドウの背景色制御";
            // 
            // lblBlue
            // 
            this.lblBlue.AutoSize = true;
            this.lblBlue.Location = new System.Drawing.Point(62, 128);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(13, 15);
            this.lblBlue.TabIndex = 2;
            this.lblBlue.Text = "0";
            // 
            // lblGreen
            // 
            this.lblGreen.AutoSize = true;
            this.lblGreen.Location = new System.Drawing.Point(62, 77);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(13, 15);
            this.lblGreen.TabIndex = 2;
            this.lblGreen.Text = "0";
            // 
            // lblRed
            // 
            this.lblRed.AutoSize = true;
            this.lblRed.Location = new System.Drawing.Point(62, 26);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(13, 15);
            this.lblRed.TabIndex = 2;
            this.lblRed.Text = "0";
            // 
            // rBar
            // 
            this.rBar.Location = new System.Drawing.Point(110, 26);
            this.rBar.Maximum = 255;
            this.rBar.Name = "rBar";
            this.rBar.Size = new System.Drawing.Size(166, 45);
            this.rBar.TabIndex = 0;
            this.rBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.rBar.Scroll += new System.EventHandler(this.colorBar_Scroll);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "色(B):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "色(G):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "色(R):";
            // 
            // gBar
            // 
            this.gBar.Location = new System.Drawing.Point(110, 77);
            this.gBar.Maximum = 255;
            this.gBar.Name = "gBar";
            this.gBar.Size = new System.Drawing.Size(166, 45);
            this.gBar.TabIndex = 0;
            this.gBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.gBar.Scroll += new System.EventHandler(this.colorBar_Scroll);
            // 
            // bBar
            // 
            this.bBar.Location = new System.Drawing.Point(110, 128);
            this.bBar.Maximum = 255;
            this.bBar.Name = "bBar";
            this.bBar.Size = new System.Drawing.Size(166, 45);
            this.bBar.TabIndex = 0;
            this.bBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.bBar.Scroll += new System.EventHandler(this.colorBar_Scroll);
            // 
            // VisibleWindow
            // 
            this.VisibleWindow.AutoSize = true;
            this.VisibleWindow.Location = new System.Drawing.Point(295, 12);
            this.VisibleWindow.Name = "VisibleWindow";
            this.VisibleWindow.Size = new System.Drawing.Size(116, 22);
            this.VisibleWindow.TabIndex = 3;
            this.VisibleWindow.Text = "子ウインドウの表示";
            this.VisibleWindow.UseCompatibleTextRendering = true;
            this.VisibleWindow.UseVisualStyleBackColor = true;
            this.VisibleWindow.CheckedChanged += new System.EventHandler(this.VisibleWindow_CheckedChanged);
            // 
            // movebar
            // 
            this.movebar.Location = new System.Drawing.Point(106, 34);
            this.movebar.Maximum = 100;
            this.movebar.Name = "movebar";
            this.movebar.Size = new System.Drawing.Size(166, 45);
            this.movebar.TabIndex = 0;
            this.movebar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.movebar.Scroll += new System.EventHandler(this.movebar_Scroll);
            // 
            // LengthBar
            // 
            this.LengthBar.Location = new System.Drawing.Point(106, 85);
            this.LengthBar.Maximum = 100;
            this.LengthBar.Name = "LengthBar";
            this.LengthBar.Size = new System.Drawing.Size(166, 45);
            this.LengthBar.TabIndex = 0;
            this.LengthBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.LengthBar.Scroll += new System.EventHandler(this.LengthBar_Scroll);
            // 
            // heightBar
            // 
            this.heightBar.Location = new System.Drawing.Point(106, 136);
            this.heightBar.Maximum = 100;
            this.heightBar.Name = "heightBar";
            this.heightBar.Size = new System.Drawing.Size(166, 45);
            this.heightBar.TabIndex = 0;
            this.heightBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.heightBar.Scroll += new System.EventHandler(this.heightBar_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "移動量:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "幅:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "高さ:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbllheight);
            this.groupBox2.Controls.Add(this.lblLength);
            this.groupBox2.Controls.Add(this.lblmoveValue);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.heightBar);
            this.groupBox2.Controls.Add(this.LengthBar);
            this.groupBox2.Controls.Add(this.movebar);
            this.groupBox2.Location = new System.Drawing.Point(261, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(328, 176);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "子ウインドウの座標制御";
            // 
            // lbllheight
            // 
            this.lbllheight.AutoSize = true;
            this.lbllheight.Location = new System.Drawing.Point(62, 136);
            this.lbllheight.Name = "lbllheight";
            this.lbllheight.Size = new System.Drawing.Size(13, 15);
            this.lbllheight.TabIndex = 2;
            this.lbllheight.Text = "0";
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(62, 85);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(13, 15);
            this.lblLength.TabIndex = 2;
            this.lblLength.Text = "0";
            // 
            // lblmoveValue
            // 
            this.lblmoveValue.AutoSize = true;
            this.lblmoveValue.Location = new System.Drawing.Point(62, 35);
            this.lblmoveValue.Name = "lblmoveValue";
            this.lblmoveValue.Size = new System.Drawing.Size(13, 15);
            this.lblmoveValue.TabIndex = 2;
            this.lblmoveValue.Text = "0";
            // 
            // introduction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 460);
            this.Controls.Add(this.VisibleWindow);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "introduction";
            this.Text = "入門課題";
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movebar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LengthBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightBar)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonRigtt;
        private System.Windows.Forms.Button buttonDownn;
        private System.Windows.Forms.Button buttonCenter;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.TrackBar rBar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar gBar;
        private System.Windows.Forms.TrackBar bBar;
        private System.Windows.Forms.CheckBox VisibleWindow;
        private System.Windows.Forms.Label lblBlue;
        private System.Windows.Forms.Label lblGreen;
        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.TrackBar movebar;
        private System.Windows.Forms.TrackBar LengthBar;
        private System.Windows.Forms.TrackBar heightBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbllheight;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblmoveValue;
    }
}

