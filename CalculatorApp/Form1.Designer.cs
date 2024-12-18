namespace CalculatorApp
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
			this.txtDisplay = new System.Windows.Forms.TextBox();
			this.txtAnswer = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnDeleteKey = new System.Windows.Forms.PictureBox();
			this.btnStart = new System.Windows.Forms.Button();
			this.btnParenthesis = new System.Windows.Forms.Button();
			this.btnModulas = new System.Windows.Forms.Button();
			this.btnDivide = new System.Windows.Forms.Button();
			this.btnMultiply = new System.Windows.Forms.Button();
			this.btnMinus = new System.Windows.Forms.Button();
			this.btnAddition = new System.Windows.Forms.Button();
			this.btnEquals = new System.Windows.Forms.Button();
			this.btnPeriod = new System.Windows.Forms.Button();
			this.btnZero = new System.Windows.Forms.Button();
			this.btnOne = new System.Windows.Forms.Button();
			this.btnTwo = new System.Windows.Forms.Button();
			this.btnThree = new System.Windows.Forms.Button();
			this.btnFour = new System.Windows.Forms.Button();
			this.btnFive = new System.Windows.Forms.Button();
			this.btnSix = new System.Windows.Forms.Button();
			this.btnSeven = new System.Windows.Forms.Button();
			this.btnEight = new System.Windows.Forms.Button();
			this.btnNine = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.btnDeleteKey)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtDisplay
			// 
			this.txtDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(227)))), ((int)(((byte)(255)))));
			this.txtDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtDisplay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDisplay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(157)))), ((int)(((byte)(255)))));
			this.txtDisplay.Location = new System.Drawing.Point(3, 3);
			this.txtDisplay.Multiline = true;
			this.txtDisplay.Name = "txtDisplay";
			this.txtDisplay.Size = new System.Drawing.Size(262, 58);
			this.txtDisplay.TabIndex = 0;
			this.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// txtAnswer
			// 
			this.txtAnswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(7)))));
			this.txtAnswer.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtAnswer.ForeColor = System.Drawing.Color.Silver;
			this.txtAnswer.Location = new System.Drawing.Point(3, 67);
			this.txtAnswer.Name = "txtAnswer";
			this.txtAnswer.Size = new System.Drawing.Size(262, 13);
			this.txtAnswer.TabIndex = 1;
			this.txtAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Silver;
			this.label1.Location = new System.Drawing.Point(12, 108);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(243, 20);
			this.label1.TabIndex = 2;
			this.label1.Text = "__________________________";
			// 
			// btnDeleteKey
			// 
			this.btnDeleteKey.BackColor = System.Drawing.SystemColors.WindowText;
			this.btnDeleteKey.Image = global::CalculatorApp.Properties.Resources.icons8_delete_key_501;
			this.btnDeleteKey.Location = new System.Drawing.Point(238, 86);
			this.btnDeleteKey.Name = "btnDeleteKey";
			this.btnDeleteKey.Size = new System.Drawing.Size(26, 19);
			this.btnDeleteKey.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.btnDeleteKey.TabIndex = 3;
			this.btnDeleteKey.TabStop = false;
			this.btnDeleteKey.Click += new System.EventHandler(this.btnDeleteKey_Click);
			// 
			// btnStart
			// 
			this.btnStart.BackColor = System.Drawing.Color.Silver;
			this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnStart.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.btnStart.FlatAppearance.BorderSize = 0;
			this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnStart.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnStart.ForeColor = System.Drawing.Color.Red;
			this.btnStart.Location = new System.Drawing.Point(22, 156);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(52, 34);
			this.btnStart.TabIndex = 10;
			this.btnStart.Text = "C";
			this.btnStart.UseVisualStyleBackColor = false;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// btnParenthesis
			// 
			this.btnParenthesis.BackColor = System.Drawing.Color.Silver;
			this.btnParenthesis.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnParenthesis.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.btnParenthesis.FlatAppearance.BorderSize = 0;
			this.btnParenthesis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnParenthesis.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnParenthesis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(46)))));
			this.btnParenthesis.Location = new System.Drawing.Point(79, 156);
			this.btnParenthesis.Name = "btnParenthesis";
			this.btnParenthesis.Size = new System.Drawing.Size(52, 34);
			this.btnParenthesis.TabIndex = 11;
			this.btnParenthesis.Text = "( )";
			this.btnParenthesis.UseVisualStyleBackColor = false;
			this.btnParenthesis.Click += new System.EventHandler(this.btnParenthesis_Click);
			// 
			// btnModulas
			// 
			this.btnModulas.BackColor = System.Drawing.Color.Silver;
			this.btnModulas.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnModulas.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.btnModulas.FlatAppearance.BorderSize = 0;
			this.btnModulas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnModulas.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnModulas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(46)))));
			this.btnModulas.Location = new System.Drawing.Point(137, 156);
			this.btnModulas.Name = "btnModulas";
			this.btnModulas.Size = new System.Drawing.Size(52, 34);
			this.btnModulas.TabIndex = 12;
			this.btnModulas.Text = "%";
			this.btnModulas.UseVisualStyleBackColor = false;
			this.btnModulas.Click += new System.EventHandler(this.btnModulas_Click);
			// 
			// btnDivide
			// 
			this.btnDivide.BackColor = System.Drawing.Color.Silver;
			this.btnDivide.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnDivide.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.btnDivide.FlatAppearance.BorderSize = 0;
			this.btnDivide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDivide.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDivide.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(46)))));
			this.btnDivide.Location = new System.Drawing.Point(195, 156);
			this.btnDivide.Name = "btnDivide";
			this.btnDivide.Size = new System.Drawing.Size(52, 34);
			this.btnDivide.TabIndex = 13;
			this.btnDivide.Text = "÷";
			this.btnDivide.UseVisualStyleBackColor = false;
			this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
			// 
			// btnMultiply
			// 
			this.btnMultiply.BackColor = System.Drawing.Color.Silver;
			this.btnMultiply.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnMultiply.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.btnMultiply.FlatAppearance.BorderSize = 0;
			this.btnMultiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMultiply.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMultiply.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(46)))));
			this.btnMultiply.Location = new System.Drawing.Point(195, 196);
			this.btnMultiply.Name = "btnMultiply";
			this.btnMultiply.Size = new System.Drawing.Size(52, 34);
			this.btnMultiply.TabIndex = 14;
			this.btnMultiply.Text = "X";
			this.btnMultiply.UseVisualStyleBackColor = false;
			this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
			// 
			// btnMinus
			// 
			this.btnMinus.BackColor = System.Drawing.Color.Silver;
			this.btnMinus.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnMinus.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.btnMinus.FlatAppearance.BorderSize = 0;
			this.btnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMinus.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMinus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(46)))));
			this.btnMinus.Location = new System.Drawing.Point(195, 236);
			this.btnMinus.Name = "btnMinus";
			this.btnMinus.Size = new System.Drawing.Size(52, 34);
			this.btnMinus.TabIndex = 14;
			this.btnMinus.Text = "-";
			this.btnMinus.UseVisualStyleBackColor = false;
			this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
			// 
			// btnAddition
			// 
			this.btnAddition.BackColor = System.Drawing.Color.Silver;
			this.btnAddition.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAddition.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.btnAddition.FlatAppearance.BorderSize = 0;
			this.btnAddition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAddition.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAddition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(46)))));
			this.btnAddition.Location = new System.Drawing.Point(195, 276);
			this.btnAddition.Name = "btnAddition";
			this.btnAddition.Size = new System.Drawing.Size(52, 34);
			this.btnAddition.TabIndex = 15;
			this.btnAddition.Text = "+";
			this.btnAddition.UseVisualStyleBackColor = false;
			this.btnAddition.Click += new System.EventHandler(this.btnAddition_Click);
			// 
			// btnEquals
			// 
			this.btnEquals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(46)))));
			this.btnEquals.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnEquals.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.btnEquals.FlatAppearance.BorderSize = 0;
			this.btnEquals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEquals.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEquals.ForeColor = System.Drawing.Color.Black;
			this.btnEquals.Location = new System.Drawing.Point(195, 316);
			this.btnEquals.Name = "btnEquals";
			this.btnEquals.Size = new System.Drawing.Size(52, 34);
			this.btnEquals.TabIndex = 16;
			this.btnEquals.Text = "=";
			this.btnEquals.UseVisualStyleBackColor = false;
			this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);
			// 
			// btnPeriod
			// 
			this.btnPeriod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(227)))), ((int)(((byte)(255)))));
			this.btnPeriod.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnPeriod.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.btnPeriod.FlatAppearance.BorderSize = 0;
			this.btnPeriod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPeriod.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPeriod.ForeColor = System.Drawing.Color.Black;
			this.btnPeriod.Location = new System.Drawing.Point(136, 316);
			this.btnPeriod.Name = "btnPeriod";
			this.btnPeriod.Size = new System.Drawing.Size(52, 34);
			this.btnPeriod.TabIndex = 17;
			this.btnPeriod.Text = ".";
			this.btnPeriod.UseVisualStyleBackColor = false;
			this.btnPeriod.Click += new System.EventHandler(this.btnPeriod_Click);
			// 
			// btnZero
			// 
			this.btnZero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(227)))), ((int)(((byte)(255)))));
			this.btnZero.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnZero.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.btnZero.FlatAppearance.BorderSize = 0;
			this.btnZero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnZero.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnZero.ForeColor = System.Drawing.Color.Black;
			this.btnZero.Location = new System.Drawing.Point(21, 316);
			this.btnZero.Name = "btnZero";
			this.btnZero.Size = new System.Drawing.Size(109, 34);
			this.btnZero.TabIndex = 0;
			this.btnZero.Text = "0";
			this.btnZero.UseVisualStyleBackColor = false;
			this.btnZero.Click += new System.EventHandler(this.btnZero_Click);
			// 
			// btnOne
			// 
			this.btnOne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(227)))), ((int)(((byte)(255)))));
			this.btnOne.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnOne.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.btnOne.FlatAppearance.BorderSize = 0;
			this.btnOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnOne.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOne.ForeColor = System.Drawing.Color.Black;
			this.btnOne.Location = new System.Drawing.Point(21, 276);
			this.btnOne.Name = "btnOne";
			this.btnOne.Size = new System.Drawing.Size(52, 34);
			this.btnOne.TabIndex = 1;
			this.btnOne.Text = "1";
			this.btnOne.UseVisualStyleBackColor = false;
			this.btnOne.Click += new System.EventHandler(this.btnOne_Click);
			// 
			// btnTwo
			// 
			this.btnTwo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(227)))), ((int)(((byte)(255)))));
			this.btnTwo.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnTwo.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.btnTwo.FlatAppearance.BorderSize = 0;
			this.btnTwo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnTwo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTwo.ForeColor = System.Drawing.Color.Black;
			this.btnTwo.Location = new System.Drawing.Point(79, 276);
			this.btnTwo.Name = "btnTwo";
			this.btnTwo.Size = new System.Drawing.Size(52, 34);
			this.btnTwo.TabIndex = 2;
			this.btnTwo.Text = "2";
			this.btnTwo.UseVisualStyleBackColor = false;
			this.btnTwo.Click += new System.EventHandler(this.btnTwo_Click);
			// 
			// btnThree
			// 
			this.btnThree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(227)))), ((int)(((byte)(255)))));
			this.btnThree.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnThree.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.btnThree.FlatAppearance.BorderSize = 0;
			this.btnThree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnThree.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThree.ForeColor = System.Drawing.Color.Black;
			this.btnThree.Location = new System.Drawing.Point(137, 276);
			this.btnThree.Name = "btnThree";
			this.btnThree.Size = new System.Drawing.Size(52, 34);
			this.btnThree.TabIndex = 3;
			this.btnThree.Text = "3";
			this.btnThree.UseVisualStyleBackColor = false;
			this.btnThree.Click += new System.EventHandler(this.btnThree_Click);
			// 
			// btnFour
			// 
			this.btnFour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(227)))), ((int)(((byte)(255)))));
			this.btnFour.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnFour.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.btnFour.FlatAppearance.BorderSize = 0;
			this.btnFour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFour.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFour.ForeColor = System.Drawing.Color.Black;
			this.btnFour.Location = new System.Drawing.Point(21, 236);
			this.btnFour.Name = "btnFour";
			this.btnFour.Size = new System.Drawing.Size(52, 34);
			this.btnFour.TabIndex = 4;
			this.btnFour.Text = "4";
			this.btnFour.UseVisualStyleBackColor = false;
			this.btnFour.Click += new System.EventHandler(this.btnFour_Click);
			// 
			// btnFive
			// 
			this.btnFive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(227)))), ((int)(((byte)(255)))));
			this.btnFive.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnFive.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.btnFive.FlatAppearance.BorderSize = 0;
			this.btnFive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFive.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFive.ForeColor = System.Drawing.Color.Black;
			this.btnFive.Location = new System.Drawing.Point(79, 236);
			this.btnFive.Name = "btnFive";
			this.btnFive.Size = new System.Drawing.Size(52, 34);
			this.btnFive.TabIndex = 5;
			this.btnFive.Text = "5";
			this.btnFive.UseVisualStyleBackColor = false;
			this.btnFive.Click += new System.EventHandler(this.btnFive_Click);
			// 
			// btnSix
			// 
			this.btnSix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(227)))), ((int)(((byte)(255)))));
			this.btnSix.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSix.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.btnSix.FlatAppearance.BorderSize = 0;
			this.btnSix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSix.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSix.ForeColor = System.Drawing.Color.Black;
			this.btnSix.Location = new System.Drawing.Point(137, 236);
			this.btnSix.Name = "btnSix";
			this.btnSix.Size = new System.Drawing.Size(52, 34);
			this.btnSix.TabIndex = 6;
			this.btnSix.Text = "6";
			this.btnSix.UseVisualStyleBackColor = false;
			this.btnSix.Click += new System.EventHandler(this.btnSix_Click);
			// 
			// btnSeven
			// 
			this.btnSeven.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(227)))), ((int)(((byte)(255)))));
			this.btnSeven.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSeven.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.btnSeven.FlatAppearance.BorderSize = 0;
			this.btnSeven.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSeven.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSeven.ForeColor = System.Drawing.Color.Black;
			this.btnSeven.Location = new System.Drawing.Point(21, 196);
			this.btnSeven.Name = "btnSeven";
			this.btnSeven.Size = new System.Drawing.Size(52, 34);
			this.btnSeven.TabIndex = 7;
			this.btnSeven.Text = "7";
			this.btnSeven.UseVisualStyleBackColor = false;
			this.btnSeven.Click += new System.EventHandler(this.btnSeven_Click);
			// 
			// btnEight
			// 
			this.btnEight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(227)))), ((int)(((byte)(255)))));
			this.btnEight.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnEight.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.btnEight.FlatAppearance.BorderSize = 0;
			this.btnEight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEight.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEight.ForeColor = System.Drawing.Color.Black;
			this.btnEight.Location = new System.Drawing.Point(79, 196);
			this.btnEight.Name = "btnEight";
			this.btnEight.Size = new System.Drawing.Size(52, 34);
			this.btnEight.TabIndex = 8;
			this.btnEight.Text = "8";
			this.btnEight.UseVisualStyleBackColor = false;
			this.btnEight.Click += new System.EventHandler(this.btnEight_Click);
			// 
			// btnNine
			// 
			this.btnNine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(227)))), ((int)(((byte)(255)))));
			this.btnNine.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnNine.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.btnNine.FlatAppearance.BorderSize = 0;
			this.btnNine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNine.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNine.ForeColor = System.Drawing.Color.Black;
			this.btnNine.Location = new System.Drawing.Point(137, 196);
			this.btnNine.Name = "btnNine";
			this.btnNine.Size = new System.Drawing.Size(52, 34);
			this.btnNine.TabIndex = 9;
			this.btnNine.Text = "9";
			this.btnNine.UseVisualStyleBackColor = false;
			this.btnNine.Click += new System.EventHandler(this.btnNine_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(7)))));
			this.panel1.Controls.Add(this.btnNine);
			this.panel1.Controls.Add(this.btnEight);
			this.panel1.Controls.Add(this.btnSeven);
			this.panel1.Controls.Add(this.btnSix);
			this.panel1.Controls.Add(this.btnFive);
			this.panel1.Controls.Add(this.btnFour);
			this.panel1.Controls.Add(this.btnThree);
			this.panel1.Controls.Add(this.btnTwo);
			this.panel1.Controls.Add(this.btnOne);
			this.panel1.Controls.Add(this.btnZero);
			this.panel1.Controls.Add(this.btnPeriod);
			this.panel1.Controls.Add(this.btnEquals);
			this.panel1.Controls.Add(this.btnAddition);
			this.panel1.Controls.Add(this.btnMinus);
			this.panel1.Controls.Add(this.btnMultiply);
			this.panel1.Controls.Add(this.btnDivide);
			this.panel1.Controls.Add(this.btnModulas);
			this.panel1.Controls.Add(this.btnParenthesis);
			this.panel1.Controls.Add(this.btnStart);
			this.panel1.Controls.Add(this.btnDeleteKey);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.txtAnswer);
			this.panel1.Controls.Add(this.txtDisplay);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(267, 397);
			this.panel1.TabIndex = 3;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(96)))), ((int)(((byte)(101)))));
			this.ClientSize = new System.Drawing.Size(291, 420);
			this.Controls.Add(this.panel1);
			this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Calculator";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
			((System.ComponentModel.ISupportInitialize)(this.btnDeleteKey)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnDeleteKey;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnParenthesis;
        private System.Windows.Forms.Button btnModulas;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnAddition;
        private System.Windows.Forms.Button btnEquals;
        private System.Windows.Forms.Button btnPeriod;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Button btnSix;
        private System.Windows.Forms.Button btnSeven;
        private System.Windows.Forms.Button btnEight;
        private System.Windows.Forms.Button btnNine;
        private System.Windows.Forms.Panel panel1;
    }
}

