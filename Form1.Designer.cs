namespace ClinicManagement
{
    partial class sad
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
            lblTitle = new Label();
            lblPatientName = new Label();
            txtPatientName = new TextBox();
            lblAge = new Label();
            txtAge = new TextBox();
            lblReason = new Label();
            txtReason = new TextBox();
            lblPatientType = new Label();
            cmbPatientType = new ComboBox();
            btnAddToQueue = new Button();
            btnClear = new Button();
            lblQueueNumber = new Label();
            lblQueueNumberOutput = new Label();
            lblPatientTypeOutput = new Label();
            lblPriority = new Label();
            lblPriorityOutput = new Label();
            lblQueueInformation = new Label();

            SuspendLayout();

            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            lblTitle.Location = new Point(174, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(482, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "CLINIC QUEUE MANAGEMENT SYSTEM";

            // 
            // lblPatientName
            // 
            lblPatientName.AutoSize = true;
            lblPatientName.Font = new Font("Segoe UI", 10F);
            lblPatientName.Location = new Point(37, 95);
            lblPatientName.Name = "lblPatientName";
            lblPatientName.Size = new Size(104, 19);
            lblPatientName.TabIndex = 1;
            lblPatientName.Text = "Patient Name:";

            // 
            // txtPatientName
            // 
            txtPatientName.Location = new Point(153, 93);
            txtPatientName.Name = "txtPatientName";
            txtPatientName.Size = new Size(230, 23);
            txtPatientName.TabIndex = 2;

            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Font = new Font("Segoe UI", 10F);
            lblAge.Location = new Point(37, 128);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(34, 19);
            lblAge.TabIndex = 3;
            lblAge.Text = "Age:";

            // 
            // txtAge
            // 
            txtAge.Location = new Point(153, 127);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(230, 23);
            txtAge.TabIndex = 4;

            // 
            // lblReason
            // 
            lblReason.AutoSize = true;
            lblReason.Font = new Font("Segoe UI", 10F);
            lblReason.Location = new Point(37, 172);
            lblReason.Name = "lblReason";
            lblReason.Size = new Size(108, 19);
            lblReason.TabIndex = 5;
            lblReason.Text = "Reason for Visit:";

            // 
            // txtReason
            // 
            txtReason.Location = new Point(153, 171);
            txtReason.Name = "txtReason";
            txtReason.Size = new Size(230, 23);
            txtReason.TabIndex = 6;

            // 
            // lblPatientType
            // 
            lblPatientType.AutoSize = true;
            lblPatientType.Font = new Font("Segoe UI", 10F);
            lblPatientType.Location = new Point(469, 95);
            lblPatientType.Name = "lblPatientType";
            lblPatientType.Size = new Size(92, 19);
            lblPatientType.TabIndex = 7;
            lblPatientType.Text = "Patient Type:";

            // 
            // cmbPatientType
            // 
            cmbPatientType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPatientType.FormattingEnabled = true;
            cmbPatientType.Items.AddRange(new object[]
            {
                "Emergency",
                "Senior",
                "Pregnant",
                "Regular"
            });
            cmbPatientType.Location = new Point(569, 93);
            cmbPatientType.Name = "cmbPatientType";
            cmbPatientType.Size = new Size(150, 23);
            cmbPatientType.TabIndex = 8;

            // 
            // btnAddToQueue
            // 
            btnAddToQueue.Location = new Point(153, 222);
            btnAddToQueue.Name = "btnAddToQueue";
            btnAddToQueue.Size = new Size(110, 43);
            btnAddToQueue.TabIndex = 9;
            btnAddToQueue.Text = "ADD TO QUEUE";
            btnAddToQueue.UseVisualStyleBackColor = true;
            btnAddToQueue.Click += btnAddToQueue_Click;

            // 
            // btnClear
            // 
            btnClear.Location = new Point(281, 222);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(89, 43);
            btnClear.TabIndex = 10;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;

            // 
            // lblQueueInformation
            // 
            lblQueueInformation.AutoSize = true;
            lblQueueInformation.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblQueueInformation.Location = new Point(252, 286);
            lblQueueInformation.Name = "lblQueueInformation";
            lblQueueInformation.Size = new Size(286, 32);
            lblQueueInformation.TabIndex = 11;
            lblQueueInformation.Text = "QUEUE INFORMATION";

            // 
            // lblQueueNumber
            // 
            lblQueueNumber.AutoSize = true;
            lblQueueNumber.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblQueueNumber.Location = new Point(38, 337);
            lblQueueNumber.Name = "lblQueueNumber";
            lblQueueNumber.Size = new Size(111, 19);
            lblQueueNumber.TabIndex = 12;
            lblQueueNumber.Text = "Queue Number:";

            // 
            // lblQueueNumberOutput
            // 
            lblQueueNumberOutput.AutoSize = true;
            lblQueueNumberOutput.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblQueueNumberOutput.ForeColor = Color.Blue;
            lblQueueNumberOutput.Location = new Point(180, 335);
            lblQueueNumberOutput.Name = "lblQueueNumberOutput";
            lblQueueNumberOutput.Size = new Size(0, 21);
            lblQueueNumberOutput.TabIndex = 13;

            // 
            // lblPatientTypeOutput
            // 
            lblPatientTypeOutput.AutoSize = true;
            lblPatientTypeOutput.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPatientTypeOutput.Location = new Point(38, 375);
            lblPatientTypeOutput.Name = "lblPatientTypeOutput";
            lblPatientTypeOutput.Size = new Size(0, 19);
            lblPatientTypeOutput.TabIndex = 14;

            // 
            // lblPriority
            // 
            lblPriority.AutoSize = true;
            lblPriority.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPriority.Location = new Point(38, 413);
            lblPriority.Name = "lblPriority";
            lblPriority.Size = new Size(59, 19);
            lblPriority.TabIndex = 15;
            lblPriority.Text = "Priority:";

            // 
            // lblPriorityOutput
            // 
            lblPriorityOutput.AutoSize = true;
            lblPriorityOutput.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPriorityOutput.ForeColor = Color.Red;
            lblPriorityOutput.Location = new Point(180, 413);
            lblPriorityOutput.Name = "lblPriorityOutput";
            lblPriorityOutput.Size = new Size(0, 19);
            lblPriorityOutput.TabIndex = 16;

            // 
            // sad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 487);
            Controls.Add(lblPriorityOutput);
            Controls.Add(lblPriority);
            Controls.Add(lblPatientTypeOutput);
            Controls.Add(lblQueueNumberOutput);
            Controls.Add(lblQueueNumber);
            Controls.Add(lblQueueInformation);
            Controls.Add(btnClear);
            Controls.Add(btnAddToQueue);
            Controls.Add(cmbPatientType);
            Controls.Add(lblPatientType);
            Controls.Add(txtReason);
            Controls.Add(lblReason);
            Controls.Add(txtAge);
            Controls.Add(lblAge);
            Controls.Add(txtPatientName);
            Controls.Add(lblPatientName);
            Controls.Add(lblTitle);
            Name = "sad";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clinic Queue Management System";

            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblPatientName;
        private TextBox txtPatientName;
        private Label lblAge;
        private TextBox txtAge;
        private Label lblReason;
        private TextBox txtReason;
        private Label lblPatientType;
        private ComboBox cmbPatientType;
        private Button btnAddToQueue;
        private Button btnClear;
        private Label lblQueueNumber;
        private Label lblQueueNumberOutput;
        private Label lblPatientTypeOutput;
        private Label lblPriority;
        private Label lblPriorityOutput;
        private Label lblQueueInformation;
    }
}