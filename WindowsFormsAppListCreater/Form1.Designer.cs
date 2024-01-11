namespace WindowsFormsAppListCreater
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonClearAll = new System.Windows.Forms.Button();
            this.buttonWriteList = new System.Windows.Forms.Button();
            this.buttonClearSelected = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.AllowDrop = true;
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(12, 41);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(776, 400);
            this.listBox1.TabIndex = 0;
            this.listBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox1_DragDrop);
            this.listBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBox1_DragEnter);
            // 
            // buttonClearAll
            // 
            this.buttonClearAll.Location = new System.Drawing.Point(12, 12);
            this.buttonClearAll.Name = "buttonClearAll";
            this.buttonClearAll.Size = new System.Drawing.Size(100, 23);
            this.buttonClearAll.TabIndex = 1;
            this.buttonClearAll.Text = "Clear All";
            this.buttonClearAll.UseVisualStyleBackColor = true;
            this.buttonClearAll.Click += new System.EventHandler(this.buttonClearAll_Click);
            // 
            // buttonWriteList
            // 
            this.buttonWriteList.Location = new System.Drawing.Point(224, 12);
            this.buttonWriteList.Name = "buttonWriteList";
            this.buttonWriteList.Size = new System.Drawing.Size(100, 23);
            this.buttonWriteList.TabIndex = 2;
            this.buttonWriteList.Text = "Write List";
            this.buttonWriteList.UseVisualStyleBackColor = true;
            this.buttonWriteList.Click += new System.EventHandler(this.buttonWriteList_Click);
            // 
            // buttonClearSelected
            // 
            this.buttonClearSelected.Location = new System.Drawing.Point(118, 12);
            this.buttonClearSelected.Name = "buttonClearSelected";
            this.buttonClearSelected.Size = new System.Drawing.Size(100, 23);
            this.buttonClearSelected.TabIndex = 3;
            this.buttonClearSelected.Text = "Clear Selected";
            this.buttonClearSelected.UseVisualStyleBackColor = true;
            this.buttonClearSelected.Click += new System.EventHandler(this.buttonClearSelected_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonClearSelected);
            this.Controls.Add(this.buttonWriteList);
            this.Controls.Add(this.buttonClearAll);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Dir List Creator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonClearAll;
        private System.Windows.Forms.Button buttonWriteList;
        private System.Windows.Forms.Button buttonClearSelected;
    }
}

