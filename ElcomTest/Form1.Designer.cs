
namespace ElcomTest
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
            this.textBoxXmlUrl = new System.Windows.Forms.TextBox();
            this.buttonLoadXml = new System.Windows.Forms.Button();
            this.richTextBoxNonChangedXml = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.labelLoadInfo = new System.Windows.Forms.Label();
            this.buttonViewtreeXml = new System.Windows.Forms.Button();
            this.buttonViewTextTreeXml = new System.Windows.Forms.Button();
            this.richTextBoxTextFormattedXML = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxXmlUrl
            // 
            this.textBoxXmlUrl.Location = new System.Drawing.Point(12, 32);
            this.textBoxXmlUrl.Name = "textBoxXmlUrl";
            this.textBoxXmlUrl.Size = new System.Drawing.Size(364, 22);
            this.textBoxXmlUrl.TabIndex = 0;
            this.textBoxXmlUrl.Text = "https://raw.githubusercontent.com/palnikovms/DataForTestingTask/master/tree.xml";
            // 
            // buttonLoadXml
            // 
            this.buttonLoadXml.Location = new System.Drawing.Point(392, 29);
            this.buttonLoadXml.Name = "buttonLoadXml";
            this.buttonLoadXml.Size = new System.Drawing.Size(121, 29);
            this.buttonLoadXml.TabIndex = 1;
            this.buttonLoadXml.Text = "Подтвердить";
            this.buttonLoadXml.UseVisualStyleBackColor = true;
            this.buttonLoadXml.Click += new System.EventHandler(this.buttonLoadXml_Click);
            // 
            // richTextBoxNonChangedXml
            // 
            this.richTextBoxNonChangedXml.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.richTextBoxNonChangedXml.Location = new System.Drawing.Point(12, 125);
            this.richTextBoxNonChangedXml.Name = "richTextBoxNonChangedXml";
            this.richTextBoxNonChangedXml.ReadOnly = true;
            this.richTextBoxNonChangedXml.Size = new System.Drawing.Size(400, 602);
            this.richTextBoxNonChangedXml.TabIndex = 2;
            this.richTextBoxNonChangedXml.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Введите ссылку для загрузки XML";
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView1.Location = new System.Drawing.Point(572, 125);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(400, 602);
            this.treeView1.TabIndex = 5;
            // 
            // labelLoadInfo
            // 
            this.labelLoadInfo.AutoSize = true;
            this.labelLoadInfo.Location = new System.Drawing.Point(12, 68);
            this.labelLoadInfo.Name = "labelLoadInfo";
            this.labelLoadInfo.Size = new System.Drawing.Size(0, 17);
            this.labelLoadInfo.TabIndex = 6;
            // 
            // buttonViewtreeXml
            // 
            this.buttonViewtreeXml.Location = new System.Drawing.Point(418, 125);
            this.buttonViewtreeXml.Name = "buttonViewtreeXml";
            this.buttonViewtreeXml.Size = new System.Drawing.Size(148, 50);
            this.buttonViewtreeXml.TabIndex = 7;
            this.buttonViewtreeXml.Text = "Отобразить иерархически";
            this.buttonViewtreeXml.UseVisualStyleBackColor = true;
            this.buttonViewtreeXml.Click += new System.EventHandler(this.buttonViewtreeXml_Click);
            // 
            // buttonViewTextTreeXml
            // 
            this.buttonViewTextTreeXml.Location = new System.Drawing.Point(418, 188);
            this.buttonViewTextTreeXml.Name = "buttonViewTextTreeXml";
            this.buttonViewTextTreeXml.Size = new System.Drawing.Size(148, 50);
            this.buttonViewTextTreeXml.TabIndex = 8;
            this.buttonViewTextTreeXml.Text = "Отобразить текстово";
            this.buttonViewTextTreeXml.UseVisualStyleBackColor = true;
            this.buttonViewTextTreeXml.Click += new System.EventHandler(this.buttonViewTextFormattedXml_Click);
            // 
            // richTextBoxTextFormattedXML
            // 
            this.richTextBoxTextFormattedXML.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxTextFormattedXML.Location = new System.Drawing.Point(572, 125);
            this.richTextBoxTextFormattedXML.Name = "richTextBoxTextFormattedXML";
            this.richTextBoxTextFormattedXML.ReadOnly = true;
            this.richTextBoxTextFormattedXML.Size = new System.Drawing.Size(400, 602);
            this.richTextBoxTextFormattedXML.TabIndex = 9;
            this.richTextBoxTextFormattedXML.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Просмотр исходного файла";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(569, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Полученный результат";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 739);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBoxTextFormattedXML);
            this.Controls.Add(this.buttonViewTextTreeXml);
            this.Controls.Add(this.buttonViewtreeXml);
            this.Controls.Add(this.labelLoadInfo);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBoxNonChangedXml);
            this.Controls.Add(this.buttonLoadXml);
            this.Controls.Add(this.textBoxXmlUrl);
            this.Name = "Form1";
            this.Text = "Xml Tree Viewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxXmlUrl;
        private System.Windows.Forms.Button buttonLoadXml;
        private System.Windows.Forms.RichTextBox richTextBoxNonChangedXml;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label labelLoadInfo;
        private System.Windows.Forms.Button buttonViewtreeXml;
        private System.Windows.Forms.Button buttonViewTextTreeXml;
        private System.Windows.Forms.RichTextBox richTextBoxTextFormattedXML;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

