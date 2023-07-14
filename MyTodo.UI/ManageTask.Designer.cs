namespace MyTodo.UI
{
    partial class ManageTask
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
            this.btnUpdateTask = new System.Windows.Forms.Button();
            this.btnDeleteTask = new System.Windows.Forms.Button();
            this.lblTaskId = new System.Windows.Forms.Label();
            this.lblTaskToManage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnUpdateTask
            // 
            this.btnUpdateTask.Location = new System.Drawing.Point(28, 82);
            this.btnUpdateTask.Name = "btnUpdateTask";
            this.btnUpdateTask.Size = new System.Drawing.Size(119, 29);
            this.btnUpdateTask.TabIndex = 0;
            this.btnUpdateTask.Text = "Update Task";
            this.btnUpdateTask.UseVisualStyleBackColor = true;
            this.btnUpdateTask.Click += new System.EventHandler(this.btnUpdateTask_Click);
            // 
            // btnDeleteTask
            // 
            this.btnDeleteTask.Location = new System.Drawing.Point(236, 82);
            this.btnDeleteTask.Name = "btnDeleteTask";
            this.btnDeleteTask.Size = new System.Drawing.Size(94, 29);
            this.btnDeleteTask.TabIndex = 1;
            this.btnDeleteTask.Text = "Delete Task";
            this.btnDeleteTask.UseVisualStyleBackColor = true;
            this.btnDeleteTask.Click += new System.EventHandler(this.btnDeleteTask_Click);
            // 
            // lblTaskId
            // 
            this.lblTaskId.AutoSize = true;
            this.lblTaskId.Location = new System.Drawing.Point(33, 9);
            this.lblTaskId.Name = "lblTaskId";
            this.lblTaskId.Size = new System.Drawing.Size(50, 20);
            this.lblTaskId.TabIndex = 3;
            this.lblTaskId.Text = "label1";
            this.lblTaskId.Visible = false;
            // 
            // lblTaskToManage
            // 
            this.lblTaskToManage.Location = new System.Drawing.Point(33, 32);
            this.lblTaskToManage.Name = "lblTaskToManage";
            this.lblTaskToManage.Size = new System.Drawing.Size(297, 27);
            this.lblTaskToManage.TabIndex = 4;
            // 
            // ManageTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 146);
            this.Controls.Add(this.lblTaskToManage);
            this.Controls.Add(this.lblTaskId);
            this.Controls.Add(this.btnDeleteTask);
            this.Controls.Add(this.btnUpdateTask);
            this.Name = "ManageTask";
            this.Text = "ManageTask";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnUpdateTask;
        private Button btnDeleteTask;

        public Label lblTaskId;
        public TextBox lblTaskToManage;
    }
}