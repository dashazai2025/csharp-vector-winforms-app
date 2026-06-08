namespace VectorLabWinForms
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.gbVectorType = new System.Windows.Forms.GroupBox();
            this.rbLinkedList = new System.Windows.Forms.RadioButton();
            this.rbArray = new System.Windows.Forms.RadioButton();
            this.lblSize = new System.Windows.Forms.Label();
            this.nudSize = new System.Windows.Forms.NumericUpDown();
            this.btnCreateGrid = new System.Windows.Forms.Button();
            this.dgvElements = new System.Windows.Forms.DataGridView();
            this.gbOperations = new System.Windows.Forms.GroupBox();
            this.btnModifyClone = new System.Windows.Forms.Button();
            this.btnClone = new System.Windows.Forms.Button();
            this.btnNorm = new System.Windows.Forms.Button();
            this.btnShowVector = new System.Windows.Forms.Button();
            this.gbFiles = new System.Windows.Forms.GroupBox();
            this.btnJsonLoad = new System.Windows.Forms.Button();
            this.btnJsonSave = new System.Windows.Forms.Button();
            this.btnTextRead = new System.Windows.Forms.Button();
            this.btnTextWrite = new System.Windows.Forms.Button();
            this.btnByteRead = new System.Windows.Forms.Button();
            this.btnByteWrite = new System.Windows.Forms.Button();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.gbVectorType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvElements)).BeginInit();
            this.gbOperations.SuspendLayout();
            this.gbFiles.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbVectorType
            // 
            this.gbVectorType.Controls.Add(this.rbLinkedList);
            this.gbVectorType.Controls.Add(this.rbArray);
            this.gbVectorType.Location = new System.Drawing.Point(12, 12);
            this.gbVectorType.Name = "gbVectorType";
            this.gbVectorType.Size = new System.Drawing.Size(200, 70);
            this.gbVectorType.TabIndex = 0;
            this.gbVectorType.TabStop = false;
            this.gbVectorType.Text = "Выбор типа вектора";
            // 
            // rbLinkedList
            // 
            this.rbLinkedList.AutoSize = true;
            this.rbLinkedList.Location = new System.Drawing.Point(6, 42);
            this.rbLinkedList.Name = "rbLinkedList";
            this.rbLinkedList.Size = new System.Drawing.Size(118, 19);
            this.rbLinkedList.TabIndex = 1;
            this.rbLinkedList.TabStop = false;
            this.rbLinkedList.Text = "LinkedListVector";
            this.rbLinkedList.UseVisualStyleBackColor = true;
            // 
            // rbArray
            // 
            this.rbArray.AutoSize = true;
            this.rbArray.Checked = true;
            this.rbArray.Location = new System.Drawing.Point(6, 22);
            this.rbArray.Name = "rbArray";
            this.rbArray.Size = new System.Drawing.Size(96, 19);
            this.rbArray.TabIndex = 0;
            this.rbArray.TabStop = true;
            this.rbArray.Text = "ArrayVector";
            this.rbArray.UseVisualStyleBackColor = true;
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(12, 95);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(97, 15);
            this.lblSize.TabIndex = 1;
            this.lblSize.Text = "Размер вектора:";
            // 
            // nudSize
            // 
            this.nudSize.Location = new System.Drawing.Point(115, 91);
            this.nudSize.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.nudSize.Name = "nudSize";
            this.nudSize.Size = new System.Drawing.Size(97, 23);
            this.nudSize.TabIndex = 2;
            this.nudSize.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // btnCreateGrid
            // 
            this.btnCreateGrid.Location = new System.Drawing.Point(218, 91);
            this.btnCreateGrid.Name = "btnCreateGrid";
            this.btnCreateGrid.Size = new System.Drawing.Size(120, 23);
            this.btnCreateGrid.TabIndex = 3;
            this.btnCreateGrid.Text = "Создать таблицу";
            this.btnCreateGrid.UseVisualStyleBackColor = true;
            this.btnCreateGrid.Click += new System.EventHandler(this.btnCreateGrid_Click);
            // 
            // dgvElements
            // 
            this.dgvElements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvElements.Location = new System.Drawing.Point(12, 120);
            this.dgvElements.Name = "dgvElements";
            this.dgvElements.RowHeadersWidth = 62;
            this.dgvElements.RowTemplate.Height = 25;
            this.dgvElements.Size = new System.Drawing.Size(326, 200);
            this.dgvElements.TabIndex = 4;
            // 
            // gbOperations
            // 
            this.gbOperations.Controls.Add(this.btnModifyClone);
            this.gbOperations.Controls.Add(this.btnClone);
            this.gbOperations.Controls.Add(this.btnNorm);
            this.gbOperations.Controls.Add(this.btnShowVector);
            this.gbOperations.Location = new System.Drawing.Point(344, 12);
            this.gbOperations.Name = "gbOperations";
            this.gbOperations.Size = new System.Drawing.Size(200, 200);
            this.gbOperations.TabIndex = 5;
            this.gbOperations.TabStop = false;
            this.gbOperations.Text = "Операции с вектором";
            // 
            // btnModifyClone
            // 
            this.btnModifyClone.Location = new System.Drawing.Point(6, 120);
            this.btnModifyClone.Name = "btnModifyClone";
            this.btnModifyClone.Size = new System.Drawing.Size(188, 40);
            this.btnModifyClone.TabIndex = 3;
            this.btnModifyClone.Text = "Изменить в клоне";
            this.btnModifyClone.UseVisualStyleBackColor = true;
            this.btnModifyClone.Click += new System.EventHandler(this.btnModifyClone_Click);
            // 
            // btnClone
            // 
            this.btnClone.Location = new System.Drawing.Point(6, 80);
            this.btnClone.Name = "btnClone";
            this.btnClone.Size = new System.Drawing.Size(188, 34);
            this.btnClone.TabIndex = 2;
            this.btnClone.Text = "Клонировать";
            this.btnClone.UseVisualStyleBackColor = true;
            this.btnClone.Click += new System.EventHandler(this.btnClone_Click);
            // 
            // btnNorm
            // 
            this.btnNorm.Location = new System.Drawing.Point(6, 45);
            this.btnNorm.Name = "btnNorm";
            this.btnNorm.Size = new System.Drawing.Size(188, 29);
            this.btnNorm.TabIndex = 1;
            this.btnNorm.Text = "Модуль вектора";
            this.btnNorm.UseVisualStyleBackColor = true;
            this.btnNorm.Click += new System.EventHandler(this.btnNorm_Click);
            // 
            // btnShowVector
            // 
            this.btnShowVector.Location = new System.Drawing.Point(6, 15);
            this.btnShowVector.Name = "btnShowVector";
            this.btnShowVector.Size = new System.Drawing.Size(188, 24);
            this.btnShowVector.TabIndex = 0;
            this.btnShowVector.Text = "Показать вектор";
            this.btnShowVector.UseVisualStyleBackColor = true;
            this.btnShowVector.Click += new System.EventHandler(this.btnShowVector_Click);
            // 
            // gbFiles
            // 
            this.gbFiles.Controls.Add(this.btnJsonLoad);
            this.gbFiles.Controls.Add(this.btnJsonSave);
            this.gbFiles.Controls.Add(this.btnTextRead);
            this.gbFiles.Controls.Add(this.btnTextWrite);
            this.gbFiles.Controls.Add(this.btnByteRead);
            this.gbFiles.Controls.Add(this.btnByteWrite);
            this.gbFiles.Location = new System.Drawing.Point(550, 12);
            this.gbFiles.Name = "gbFiles";
            this.gbFiles.Size = new System.Drawing.Size(200, 308);
            this.gbFiles.TabIndex = 6;
            this.gbFiles.TabStop = false;
            this.gbFiles.Text = "Файловые операции";
            // 
            // btnJsonLoad
            // 
            this.btnJsonLoad.Location = new System.Drawing.Point(6, 240);
            this.btnJsonLoad.Name = "btnJsonLoad";
            this.btnJsonLoad.Size = new System.Drawing.Size(188, 30);
            this.btnJsonLoad.TabIndex = 5;
            this.btnJsonLoad.Text = "JSON загрузить";
            this.btnJsonLoad.UseVisualStyleBackColor = true;
            this.btnJsonLoad.Click += new System.EventHandler(this.btnJsonLoad_Click);
            // 
            // btnJsonSave
            // 
            this.btnJsonSave.Location = new System.Drawing.Point(6, 200);
            this.btnJsonSave.Name = "btnJsonSave";
            this.btnJsonSave.Size = new System.Drawing.Size(188, 34);
            this.btnJsonSave.TabIndex = 4;
            this.btnJsonSave.Text = "JSON сохранить";
            this.btnJsonSave.UseVisualStyleBackColor = true;
            this.btnJsonSave.Click += new System.EventHandler(this.btnJsonSave_Click);
            // 
            // btnTextRead
            // 
            this.btnTextRead.Location = new System.Drawing.Point(6, 150);
            this.btnTextRead.Name = "btnTextRead";
            this.btnTextRead.Size = new System.Drawing.Size(188, 34);
            this.btnTextRead.TabIndex = 3;
            this.btnTextRead.Text = "Текстовый ввод";
            this.btnTextRead.UseVisualStyleBackColor = true;
            this.btnTextRead.Click += new System.EventHandler(this.btnTextRead_Click);
            // 
            // btnTextWrite
            // 
            this.btnTextWrite.Location = new System.Drawing.Point(6, 110);
            this.btnTextWrite.Name = "btnTextWrite";
            this.btnTextWrite.Size = new System.Drawing.Size(188, 34);
            this.btnTextWrite.TabIndex = 2;
            this.btnTextWrite.Text = "Текстовый вывод";
            this.btnTextWrite.UseVisualStyleBackColor = true;
            this.btnTextWrite.Click += new System.EventHandler(this.btnTextWrite_Click);
            // 
            // btnByteRead
            // 
            this.btnByteRead.Location = new System.Drawing.Point(6, 65);
            this.btnByteRead.Name = "btnByteRead";
            this.btnByteRead.Size = new System.Drawing.Size(188, 34);
            this.btnByteRead.TabIndex = 1;
            this.btnByteRead.Text = "Байтовый ввод";
            this.btnByteRead.UseVisualStyleBackColor = true;
            this.btnByteRead.Click += new System.EventHandler(this.btnByteRead_Click);
            // 
            // btnByteWrite
            // 
            this.btnByteWrite.Location = new System.Drawing.Point(6, 22);
            this.btnByteWrite.Name = "btnByteWrite";
            this.btnByteWrite.Size = new System.Drawing.Size(188, 34);
            this.btnByteWrite.TabIndex = 0;
            this.btnByteWrite.Text = "Байтовый вывод";
            this.btnByteWrite.UseVisualStyleBackColor = true;
            this.btnByteWrite.Click += new System.EventHandler(this.btnByteWrite_Click);
            // 
            // rtbOutput
            // 
            this.rtbOutput.Location = new System.Drawing.Point(12, 326);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.Size = new System.Drawing.Size(738, 200);
            this.rtbOutput.TabIndex = 7;
            this.rtbOutput.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 538);
            this.Controls.Add(this.rtbOutput);
            this.Controls.Add(this.gbFiles);
            this.Controls.Add(this.gbOperations);
            this.Controls.Add(this.dgvElements);
            this.Controls.Add(this.btnCreateGrid);
            this.Controls.Add(this.nudSize);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.gbVectorType);
            this.Name = "Form1";
            this.Text = "Лабораторная работа №5 - Векторы";
            this.gbVectorType.ResumeLayout(false);
            this.gbVectorType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvElements)).EndInit();
            this.gbOperations.ResumeLayout(false);
            this.gbFiles.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.GroupBox gbVectorType;
        private System.Windows.Forms.RadioButton rbLinkedList;
        private System.Windows.Forms.RadioButton rbArray;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.NumericUpDown nudSize;
        private System.Windows.Forms.Button btnCreateGrid;
        private System.Windows.Forms.DataGridView dgvElements;
        private System.Windows.Forms.GroupBox gbOperations;
        private System.Windows.Forms.Button btnModifyClone;
        private System.Windows.Forms.Button btnClone;
        private System.Windows.Forms.Button btnNorm;
        private System.Windows.Forms.Button btnShowVector;
        private System.Windows.Forms.GroupBox gbFiles;
        private System.Windows.Forms.Button btnJsonLoad;
        private System.Windows.Forms.Button btnJsonSave;
        private System.Windows.Forms.Button btnTextRead;
        private System.Windows.Forms.Button btnTextWrite;
        private System.Windows.Forms.Button btnByteRead;
        private System.Windows.Forms.Button btnByteWrite;
        private System.Windows.Forms.RichTextBox rtbOutput;
    }
}