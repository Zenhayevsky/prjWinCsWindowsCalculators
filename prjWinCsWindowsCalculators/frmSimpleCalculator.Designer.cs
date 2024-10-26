using System.Windows.Forms;

namespace prjWinCsWindowsCalculators
{
    partial class frmSimpleCalculator
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
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnAdition = new System.Windows.Forms.Button();
            this.btnSubstraction = new System.Windows.Forms.Button();
            this.btnMultiplication = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnInverse = new System.Windows.Forms.Button();
            this.btSquare = new System.Windows.Forms.Button();
            this.btnSquareRoot = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btntwo = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnEigth = new System.Windows.Forms.Button();
            this.btnSeven = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.btnPlusToMinus = new System.Windows.Forms.Button();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnPorcent = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblVisor = new System.Windows.Forms.Label();
            this.lblOperation = new System.Windows.Forms.Label();
            this.btnC_Reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEqual
            // 
            this.btnEqual.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEqual.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEqual.FlatAppearance.BorderSize = 0;
            this.btnEqual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEqual.Location = new System.Drawing.Point(402, 574);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(123, 67);
            this.btnEqual.TabIndex = 95;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = false;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // btnAdition
            // 
            this.btnAdition.BackColor = System.Drawing.Color.LightGray;
            this.btnAdition.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdition.FlatAppearance.BorderSize = 0;
            this.btnAdition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdition.Location = new System.Drawing.Point(402, 504);
            this.btnAdition.Name = "btnAdition";
            this.btnAdition.Size = new System.Drawing.Size(123, 67);
            this.btnAdition.TabIndex = 94;
            this.btnAdition.Text = "+";
            this.btnAdition.UseVisualStyleBackColor = false;
            this.btnAdition.Click += new System.EventHandler(this.btnAdition_Click);
            // 
            // btnSubstraction
            // 
            this.btnSubstraction.BackColor = System.Drawing.Color.LightGray;
            this.btnSubstraction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubstraction.FlatAppearance.BorderSize = 0;
            this.btnSubstraction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubstraction.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubstraction.Location = new System.Drawing.Point(402, 434);
            this.btnSubstraction.Name = "btnSubstraction";
            this.btnSubstraction.Size = new System.Drawing.Size(123, 67);
            this.btnSubstraction.TabIndex = 93;
            this.btnSubstraction.Text = "-";
            this.btnSubstraction.UseVisualStyleBackColor = false;
            this.btnSubstraction.Click += new System.EventHandler(this.btnSubstraction_Click);
            // 
            // btnMultiplication
            // 
            this.btnMultiplication.BackColor = System.Drawing.Color.LightGray;
            this.btnMultiplication.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMultiplication.FlatAppearance.BorderSize = 0;
            this.btnMultiplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultiplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplication.Location = new System.Drawing.Point(402, 364);
            this.btnMultiplication.Name = "btnMultiplication";
            this.btnMultiplication.Size = new System.Drawing.Size(123, 67);
            this.btnMultiplication.TabIndex = 92;
            this.btnMultiplication.Text = "x";
            this.btnMultiplication.UseVisualStyleBackColor = false;
            this.btnMultiplication.Click += new System.EventHandler(this.btnMultiplication_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.BackColor = System.Drawing.Color.LightGray;
            this.btnDivision.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDivision.FlatAppearance.BorderSize = 0;
            this.btnDivision.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivision.Location = new System.Drawing.Point(402, 294);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(123, 67);
            this.btnDivision.TabIndex = 91;
            this.btnDivision.Text = "÷";
            this.btnDivision.UseVisualStyleBackColor = false;
            this.btnDivision.Click += new System.EventHandler(this.btnDivision_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.LightGray;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(402, 224);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(123, 67);
            this.btnClear.TabIndex = 90;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDot
            // 
            this.btnDot.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnDot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDot.FlatAppearance.BorderSize = 0;
            this.btnDot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDot.Location = new System.Drawing.Point(276, 574);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(123, 67);
            this.btnDot.TabIndex = 89;
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = false;
            // 
            // btnThree
            // 
            this.btnThree.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnThree.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThree.FlatAppearance.BorderSize = 0;
            this.btnThree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThree.Location = new System.Drawing.Point(276, 504);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(123, 67);
            this.btnThree.TabIndex = 88;
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = false;
            this.btnThree.Click += new System.EventHandler(this.btnThree_Click);
            // 
            // btnInverse
            // 
            this.btnInverse.BackColor = System.Drawing.Color.LightGray;
            this.btnInverse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInverse.FlatAppearance.BorderSize = 0;
            this.btnInverse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInverse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInverse.Location = new System.Drawing.Point(24, 294);
            this.btnInverse.Name = "btnInverse";
            this.btnInverse.Size = new System.Drawing.Size(123, 67);
            this.btnInverse.TabIndex = 87;
            this.btnInverse.Text = "1/x";
            this.btnInverse.UseVisualStyleBackColor = false;
            this.btnInverse.Click += new System.EventHandler(this.btnInverse_Click);
            // 
            // btSquare
            // 
            this.btSquare.BackColor = System.Drawing.Color.LightGray;
            this.btSquare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSquare.FlatAppearance.BorderSize = 0;
            this.btSquare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSquare.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSquare.Location = new System.Drawing.Point(150, 294);
            this.btSquare.Name = "btSquare";
            this.btSquare.Size = new System.Drawing.Size(123, 67);
            this.btSquare.TabIndex = 86;
            this.btSquare.Text = "x²";
            this.btSquare.UseVisualStyleBackColor = false;
            this.btSquare.Click += new System.EventHandler(this.btnSquare_Click);
            // 
            // btnSquareRoot
            // 
            this.btnSquareRoot.BackColor = System.Drawing.Color.LightGray;
            this.btnSquareRoot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSquareRoot.FlatAppearance.BorderSize = 0;
            this.btnSquareRoot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSquareRoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSquareRoot.Location = new System.Drawing.Point(276, 294);
            this.btnSquareRoot.Name = "btnSquareRoot";
            this.btnSquareRoot.Size = new System.Drawing.Size(123, 67);
            this.btnSquareRoot.TabIndex = 85;
            this.btnSquareRoot.Text = "²√x";
            this.btnSquareRoot.UseVisualStyleBackColor = false;
            this.btnSquareRoot.Click += new System.EventHandler(this.btnSquareRoot_Click);
            // 
            // btnZero
            // 
            this.btnZero.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnZero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnZero.FlatAppearance.BorderSize = 0;
            this.btnZero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZero.Location = new System.Drawing.Point(150, 574);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(123, 67);
            this.btnZero.TabIndex = 83;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = false;
            this.btnZero.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // btntwo
            // 
            this.btntwo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btntwo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btntwo.FlatAppearance.BorderSize = 0;
            this.btntwo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntwo.Location = new System.Drawing.Point(150, 504);
            this.btntwo.Name = "btntwo";
            this.btntwo.Size = new System.Drawing.Size(123, 67);
            this.btntwo.TabIndex = 82;
            this.btntwo.Text = "2";
            this.btntwo.UseVisualStyleBackColor = false;
            this.btntwo.Click += new System.EventHandler(this.btntwo_Click);
            // 
            // btnFive
            // 
            this.btnFive.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnFive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFive.FlatAppearance.BorderSize = 0;
            this.btnFive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFive.Location = new System.Drawing.Point(150, 434);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(123, 67);
            this.btnFive.TabIndex = 81;
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = false;
            this.btnFive.Click += new System.EventHandler(this.btnFive_Click);
            // 
            // btnEigth
            // 
            this.btnEigth.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnEigth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEigth.FlatAppearance.BorderSize = 0;
            this.btnEigth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEigth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEigth.Location = new System.Drawing.Point(150, 364);
            this.btnEigth.Name = "btnEigth";
            this.btnEigth.Size = new System.Drawing.Size(123, 67);
            this.btnEigth.TabIndex = 80;
            this.btnEigth.Text = "8";
            this.btnEigth.UseVisualStyleBackColor = false;
            this.btnEigth.Click += new System.EventHandler(this.btnEigth_Click);
            // 
            // btnSeven
            // 
            this.btnSeven.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSeven.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeven.FlatAppearance.BorderSize = 0;
            this.btnSeven.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeven.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeven.Location = new System.Drawing.Point(24, 364);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(123, 67);
            this.btnSeven.TabIndex = 79;
            this.btnSeven.Text = "7";
            this.btnSeven.UseVisualStyleBackColor = false;
            this.btnSeven.Click += new System.EventHandler(this.button8_Click);
            // 
            // btnCE
            // 
            this.btnCE.BackColor = System.Drawing.Color.LightGray;
            this.btnCE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCE.FlatAppearance.BorderSize = 0;
            this.btnCE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCE.Location = new System.Drawing.Point(150, 224);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(123, 67);
            this.btnCE.TabIndex = 78;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = false;
            this.btnCE.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnPlusToMinus
            // 
            this.btnPlusToMinus.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnPlusToMinus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlusToMinus.FlatAppearance.BorderSize = 0;
            this.btnPlusToMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlusToMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlusToMinus.Location = new System.Drawing.Point(24, 574);
            this.btnPlusToMinus.Name = "btnPlusToMinus";
            this.btnPlusToMinus.Size = new System.Drawing.Size(123, 67);
            this.btnPlusToMinus.TabIndex = 77;
            this.btnPlusToMinus.Text = "+/-";
            this.btnPlusToMinus.UseVisualStyleBackColor = false;
            // 
            // btnOne
            // 
            this.btnOne.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnOne.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOne.FlatAppearance.BorderSize = 0;
            this.btnOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOne.Location = new System.Drawing.Point(24, 504);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(123, 67);
            this.btnOne.TabIndex = 76;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = false;
            this.btnOne.Click += new System.EventHandler(this.btnOne_Click);
            // 
            // btnFour
            // 
            this.btnFour.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnFour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFour.FlatAppearance.BorderSize = 0;
            this.btnFour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFour.Location = new System.Drawing.Point(24, 434);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(123, 67);
            this.btnFour.TabIndex = 75;
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = false;
            this.btnFour.Click += new System.EventHandler(this.btnFour_Click);
            // 
            // btnNine
            // 
            this.btnNine.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnNine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNine.FlatAppearance.BorderSize = 0;
            this.btnNine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNine.Location = new System.Drawing.Point(276, 364);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(123, 67);
            this.btnNine.TabIndex = 74;
            this.btnNine.Text = "9";
            this.btnNine.UseVisualStyleBackColor = false;
            this.btnNine.Click += new System.EventHandler(this.btnNine_Click);
            // 
            // btnSix
            // 
            this.btnSix.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSix.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSix.FlatAppearance.BorderSize = 0;
            this.btnSix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSix.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSix.Location = new System.Drawing.Point(276, 434);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(123, 67);
            this.btnSix.TabIndex = 73;
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = false;
            this.btnSix.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnPorcent
            // 
            this.btnPorcent.BackColor = System.Drawing.Color.LightGray;
            this.btnPorcent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPorcent.FlatAppearance.BorderSize = 0;
            this.btnPorcent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPorcent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPorcent.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPorcent.Location = new System.Drawing.Point(24, 224);
            this.btnPorcent.Name = "btnPorcent";
            this.btnPorcent.Size = new System.Drawing.Size(123, 67);
            this.btnPorcent.TabIndex = 72;
            this.btnPorcent.Text = "%";
            this.btnPorcent.UseVisualStyleBackColor = false;
            this.btnPorcent.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(112, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 20);
            this.label7.TabIndex = 71;
            this.label7.Text = "MR";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(206, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 20);
            this.label6.TabIndex = 70;
            this.label6.Text = "M+";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(299, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 20);
            this.label5.TabIndex = 69;
            this.label5.Text = "M-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(398, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 20);
            this.label4.TabIndex = 68;
            this.label4.Text = "MS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(492, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 20);
            this.label3.TabIndex = 67;
            this.label3.Text = "M>";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 20);
            this.label2.TabIndex = 66;
            this.label2.Text = "MC";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 23);
            this.label1.TabIndex = 64;
            this.label1.Text = "Standart";
            // 
            // lblVisor
            // 
            this.lblVisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisor.Location = new System.Drawing.Point(39, 94);
            this.lblVisor.Name = "lblVisor";
            this.lblVisor.Size = new System.Drawing.Size(503, 63);
            this.lblVisor.TabIndex = 96;
            this.lblVisor.Text = "0";
            this.lblVisor.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lblVisor.Click += new System.EventHandler(this.label8_Click);
            // 
            // lblOperation
            // 
            this.lblOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperation.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblOperation.Location = new System.Drawing.Point(11, 59);
            this.lblOperation.Name = "lblOperation";
            this.lblOperation.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblOperation.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblOperation.Size = new System.Drawing.Size(501, 35);
            this.lblOperation.TabIndex = 97;
            this.lblOperation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblOperation.Click += new System.EventHandler(this.lblOperation_Click);
            // 
            // btnC_Reset
            // 
            this.btnC_Reset.BackColor = System.Drawing.Color.LightGray;
            this.btnC_Reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnC_Reset.FlatAppearance.BorderSize = 0;
            this.btnC_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnC_Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC_Reset.Location = new System.Drawing.Point(276, 224);
            this.btnC_Reset.Name = "btnC_Reset";
            this.btnC_Reset.Size = new System.Drawing.Size(123, 67);
            this.btnC_Reset.TabIndex = 98;
            this.btnC_Reset.Text = "C";
            this.btnC_Reset.UseVisualStyleBackColor = false;
            this.btnC_Reset.Click += new System.EventHandler(this.btnC_Rese_Click);
            // 
            // frmSimpleCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(545, 664);
            this.Controls.Add(this.btnC_Reset);
            this.Controls.Add(this.lblOperation);
            this.Controls.Add(this.lblVisor);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btnAdition);
            this.Controls.Add(this.btnSubstraction);
            this.Controls.Add(this.btnMultiplication);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDot);
            this.Controls.Add(this.btnThree);
            this.Controls.Add(this.btnInverse);
            this.Controls.Add(this.btSquare);
            this.Controls.Add(this.btnSquareRoot);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.btntwo);
            this.Controls.Add(this.btnFive);
            this.Controls.Add(this.btnEigth);
            this.Controls.Add(this.btnSeven);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.btnPlusToMinus);
            this.Controls.Add(this.btnOne);
            this.Controls.Add(this.btnFour);
            this.Controls.Add(this.btnNine);
            this.Controls.Add(this.btnSix);
            this.Controls.Add(this.btnPorcent);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmSimpleCalculator";
            this.Text = "frmSimpleCalculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnAdition;
        private System.Windows.Forms.Button btnSubstraction;
        private System.Windows.Forms.Button btnMultiplication;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnInverse;
        private System.Windows.Forms.Button btSquare;
        private System.Windows.Forms.Button btnSquareRoot;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btntwo;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Button btnEigth;
        private System.Windows.Forms.Button btnSeven;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btnPlusToMinus;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Button btnNine;
        private System.Windows.Forms.Button btnSix;
        private System.Windows.Forms.Button btnPorcent;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Label lblVisor;
        private Label lblOperation;
        private Button btnC_Reset;
    }
}