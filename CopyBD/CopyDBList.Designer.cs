namespace CopyBD
{
    partial class CopyDBList
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
            this.listBoxBDOnSrvr = new System.Windows.Forms.ListBox();
            this.listBoxBDForCopy = new System.Windows.Forms.ListBox();
            this.SrvrNameLbl = new System.Windows.Forms.Label();
            this.BdOnSrvrLbl = new System.Windows.Forms.Label();
            this.ToBtn = new System.Windows.Forms.Button();
            this.refreshBDListBtn = new System.Windows.Forms.Button();
            this.textBoxSrvrName = new System.Windows.Forms.TextBox();
            this.BdForCopyLbl = new System.Windows.Forms.Label();
            this.delBtn = new System.Windows.Forms.Button();
            this.startBtn = new System.Windows.Forms.Button();
            this.postfixTxt = new System.Windows.Forms.TextBox();
            this.postfixLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxBDOnSrvr
            // 
            this.listBoxBDOnSrvr.FormattingEnabled = true;
            this.listBoxBDOnSrvr.Location = new System.Drawing.Point(12, 105);
            this.listBoxBDOnSrvr.Name = "listBoxBDOnSrvr";
            this.listBoxBDOnSrvr.Size = new System.Drawing.Size(188, 225);
            this.listBoxBDOnSrvr.TabIndex = 0;
            this.listBoxBDOnSrvr.SelectedIndexChanged += new System.EventHandler(this.listBoxBDOnSrvr_SelectedIndexChanged);
            // 
            // listBoxBDForCopy
            // 
            this.listBoxBDForCopy.FormattingEnabled = true;
            this.listBoxBDForCopy.Location = new System.Drawing.Point(249, 105);
            this.listBoxBDForCopy.Name = "listBoxBDForCopy";
            this.listBoxBDForCopy.Size = new System.Drawing.Size(205, 225);
            this.listBoxBDForCopy.TabIndex = 1;
            // 
            // SrvrNameLbl
            // 
            this.SrvrNameLbl.AutoSize = true;
            this.SrvrNameLbl.Location = new System.Drawing.Point(12, 41);
            this.SrvrNameLbl.Name = "SrvrNameLbl";
            this.SrvrNameLbl.Size = new System.Drawing.Size(77, 13);
            this.SrvrNameLbl.TabIndex = 2;
            this.SrvrNameLbl.Text = "Имя сервера:";
            // 
            // BdOnSrvrLbl
            // 
            this.BdOnSrvrLbl.AutoSize = true;
            this.BdOnSrvrLbl.Location = new System.Drawing.Point(9, 89);
            this.BdOnSrvrLbl.Name = "BdOnSrvrLbl";
            this.BdOnSrvrLbl.Size = new System.Drawing.Size(125, 13);
            this.BdOnSrvrLbl.TabIndex = 3;
            this.BdOnSrvrLbl.Text = "Список баз на сервере";
            // 
            // ToBtn
            // 
            this.ToBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToBtn.Location = new System.Drawing.Point(206, 172);
            this.ToBtn.Name = "ToBtn";
            this.ToBtn.Size = new System.Drawing.Size(37, 23);
            this.ToBtn.TabIndex = 4;
            this.ToBtn.Text = "-->";
            this.ToBtn.UseVisualStyleBackColor = true;
            this.ToBtn.Click += new System.EventHandler(this.ToBtn_Click);
            // 
            // refreshBDListBtn
            // 
            this.refreshBDListBtn.Location = new System.Drawing.Point(216, 36);
            this.refreshBDListBtn.Name = "refreshBDListBtn";
            this.refreshBDListBtn.Size = new System.Drawing.Size(143, 23);
            this.refreshBDListBtn.TabIndex = 5;
            this.refreshBDListBtn.Text = "Обновить список БД";
            this.refreshBDListBtn.UseVisualStyleBackColor = true;
            this.refreshBDListBtn.Click += new System.EventHandler(this.refreshBDListBtn_Click);
            // 
            // textBoxSrvrName
            // 
            this.textBoxSrvrName.Location = new System.Drawing.Point(100, 38);
            this.textBoxSrvrName.Name = "textBoxSrvrName";
            this.textBoxSrvrName.Size = new System.Drawing.Size(100, 20);
            this.textBoxSrvrName.TabIndex = 6;
            // 
            // BdForCopyLbl
            // 
            this.BdForCopyLbl.AutoSize = true;
            this.BdForCopyLbl.Location = new System.Drawing.Point(246, 89);
            this.BdForCopyLbl.Name = "BdForCopyLbl";
            this.BdForCopyLbl.Size = new System.Drawing.Size(155, 13);
            this.BdForCopyLbl.TabIndex = 7;
            this.BdForCopyLbl.Text = "Список баз для копирования";
            // 
            // delBtn
            // 
            this.delBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delBtn.Location = new System.Drawing.Point(206, 216);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(37, 23);
            this.delBtn.TabIndex = 8;
            this.delBtn.Text = "<--";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(355, 346);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(99, 23);
            this.startBtn.TabIndex = 9;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // postfixTxt
            // 
            this.postfixTxt.Location = new System.Drawing.Point(249, 348);
            this.postfixTxt.Name = "postfixTxt";
            this.postfixTxt.Size = new System.Drawing.Size(100, 20);
            this.postfixTxt.TabIndex = 11;
            // 
            // postfixLbl
            // 
            this.postfixLbl.AutoSize = true;
            this.postfixLbl.Location = new System.Drawing.Point(182, 351);
            this.postfixLbl.Name = "postfixLbl";
            this.postfixLbl.Size = new System.Drawing.Size(61, 13);
            this.postfixLbl.TabIndex = 10;
            this.postfixLbl.Text = "Постфикс:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Location = new System.Drawing.Point(12, 351);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "БазаДанных42";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(92, 351);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "*постфикс*";
            // 
            // CopyDBList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 391);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.postfixTxt);
            this.Controls.Add(this.postfixLbl);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.BdForCopyLbl);
            this.Controls.Add(this.textBoxSrvrName);
            this.Controls.Add(this.refreshBDListBtn);
            this.Controls.Add(this.ToBtn);
            this.Controls.Add(this.BdOnSrvrLbl);
            this.Controls.Add(this.SrvrNameLbl);
            this.Controls.Add(this.listBoxBDForCopy);
            this.Controls.Add(this.listBoxBDOnSrvr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "CopyDBList";
            this.Text = "Копирование Баз Данных";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxBDOnSrvr;
        private System.Windows.Forms.ListBox listBoxBDForCopy;
        private System.Windows.Forms.Label SrvrNameLbl;
        private System.Windows.Forms.Label BdOnSrvrLbl;
        private System.Windows.Forms.Button ToBtn;
        private System.Windows.Forms.Button refreshBDListBtn;
        private System.Windows.Forms.TextBox textBoxSrvrName;
        private System.Windows.Forms.Label BdForCopyLbl;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.TextBox postfixTxt;
        private System.Windows.Forms.Label postfixLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}