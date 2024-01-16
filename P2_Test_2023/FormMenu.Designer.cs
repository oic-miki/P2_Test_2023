namespace P2_Test_2023
{
    partial class FormMenu
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
            label1 = new Label();
            textBoxId = new TextBox();
            label2 = new Label();
            textBoxName = new TextBox();
            label3 = new Label();
            textBoxPrice = new TextBox();
            buttonRegist = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 27);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 0;
            label1.Text = "メニューId";
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(136, 27);
            textBoxId.Margin = new Padding(3, 2, 3, 2);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(182, 23);
            textBoxId.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 66);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 2;
            label2.Text = "メニュー名";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(136, 66);
            textBoxName.Margin = new Padding(3, 2, 3, 2);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(182, 23);
            textBoxName.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 100);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 4;
            label3.Text = "価格";
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(136, 100);
            textBoxPrice.Margin = new Padding(3, 2, 3, 2);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(182, 23);
            textBoxPrice.TabIndex = 5;
            // 
            // buttonRegist
            // 
            buttonRegist.Location = new Point(375, 20);
            buttonRegist.Margin = new Padding(3, 2, 3, 2);
            buttonRegist.Name = "buttonRegist";
            buttonRegist.Size = new Size(102, 26);
            buttonRegist.TabIndex = 6;
            buttonRegist.Text = "登録";
            buttonRegist.UseVisualStyleBackColor = true;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(494, 202);
            Controls.Add(buttonRegist);
            Controls.Add(textBoxPrice);
            Controls.Add(label3);
            Controls.Add(textBoxName);
            Controls.Add(label2);
            Controls.Add(textBoxId);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormMenu";
            Text = "メニュー管理画面";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxId;
        private Label label2;
        private TextBox textBoxName;
        private Label label3;
        private TextBox textBoxPrice;
        private Button buttonRegist;
    }
}