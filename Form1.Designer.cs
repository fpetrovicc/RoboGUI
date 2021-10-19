
namespace RoboGUI
{
    partial class Robogui
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Robogui));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.stopButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.portSelector = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.sendComButton = new System.Windows.Forms.Button();
            this.comTextBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.letterB = new System.Windows.Forms.Button();
            this.letterC = new System.Windows.Forms.Button();
            this.letterA = new System.Windows.Forms.Button();
            this.letterD = new System.Windows.Forms.Button();
            this.letterE = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.stopButton);
            this.groupBox1.Controls.Add(this.startButton);
            this.groupBox1.Controls.Add(this.portSelector);
            this.groupBox1.Location = new System.Drawing.Point(12, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(138, 87);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Start i povezivanje";
            // 
            // stopButton
            // 
            this.stopButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stopButton.Location = new System.Drawing.Point(68, 48);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(62, 31);
            this.stopButton.TabIndex = 2;
            this.stopButton.Text = "STOP";
            this.stopButton.UseVisualStyleBackColor = true;
            // 
            // startButton
            // 
            this.startButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.startButton.Location = new System.Drawing.Point(6, 48);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(62, 31);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "START";
            this.startButton.UseVisualStyleBackColor = true;
            // 
            // portSelector
            // 
            this.portSelector.FormattingEnabled = true;
            this.portSelector.Location = new System.Drawing.Point(6, 21);
            this.portSelector.Name = "portSelector";
            this.portSelector.Size = new System.Drawing.Size(124, 21);
            this.portSelector.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.sendComButton);
            this.groupBox2.Controls.Add(this.comTextBox);
            this.groupBox2.Location = new System.Drawing.Point(156, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(138, 87);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tekstualne komande";
            // 
            // sendComButton
            // 
            this.sendComButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sendComButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.sendComButton.Location = new System.Drawing.Point(6, 50);
            this.sendComButton.Name = "sendComButton";
            this.sendComButton.Size = new System.Drawing.Size(126, 31);
            this.sendComButton.TabIndex = 1;
            this.sendComButton.Text = "POSLATI";
            this.sendComButton.UseVisualStyleBackColor = true;
            // 
            // comTextBox
            // 
            this.comTextBox.Location = new System.Drawing.Point(6, 21);
            this.comTextBox.Name = "comTextBox";
            this.comTextBox.Size = new System.Drawing.Size(126, 22);
            this.comTextBox.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.letterE);
            this.groupBox3.Controls.Add(this.letterD);
            this.groupBox3.Controls.Add(this.letterB);
            this.groupBox3.Controls.Add(this.letterC);
            this.groupBox3.Controls.Add(this.letterA);
            this.groupBox3.Location = new System.Drawing.Point(18, 99);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(260, 68);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pojedinacna slova";
            // 
            // letterB
            // 
            this.letterB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.letterB.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.letterB.Location = new System.Drawing.Point(57, 18);
            this.letterB.Name = "letterB";
            this.letterB.Size = new System.Drawing.Size(45, 44);
            this.letterB.TabIndex = 3;
            this.letterB.Text = "B";
            this.letterB.UseVisualStyleBackColor = true;
            // 
            // letterC
            // 
            this.letterC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.letterC.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.letterC.Location = new System.Drawing.Point(108, 18);
            this.letterC.Name = "letterC";
            this.letterC.Size = new System.Drawing.Size(45, 44);
            this.letterC.TabIndex = 2;
            this.letterC.Text = "C";
            this.letterC.UseVisualStyleBackColor = true;
            // 
            // letterA
            // 
            this.letterA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.letterA.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.letterA.Location = new System.Drawing.Point(6, 18);
            this.letterA.Name = "letterA";
            this.letterA.Size = new System.Drawing.Size(45, 44);
            this.letterA.TabIndex = 0;
            this.letterA.Text = "A";
            this.letterA.UseVisualStyleBackColor = true;
            // 
            // letterD
            // 
            this.letterD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.letterD.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.letterD.Location = new System.Drawing.Point(159, 18);
            this.letterD.Name = "letterD";
            this.letterD.Size = new System.Drawing.Size(45, 44);
            this.letterD.TabIndex = 4;
            this.letterD.Text = "D";
            this.letterD.UseVisualStyleBackColor = true;
            // 
            // letterE
            // 
            this.letterE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.letterE.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.letterE.Location = new System.Drawing.Point(209, 18);
            this.letterE.Name = "letterE";
            this.letterE.Size = new System.Drawing.Size(45, 44);
            this.letterE.TabIndex = 5;
            this.letterE.Text = "E";
            this.letterE.UseVisualStyleBackColor = true;
            // 
            // robogui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 178);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Name = "Robogui";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RoboGUI";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button letterE;

        private System.Windows.Forms.Button letterD;

        private System.Windows.Forms.Button letterB;

        private System.Windows.Forms.Button letterC;

        private System.Windows.Forms.Button letterA;



        private System.Windows.Forms.GroupBox groupBox3;

        private System.Windows.Forms.TextBox comTextBox;
        private System.Windows.Forms.Button sendComButton;

        private System.Windows.Forms.GroupBox groupBox2;

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.ComboBox portSelector;
        private System.Windows.Forms.Button stopButton;
    }
}

