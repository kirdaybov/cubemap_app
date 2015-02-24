namespace cubemap_app
{
    partial class Main_Form
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
            this.status_strip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.progress_bar = new System.Windows.Forms.ToolStripProgressBar();
            this.open_file_button = new System.Windows.Forms.Button();
            this.open_file_dialog = new System.Windows.Forms.OpenFileDialog();
            this.panorama_picture_box = new System.Windows.Forms.PictureBox();
            this.tabs_image = new System.Windows.Forms.TabControl();
            this.tab_panorama = new System.Windows.Forms.TabPage();
            this.tab_cubemap = new System.Windows.Forms.TabPage();
            this.tabs_options = new System.Windows.Forms.TabControl();
            this.tab_genaral_properties = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tab_cubemap_properties = new System.Windows.Forms.TabPage();
            this.width_text_box = new System.Windows.Forms.TextBox();
            this.height_text_box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.resolution_combo_box = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.generate_cubemap_button = new System.Windows.Forms.Button();
            this.save_cubemap_button = new System.Windows.Forms.Button();
            this.save_to_input_check_box = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.process_batch_button = new System.Windows.Forms.Button();
            this.input_folder_text_box = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.output_folder_text_box = new System.Windows.Forms.TextBox();
            this.rotate_z_track_bar = new System.Windows.Forms.TrackBar();
            this.blur_track_bar = new System.Windows.Forms.TrackBar();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.status_strip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panorama_picture_box)).BeginInit();
            this.tabs_image.SuspendLayout();
            this.tab_panorama.SuspendLayout();
            this.tabs_options.SuspendLayout();
            this.tab_genaral_properties.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tab_cubemap_properties.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rotate_z_track_bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blur_track_bar)).BeginInit();
            this.SuspendLayout();
            // 
            // status_strip
            // 
            this.status_strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.progress_bar});
            this.status_strip.Location = new System.Drawing.Point(0, 514);
            this.status_strip.Name = "status_strip";
            this.status_strip.Size = new System.Drawing.Size(847, 22);
            this.status_strip.TabIndex = 0;
            this.status_strip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel1.Text = "Ready";
            // 
            // progress_bar
            // 
            this.progress_bar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.progress_bar.Name = "progress_bar";
            this.progress_bar.Size = new System.Drawing.Size(100, 16);
            // 
            // open_file_button
            // 
            this.open_file_button.Location = new System.Drawing.Point(3, 3);
            this.open_file_button.Name = "open_file_button";
            this.open_file_button.Size = new System.Drawing.Size(188, 23);
            this.open_file_button.TabIndex = 1;
            this.open_file_button.Text = "Load Panorama/Cubemap";
            this.open_file_button.UseVisualStyleBackColor = true;
            this.open_file_button.Click += new System.EventHandler(this.open_file_button_Click);
            // 
            // panorama_picture_box
            // 
            this.panorama_picture_box.BackColor = System.Drawing.Color.Maroon;
            this.panorama_picture_box.Location = new System.Drawing.Point(0, 0);
            this.panorama_picture_box.Name = "panorama_picture_box";
            this.panorama_picture_box.Size = new System.Drawing.Size(434, 386);
            this.panorama_picture_box.TabIndex = 2;
            this.panorama_picture_box.TabStop = false;
            // 
            // tabs_image
            // 
            this.tabs_image.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabs_image.Controls.Add(this.tab_panorama);
            this.tabs_image.Controls.Add(this.tab_cubemap);
            this.tabs_image.Location = new System.Drawing.Point(12, 1);
            this.tabs_image.Name = "tabs_image";
            this.tabs_image.SelectedIndex = 0;
            this.tabs_image.Size = new System.Drawing.Size(601, 510);
            this.tabs_image.TabIndex = 3;
            // 
            // tab_panorama
            // 
            this.tab_panorama.Controls.Add(this.panorama_picture_box);
            this.tab_panorama.Location = new System.Drawing.Point(4, 22);
            this.tab_panorama.Name = "tab_panorama";
            this.tab_panorama.Padding = new System.Windows.Forms.Padding(3);
            this.tab_panorama.Size = new System.Drawing.Size(593, 484);
            this.tab_panorama.TabIndex = 0;
            this.tab_panorama.Text = "Panorama";
            this.tab_panorama.UseVisualStyleBackColor = true;
            // 
            // tab_cubemap
            // 
            this.tab_cubemap.Location = new System.Drawing.Point(4, 22);
            this.tab_cubemap.Name = "tab_cubemap";
            this.tab_cubemap.Padding = new System.Windows.Forms.Padding(3);
            this.tab_cubemap.Size = new System.Drawing.Size(593, 484);
            this.tab_cubemap.TabIndex = 1;
            this.tab_cubemap.Text = "Cubemap";
            this.tab_cubemap.UseVisualStyleBackColor = true;
            // 
            // tabs_options
            // 
            this.tabs_options.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabs_options.Controls.Add(this.tab_genaral_properties);
            this.tabs_options.Controls.Add(this.tab_cubemap_properties);
            this.tabs_options.Location = new System.Drawing.Point(619, 1);
            this.tabs_options.Name = "tabs_options";
            this.tabs_options.SelectedIndex = 0;
            this.tabs_options.Size = new System.Drawing.Size(216, 510);
            this.tabs_options.TabIndex = 4;
            // 
            // tab_genaral_properties
            // 
            this.tab_genaral_properties.Controls.Add(this.panel4);
            this.tab_genaral_properties.Controls.Add(this.label6);
            this.tab_genaral_properties.Controls.Add(this.panel3);
            this.tab_genaral_properties.Controls.Add(this.label5);
            this.tab_genaral_properties.Controls.Add(this.label2);
            this.tab_genaral_properties.Controls.Add(this.panel2);
            this.tab_genaral_properties.Controls.Add(this.label1);
            this.tab_genaral_properties.Controls.Add(this.panel1);
            this.tab_genaral_properties.Location = new System.Drawing.Point(4, 22);
            this.tab_genaral_properties.Name = "tab_genaral_properties";
            this.tab_genaral_properties.Padding = new System.Windows.Forms.Padding(3);
            this.tab_genaral_properties.Size = new System.Drawing.Size(208, 484);
            this.tab_genaral_properties.TabIndex = 0;
            this.tab_genaral_properties.Text = "General Properties";
            this.tab_genaral_properties.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Output Resolution";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.resolution_combo_box);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.height_text_box);
            this.panel2.Controls.Add(this.width_text_box);
            this.panel2.Location = new System.Drawing.Point(6, 117);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(196, 84);
            this.panel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Load";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.open_file_button);
            this.panel1.Location = new System.Drawing.Point(6, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(196, 69);
            this.panel1.TabIndex = 3;
            // 
            // tab_cubemap_properties
            // 
            this.tab_cubemap_properties.Controls.Add(this.label10);
            this.tab_cubemap_properties.Controls.Add(this.label9);
            this.tab_cubemap_properties.Controls.Add(this.blur_track_bar);
            this.tab_cubemap_properties.Controls.Add(this.rotate_z_track_bar);
            this.tab_cubemap_properties.Location = new System.Drawing.Point(4, 22);
            this.tab_cubemap_properties.Name = "tab_cubemap_properties";
            this.tab_cubemap_properties.Padding = new System.Windows.Forms.Padding(3);
            this.tab_cubemap_properties.Size = new System.Drawing.Size(208, 484);
            this.tab_cubemap_properties.TabIndex = 1;
            this.tab_cubemap_properties.Text = "Cubemap Properties";
            this.tab_cubemap_properties.UseVisualStyleBackColor = true;
            // 
            // width_text_box
            // 
            this.width_text_box.Location = new System.Drawing.Point(3, 3);
            this.width_text_box.Name = "width_text_box";
            this.width_text_box.Size = new System.Drawing.Size(72, 20);
            this.width_text_box.TabIndex = 0;
            // 
            // height_text_box
            // 
            this.height_text_box.Location = new System.Drawing.Point(94, 3);
            this.height_text_box.Name = "height_text_box";
            this.height_text_box.Size = new System.Drawing.Size(72, 20);
            this.height_text_box.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "x";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(168, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "px";
            // 
            // resolution_combo_box
            // 
            this.resolution_combo_box.FormattingEnabled = true;
            this.resolution_combo_box.Location = new System.Drawing.Point(4, 30);
            this.resolution_combo_box.Name = "resolution_combo_box";
            this.resolution_combo_box.Size = new System.Drawing.Size(187, 21);
            this.resolution_combo_box.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Generate and Save";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.save_to_input_check_box);
            this.panel3.Controls.Add(this.save_cubemap_button);
            this.panel3.Controls.Add(this.generate_cubemap_button);
            this.panel3.Location = new System.Drawing.Point(6, 234);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(196, 100);
            this.panel3.TabIndex = 7;
            // 
            // generate_cubemap_button
            // 
            this.generate_cubemap_button.Location = new System.Drawing.Point(4, 3);
            this.generate_cubemap_button.Name = "generate_cubemap_button";
            this.generate_cubemap_button.Size = new System.Drawing.Size(188, 23);
            this.generate_cubemap_button.TabIndex = 2;
            this.generate_cubemap_button.Text = "Generate CubeMap";
            this.generate_cubemap_button.UseVisualStyleBackColor = true;
            // 
            // save_cubemap_button
            // 
            this.save_cubemap_button.Location = new System.Drawing.Point(4, 32);
            this.save_cubemap_button.Name = "save_cubemap_button";
            this.save_cubemap_button.Size = new System.Drawing.Size(188, 23);
            this.save_cubemap_button.TabIndex = 3;
            this.save_cubemap_button.Text = "Save CubeMap";
            this.save_cubemap_button.UseVisualStyleBackColor = true;
            // 
            // save_to_input_check_box
            // 
            this.save_to_input_check_box.AutoSize = true;
            this.save_to_input_check_box.Location = new System.Drawing.Point(5, 62);
            this.save_to_input_check_box.Name = "save_to_input_check_box";
            this.save_to_input_check_box.Size = new System.Drawing.Size(151, 17);
            this.save_to_input_check_box.TabIndex = 4;
            this.save_to_input_check_box.Text = "Save *.DDS to input folder";
            this.save_to_input_check_box.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 341);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Batch";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.output_folder_text_box);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.input_folder_text_box);
            this.panel4.Controls.Add(this.process_batch_button);
            this.panel4.Location = new System.Drawing.Point(6, 357);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(196, 121);
            this.panel4.TabIndex = 9;
            // 
            // process_batch_button
            // 
            this.process_batch_button.Location = new System.Drawing.Point(5, 95);
            this.process_batch_button.Name = "process_batch_button";
            this.process_batch_button.Size = new System.Drawing.Size(187, 23);
            this.process_batch_button.TabIndex = 0;
            this.process_batch_button.Text = "Process!";
            this.process_batch_button.UseVisualStyleBackColor = true;
            // 
            // input_folder_text_box
            // 
            this.input_folder_text_box.Location = new System.Drawing.Point(5, 24);
            this.input_folder_text_box.Name = "input_folder_text_box";
            this.input_folder_text_box.Size = new System.Drawing.Size(152, 20);
            this.input_folder_text_box.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Input folder (file)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Output folder";
            // 
            // output_folder_text_box
            // 
            this.output_folder_text_box.Location = new System.Drawing.Point(5, 67);
            this.output_folder_text_box.Name = "output_folder_text_box";
            this.output_folder_text_box.Size = new System.Drawing.Size(152, 20);
            this.output_folder_text_box.TabIndex = 3;
            // 
            // rotate_z_track_bar
            // 
            this.rotate_z_track_bar.Location = new System.Drawing.Point(6, 23);
            this.rotate_z_track_bar.Name = "rotate_z_track_bar";
            this.rotate_z_track_bar.Size = new System.Drawing.Size(196, 45);
            this.rotate_z_track_bar.TabIndex = 0;
            // 
            // blur_track_bar
            // 
            this.blur_track_bar.Location = new System.Drawing.Point(6, 100);
            this.blur_track_bar.Name = "blur_track_bar";
            this.blur_track_bar.Size = new System.Drawing.Size(196, 45);
            this.blur_track_bar.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Rotate CubeMap around Z axis";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Blur CubeMap";
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 536);
            this.Controls.Add(this.tabs_options);
            this.Controls.Add(this.tabs_image);
            this.Controls.Add(this.status_strip);
            this.Name = "Main_Form";
            this.Text = "Cubemap Editor";
            this.status_strip.ResumeLayout(false);
            this.status_strip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panorama_picture_box)).EndInit();
            this.tabs_image.ResumeLayout(false);
            this.tab_panorama.ResumeLayout(false);
            this.tabs_options.ResumeLayout(false);
            this.tab_genaral_properties.ResumeLayout(false);
            this.tab_genaral_properties.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tab_cubemap_properties.ResumeLayout(false);
            this.tab_cubemap_properties.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rotate_z_track_bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blur_track_bar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip status_strip;
        private System.Windows.Forms.Button open_file_button;
        private System.Windows.Forms.OpenFileDialog open_file_dialog;
        private System.Windows.Forms.PictureBox panorama_picture_box;
        private System.Windows.Forms.ToolStripProgressBar progress_bar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TabControl tabs_image;
        private System.Windows.Forms.TabPage tab_panorama;
        private System.Windows.Forms.TabPage tab_cubemap;
        private System.Windows.Forms.TabControl tabs_options;
        private System.Windows.Forms.TabPage tab_genaral_properties;
        private System.Windows.Forms.TabPage tab_cubemap_properties;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox resolution_combo_box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox height_text_box;
        private System.Windows.Forms.TextBox width_text_box;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox output_folder_text_box;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox input_folder_text_box;
        private System.Windows.Forms.Button process_batch_button;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox save_to_input_check_box;
        private System.Windows.Forms.Button save_cubemap_button;
        private System.Windows.Forms.Button generate_cubemap_button;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TrackBar blur_track_bar;
        private System.Windows.Forms.TrackBar rotate_z_track_bar;
    }
}

