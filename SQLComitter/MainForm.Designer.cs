﻿using System.Windows.Forms;

namespace SQLCommitter
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.repositoryTextBox = new System.Windows.Forms.TextBox();
            this.repositoryBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.repositoryButton = new System.Windows.Forms.Button();
            this.commitTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.authorNameEmailTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fileNameTextBox = new System.Windows.Forms.TextBox();
            this.commitButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.filePathTextBox = new System.Windows.Forms.TextBox();
            this.sqlScintilla = new ScintillaNET.Scintilla();
            this.reposDataGridView = new System.Windows.Forms.DataGridView();
            this.repoPathColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pathColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.committerNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.committerEmailColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activateColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.committerNameEmailTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sqlScintilla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // repositoryTextBox
            // 
            this.repositoryTextBox.Location = new System.Drawing.Point(13, 13);
            this.repositoryTextBox.Name = "repositoryTextBox";
            this.repositoryTextBox.Size = new System.Drawing.Size(678, 20);
            this.repositoryTextBox.TabIndex = 0;
            // 
            // repositoryBrowserDialog
            // 
            this.repositoryBrowserDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.repositoryBrowserDialog.ShowNewFolderButton = false;
            // 
            // repositoryButton
            // 
            this.repositoryButton.Location = new System.Drawing.Point(697, 10);
            this.repositoryButton.Name = "repositoryButton";
            this.repositoryButton.Size = new System.Drawing.Size(75, 23);
            this.repositoryButton.TabIndex = 1;
            this.repositoryButton.Text = "Repository...";
            this.repositoryButton.UseVisualStyleBackColor = true;
            this.repositoryButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // commitTextBox
            // 
            this.commitTextBox.Location = new System.Drawing.Point(13, 55);
            this.commitTextBox.Multiline = true;
            this.commitTextBox.Name = "commitTextBox";
            this.commitTextBox.Size = new System.Drawing.Size(336, 104);
            this.commitTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Commit Message";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(375, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Author";
            // 
            // authorNameEmailTextBox
            // 
            this.authorNameEmailTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.authorNameEmailTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.authorNameEmailTextBox.Location = new System.Drawing.Point(378, 55);
            this.authorNameEmailTextBox.Name = "authorNameEmailTextBox";
            this.authorNameEmailTextBox.Size = new System.Drawing.Size(394, 20);
            this.authorNameEmailTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(12, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "SQL Content";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(375, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "SQL Filename";
            // 
            // fileNameTextBox
            // 
            this.fileNameTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.fileNameTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.fileNameTextBox.Location = new System.Drawing.Point(505, 139);
            this.fileNameTextBox.Name = "fileNameTextBox";
            this.fileNameTextBox.Size = new System.Drawing.Size(267, 20);
            this.fileNameTextBox.TabIndex = 5;
            // 
            // commitButton
            // 
            this.commitButton.Location = new System.Drawing.Point(697, 505);
            this.commitButton.Name = "commitButton";
            this.commitButton.Size = new System.Drawing.Size(75, 23);
            this.commitButton.TabIndex = 7;
            this.commitButton.Text = "Commit";
            this.commitButton.UseVisualStyleBackColor = true;
            this.commitButton.Click += new System.EventHandler(this.commitButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(697, 534);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Clear";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // filePathTextBox
            // 
            this.filePathTextBox.Location = new System.Drawing.Point(378, 139);
            this.filePathTextBox.Name = "filePathTextBox";
            this.filePathTextBox.Size = new System.Drawing.Size(121, 20);
            this.filePathTextBox.TabIndex = 4;
            // 
            // sqlScintilla
            // 
            this.sqlScintilla.AllowDrop = true;
            this.sqlScintilla.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sqlScintilla.ConfigurationManager.Language = "sql";
            this.sqlScintilla.EndOfLine.Mode = ScintillaNET.EndOfLineMode.LF;
            this.sqlScintilla.Indentation.TabWidth = 4;
            this.sqlScintilla.Indentation.UseTabs = false;
            this.sqlScintilla.Lexing.Lexer = ScintillaNET.Lexer.Sql;
            this.sqlScintilla.Lexing.LexerName = "sql";
            this.sqlScintilla.Lexing.LineCommentPrefix = "";
            this.sqlScintilla.Lexing.StreamCommentPrefix = "";
            this.sqlScintilla.Lexing.StreamCommentSufix = "";
            this.sqlScintilla.Location = new System.Drawing.Point(15, 188);
            this.sqlScintilla.Name = "sqlScintilla";
            this.sqlScintilla.Size = new System.Drawing.Size(757, 311);
            this.sqlScintilla.Styles.BraceBad.FontName = "Verdana\0\0\0\0\0\0\0\0\0\0\0\0\0";
            this.sqlScintilla.Styles.BraceLight.FontName = "Verdana\0\0\0\0\0\0\0\0\0\0\0\0\0";
            this.sqlScintilla.Styles.CallTip.FontName = "Segoe UI\0\0\0\0\0\0\0\0\0\0\0\0";
            this.sqlScintilla.Styles.ControlChar.FontName = "Verdana\0\0\0\0\0\0\0\0\0\0\0\0\0";
            this.sqlScintilla.Styles.Default.FontName = "Verdana\0\0\0\0\0\0\0\0\0\0\0\0\0";
            this.sqlScintilla.Styles.IndentGuide.FontName = "Verdana\0\0\0\0\0\0\0\0\0\0\0\0\0";
            this.sqlScintilla.Styles.LastPredefined.FontName = "Verdana\0\0\0\0\0\0\0\0\0\0\0\0\0";
            this.sqlScintilla.Styles.LineNumber.FontName = "Verdana\0\0\0\0\0\0\0\0\0\0\0\0\0";
            this.sqlScintilla.Styles.Max.FontName = "Verdana\0\0\0\0\0\0\0\0\0\0\0\0\0";
            this.sqlScintilla.TabIndex = 6;
            this.sqlScintilla.DragDrop += new System.Windows.Forms.DragEventHandler(this.sqlScintilla_DragDrop);
            this.sqlScintilla.DragEnter += new System.Windows.Forms.DragEventHandler(this.sqlScintilla_DragEnter);
            // 
            // reposDataGridView
            // 
            this.reposDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reposDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.repoPathColumn,
            this.pathColumn,
            this.committerNameColumn,
            this.committerEmailColumn,
            this.activateColumn});
            this.reposDataGridView.Location = new System.Drawing.Point(15, 505);
            this.reposDataGridView.Name = "reposDataGridView";
            this.reposDataGridView.Size = new System.Drawing.Size(664, 105);
            this.reposDataGridView.TabIndex = 9;
            this.reposDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.reposDataGridView_CellContentClick);
            // 
            // repoPathColumn
            // 
            this.repoPathColumn.HeaderText = "RepoPath";
            this.repoPathColumn.Name = "repoPathColumn";
            this.repoPathColumn.Width = 180;
            // 
            // pathColumn
            // 
            this.pathColumn.HeaderText = "SQL Directory";
            this.pathColumn.Name = "pathColumn";
            this.pathColumn.Width = 150;
            // 
            // committerNameColumn
            // 
            this.committerNameColumn.HeaderText = "CommitterName";
            this.committerNameColumn.Name = "committerNameColumn";
            this.committerNameColumn.Width = 120;
            // 
            // committerEmailColumn
            // 
            this.committerEmailColumn.HeaderText = "CommiterEmail";
            this.committerEmailColumn.Name = "committerEmailColumn";
            this.committerEmailColumn.Width = 120;
            // 
            // activateColumn
            // 
            this.activateColumn.HeaderText = "Activate";
            this.activateColumn.Name = "activateColumn";
            this.activateColumn.Width = 50;
            // 
            // committerNameEmailTextBox
            // 
            this.committerNameEmailTextBox.Location = new System.Drawing.Point(378, 98);
            this.committerNameEmailTextBox.Name = "committerNameEmailTextBox";
            this.committerNameEmailTextBox.Size = new System.Drawing.Size(394, 20);
            this.committerNameEmailTextBox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(375, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Committer";
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(784, 622);
            this.Controls.Add(this.committerNameEmailTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.reposDataGridView);
            this.Controls.Add(this.sqlScintilla);
            this.Controls.Add(this.filePathTextBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.commitButton);
            this.Controls.Add(this.fileNameTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.authorNameEmailTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.commitTextBox);
            this.Controls.Add(this.repositoryButton);
            this.Controls.Add(this.repositoryTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "SQL Committer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sqlScintilla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reposDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox repositoryTextBox;
        private System.Windows.Forms.FolderBrowserDialog repositoryBrowserDialog;
        private System.Windows.Forms.Button repositoryButton;
        private System.Windows.Forms.TextBox commitTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox authorNameEmailTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fileNameTextBox;
        private System.Windows.Forms.Button commitButton;
        private System.Windows.Forms.Button cancelButton;
        private TextBox filePathTextBox;
        private ScintillaNET.Scintilla sqlScintilla;
        private DataGridView reposDataGridView;
        private TextBox committerNameEmailTextBox;
        private Label label5;
        private DataGridViewTextBoxColumn repoPathColumn;
        private DataGridViewTextBoxColumn pathColumn;
        private DataGridViewTextBoxColumn committerNameColumn;
        private DataGridViewTextBoxColumn committerEmailColumn;
        private DataGridViewButtonColumn activateColumn;
    }
}

