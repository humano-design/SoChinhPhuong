namespace SoChinhPhuong
{
    partial class Form1
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
            button1 = new Button();
            box = new TextBox();
            ketqua = new Label();
            list = new ListBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(61, 126);
            button1.Name = "button1";
            button1.Size = new Size(157, 65);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // box
            // 
            box.Location = new Point(61, 46);
            box.Multiline = true;
            box.Name = "box";
            box.Size = new Size(120, 42);
            box.TabIndex = 1;
            box.TextChanged += box_TextChanged;
            // 
            // ketqua
            // 
            ketqua.AutoSize = true;
            ketqua.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ketqua.Location = new Point(205, 46);
            ketqua.Name = "ketqua";
            ketqua.Size = new Size(109, 32);
            ketqua.TabIndex = 2;
            ketqua.Text = "KẾT QUẢ";
            // 
            // list
            // 
            list.FormattingEnabled = true;
            list.ItemHeight = 15;
            list.Location = new Point(471, 72);
            list.Name = "list";
            list.Size = new Size(208, 154);
            list.TabIndex = 3;
            list.SelectedIndexChanged += list_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(list);
            Controls.Add(ketqua);
            Controls.Add(box);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox box;
        private Label ketqua;
        private ListBox list;
    }
}
