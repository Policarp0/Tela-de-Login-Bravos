namespace WinFormsApp1
{
    partial class Idenitifcacao
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Idenitifcacao));
            groupBox1 = new GroupBox();
            cancelarBtn = new Button();
            okBtn = new Button();
            groupBox3 = new GroupBox();
            txtSenha = new TextBox();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtUsuario = new TextBox();
            groupBox2 = new GroupBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            imageList1 = new ImageList(components);
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            resources.ApplyResources(groupBox1, "groupBox1");
            groupBox1.Controls.Add(cancelarBtn);
            groupBox1.Controls.Add(okBtn);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Name = "groupBox1";
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // cancelarBtn
            // 
            resources.ApplyResources(cancelarBtn, "cancelarBtn");
            cancelarBtn.Name = "cancelarBtn";
            cancelarBtn.UseVisualStyleBackColor = true;
            cancelarBtn.Click += button2_Click;
            // 
            // okBtn
            // 
            resources.ApplyResources(okBtn, "okBtn");
            okBtn.Name = "okBtn";
            okBtn.UseVisualStyleBackColor = true;
            okBtn.Click += Ok_Click;
            // 
            // groupBox3
            // 
            resources.ApplyResources(groupBox3, "groupBox3");
            groupBox3.Controls.Add(txtSenha);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(dateTimePicker1);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(txtUsuario);
            groupBox3.Name = "groupBox3";
            groupBox3.TabStop = false;
            // 
            // txtSenha
            // 
            resources.ApplyResources(txtSenha, "txtSenha");
            txtSenha.Name = "txtSenha";
            txtSenha.UseSystemPasswordChar = true;
            txtSenha.TextChanged += txtSenha_TextChanged;
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.Name = "label4";
            label4.Click += label4_Click;
            // 
            // dateTimePicker1
            // 
            resources.ApplyResources(dateTimePicker1, "dateTimePicker1");
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.TabStop = false;
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            label1.Click += label1_Click;
            // 
            // txtUsuario
            // 
            resources.ApplyResources(txtUsuario, "txtUsuario");
            txtUsuario.CharacterCasing = CharacterCasing.Upper;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.TextChanged += textBox2_TextChanged;
            // 
            // groupBox2
            // 
            resources.ApplyResources(groupBox2, "groupBox2");
            groupBox2.Name = "groupBox2";
            groupBox2.TabStop = false;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            resources.ApplyResources(imageList1, "imageList1");
            imageList1.TransparentColor = Color.Transparent;
            // 
            // Idenitifcacao
            // 
            AcceptButton = okBtn;
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            CancelButton = cancelarBtn;
            ControlBox = false;
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Idenitifcacao";
            ShowIcon = false;
            TopMost = true;
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private Button cancelarBtn;
        private Button okBtn;
        private GroupBox groupBox3;
        private Label label1;
        private TextBox txtUsuario;
        private GroupBox groupBox2;
        private Label label2;
        private Label label3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private ImageList imageList1;
        private TextBox txtSenha;
    }
}
