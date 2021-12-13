namespace WindowsFormsApp5
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label7 = new System.Windows.Forms.Label();
            this.labelNapisAktualnyProdukt = new System.Windows.Forms.Label();
            this.labelAktualnyProdukt = new System.Windows.Forms.Label();
            this.radioButtonLinky = new System.Windows.Forms.RadioButton();
            this.radioButtonSmets = new System.Windows.Forms.RadioButton();
            this.radioButtonCyble8 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonCyble12 = new System.Windows.Forms.RadioButton();
            this.labelStatus101 = new System.Windows.Forms.Label();
            this.buttonModbusTest = new System.Windows.Forms.Button();
            this.buttonTrigScan101 = new System.Windows.Forms.Button();
            this.labelBufor101 = new System.Windows.Forms.Label();
            this.labelStatus100 = new System.Windows.Forms.Label();
            this.labelNapisStatusSkaner101 = new System.Windows.Forms.Label();
            this.labelNapisStatusSkaner100 = new System.Windows.Forms.Label();
            this.labelBufor100 = new System.Windows.Forms.Label();
            this.buttonTrigScan100 = new System.Windows.Forms.Button();
            this.labelDescription1 = new System.Windows.Forms.Label();
            this.labelDescription2 = new System.Windows.Forms.Label();
            this.labelDescription3 = new System.Windows.Forms.Label();
            this.labelDescription4 = new System.Windows.Forms.Label();
            this.labelDescription5 = new System.Windows.Forms.Label();
            this.labelDescription6 = new System.Windows.Forms.Label();
            this.labelDescription7 = new System.Windows.Forms.Label();
            this.labelDescription8 = new System.Windows.Forms.Label();
            this.labelDescription9 = new System.Windows.Forms.Label();
            this.labelDescription10 = new System.Windows.Forms.Label();
            this.labelDescription11 = new System.Windows.Forms.Label();
            this.labelDescription12 = new System.Windows.Forms.Label();
            this.labelBarcode1 = new System.Windows.Forms.Label();
            this.labelBarcode2 = new System.Windows.Forms.Label();
            this.labelBarcode3 = new System.Windows.Forms.Label();
            this.labelBarcode4 = new System.Windows.Forms.Label();
            this.labelBarcode5 = new System.Windows.Forms.Label();
            this.labelBarcode6 = new System.Windows.Forms.Label();
            this.labelBarcode7 = new System.Windows.Forms.Label();
            this.labelBarcode8 = new System.Windows.Forms.Label();
            this.labelBarcode9 = new System.Windows.Forms.Label();
            this.labelBarcode10 = new System.Windows.Forms.Label();
            this.labelBarcode11 = new System.Windows.Forms.Label();
            this.labelBarcode12 = new System.Windows.Forms.Label();
            this.labelUnused = new System.Windows.Forms.Label();
            this.labelUnused2 = new System.Windows.Forms.Label();
            this.buttonActuator = new System.Windows.Forms.Button();
            this.labelCoverUTR = new System.Windows.Forms.Label();
            this.labelNapisUTR = new System.Windows.Forms.Label();
            this.textBoxUtr = new System.Windows.Forms.TextBox();
            this.textBoxLot = new System.Windows.Forms.TextBox();
            this.labelNapisPodajLot = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1162, 110);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "  ";
            // 
            // labelNapisAktualnyProdukt
            // 
            this.labelNapisAktualnyProdukt.AutoSize = true;
            this.labelNapisAktualnyProdukt.BackColor = System.Drawing.SystemColors.Info;
            this.labelNapisAktualnyProdukt.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNapisAktualnyProdukt.Location = new System.Drawing.Point(889, 10);
            this.labelNapisAktualnyProdukt.Name = "labelNapisAktualnyProdukt";
            this.labelNapisAktualnyProdukt.Size = new System.Drawing.Size(356, 51);
            this.labelNapisAktualnyProdukt.TabIndex = 19;
            this.labelNapisAktualnyProdukt.Text = "Aktualny produkt:";
            // 
            // labelAktualnyProdukt
            // 
            this.labelAktualnyProdukt.AutoSize = true;
            this.labelAktualnyProdukt.BackColor = System.Drawing.SystemColors.Window;
            this.labelAktualnyProdukt.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAktualnyProdukt.Location = new System.Drawing.Point(889, 66);
            this.labelAktualnyProdukt.Name = "labelAktualnyProdukt";
            this.labelAktualnyProdukt.Size = new System.Drawing.Size(258, 37);
            this.labelAktualnyProdukt.TabIndex = 20;
            this.labelAktualnyProdukt.Text = "Wybierz produkt!";
            // 
            // radioButtonLinky
            // 
            this.radioButtonLinky.AutoSize = true;
            this.radioButtonLinky.Location = new System.Drawing.Point(11, 52);
            this.radioButtonLinky.Name = "radioButtonLinky";
            this.radioButtonLinky.Size = new System.Drawing.Size(144, 33);
            this.radioButtonLinky.TabIndex = 21;
            this.radioButtonLinky.Text = "LinkyT2P2";
            this.radioButtonLinky.UseVisualStyleBackColor = true;
            this.radioButtonLinky.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButtonSmets
            // 
            this.radioButtonSmets.AutoSize = true;
            this.radioButtonSmets.Location = new System.Drawing.Point(11, 93);
            this.radioButtonSmets.Name = "radioButtonSmets";
            this.radioButtonSmets.Size = new System.Drawing.Size(112, 33);
            this.radioButtonSmets.TabIndex = 21;
            this.radioButtonSmets.Text = "Smets2";
            this.radioButtonSmets.UseVisualStyleBackColor = true;
            this.radioButtonSmets.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButtonCyble8
            // 
            this.radioButtonCyble8.AutoSize = true;
            this.radioButtonCyble8.Location = new System.Drawing.Point(11, 134);
            this.radioButtonCyble8.Name = "radioButtonCyble8";
            this.radioButtonCyble8.Size = new System.Drawing.Size(190, 33);
            this.radioButtonCyble8.TabIndex = 21;
            this.radioButtonCyble8.Text = "Cyble 8 kodów";
            this.radioButtonCyble8.UseVisualStyleBackColor = true;
            this.radioButtonCyble8.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonLinky);
            this.groupBox1.Controls.Add(this.radioButtonCyble12);
            this.groupBox1.Controls.Add(this.radioButtonCyble8);
            this.groupBox1.Controls.Add(this.radioButtonSmets);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(892, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 235);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wybierz produkt";
            // 
            // radioButtonCyble12
            // 
            this.radioButtonCyble12.AutoSize = true;
            this.radioButtonCyble12.Location = new System.Drawing.Point(11, 175);
            this.radioButtonCyble12.Name = "radioButtonCyble12";
            this.radioButtonCyble12.Size = new System.Drawing.Size(203, 33);
            this.radioButtonCyble12.TabIndex = 21;
            this.radioButtonCyble12.Text = "Cyble 12 kodów";
            this.radioButtonCyble12.UseVisualStyleBackColor = true;
            this.radioButtonCyble12.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // labelStatus101
            // 
            this.labelStatus101.AutoSize = true;
            this.labelStatus101.Location = new System.Drawing.Point(15, 43);
            this.labelStatus101.Name = "labelStatus101";
            this.labelStatus101.Size = new System.Drawing.Size(61, 13);
            this.labelStatus101.TabIndex = 24;
            this.labelStatus101.Text = "Połączenie";
            // 
            // buttonModbusTest
            // 
            this.buttonModbusTest.Location = new System.Drawing.Point(1080, 528);
            this.buttonModbusTest.Name = "buttonModbusTest";
            this.buttonModbusTest.Size = new System.Drawing.Size(77, 39);
            this.buttonModbusTest.TabIndex = 25;
            this.buttonModbusTest.Text = "modbus_test";
            this.buttonModbusTest.UseVisualStyleBackColor = true;
            this.buttonModbusTest.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonTrigScan101
            // 
            this.buttonTrigScan101.Location = new System.Drawing.Point(887, 528);
            this.buttonTrigScan101.Name = "buttonTrigScan101";
            this.buttonTrigScan101.Size = new System.Drawing.Size(75, 39);
            this.buttonTrigScan101.TabIndex = 27;
            this.buttonTrigScan101.Text = "wyzwolenie skaner101";
            this.buttonTrigScan101.UseVisualStyleBackColor = true;
            this.buttonTrigScan101.Click += new System.EventHandler(this.button4_Click);
            // 
            // labelBufor101
            // 
            this.labelBufor101.BackColor = System.Drawing.SystemColors.Info;
            this.labelBufor101.Location = new System.Drawing.Point(8, 365);
            this.labelBufor101.Name = "labelBufor101";
            this.labelBufor101.Size = new System.Drawing.Size(420, 216);
            this.labelBufor101.TabIndex = 29;
            this.labelBufor101.Text = "Bufor skanera 101";
            // 
            // labelStatus100
            // 
            this.labelStatus100.AutoSize = true;
            this.labelStatus100.Location = new System.Drawing.Point(446, 43);
            this.labelStatus100.Name = "labelStatus100";
            this.labelStatus100.Size = new System.Drawing.Size(61, 13);
            this.labelStatus100.TabIndex = 30;
            this.labelStatus100.Text = "Połączenie";
            // 
            // labelNapisStatusSkaner101
            // 
            this.labelNapisStatusSkaner101.AutoSize = true;
            this.labelNapisStatusSkaner101.BackColor = System.Drawing.SystemColors.Window;
            this.labelNapisStatusSkaner101.Location = new System.Drawing.Point(15, 12);
            this.labelNapisStatusSkaner101.Name = "labelNapisStatusSkaner101";
            this.labelNapisStatusSkaner101.Size = new System.Drawing.Size(93, 13);
            this.labelNapisStatusSkaner101.TabIndex = 28;
            this.labelNapisStatusSkaner101.Text = "Status skaner 101";
            // 
            // labelNapisStatusSkaner100
            // 
            this.labelNapisStatusSkaner100.AutoSize = true;
            this.labelNapisStatusSkaner100.BackColor = System.Drawing.SystemColors.Window;
            this.labelNapisStatusSkaner100.Location = new System.Drawing.Point(446, 12);
            this.labelNapisStatusSkaner100.Name = "labelNapisStatusSkaner100";
            this.labelNapisStatusSkaner100.Size = new System.Drawing.Size(93, 13);
            this.labelNapisStatusSkaner100.TabIndex = 28;
            this.labelNapisStatusSkaner100.Text = "Status skaner 100";
            // 
            // labelBufor100
            // 
            this.labelBufor100.BackColor = System.Drawing.SystemColors.Info;
            this.labelBufor100.Location = new System.Drawing.Point(439, 365);
            this.labelBufor100.Name = "labelBufor100";
            this.labelBufor100.Size = new System.Drawing.Size(420, 216);
            this.labelBufor100.TabIndex = 29;
            this.labelBufor100.Text = "Bufor skanera 100";
            // 
            // buttonTrigScan100
            // 
            this.buttonTrigScan100.Location = new System.Drawing.Point(984, 528);
            this.buttonTrigScan100.Name = "buttonTrigScan100";
            this.buttonTrigScan100.Size = new System.Drawing.Size(75, 39);
            this.buttonTrigScan100.TabIndex = 31;
            this.buttonTrigScan100.Text = "wyzwolenie skaner 100";
            this.buttonTrigScan100.UseVisualStyleBackColor = true;
            this.buttonTrigScan100.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // labelDescription1
            // 
            this.labelDescription1.AutoSize = true;
            this.labelDescription1.Location = new System.Drawing.Point(11, 100);
            this.labelDescription1.Name = "labelDescription1";
            this.labelDescription1.Size = new System.Drawing.Size(49, 13);
            this.labelDescription1.TabIndex = 33;
            this.labelDescription1.Text = "barkod1:";
            // 
            // labelDescription2
            // 
            this.labelDescription2.AutoSize = true;
            this.labelDescription2.Location = new System.Drawing.Point(11, 141);
            this.labelDescription2.Name = "labelDescription2";
            this.labelDescription2.Size = new System.Drawing.Size(49, 13);
            this.labelDescription2.TabIndex = 33;
            this.labelDescription2.Text = "barkod2:";
            // 
            // labelDescription3
            // 
            this.labelDescription3.AutoSize = true;
            this.labelDescription3.Location = new System.Drawing.Point(11, 179);
            this.labelDescription3.Name = "labelDescription3";
            this.labelDescription3.Size = new System.Drawing.Size(49, 13);
            this.labelDescription3.TabIndex = 33;
            this.labelDescription3.Text = "barkod3:";
            // 
            // labelDescription4
            // 
            this.labelDescription4.AutoSize = true;
            this.labelDescription4.Location = new System.Drawing.Point(11, 219);
            this.labelDescription4.Name = "labelDescription4";
            this.labelDescription4.Size = new System.Drawing.Size(49, 13);
            this.labelDescription4.TabIndex = 33;
            this.labelDescription4.Text = "barkod4:";
            // 
            // labelDescription5
            // 
            this.labelDescription5.AutoSize = true;
            this.labelDescription5.Location = new System.Drawing.Point(11, 260);
            this.labelDescription5.Name = "labelDescription5";
            this.labelDescription5.Size = new System.Drawing.Size(49, 13);
            this.labelDescription5.TabIndex = 33;
            this.labelDescription5.Text = "barkod5:";
            // 
            // labelDescription6
            // 
            this.labelDescription6.AutoSize = true;
            this.labelDescription6.Location = new System.Drawing.Point(11, 298);
            this.labelDescription6.Name = "labelDescription6";
            this.labelDescription6.Size = new System.Drawing.Size(49, 13);
            this.labelDescription6.TabIndex = 33;
            this.labelDescription6.Text = "barkod6:";
            // 
            // labelDescription7
            // 
            this.labelDescription7.AutoSize = true;
            this.labelDescription7.Location = new System.Drawing.Point(440, 100);
            this.labelDescription7.Name = "labelDescription7";
            this.labelDescription7.Size = new System.Drawing.Size(49, 13);
            this.labelDescription7.TabIndex = 33;
            this.labelDescription7.Text = "barkod7:";
            // 
            // labelDescription8
            // 
            this.labelDescription8.AutoSize = true;
            this.labelDescription8.Location = new System.Drawing.Point(439, 140);
            this.labelDescription8.Name = "labelDescription8";
            this.labelDescription8.Size = new System.Drawing.Size(49, 13);
            this.labelDescription8.TabIndex = 33;
            this.labelDescription8.Text = "barkod8:";
            // 
            // labelDescription9
            // 
            this.labelDescription9.AutoSize = true;
            this.labelDescription9.Location = new System.Drawing.Point(439, 178);
            this.labelDescription9.Name = "labelDescription9";
            this.labelDescription9.Size = new System.Drawing.Size(49, 13);
            this.labelDescription9.TabIndex = 33;
            this.labelDescription9.Text = "barkod9:";
            // 
            // labelDescription10
            // 
            this.labelDescription10.AutoSize = true;
            this.labelDescription10.Location = new System.Drawing.Point(439, 217);
            this.labelDescription10.Name = "labelDescription10";
            this.labelDescription10.Size = new System.Drawing.Size(55, 13);
            this.labelDescription10.TabIndex = 33;
            this.labelDescription10.Text = "barkod10:";
            // 
            // labelDescription11
            // 
            this.labelDescription11.AutoSize = true;
            this.labelDescription11.Location = new System.Drawing.Point(439, 258);
            this.labelDescription11.Name = "labelDescription11";
            this.labelDescription11.Size = new System.Drawing.Size(55, 13);
            this.labelDescription11.TabIndex = 33;
            this.labelDescription11.Text = "barkod11:";
            // 
            // labelDescription12
            // 
            this.labelDescription12.AutoSize = true;
            this.labelDescription12.Location = new System.Drawing.Point(440, 297);
            this.labelDescription12.Name = "labelDescription12";
            this.labelDescription12.Size = new System.Drawing.Size(55, 13);
            this.labelDescription12.TabIndex = 33;
            this.labelDescription12.Text = "barkod12:";
            // 
            // labelBarcode1
            // 
            this.labelBarcode1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBarcode1.Location = new System.Drawing.Point(68, 92);
            this.labelBarcode1.Name = "labelBarcode1";
            this.labelBarcode1.Size = new System.Drawing.Size(344, 28);
            this.labelBarcode1.TabIndex = 34;
            this.labelBarcode1.Text = "barkod1";
            // 
            // labelBarcode2
            // 
            this.labelBarcode2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBarcode2.Location = new System.Drawing.Point(68, 133);
            this.labelBarcode2.Name = "labelBarcode2";
            this.labelBarcode2.Size = new System.Drawing.Size(344, 28);
            this.labelBarcode2.TabIndex = 34;
            this.labelBarcode2.Text = "barkod2";
            this.labelBarcode2.Click += new System.EventHandler(this.label_barkod2_Click);
            // 
            // labelBarcode3
            // 
            this.labelBarcode3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBarcode3.Location = new System.Drawing.Point(68, 173);
            this.labelBarcode3.Name = "labelBarcode3";
            this.labelBarcode3.Size = new System.Drawing.Size(344, 28);
            this.labelBarcode3.TabIndex = 34;
            this.labelBarcode3.Text = "barkod3";
            // 
            // labelBarcode4
            // 
            this.labelBarcode4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBarcode4.Location = new System.Drawing.Point(68, 213);
            this.labelBarcode4.Name = "labelBarcode4";
            this.labelBarcode4.Size = new System.Drawing.Size(344, 28);
            this.labelBarcode4.TabIndex = 34;
            this.labelBarcode4.Text = "barkod4";
            // 
            // labelBarcode5
            // 
            this.labelBarcode5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBarcode5.Location = new System.Drawing.Point(68, 253);
            this.labelBarcode5.Name = "labelBarcode5";
            this.labelBarcode5.Size = new System.Drawing.Size(344, 28);
            this.labelBarcode5.TabIndex = 34;
            this.labelBarcode5.Text = "barkod5";
            // 
            // labelBarcode6
            // 
            this.labelBarcode6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBarcode6.Location = new System.Drawing.Point(68, 292);
            this.labelBarcode6.Name = "labelBarcode6";
            this.labelBarcode6.Size = new System.Drawing.Size(344, 28);
            this.labelBarcode6.TabIndex = 34;
            this.labelBarcode6.Text = "barkod5";
            // 
            // labelBarcode7
            // 
            this.labelBarcode7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBarcode7.Location = new System.Drawing.Point(500, 94);
            this.labelBarcode7.Name = "labelBarcode7";
            this.labelBarcode7.Size = new System.Drawing.Size(344, 28);
            this.labelBarcode7.TabIndex = 34;
            this.labelBarcode7.Text = "barkod7";
            // 
            // labelBarcode8
            // 
            this.labelBarcode8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBarcode8.Location = new System.Drawing.Point(500, 133);
            this.labelBarcode8.Name = "labelBarcode8";
            this.labelBarcode8.Size = new System.Drawing.Size(344, 28);
            this.labelBarcode8.TabIndex = 34;
            this.labelBarcode8.Text = "barkod8";
            // 
            // labelBarcode9
            // 
            this.labelBarcode9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBarcode9.Location = new System.Drawing.Point(500, 173);
            this.labelBarcode9.Name = "labelBarcode9";
            this.labelBarcode9.Size = new System.Drawing.Size(344, 28);
            this.labelBarcode9.TabIndex = 34;
            this.labelBarcode9.Text = "barkod9";
            // 
            // labelBarcode10
            // 
            this.labelBarcode10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBarcode10.Location = new System.Drawing.Point(500, 213);
            this.labelBarcode10.Name = "labelBarcode10";
            this.labelBarcode10.Size = new System.Drawing.Size(344, 28);
            this.labelBarcode10.TabIndex = 34;
            this.labelBarcode10.Text = "barkod10";
            // 
            // labelBarcode11
            // 
            this.labelBarcode11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBarcode11.Location = new System.Drawing.Point(500, 253);
            this.labelBarcode11.Name = "labelBarcode11";
            this.labelBarcode11.Size = new System.Drawing.Size(344, 28);
            this.labelBarcode11.TabIndex = 34;
            this.labelBarcode11.Text = "barkod11";
            // 
            // labelBarcode12
            // 
            this.labelBarcode12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBarcode12.Location = new System.Drawing.Point(500, 292);
            this.labelBarcode12.Name = "labelBarcode12";
            this.labelBarcode12.Size = new System.Drawing.Size(344, 28);
            this.labelBarcode12.TabIndex = 34;
            this.labelBarcode12.Text = "barkod12";
            // 
            // labelUnused
            // 
            this.labelUnused.BackColor = System.Drawing.SystemColors.HighlightText;
            this.labelUnused.Location = new System.Drawing.Point(8, 66);
            this.labelUnused.Name = "labelUnused";
            this.labelUnused.Size = new System.Drawing.Size(420, 281);
            this.labelUnused.TabIndex = 35;
            this.labelUnused.Text = "        ";
            // 
            // labelUnused2
            // 
            this.labelUnused2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.labelUnused2.Location = new System.Drawing.Point(436, 66);
            this.labelUnused2.Name = "labelUnused2";
            this.labelUnused2.Size = new System.Drawing.Size(420, 281);
            this.labelUnused2.TabIndex = 35;
            this.labelUnused2.Text = "        ";
            // 
            // buttonActuator
            // 
            this.buttonActuator.Location = new System.Drawing.Point(1179, 528);
            this.buttonActuator.Name = "buttonActuator";
            this.buttonActuator.Size = new System.Drawing.Size(75, 37);
            this.buttonActuator.TabIndex = 37;
            this.buttonActuator.Text = "wysun silownik";
            this.buttonActuator.UseVisualStyleBackColor = true;
            this.buttonActuator.Click += new System.EventHandler(this.button5_Click);
            // 
            // labelCoverUTR
            // 
            this.labelCoverUTR.Location = new System.Drawing.Point(864, 431);
            this.labelCoverUTR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCoverUTR.Name = "labelCoverUTR";
            this.labelCoverUTR.Size = new System.Drawing.Size(414, 150);
            this.labelCoverUTR.TabIndex = 38;
            this.labelCoverUTR.Text = "                         ";
            // 
            // labelNapisUTR
            // 
            this.labelNapisUTR.AutoSize = true;
            this.labelNapisUTR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNapisUTR.Location = new System.Drawing.Point(1110, 350);
            this.labelNapisUTR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNapisUTR.Name = "labelNapisUTR";
            this.labelNapisUTR.Size = new System.Drawing.Size(74, 17);
            this.labelNapisUTR.TabIndex = 39;
            this.labelNapisUTR.Text = "Tryb_UTR";
            // 
            // textBoxUtr
            // 
            this.textBoxUtr.Location = new System.Drawing.Point(1113, 369);
            this.textBoxUtr.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxUtr.Name = "textBoxUtr";
            this.textBoxUtr.Size = new System.Drawing.Size(127, 20);
            this.textBoxUtr.TabIndex = 40;
            this.textBoxUtr.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxLot
            // 
            this.textBoxLot.Location = new System.Drawing.Point(892, 369);
            this.textBoxLot.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxLot.MaxLength = 10;
            this.textBoxLot.Name = "textBoxLot";
            this.textBoxLot.Size = new System.Drawing.Size(174, 20);
            this.textBoxLot.TabIndex = 41;
            this.textBoxLot.Visible = false;
            this.textBoxLot.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            // 
            // labelNapisPodajLot
            // 
            this.labelNapisPodajLot.AutoSize = true;
            this.labelNapisPodajLot.Location = new System.Drawing.Point(895, 350);
            this.labelNapisPodajLot.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNapisPodajLot.Name = "labelNapisPodajLot";
            this.labelNapisPodajLot.Size = new System.Drawing.Size(124, 13);
            this.labelNapisPodajLot.TabIndex = 42;
            this.labelNapisPodajLot.Text = "Podaj numer LOT baterii:";
            this.labelNapisPodajLot.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(990, 458);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(194, 20);
            this.textBox1.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(994, 440);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "nadaj recznie:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1330, 594);
            this.Controls.Add(this.labelCoverUTR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelNapisPodajLot);
            this.Controls.Add(this.textBoxLot);
            this.Controls.Add(this.textBoxUtr);
            this.Controls.Add(this.labelNapisUTR);
            this.Controls.Add(this.buttonActuator);
            this.Controls.Add(this.labelBarcode12);
            this.Controls.Add(this.labelBarcode6);
            this.Controls.Add(this.labelBarcode11);
            this.Controls.Add(this.labelBarcode10);
            this.Controls.Add(this.labelBarcode5);
            this.Controls.Add(this.labelBarcode9);
            this.Controls.Add(this.labelBarcode4);
            this.Controls.Add(this.labelBarcode8);
            this.Controls.Add(this.labelBarcode3);
            this.Controls.Add(this.labelBarcode7);
            this.Controls.Add(this.labelBarcode2);
            this.Controls.Add(this.labelBarcode1);
            this.Controls.Add(this.labelDescription12);
            this.Controls.Add(this.labelDescription6);
            this.Controls.Add(this.labelDescription11);
            this.Controls.Add(this.labelDescription5);
            this.Controls.Add(this.labelDescription10);
            this.Controls.Add(this.labelDescription4);
            this.Controls.Add(this.labelDescription9);
            this.Controls.Add(this.labelDescription3);
            this.Controls.Add(this.labelDescription8);
            this.Controls.Add(this.labelDescription2);
            this.Controls.Add(this.labelDescription7);
            this.Controls.Add(this.labelDescription1);
            this.Controls.Add(this.buttonTrigScan100);
            this.Controls.Add(this.labelStatus100);
            this.Controls.Add(this.labelBufor100);
            this.Controls.Add(this.labelBufor101);
            this.Controls.Add(this.labelNapisStatusSkaner100);
            this.Controls.Add(this.labelNapisStatusSkaner101);
            this.Controls.Add(this.buttonTrigScan101);
            this.Controls.Add(this.buttonModbusTest);
            this.Controls.Add(this.labelStatus101);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelAktualnyProdukt);
            this.Controls.Add(this.labelNapisAktualnyProdukt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelUnused2);
            this.Controls.Add(this.labelUnused);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Skanerki 20s-1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelNapisAktualnyProdukt;
        private System.Windows.Forms.Label labelAktualnyProdukt;
        private System.Windows.Forms.RadioButton radioButtonLinky;
        private System.Windows.Forms.RadioButton radioButtonSmets;
        private System.Windows.Forms.RadioButton radioButtonCyble8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonCyble12;
        internal System.Windows.Forms.Label labelStatus101;
        private System.Windows.Forms.Button buttonModbusTest;
        private System.Windows.Forms.Button buttonTrigScan101;
        private System.Windows.Forms.Label labelBufor101;
        internal System.Windows.Forms.Label labelStatus100;
        private System.Windows.Forms.Label labelNapisStatusSkaner101;
        private System.Windows.Forms.Label labelNapisStatusSkaner100;
        private System.Windows.Forms.Label labelBufor100;
        private System.Windows.Forms.Button buttonTrigScan100;
        private System.Windows.Forms.Label labelDescription1;
        private System.Windows.Forms.Label labelDescription2;
        private System.Windows.Forms.Label labelDescription3;
        private System.Windows.Forms.Label labelDescription4;
        private System.Windows.Forms.Label labelDescription5;
        private System.Windows.Forms.Label labelDescription6;
        private System.Windows.Forms.Label labelDescription7;
        private System.Windows.Forms.Label labelDescription8;
        private System.Windows.Forms.Label labelDescription9;
        private System.Windows.Forms.Label labelDescription10;
        private System.Windows.Forms.Label labelDescription11;
        private System.Windows.Forms.Label labelDescription12;
        private System.Windows.Forms.Label labelBarcode1;
        private System.Windows.Forms.Label labelBarcode2;
        private System.Windows.Forms.Label labelBarcode3;
        private System.Windows.Forms.Label labelBarcode4;
        private System.Windows.Forms.Label labelBarcode5;
        private System.Windows.Forms.Label labelBarcode6;
        private System.Windows.Forms.Label labelBarcode7;
        private System.Windows.Forms.Label labelBarcode8;
        private System.Windows.Forms.Label labelBarcode9;
        private System.Windows.Forms.Label labelBarcode10;
        private System.Windows.Forms.Label labelBarcode11;
        private System.Windows.Forms.Label labelBarcode12;
        private System.Windows.Forms.Label labelUnused;
        private System.Windows.Forms.Label labelUnused2;
        private System.Windows.Forms.Button buttonActuator;
        private System.Windows.Forms.Label labelCoverUTR;
        private System.Windows.Forms.Label labelNapisUTR;
        private System.Windows.Forms.TextBox textBoxUtr;
        private System.Windows.Forms.TextBox textBoxLot;
        private System.Windows.Forms.Label labelNapisPodajLot;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}

