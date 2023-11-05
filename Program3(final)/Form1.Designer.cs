
namespace Program3_final_
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
            this.cityLabel = new System.Windows.Forms.Label();
            this.entreeLabel = new System.Windows.Forms.Label();
            this.servingsLabel = new System.Windows.Forms.Label();
            this.calculate = new System.Windows.Forms.Button();
            this.cityComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.entreeInput = new System.Windows.Forms.TextBox();
            this.servingsInput = new System.Windows.Forms.TextBox();
            this.initialLabel = new System.Windows.Forms.Label();
            this.adjustedLabel = new System.Windows.Forms.Label();
            this.shipmentLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.shipmentOutput = new System.Windows.Forms.Label();
            this.initialCostOutput = new System.Windows.Forms.Label();
            this.adjustedCostOutput = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.totalPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(132, 58);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(28, 15);
            this.cityLabel.TabIndex = 0;
            this.cityLabel.Text = "City";
            // 
            // entreeLabel
            // 
            this.entreeLabel.AutoSize = true;
            this.entreeLabel.Location = new System.Drawing.Point(44, 99);
            this.entreeLabel.Name = "entreeLabel";
            this.entreeLabel.Size = new System.Drawing.Size(116, 15);
            this.entreeLabel.TabIndex = 1;
            this.entreeLabel.Text = "Entree/Item Number";
            // 
            // servingsLabel
            // 
            this.servingsLabel.AutoSize = true;
            this.servingsLabel.Location = new System.Drawing.Point(52, 140);
            this.servingsLabel.Name = "servingsLabel";
            this.servingsLabel.Size = new System.Drawing.Size(108, 15);
            this.servingsLabel.TabIndex = 2;
            this.servingsLabel.Text = "Quantity (Servings)";
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(130, 188);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(75, 23);
            this.calculate.TabIndex = 3;
            this.calculate.Text = "Calculate";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // cityComboBox
            // 
            this.cityComboBox.FormattingEnabled = true;
            this.cityComboBox.Items.AddRange(new object[] {
            "Louisville",
            "Lexington",
            "Indianapolis",
            "Nashville"});
            this.cityComboBox.Location = new System.Drawing.Point(166, 55);
            this.cityComboBox.Name = "cityComboBox";
            this.cityComboBox.Size = new System.Drawing.Size(121, 23);
            this.cityComboBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(166, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 15);
            this.label4.TabIndex = 5;
            // 
            // entreeInput
            // 
            this.entreeInput.Location = new System.Drawing.Point(166, 96);
            this.entreeInput.Name = "entreeInput";
            this.entreeInput.Size = new System.Drawing.Size(121, 23);
            this.entreeInput.TabIndex = 6;
            // 
            // servingsInput
            // 
            this.servingsInput.Location = new System.Drawing.Point(166, 137);
            this.servingsInput.Name = "servingsInput";
            this.servingsInput.Size = new System.Drawing.Size(121, 23);
            this.servingsInput.TabIndex = 7;
            // 
            // initialLabel
            // 
            this.initialLabel.AutoSize = true;
            this.initialLabel.Location = new System.Drawing.Point(40, 238);
            this.initialLabel.Name = "initialLabel";
            this.initialLabel.Size = new System.Drawing.Size(63, 15);
            this.initialLabel.TabIndex = 8;
            this.initialLabel.Text = "Initial Cost";
            // 
            // adjustedLabel
            // 
            this.adjustedLabel.AutoSize = true;
            this.adjustedLabel.Location = new System.Drawing.Point(42, 279);
            this.adjustedLabel.Name = "adjustedLabel";
            this.adjustedLabel.Size = new System.Drawing.Size(84, 15);
            this.adjustedLabel.TabIndex = 10;
            this.adjustedLabel.Text = "Adjusted Cost:";
            // 
            // shipmentLabel
            // 
            this.shipmentLabel.AutoSize = true;
            this.shipmentLabel.Location = new System.Drawing.Point(42, 319);
            this.shipmentLabel.Name = "shipmentLabel";
            this.shipmentLabel.Size = new System.Drawing.Size(85, 15);
            this.shipmentLabel.TabIndex = 12;
            this.shipmentLabel.Text = "Shipment Cost";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(618, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 15);
            this.label8.TabIndex = 13;
            // 
            // shipmentOutput
            // 
            this.shipmentOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.shipmentOutput.Location = new System.Drawing.Point(192, 318);
            this.shipmentOutput.Name = "shipmentOutput";
            this.shipmentOutput.Size = new System.Drawing.Size(100, 23);
            this.shipmentOutput.TabIndex = 15;
            // 
            // initialCostOutput
            // 
            this.initialCostOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.initialCostOutput.Location = new System.Drawing.Point(192, 237);
            this.initialCostOutput.Name = "initialCostOutput";
            this.initialCostOutput.Size = new System.Drawing.Size(100, 23);
            this.initialCostOutput.TabIndex = 16;
            // 
            // adjustedCostOutput
            // 
            this.adjustedCostOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.adjustedCostOutput.Location = new System.Drawing.Point(192, 278);
            this.adjustedCostOutput.Name = "adjustedCostOutput";
            this.adjustedCostOutput.Size = new System.Drawing.Size(100, 23);
            this.adjustedCostOutput.TabIndex = 17;
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(42, 362);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(61, 15);
            this.totalLabel.TabIndex = 18;
            this.totalLabel.Text = "Total Price";
            // 
            // totalPrice
            // 
            this.totalPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalPrice.Location = new System.Drawing.Point(192, 361);
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.Size = new System.Drawing.Size(100, 23);
            this.totalPrice.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 450);
            this.Controls.Add(this.totalPrice);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.adjustedCostOutput);
            this.Controls.Add(this.initialCostOutput);
            this.Controls.Add(this.shipmentOutput);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.shipmentLabel);
            this.Controls.Add(this.adjustedLabel);
            this.Controls.Add(this.initialLabel);
            this.Controls.Add(this.servingsInput);
            this.Controls.Add(this.entreeInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cityComboBox);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.servingsLabel);
            this.Controls.Add(this.entreeLabel);
            this.Controls.Add(this.cityLabel);
            this.Name = "Form1";
            this.Text = "uThankItWeMakeIt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label entreeLabel;
        private System.Windows.Forms.Label servingsLabel;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.ComboBox cityComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox entreeInput;
        private System.Windows.Forms.TextBox servingsInput;
        private System.Windows.Forms.Label initialLabel;
        private System.Windows.Forms.Label adjustedLabel;
        private System.Windows.Forms.Label shipmentLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label shipmentOutput;
        private System.Windows.Forms.Label initialCostOutput;
        private System.Windows.Forms.Label adjustedCostOutput;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label totalPrice;
    }
}

