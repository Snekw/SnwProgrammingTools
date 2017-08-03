namespace BinToHex
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
            this.components = new System.ComponentModel.Container();
            this.B_7 = new System.Windows.Forms.Button();
            this.B_6 = new System.Windows.Forms.Button();
            this.B_5 = new System.Windows.Forms.Button();
            this.B_4 = new System.Windows.Forms.Button();
            this.B_0 = new System.Windows.Forms.Button();
            this.B_1 = new System.Windows.Forms.Button();
            this.B_2 = new System.Windows.Forms.Button();
            this.B_3 = new System.Windows.Forms.Button();
            this.B_RESET0 = new System.Windows.Forms.Button();
            this.B_RESET1 = new System.Windows.Forms.Button();
            this.TB_OUT = new System.Windows.Forms.TextBox();
            this.B_COPY = new System.Windows.Forms.Button();
            this.FormContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.topMostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.B_TOBIN = new System.Windows.Forms.Button();
            this.FormContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // B_7
            // 
            this.B_7.Location = new System.Drawing.Point(9, 12);
            this.B_7.Name = "B_7";
            this.B_7.Size = new System.Drawing.Size(21, 21);
            this.B_7.TabIndex = 2;
            this.B_7.Tag = "";
            this.B_7.Text = "0";
            this.B_7.UseVisualStyleBackColor = true;
            this.B_7.Click += new System.EventHandler(this.ByteChangeEvent);
            // 
            // B_6
            // 
            this.B_6.Location = new System.Drawing.Point(36, 12);
            this.B_6.Name = "B_6";
            this.B_6.Size = new System.Drawing.Size(21, 21);
            this.B_6.TabIndex = 3;
            this.B_6.Tag = "";
            this.B_6.Text = "0";
            this.B_6.UseVisualStyleBackColor = true;
            this.B_6.Click += new System.EventHandler(this.ByteChangeEvent);
            // 
            // B_5
            // 
            this.B_5.Location = new System.Drawing.Point(63, 12);
            this.B_5.Name = "B_5";
            this.B_5.Size = new System.Drawing.Size(21, 21);
            this.B_5.TabIndex = 4;
            this.B_5.Tag = "";
            this.B_5.Text = "0";
            this.B_5.UseVisualStyleBackColor = true;
            this.B_5.Click += new System.EventHandler(this.ByteChangeEvent);
            // 
            // B_4
            // 
            this.B_4.Location = new System.Drawing.Point(90, 12);
            this.B_4.Name = "B_4";
            this.B_4.Size = new System.Drawing.Size(21, 21);
            this.B_4.TabIndex = 5;
            this.B_4.Tag = "";
            this.B_4.Text = "0";
            this.B_4.UseVisualStyleBackColor = true;
            this.B_4.Click += new System.EventHandler(this.ByteChangeEvent);
            // 
            // B_0
            // 
            this.B_0.Location = new System.Drawing.Point(215, 12);
            this.B_0.Name = "B_0";
            this.B_0.Size = new System.Drawing.Size(21, 21);
            this.B_0.TabIndex = 9;
            this.B_0.Tag = "";
            this.B_0.Text = "0";
            this.B_0.UseVisualStyleBackColor = true;
            this.B_0.Click += new System.EventHandler(this.ByteChangeEvent);
            // 
            // B_1
            // 
            this.B_1.Location = new System.Drawing.Point(188, 12);
            this.B_1.Name = "B_1";
            this.B_1.Size = new System.Drawing.Size(21, 21);
            this.B_1.TabIndex = 8;
            this.B_1.Tag = "";
            this.B_1.Text = "0";
            this.B_1.UseVisualStyleBackColor = true;
            this.B_1.Click += new System.EventHandler(this.ByteChangeEvent);
            // 
            // B_2
            // 
            this.B_2.Location = new System.Drawing.Point(161, 12);
            this.B_2.Name = "B_2";
            this.B_2.Size = new System.Drawing.Size(21, 21);
            this.B_2.TabIndex = 7;
            this.B_2.Tag = "";
            this.B_2.Text = "0";
            this.B_2.UseVisualStyleBackColor = true;
            this.B_2.Click += new System.EventHandler(this.ByteChangeEvent);
            // 
            // B_3
            // 
            this.B_3.Location = new System.Drawing.Point(134, 12);
            this.B_3.Name = "B_3";
            this.B_3.Size = new System.Drawing.Size(21, 21);
            this.B_3.TabIndex = 6;
            this.B_3.Tag = "";
            this.B_3.Text = "0";
            this.B_3.UseVisualStyleBackColor = true;
            this.B_3.Click += new System.EventHandler(this.ByteChangeEvent);
            // 
            // B_RESET0
            // 
            this.B_RESET0.Location = new System.Drawing.Point(9, 39);
            this.B_RESET0.Name = "B_RESET0";
            this.B_RESET0.Size = new System.Drawing.Size(102, 23);
            this.B_RESET0.TabIndex = 10;
            this.B_RESET0.Tag = "0";
            this.B_RESET0.Text = "Reset 0";
            this.B_RESET0.UseVisualStyleBackColor = true;
            this.B_RESET0.Click += new System.EventHandler(this.ByteReset);
            // 
            // B_RESET1
            // 
            this.B_RESET1.Location = new System.Drawing.Point(134, 39);
            this.B_RESET1.Name = "B_RESET1";
            this.B_RESET1.Size = new System.Drawing.Size(102, 23);
            this.B_RESET1.TabIndex = 11;
            this.B_RESET1.Tag = "1";
            this.B_RESET1.Text = "Reset 1";
            this.B_RESET1.UseVisualStyleBackColor = true;
            this.B_RESET1.Click += new System.EventHandler(this.ByteReset);
            // 
            // TB_OUT
            // 
            this.TB_OUT.Location = new System.Drawing.Point(273, 13);
            this.TB_OUT.Name = "TB_OUT";
            this.TB_OUT.Size = new System.Drawing.Size(100, 20);
            this.TB_OUT.TabIndex = 12;
            // 
            // B_COPY
            // 
            this.B_COPY.Location = new System.Drawing.Point(273, 39);
            this.B_COPY.Name = "B_COPY";
            this.B_COPY.Size = new System.Drawing.Size(100, 23);
            this.B_COPY.TabIndex = 13;
            this.B_COPY.Text = "Copy";
            this.B_COPY.UseVisualStyleBackColor = true;
            this.B_COPY.Click += new System.EventHandler(this.B_COPY_Click);
            // 
            // FormContextMenu
            // 
            this.FormContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.topMostToolStripMenuItem});
            this.FormContextMenu.Name = "FormContextMenu";
            this.FormContextMenu.Size = new System.Drawing.Size(125, 26);
            // 
            // topMostToolStripMenuItem
            // 
            this.topMostToolStripMenuItem.Checked = true;
            this.topMostToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.topMostToolStripMenuItem.Name = "topMostToolStripMenuItem";
            this.topMostToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.topMostToolStripMenuItem.Text = "Top most";
            this.topMostToolStripMenuItem.Click += new System.EventHandler(this.topMostToolStripMenuItem_Click);
            // 
            // B_TOBIN
            // 
            this.B_TOBIN.Location = new System.Drawing.Point(243, 12);
            this.B_TOBIN.Name = "B_TOBIN";
            this.B_TOBIN.Size = new System.Drawing.Size(24, 50);
            this.B_TOBIN.TabIndex = 14;
            this.B_TOBIN.Text = "<";
            this.B_TOBIN.UseVisualStyleBackColor = true;
            this.B_TOBIN.Click += new System.EventHandler(this.B_TOBIN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 69);
            this.ContextMenuStrip = this.FormContextMenu;
            this.Controls.Add(this.B_TOBIN);
            this.Controls.Add(this.B_COPY);
            this.Controls.Add(this.TB_OUT);
            this.Controls.Add(this.B_RESET1);
            this.Controls.Add(this.B_RESET0);
            this.Controls.Add(this.B_0);
            this.Controls.Add(this.B_1);
            this.Controls.Add(this.B_2);
            this.Controls.Add(this.B_3);
            this.Controls.Add(this.B_4);
            this.Controls.Add(this.B_5);
            this.Controls.Add(this.B_6);
            this.Controls.Add(this.B_7);
            this.MaximumSize = new System.Drawing.Size(402, 108);
            this.MinimumSize = new System.Drawing.Size(402, 108);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Byte to hex with buttons";
            this.TopMost = true;
            this.FormContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button B_7;
        private System.Windows.Forms.Button B_6;
        private System.Windows.Forms.Button B_5;
        private System.Windows.Forms.Button B_4;
        private System.Windows.Forms.Button B_0;
        private System.Windows.Forms.Button B_1;
        private System.Windows.Forms.Button B_2;
        private System.Windows.Forms.Button B_3;
        private System.Windows.Forms.Button B_RESET0;
        private System.Windows.Forms.Button B_RESET1;
        private System.Windows.Forms.TextBox TB_OUT;
        private System.Windows.Forms.Button B_COPY;
        private System.Windows.Forms.ContextMenuStrip FormContextMenu;
        private System.Windows.Forms.ToolStripMenuItem topMostToolStripMenuItem;
        private System.Windows.Forms.Button B_TOBIN;
    }
}

